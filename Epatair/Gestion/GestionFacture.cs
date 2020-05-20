using Epatair.Dto;
using Epatair.Formulaires;
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
        public void NouvelleFacture(AvionDTO avion, PiloteDTO instruteur, PiloteDTO pilote,DateTime HeureDemarrage, DateTime HeureArret, DateTime HeureAtterissage, DateTime HeureDecolage, double tarifAvion)
        {
            double HeuredeVol, HeureSol;

            HeuredeVol = calculertempsVol(HeureDecolage, HeureAtterissage);
            HeureSol = calculertempssol(HeureDemarrage, HeureDecolage, HeureAtterissage, HeureArret);

            Mappeur.MappeurFacture mappeur = new Mappeur.MappeurFacture();
            facture=mappeur.Map(avion,instruteur,  pilote,  HeuredeVol,  HeureSol,  HeureDemarrage, HeureArret,  HeureAtterissage,  HeureDecolage,  tarifHrVol,  tarifHrSol,facture);

            calculertotalFacture(facture);
        }

        //fonction pour calculer le total d'une facture
        public double calculertotalFacture(FactureDto facture)
        {

            return(facture.HrVol * facture.TarifHrVol) + (facture.TarifHrSol * facture.HrSol);

        }
        
        //Fonction permettant d'aller chercher et de retourner une liste de facture
        public List<FactureDto> getliste()
        {
            return RepositoryFacture.GetListeFacture();

        }

        private double calculertempssol(DateTime heureDemarrage,DateTime heuredecollage,DateTime heureatterrissage,DateTime heurearret)
        {
            double heuresol;
            heuresol=(heuredecollage - heureDemarrage).TotalHours;

            heuresol += (heurearret - heureatterrissage).TotalHours;

            return heuresol;
        
        }
        private double calculertempsVol(DateTime heuredecollage,DateTime heureatterrissage )
        {

            return (heureatterrissage - heuredecollage).TotalHours;

        }
    }
}
