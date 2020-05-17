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
    public class GestionFacture
    {
        IRepositoryFacture RepositoryFacture = new RepositoryFacture();
        double tarifHrVol,tarifHrSol,TarifHrSolInstruteur,TarifHrVolInstruteur;

        public void NouvelleFacture(int avion, string instruteur, string pilote, double HeuredeVol, double HeureSol, DateTime HeureDemarrage, DateTime HeureArret, DateTime HeureAtterissage, DateTime HeureDecolage)
        {
            RepositoryFacture.NouvelleFacture(avion, instruteur, pilote, HeuredeVol, HeureSol, HeureDemarrage, HeureArret, HeureAtterissage, HeureDecolage);

            

        }

        public double calculertotal(double HeuredeVol, double HeureSol)
        {
            return 0;
        }
        public List<FactureDto> getliste()
            {
                return RepositoryFacture.GetListeFacture();

            }

    }
}
