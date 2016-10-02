using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DgtWsProxy.dgt;
using NLog;
using System.IO;
//using System.IO.Compression;
using Ionic.Zip;
using Ionic.Zlib;

namespace DgtWsProxy
{
    public static class Mappers
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public static Peticion Map(this DgtRequest request)
        {
            Peticion pt = new dgt.Peticion()
            {
                filtro = new dgt.Filtro()
                {
                    Categoria = "1",
                    Subcategoria = ((int)request.FileType).ToString(),
                    Fecha = request.FileDate.ToString("dd/MM/yyyy")
                }
            };
            return pt;
        }

        public static DgtResponse MapFrom(this DgtResponse dgtr, Respuesta r)
        {
            try
            {
                _logger.Trace("Conversion de la respuesta");
                if (r.estado.codigoEstado == "0000" && r?.identificadorRespuesta?.multiParte?.NumTotalFragmentos == "1")
                {
                    dgtr.State = DgtResponseState.Ok;
                    dgtr.FileName = Path.ChangeExtension(r.identificadorRespuesta.multiParte.NombreFichero, "txt");
                    var byteData = Convert.FromBase64String(r.datosSalida);

                    using (var byteDataStream = new MemoryStream(byteData))
                    {
                        var zipFile = ZipFile.Read(byteDataStream);
                        foreach (ZipEntry e in zipFile)
                        {
                            using (var outsteram = new MemoryStream())
                            {
                                using (StreamReader reader = new StreamReader(e.OpenReader(), Encoding.Default))
                                {
                                    dgtr.FileContent = reader.ReadToEnd();
                                }
                            }
                        }
                    }
                }
                else if (r.estado.codigoEstado == "0000")
                {
                    dgtr.State = DgtResponseState.BadRequest;
                }
                else
                {
                    dgtr.State = DgtResponseState.BadRequest;
                }
                return dgtr;
            }
            catch (Exception e)
            {
                _logger.Error(e, "Error en la conversión de los datos");
                throw;
            }
        }
    }
}
