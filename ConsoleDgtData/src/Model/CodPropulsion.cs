using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDgtData
{
    public class CodPropulsion:Dictionary<string,string>
    {
        public CodPropulsion()
        {
            this.Add("0", "Gasolina");
            this.Add("1", "Diesel");
            this.Add("2", "Eléctrico");
            this.Add("3", "Otros");
            this.Add("4", "Butano");
            this.Add("5", "Solar");
            this.Add("6", "Gas Licuado de Petróleo");
            this.Add("7", "Gas Natural Comprimido");
            this.Add("8", "Gas Natural Licuado");
            this.Add("9", "Hidrógeno");
            this.Add("A", "Biometano");
            this.Add("B", "Etanol");
            this.Add("C", "Biodiesel");
        }
    }
}
