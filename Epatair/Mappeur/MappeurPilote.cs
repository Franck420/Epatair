using Epatair.Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Mappeur
{
    //Mappeur pour mapper vers notre PiloteDTO

    class MappeurPilote
    {
        //Fonction pour mapper a partir d'un sqlDataReader
        public void Map(SqlDataReader source, PiloteDTO cible)
        {
            cible.IdPilote = (int)source["IdPilote"];
            cible.Grade = (string)source["Titre"];
            cible.Nom = (string)source["Nom"];
        }

        //Fonction pour mapper a partir d'informations partielles
        public void Map(string nom,string IdGrade, PiloteDTO cible)
        {
            
            cible.Nom = nom;
            cible.Grade = IdGrade;

        }

        //Fonction pour mapper a partir d'informations complètes
        public void Map(int Id,string nom, string IdGrade, PiloteDTO cible)
        {
            cible.IdPilote = Id;
            cible.Nom = nom;
            cible.Grade = IdGrade;
        }
    }
}
