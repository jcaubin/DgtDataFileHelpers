using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDgtData
{
    /// <summary>
    /// Indicador del motivo de la baja definitiva.
    /// IND_BAJA_DEF
    /// </summary>
    public class CodBaja : Dictionary<string, string>
    {
        public CodBaja()
        {
            this.Add("0", "Desguace");
            this.Add("1", "Agotamiento");
            this.Add("2", "Antigüedad");
            this.Add("3", "Renovación del parque");
            this.Add("4", "Otros motivos");
            this.Add("5", "R.D.L 4/1994 , R.D.L 10/1994 , R.D.L 4/1997");
            this.Add("7", "Voluntaria");
            this.Add("8", "Exportación");
            this.Add("9", "Transito comunitario");
            this.Add("A", "De oficio por abandono");
            this.Add("B", "De oficio por seguridad");
            this.Add("C", "Por Tratamiento Residual");
        }
    }
}
