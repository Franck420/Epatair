using Epatair.Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Mappeur
{
    class MappeurFacture
    {
        public void Map(SqlDataReader source, FactureDto cible)
        {

            cible.Idfacture = (int)source["IdFacture"];

            cible.HrVol = (float)source["HrVol"];
            cible.HrSol = (float)source["HrSol"];
            cible.TarifHrVol = (float)source["TarifHrVol"];
            cible.TarifHrSol = (float)source["TarifHrVol"];
            cible.TarifHrVolInstruteur = (float)source["HrVolInstruteur"];
            cible.TarifHrSolInstruteur = (float)source["HrSolInstruteur"];

            cible.IdAvion = (int)source["IdAvion"];

            cible.Pilote = (string)source["Pilote"];
            cible.Instructeur = (string)source["Instruteur"];

            cible.HrDemarrage = (DateTime)source["HrDemarage"];
            cible.HrDemarrage2 = (DateTime)source["HrDemarage2"];
            cible.HrArret = (DateTime)source["HrArret"];
            cible.HrAtterissage = (DateTime)source["HrAtterissage"];

        }
    }
}
