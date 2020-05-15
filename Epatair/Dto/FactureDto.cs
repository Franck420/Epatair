using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Dto
{
    //Stock les donnee d une facture
   public class FactureDto
    {
       public int Idfacture;

        public double HrVol { get; set; }
        public double TarifHrVol { get; set; }
        public double HrSol { get; set; }
        public double TarifHrSol { get; set; }
        public double TarifHrSolInstruteur { get; set; }
        public double TarifHrVolInstruteur { get; set; }

        //public AvionDto IdAvion { get; set; }

        //public PiloteDto Instructeur { get; set; }

        //public PiloteDto Pilote { get; set; }

        public DateTime HrDemarrage { get; set; }
        public DateTime HrArret { get; set; }
        public DateTime HrAtterissage { get; set; }
        public DateTime HrDemarrage2 { get; set; }

    }
}
