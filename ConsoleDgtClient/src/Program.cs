using DgtWsProxy;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDgtClient
{
    class Program
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            try
            {
                var options = new ClientArgs();
                if (CommandLine.Parser.Default.ParseArguments(args, options))
                {
                    switch (options.TipoFichero)
                    {
                        case TipoFichero.matriculas:
                            DownloadMatriculaciones(options.Begin, options.End);
                            break;
                        case TipoFichero.bajas:
                            DownloadBajas(options.Begin, options.End);
                            break;
                        case TipoFichero.transferencias:
                            DownloadTransferencias(options.Begin, options.End);
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void DownloadMatriculaciones(DateTime begin, DateTime end)
        {
            DgtService s = new DgtService();
            string filename = string.Format("export_diario_mat_{0}_{1}.txt", begin.ToString("yyyyMMdd"), end.ToString("yyyyMMdd"));
            for (DateTime date = begin; date <= end; date = date.AddDays(1))
            {
                var r2 = s.GetDgtMicrodatos(new DgtRequest() { FileType = DgtSubcategory.Matriculaciones, FileDate = date });
                if (r2.State == DgtResponseState.Ok)
                {
                    File.WriteAllText(r2.FileName, r2.FileContent, Encoding.Default);
                    File.AppendAllText(filename, r2.FileContent, Encoding.Default);
                }
            }
        }

        private static void DownloadBajas(DateTime begin, DateTime end)
        {
            DgtService s = new DgtService();
            string filename = string.Format("export_diario_bajas_{0}_{1}.txt", begin.ToString("yyyyMMdd"), end.ToString("yyyyMMdd"));
            for (DateTime date = begin; date <= end; date = date.AddDays(1))
            {
                var r2 = s.GetDgtMicrodatos(new DgtRequest() { FileType = DgtSubcategory.Bajas, FileDate = date });
                if (r2.State == DgtResponseState.Ok)
                {
                    File.WriteAllText(r2.FileName, r2.FileContent, Encoding.Default);
                    File.AppendAllText(filename, r2.FileContent, Encoding.Default);
                }
            }
        }

        private static void DownloadTransferencias(DateTime begin, DateTime end)
        {
            DgtService s = new DgtService();
            string filename = string.Format("export_diario_trf_{0}_{1}.txt", begin.ToString("yyyyMMdd"), end.ToString("yyyyMMdd"));
            for (DateTime date = begin; date <= end; date = date.AddDays(1))
            {
                var r2 = s.GetDgtMicrodatos(new DgtRequest() { FileType = DgtSubcategory.Transferencias, FileDate = date });
                if (r2.State == DgtResponseState.Ok)
                {
                    File.WriteAllText(r2.FileName, r2.FileContent, Encoding.Default);
                    File.AppendAllText(filename, r2.FileContent, Encoding.Default);
                }
            }
        }
    }
}
