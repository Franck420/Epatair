using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Validation
{
    //Classe contenant des fonctions de validation 
    class ValidationFacture
    {
        //fonction pour valider les Doubles
        public bool validationDouble(string nombre)
        {
            return double.TryParse(nombre, out double nombreverifier)&& nombreverifier>=0;     
        }

        //Fonction pour valider les DateTime
        public bool ValidationDatetime(string text)
        {
            return DateTime.TryParse(text, out DateTime dateverifier);
        
        }

    }
}
