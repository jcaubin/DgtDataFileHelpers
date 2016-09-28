using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgtWsProxy
{
    public class DgtRequest
    {
        /// <summary>
        /// Subcategoria solicitada
        /// </summary>
        public DgtSubcategory FileType { get; set; }

        /// <summary>
        /// Fecha solicitada
        /// </summary>
        public DateTime FileDate { get; set; }
    }

    public enum DgtSubcategory
    {
        Bajas = 1,
        Transferencias = 3,
        Matriculaciones = 4
    }
}
