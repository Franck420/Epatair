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
        double tarifHrVol,tarifHrSol,TarifHrSolInstruteur,TarifHrVolInstruteur;

        //Fonction pour créer une nouvelle facture
        public void NouvelleFacture(int avion, string instruteur, string pilote, double HeuredeVol, double HeureSol, DateTime HeureDemarrage, DateTime HeureArret, DateTime HeureAtterissage, DateTime HeureDecolage)
        {
            RepositoryFacture.NouvelleFacture(avion, instruteur, pilote, HeuredeVol, HeureSol, HeureDemarrage, HeureArret, HeureAtterissage, HeureDecolage);
        }

        //fonction pour calculer le total d'une facture
        public double calculertotal(double HeuredeVol, double HeureSol)
        {
            return 0;
        }
        
        //Fonction permettant d'aller chercher et de retourner une liste de facture
        public List<FactureDto> getliste()
        {
            return RepositoryFacture.GetListeFacture();

        }

    }
}
