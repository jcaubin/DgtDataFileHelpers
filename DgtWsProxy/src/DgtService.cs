using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DgtWsProxy.dgt;
using NLog;

namespace DgtWsProxy
{
    public class DgtService
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        descargaArchivoMicrodatosPortTypeClient _proxy;

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="endpoint">Nombre del encpoint</param>
        public DgtService(string endpoint)
        {
            _proxy = new descargaArchivoMicrodatosPortTypeClient(endpoint);
        }

        public DgtService()
        {
            _proxy = new descargaArchivoMicrodatosPortTypeClient("descargaArchivoMicrodatosSoap");
        }

        public DgtResponse GetDgtMicrodatos(DgtRequest req)
        {
            try
            {
                Peticion pet = req.Map();
                Respuesta dr = _proxy.descargaArchivoMicrodatos(pet);
                DgtResponse resp = new DgtWsProxy.DgtResponse();
                resp.MapFrom(dr);              
                return resp;
            }
            catch (System.ServiceModel.CommunicationException e)
            {
                _logger.Error(e, "Error de comunicacion en el proxy DGT;");
                throw;
            }
            catch (Exception e)
            {
                _logger.Error(e, "Error general en la peticion al WS DGT");
                throw;
            }
        }
    }
}
