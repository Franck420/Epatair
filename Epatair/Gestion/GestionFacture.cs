using Epatair.Dto;
using Epatair.Repositorie;
using Epatair.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Gestion
{

    //Classe qui s'occupe de la gestion des factures
    public class GestionFacture
    {
        IRepositoryFacture RepositoryFacture = new RepositoryFacture();
        double tarifHrVol = 10;
        double tarifHrSol = 20;

        FactureDto facture = new FactureDto();

        //Fonction pour créer une nouvelle facture
        public void NouvelleFacture(AvionDTO avion, PiloteDTO instruteur, PiloteDTO pilote,DateTime HeureDemarrage, DateTime HeureArret, DateTime HeureAtterissage, DateTime HeureDecolage,double tarifHrVol,double tarifHrSol, double tarifAvion)
        {
            double HeuredeVol, HeureSol;

            Mappeur.MappeurFacture mappeur = new Mappeur.MappeurFacture();

            facture=mappeur.Map(avion,instruteur,  pilote,  HeuredeVol,  HeureSol,  HeureDemarrage, HeureArret,  HeureAtterissage,  HeureDecolage,  tarifHrVol,  tarifHrSol,facture);
            
        }

        //fonction pour calculer le total d'une facture
        public double calculertotalFacture(FactureDto facture)
        {
            
        }
        
        //Fonction permettant d'aller chercher et de retourner une liste de facture
        public List<FactureDto> getliste()
        {
            return RepositoryFacture.GetListeFacture();

        }

        private void calculertempssol()
        { 
            facture.HrSol
        
        }
        private void calculertempsVol()
        {


        }
    }
}
