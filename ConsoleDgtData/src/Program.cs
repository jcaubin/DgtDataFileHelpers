using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FileHelpers;

namespace ConsoleDgtData
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new CmOptions();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                switch (options.TipoFichero)
                {
                    case TipoFichero.matriculas:
                        ProcessMatriculaciones(options.FileName);
                        break;
                    case TipoFichero.bajas:
                        ProcessBajas(options.FileName);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                return;
            }
        }

        private static void ProcessMatriculaciones(string filename)
        {
            try
            {
                //lectura
                Console.WriteLine("Procesando {0}.", filename);
                var engine = new FileHelperEngine<MatriculacionData>();
                var result = engine.ReadFile(filename);

                //transformacion
                CodPropulsion codPropulsionMap = new CodPropulsion();
                CodServicio codServicioMap = new CodServicio();
                CodBaja codBajaMap = new CodBaja();
                foreach (var item in result)
                {
                    item.CodPropulsionItv = (string.IsNullOrWhiteSpace(item.CodPropulsionItv)) ? "" : codPropulsionMap[item.CodPropulsionItv];
                    item.Servicio = (string.IsNullOrWhiteSpace(item.Servicio)) ? "" : codServicioMap[item.Servicio];
                    item.IndBajaDef = codBajaMap.SingleOrDefault(c => c.Key == item.IndBajaDef).Value;
                }
                Mapper.Initialize(cfg => cfg.CreateMap<MatriculacionData, MatriculacionDataOut>());
                var mo = Mapper.Map<MatriculacionDataOut>(result[0]);
                var s = result.Select(r => Mapper.Map<MatriculacionDataOut>(r));

                //escritura
                var outEngine = new FileHelperEngine<MatriculacionDataOut>();
                outEngine.HeaderText = engine.GetFileHeader().Replace('\t', ';');
                outEngine.WriteFile(filename + ".converted.csv", s);
                Console.WriteLine("Proceso terminado.");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el proceso: {0}", e.Message);
            }
        }

        private static void ProcessBajas(string filename)
        {
            try
            {
                //lectura
                Console.WriteLine("Procesando {0}.", filename);
                var engine = new FileHelperEngine<BajaData>();
                var result = engine.ReadFile(filename);

                //transformacion
                CodPropulsion codPropulsionMap = new CodPropulsion();
                CodServicio codServicioMap = new CodServicio();
                CodBaja codBajaMap = new CodBaja();
                foreach (var item in result)
                {
                    item.CodPropulsionItv = (string.IsNullOrWhiteSpace(item.CodPropulsionItv)) ? "" : codPropulsionMap[item.CodPropulsionItv];
                    item.Servicio = (string.IsNullOrWhiteSpace(item.Servicio)) ? "" : codServicioMap[item.Servicio];
                    item.IndBajaDef = codBajaMap.SingleOrDefault(c => c.Key == item.IndBajaDef).Value;
                }
                Mapper.Initialize(cfg => cfg.CreateMap<BajaData, BajaDataOut>());
                var mo = Mapper.Map<BajaDataOut>(result[0]);
                var s = result.Select(r => Mapper.Map<BajaDataOut>(r));

                //escritura
                var outEngine = new FileHelperEngine<BajaDataOut>();
                outEngine.HeaderText = engine.GetFileHeader().Replace('\t', ';');
                outEngine.WriteFile(filename + ".converted.csv", s);
                Console.WriteLine("Proceso terminado.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el proceso: {0}", e.Message);
            }
        }

    }
}
