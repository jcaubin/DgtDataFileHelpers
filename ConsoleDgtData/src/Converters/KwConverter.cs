using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace ConsoleDgtData.Converters
{
    public class KwConverter : ConverterBase
    {
        public override object StringToField(string from)
        {
            Decimal value;
            if (decimal.TryParse(from, NumberStyles.Any, CultureInfo.InvariantCulture, out value ))
            {
                return value;
            }
            else
            {
                return null;
            }
        }
    }
}
