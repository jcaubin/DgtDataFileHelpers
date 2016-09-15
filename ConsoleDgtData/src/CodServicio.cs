using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDgtData
{
    public class CodServicio:Dictionary<string,string>
    {
        public CodServicio()
        {
            this.Add("A00", "Público PUBL-Sin especificar");
            this.Add("A01", "Público PUBL-Alquiler sin conductor");
            this.Add("A02", "Público PUBL-Alquiler con conductor");
            this.Add("A03", "Público PUBL-Aprendizaje de conducción");
            this.Add("A04", "Público PUBL-Taxi");
            this.Add("A05", "Público PUBL-Auxilio en carretera");
            this.Add("A07", "Público PUBL-Ambulancia");
            this.Add("A08", "Público PUBL-Funerario");
            this.Add("A09", "Particular PART-Obras");
            this.Add("A10", "Público PUBL-Mercancías peligrosas");
            this.Add("A11", "Público PUBL-Basurero");
            this.Add("A12", "Público PUBL-Transporte escolar");
            this.Add("A13", "Público PUBL-Policía");
            this.Add("A14", "Público PUBL-Bomberos");
            this.Add("A15", "Público PUBL-Protección civil y salvamento");
            this.Add("A16", "Público PUBL-Defensa");
            this.Add("A18", "Público PUBL-Actividad económica");
            this.Add("A20", "Público PUBL-Mercancías perecederas");
            this.Add("B00", "Particular PART-Sin especificar");
            this.Add("B06", "Particular PART-Agrícola");
            this.Add("B07", "ParticularPART-");
            this.Add("B09", "Particular PART-Obras");
            this.Add("B17", "Particular PART-Vivienda");
            this.Add("B18", "Público PART-Actividad económica");
            this.Add("B19", "Particular PART-Recreativo");
            this.Add("B21", "Particular PART-Vehículo para ferias");
        }
    }
}
