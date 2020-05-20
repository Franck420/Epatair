using Epatair.Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Mappeur
{
    //Mappeur pour mapper vers notre FactureDTO
    public class MappeurFacture
    {
        //Fonction pour mapper a partir d'un sqlDataReader
        public void Map(SqlDataReader source, FactureDto cible)
        {

            cible.Idfacture = (int)source["IdFacture"];

            cible.HrVol = (float)source["HrVol"];
            cible.HrSol = (float)source["HrSol"];
            cible.TarifHrVol = (float)source["TarifHrVol"];
            cible.TarifHrSol = (float)source["TarifHrVol"];
          


            cible.HrDemarrage = (DateTime)source["HrDemarage"];
            cible.HrDecollage = (DateTime)source["HrDemarage2"];
            cible.HrArret = (DateTime)source["HrArret"];
            cible.HrAtterissage = (DateTime)source["HrAtterissage"];

        }

        public FactureDto  Map(AvionDTO avion, PiloteDTO instruteur, PiloteDTO pilote, double HeuredeVol, double HeureSol, DateTime HeureDemarrage, DateTime HeureArret, DateTime HeureAtterissage, DateTime HeureDecolage, double tarifHrVol, double tarifHrSol , FactureDto cible)
        {

            

            cible.HrVol = HeuredeVol;
            cible.HrSol = HeureSol;
            cible.TarifHrVol = tarifHrVol;
            cible.TarifHrSol = tarifHrSol;
        


            cible.HrDemarrage = HeureDemarrage;
            cible.HrDecollage =HeureDecolage;
            cible.HrArret =HeureArret;
            cible.HrAtterissage = HeureAtterissage;

            return cible;
        }
    }
}
