using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Dto
{
    //DTO contenant les informations de nos avions
    public class PiloteDTO
    {
        public int IdPilote;
        public string Nom { get; set; }
        public string Grade { get; set; }
    }
}
