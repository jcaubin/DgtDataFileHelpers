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
    }
}
