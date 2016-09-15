using System;
using System.Collections.Generic;
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
            try
            {
                string filename = args[0];
                if (string.IsNullOrWhiteSpace(filename))
                {
                    Console.WriteLine("Uso: app nombreDeFichero");
                    return;
                }

                //lectura
                Console.WriteLine("Procesando {0}.", filename);
                var engine = new FileHelperEngine<MatriculacionData>();
                var result = engine.ReadFile(filename);

                //transformacion
                CodPropulsion codPropulsionMap = new CodPropulsion();
                CodServicio codServicioMap = new CodServicio();
                foreach (var item in result)
                {
                    item.CodPropulsionItv = (string.IsNullOrWhiteSpace(item.CodPropulsionItv)) ? "" : codPropulsionMap[item.CodPropulsionItv];
                    item.Servicio = (string.IsNullOrWhiteSpace(item.Servicio)) ? "" : codServicioMap[item.Servicio];
                }
                Mapper.Initialize(cfg => cfg.CreateMap<MatriculacionData, MatrinculacionDataOut>());
                var mo = Mapper.Map<MatrinculacionDataOut>(result[0]);
                var s = result.Select(r => Mapper.Map<MatrinculacionDataOut>(r));

                //escritura
                var outEngine = new FileHelperEngine<MatrinculacionDataOut>();
                outEngine.HeaderText = engine.GetFileHeader().Replace('\t', ';');
                outEngine.WriteFile(filename + ".converted.csv", s);
                Console.WriteLine("Proceso terminado.");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el proceso: {0}", e.Message);
                throw;
            }
        }
    }
}
