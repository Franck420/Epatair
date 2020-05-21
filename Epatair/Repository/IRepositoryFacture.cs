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
        //Fonction permettant d'aller chercher et de retourner une liste de facture
        List<Dto.FactureDto> GetListeFacture();

        //Fonction pour créer une nouvelle facture
        void NouvelleFacture(FactureDto facture);

        //Fonction permettant d'aller chercher une facture avec son ID
        FactureDto GetFacture(int IdFacture);


    }
}
