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
      
        

        public AvionDTO avion { get; set; }
        

        public PiloteDTO Instructeur { get; set; }

        public PiloteDTO Pilote { get; set; }

        public DateTime HrDemarrage { get; set; }
        public DateTime HrArret { get; set; }
        public DateTime HrAtterissage { get; set; }
        public DateTime HrDecollage { get; set; }

    }
}
