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
    public class Program
    {
        static void Main(string[] args)
        {
            var options = new CmOptions();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                switch (options.TipoFichero)
                {
                    case TipoFichero.matriculas:
                        //ProcessMatriculaciones(options.FileName, options.Marca);
                        Process<MatriculacionData, MatriculacionDataOut>(options.FileName, options.Marca);
                        break;
                    case TipoFichero.bajas:
                        //ProcessBajas(options.FileName, options.Marca);
                        Process<BajaData, BajaDataOut>(options.FileName, options.Marca);
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

        private static void ProcessMatriculaciones(string filename, string filtroMarca = "")
        {
            try
            {
                //lectura
                Console.WriteLine("Procesando {0}.", filename);
                var engine = new FileHelperEngine<MatriculacionData>();
                var result = engine.ReadFile(filename);

                //Filtro
                if (!string.IsNullOrWhiteSpace(filtroMarca)) result = result.Where(r => r.MarcaItv.Contains(filtroMarca)).ToArray();

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
                var s = result.Select(r => Mapper.Map<MatriculacionDataOut>(r));

                //escritura
                var outEngine = new FileHelperEngine<MatriculacionDataOut>();
                outEngine.HeaderText = engine.GetFileHeader().Replace('\t', ';');
                outEngine.WriteFile(filename + filtroMarca + ".converted.csv", s);
                Console.WriteLine("Proceso terminado.");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el proceso: {0}", e.Message);
            }
        }

        private static void ProcessBajas(string filename, string filtroMarca = "")
        {
            try
            {
                //lectura
                Console.WriteLine("Procesando {0}.", filename);
                var engine = new FileHelperEngine<BajaData>();
                var result = engine.ReadFile(filename);

                //Filtro
                if (!string.IsNullOrWhiteSpace(filtroMarca)) result = result.Where(r => r.MarcaItv.Contains(filtroMarca)).ToArray();

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
                var s = result.Select(r => Mapper.Map<BajaDataOut>(r));

                //escritura
                var outEngine = new FileHelperEngine<BajaDataOut>();
                outEngine.HeaderText = engine.GetFileHeader().Replace('\t', ';');
                outEngine.WriteFile(filename + filtroMarca + ".converted.csv", s);
                Console.WriteLine("Proceso terminado.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el proceso: {0}", e.Message);
            }
        }

        private static void Process<TInput, TOutput>(string filename, string filtroMarca = "") where TInput : VehicInputData where TOutput : VehicOutputData
        {
            try
            {
                //lectura
                Console.WriteLine("Procesando {0}.", filename);
                var engine = new FileHelperEngine<TInput>();
                var result = engine.ReadFile(filename);

                //Filtro
                if (!string.IsNullOrWhiteSpace(filtroMarca)) result = result.Where(r => r.MarcaItv.Contains(filtroMarca)).ToArray();

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
                Mapper.Initialize(cfg => cfg.CreateMap<TInput, TOutput>());
                var s = result.Select(r => Mapper.Map<TOutput>(r));

                //escritura
                var outEngine = new FileHelperEngine<TOutput>();
                outEngine.HeaderText = engine.GetFileHeader().Replace('\t', ';');
                outEngine.WriteFile(filename + filtroMarca + ".converted.csv", s);
                Console.WriteLine("Proceso terminado.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el proceso: {0}", e.Message);
            }
        }
    }
}
