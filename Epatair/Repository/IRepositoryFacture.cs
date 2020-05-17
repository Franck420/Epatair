using Epatair.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Repository
{
    public interface IRepositoryFacture
    {


        List<Dto.FactureDto> GetListeFacture();

        void NouvelleFacture(int avion, string instruteur, string pilote, double HeuredeVol, double HeureSol, DateTime HeureDemarrage, DateTime HeureArret, DateTime HeureAtterissage, DateTime HeureDecolage);

       

    }
}
