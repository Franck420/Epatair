using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Validation
{
    class ValidationFacture
    {
        public bool validationDouble(string nombre)
        {
            return double.TryParse(nombre, out double nombreverifier)&& nombreverifier>=0;     
        }

        public bool ValidationDatetime(string text)
        {
            return DateTime.TryParse(text, out DateTime dateverifier);
        
        }

    }
}
