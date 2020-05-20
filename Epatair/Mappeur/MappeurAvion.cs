using Epatair.Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Mappeur
{
    //Mappeur pour mapper vers notre AvionDTO
    class MappeurAvion
    {
        //Fonction pour mapper a partir d'un sqlDataReader
        public void Map(SqlDataReader source, AvionDTO cible)
        {
            cible.IdAvion = (int)source["IdAvion"];
            cible.Nom = (string)source["Nom"];
            cible.IdLogbook = (int)source["IdLogbook"];
            cible.tarif = (double)source["Tarif"];
        }

        //Fonction pour mapper a partir des informations entrées
        public void Map(int IdAvion, string Nom, int IdLogbook, AvionDTO cible ,double tarif)
        {
            cible.IdAvion = IdAvion;
            cible.Nom = Nom;
            cible.IdLogbook = IdLogbook;
            cible.tarif=tarif
        }
    }
}
