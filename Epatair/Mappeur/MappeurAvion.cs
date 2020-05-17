using Epatair.Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Mappeur
{
    class MappeurAvion
    {
        public void Map(SqlDataReader source, AvionDTO cible)
        {
            cible.IdAvion = (int)source["IdAvion"];
            cible.Nom = (string)source["Nom"];
            cible.IdLogbook = (int)source["IdLogbook"];            
        }

        public void Map(int IdAvion, string Nom, int IdLogbook, AvionDTO cible)
        {
            cible.IdAvion = IdAvion;
            cible.Nom = Nom;
            cible.IdLogbook = IdLogbook;
        }
    }
}
