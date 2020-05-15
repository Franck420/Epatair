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

        void NouvelleFacture(FactureDto facture);

       

    }
}
