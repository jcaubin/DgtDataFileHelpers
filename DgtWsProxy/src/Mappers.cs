using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DgtWsProxy.dgt;

namespace DgtWsProxy
{
    public static class Mappers
    {
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
            if (r.estado.codigoEstado == "0000" && r?.identificadorRespuesta?.multiParte?.NumTotalFragmentos == "1")
            {
                dgtr.State = DgtResponseState.Ok;
                dgtr.FileName = r.identificadorRespuesta.multiParte.NombreFichero;
                dgtr.FileContent = r.datosSalida;
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
    }
}
