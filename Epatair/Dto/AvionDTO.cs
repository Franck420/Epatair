using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Epatair.Dto
{
    //DTO contenant les informations de nos avions
    public class AvionDTO
    {
        public int IdAvion;
        public string Nom { get; set; }
        public int IdLogbook { get; set; }

        public double tarif { get; set; }
    }
}
