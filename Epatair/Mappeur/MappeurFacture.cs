﻿using Epatair.Dto;
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

            cible.HrVol = (double)source["HeureVol"];
            cible.HrSol = (double)source["HeureSol"];
            cible.TarifHrVol = (double)source["TarifHeureVol"];
            cible.TarifHrSol = (double)source["TarifHoraireSol"];

            cible.avion = (int)source["IdAvion"];
            cible.Instructeur = (int)source["IdInstructeur"];
            cible.Pilote = (int)source["IdPilote"];

            cible.HrDemarrage = (DateTime)source["HeureDemarrage"];
            cible.HrDecollage = (DateTime)source["HeureDecollage"];
            cible.HrArret = (DateTime)source["HeureArret"];
            cible.HrAtterissage = (DateTime)source["HeureAtterissage"];



        }

        //Fonction pour mapper a partir des informations de la facture
        public FactureDto  Map(AvionDTO avion, PiloteDTO instruteur, PiloteDTO pilote, double HeuredeVol, double HeureSol, DateTime HeureDemarrage, DateTime HeureArret, DateTime HeureAtterissage, DateTime HeureDecolage, double tarifHrVol, double tarifHrSol , FactureDto cible)
        {

            

            cible.HrVol = HeuredeVol;
            cible.HrSol = HeureSol;
            cible.TarifHrVol = tarifHrVol;
            cible.TarifHrSol = tarifHrSol;

            cible.avion = avion.IdAvion;
            cible.Instructeur = instruteur.IdPilote;
            cible.Pilote = pilote.IdPilote;

            cible.HrDemarrage = HeureDemarrage;
            cible.HrDecollage =HeureDecolage;
            cible.HrArret =HeureArret;
            cible.HrAtterissage = HeureAtterissage;

            return cible;
        }
    }
}
