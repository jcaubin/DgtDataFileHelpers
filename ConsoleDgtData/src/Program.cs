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
using EntityFramework.BulkInsert.Extensions;
using CommandLine;
using System.IO.Compression;

namespace ConsoleDgtData
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var result = Parser.Default.ParseArguments<CmOptions>(args).WithParsed<CmOptions>(options =>
                {
                    switch (options.TipoFichero)
                    {
                        case TipoFichero.matriculas:
                            Process<MatriculacionData, MatriculacionDataOut>(options);
                            break;
                        case TipoFichero.bajas:
                            Process<BajaData, BajaDataOut>(options);
                            break;
                        case TipoFichero.transferencias:
                            Process<BajaData, BajaDataOut>(options);
                            break;
                        default:
                            Console.WriteLine("Opciones no validas");
                            break;
                    }
                })
                .WithNotParsed<CmOptions>((errs) =>
                {
                    Console.WriteLine("Error las opciones;");
                });

            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el procesamiento: {0};", e.Message);
            }
        }

        public static int Process<TInput, TOutput>(CmOptions options) where TInput : VehicInputData where TOutput : VehicOutputData
        {
            try
            {
                Mapper.Initialize(cfg => cfg.CreateMap<TInput, TOutput>());
                var engine = new FileHelperEngine<TInput>();
                engine.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;

                var files = Directory.EnumerateFiles(Path.GetDirectoryName(options.FileName), Path.GetFileName(options.FileName));

                foreach (string filename in files)
                {
                    string filtroMarca = options.Marca;
                    Console.WriteLine("Procesando {0}.", filename);

                    //descompresion y lectura           
                    ZipArchive archive = ZipFile.Open(filename, ZipArchiveMode.Read);
                    ZipArchiveEntry entry = archive.Entries[0];

                   

                    var result = engine.ReadStream(new StreamReader(entry.Open()));

                    //Filtro
                    if (!string.IsNullOrWhiteSpace(filtroMarca)) result = result.Where(r => r.MarcaItv.Contains(filtroMarca)).ToArray();

                    //Decodificacion
                    CodPropulsion codPropulsionMap = new CodPropulsion();
                    CodServicio codServicioMap = new CodServicio();
                    CodBaja codBajaMap = new CodBaja();
                    foreach (var item in result)
                    {
                        item.CodPropulsionItv = (string.IsNullOrWhiteSpace(item.CodPropulsionItv)) ? "" : codPropulsionMap[item.CodPropulsionItv];
                        item.Servicio = (string.IsNullOrWhiteSpace(item.Servicio)) ? "" : codServicioMap[item.Servicio];
                        item.IndBajaDef = codBajaMap.SingleOrDefault(c => c.Key == item.IndBajaDef).Value;
                    }
                    var s = result.Select(r => Mapper.Map<TOutput>(r));

                    //escritura
                    var outEngine = new FileHelperEngine<TOutput>();
                    outEngine.HeaderText = engine.GetFileHeader().Replace('\t', ';');
                    var outFileName = filename + (string.IsNullOrWhiteSpace(filtroMarca) ? "" : ".") + filtroMarca + ".converted.zip";
                    if (options.Salida == TipoSalida.csv)
                    {
                        outFileName = Path.ChangeExtension(outFileName, "csv");
                        outEngine.WriteFile(outFileName, s);
                    }
                    else if (options.Salida == TipoSalida.zip)
                    {
                        outFileName = Path.ChangeExtension(outFileName, "zip");
                        var fileNamePart = Path.GetFileNameWithoutExtension(outFileName) + ".csv";
                        using (FileStream zipToOpen = new FileStream(outFileName, FileMode.Create))
                        {
                            using (ZipArchive za = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                            {
                                ZipArchiveEntry readmeEntry = za.CreateEntry(fileNamePart);
                                using (StreamWriter writer = new StreamWriter(readmeEntry.Open(), Encoding.GetEncoding(28591)))
                                {
                                    outEngine.WriteStream(writer, s);
                                }
                            }
                        }
                    }

                    Console.WriteLine("Proceso terminado. ");
                    Console.WriteLine("Fichero de salida:  {0}", outFileName);
                }
                if (engine.ErrorManager.HasErrors) engine.ErrorManager.SaveErrors("errors.out");

                return 1;
            }
            catch (ConvertException e)
            {
                Console.WriteLine("Error en el proceso: {0}; linea {1}; columna {2};", e.Message, e.LineNumber, e.ColumnNumber);
                throw;
                //return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el proceso: {0}", e.Message);
                throw;
                //return 0;
            }
        }

        public static int Load<TInput>(string filename, TipoFichero? tipoFichero, string filtroMarca = "") where TInput : VehicInputData
        {
            try
            {

                //lectura
                Console.WriteLine("Procesando {0}.", filename);
                var engine = new FileHelperEngine<TInput>();
                var result = engine.ReadFile(filename);

                //Filtro
                if (!string.IsNullOrWhiteSpace(filtroMarca)) result = result.Where(r => r.MarcaItv.Contains(filtroMarca)).ToArray();


                Mapper.Initialize(cfg => cfg.CreateMap<TInput, VehicleData>());

                var s = (result.Select(r => Mapper.Map<VehicleData>(r)));
                s = s.Select(q => MapV(q, tipoFichero, filename));


                using (RegistroDgtContext context = new DAL.RegistroDgtContext())
                {
                    context.BulkInsert<VehicleData>(s);
                    return 1;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el proceso: {0}", e.Message);
                throw;
                // return 0;
            }
        }

        private static VehicleData MapV(VehicleData vo, TipoFichero? tf, string NombreFichero)
        {
            vo.TipoFichero = tf;
            vo.NombreFichero = NombreFichero;
            return vo;
        }

    }
}
