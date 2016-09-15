using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDgtData
{
    public enum CodClaseMatricula
    {
        Ordinaria = 0,
        Turística = 1,
        Remolque = 2,
        Diplomática = 3,
        Reservada = 4,
        VehículoEspecial = 5,
        Ciclomotor = 6,
        TransporteTemporal = 7,
        Histórica = 8
    }

    public enum CodProcedencia
    {
        FabricaciónNacional = 0,
        ImportaciónNoComunitaria = 1,
        Subasta = 2,
        ImportaciónUE = 3
    }

    public enum OldCodServicio
    {
        Particular = 0,
        Público = 1,
        AutoTaxi = 2,
        AlquilerConConductor = 3,
        AlquilerSinConductor = 4,
        EscuelaDeConductores = 5,
        Agrícola = 6,
        ObrasYServicios = 7,
        TransporteEscolar = 8,
        MercancíasPeligrosas = 9
    }
}
