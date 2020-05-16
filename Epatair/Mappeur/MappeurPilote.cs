using Epatair.Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Mappeur
{
    class MappeurPilote
    {
        public void Map(SqlDataReader source, PiloteDTO cible)
        {

            cible.IdPilote = (int)source["IdPilote"];
            cible.Grade = (string)source["Titre"];
            cible.Nom = (string)source["Nom"];

        }
        public void Map(string nom,string IdGrade, PiloteDTO cible)
        {
            
            cible.Nom = nom;
            cible.Grade = IdGrade;

        }
    }
}
