using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Dto
{
    //Stock les données d'une facture
   public class FactureDto
    {
       public int Idfacture;

        public double HrVol { get; set; }
        public double TarifHrVol { get; set; }
        public double HrSol { get; set; }
        public double TarifHrSol { get; set; }
      
        

        public int avion { get; set; }
        

        public int Instructeur { get; set; }

        public int Pilote { get; set; }

        public DateTime HrDemarrage { get; set; }
        public DateTime HrArret { get; set; }
        public DateTime HrAtterissage { get; set; }
        public DateTime HrDecollage { get; set; }

    }
}
