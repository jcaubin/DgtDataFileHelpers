using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ConsoleDgtData.DAL;
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
                        Process<MatriculacionData, MatriculacionDataOut>(options.FileName, options.Marca);
                        break;
                    case TipoFichero.bajas:
                        Process<BajaData, BajaDataOut>(options.FileName, options.Marca);
                        break;
                    case TipoFichero.transferencias:
                        Process<BajaData, BajaDataOut>(options.FileName, options.Marca);
                        break;
                    default:
                        Console.WriteLine("Opciones no validas");
                        break;
                }
            }
            else
            {
                return;
            }
        }

        public static int Process<TInput, TOutput>(string filename, string filtroMarca = "") where TInput : VehicInputData where TOutput : VehicOutputData
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
                var outFileName = filename + (string.IsNullOrWhiteSpace(filtroMarca) ? "" : ".") + filtroMarca + ".converted.csv";
                outEngine.HeaderText = engine.GetFileHeader().Replace('\t', ';');
                outEngine.WriteFile(outFileName, s);
                Console.WriteLine("Proceso terminado. ");
                Console.WriteLine("Fichero de salida:  {0}", outFileName);
                return s.Count();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el proceso: {0}", e.Message);
                return 0;
            }
        }

        public static int Load<TInput>(string filename, string filtroMarca = "") where TInput : VehicInputData
        {
            try
            {
                //lectura
                Console.WriteLine("Procesando {0}.", filename);
                var engine = new FileHelperEngine<TInput>();
                var result = engine.ReadFile(filename);

                //Filtro
                if (!string.IsNullOrWhiteSpace(filtroMarca)) result = result.Where(r => r.MarcaItv.Contains(filtroMarca)).ToArray();

                ////transformacion
                //CodPropulsion codPropulsionMap = new CodPropulsion();
                //CodServicio codServicioMap = new CodServicio();
                //CodBaja codBajaMap = new CodBaja();
                //foreach (var item in result)
                //{
                //    item.CodPropulsionItv = (string.IsNullOrWhiteSpace(item.CodPropulsionItv)) ? "" : codPropulsionMap[item.CodPropulsionItv];
                //    item.Servicio = (string.IsNullOrWhiteSpace(item.Servicio)) ? "" : codServicioMap[item.Servicio];
                //    item.IndBajaDef = codBajaMap.SingleOrDefault(c => c.Key == item.IndBajaDef).Value;
                //}


                Mapper.Initialize(cfg => cfg.CreateMap<TInput, VehicleData>());
                //var s = (result.Select(r => Mapper.Map<VehicleData>(r))).ToList();
                //s.ForEach(c => { c.TipoFichero = TipoFichero.matriculas; c.NombreFichero = filename; });

                var s = (result.Select(r => Mapper.Map<VehicleData>(r)));
                s = s.Select(q =>  MapV(q, TipoFichero.matriculas, filename) );

                using (RegistroDgtContext context = new DAL.RegistroDgtContext())
                {
                    context.Registros.AddRange(s);
                    var nc = context.SaveChanges();
                    return nc;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el proceso: {0}", e.Message);
                return 0;
            }
        }

        private static VehicleData MapV(VehicleData vo, TipoFichero tf, string NombreFichero)
        {
            vo.TipoFichero = TipoFichero.matriculas;
            vo.NombreFichero = NombreFichero;
            return vo;
        }

    }
}
