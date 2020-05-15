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
        IRepositoryFacture RepositoryFacture=new RepositoryFacture();

        public void NouvelleFacture(int avion,string instruteur,string pilote,double HeuredeVol,double HeureSol,DateTime HeureDemarrage,DateTime HeureArret,DateTime HeureAtterissage,DateTime HeureDecolage)
        {
       



        }

        private double calculertotal()
        {
            return 0;
        }

    }
}
