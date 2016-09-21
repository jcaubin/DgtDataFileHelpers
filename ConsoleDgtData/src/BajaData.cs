using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace ConsoleDgtData
{
    /// <summary>
    /// Estructura de datos de BAJA de la DGT
    /// </summary>
    [FixedLengthRecord(FixedMode.AllowMoreChars)]
    public class BajaData: VehicInputData
    {

    }
}
