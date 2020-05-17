using Epatair.Dto;
using Epatair.Mappeur;
using Epatair.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Gestion
{
    public class GestionAvion
    {
        IRepositoryAvion repositoryAvion = new RepositoryAvion();
        AvionDTO Avion = new AvionDTO();
        MappeurAvion mappeurAvion = new MappeurAvion();

        public List<AvionDTO> GetListeAvion()
        {
            return repositoryAvion.GetListeAvion();
        }

        public void SupprimerAvion(int IdAvion)
        {
            repositoryAvion.SupprimerAvion(IdAvion);
        }

        public void NouvelleAvion(string Nom, int IdLogbook)
        {          
            repositoryAvion.NouvealleAvion(Nom, IdLogbook);
        }

        public void ModifierAvion(int IdAvion, string Nom, int IdLogbook)
        {
            mappeurAvion.Map(IdAvion, Nom, IdLogbook, Avion);
            repositoryAvion.ModifierAvion(Avion);
        }
    }
}
