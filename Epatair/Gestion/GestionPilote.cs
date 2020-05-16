using Epatair.Dto;
using Epatair.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Gestion
{
    public class GestionPilote
    {
        IRepositoryPilote repositoryPilote = new RepositoryPilote();

        public List<PiloteDTO> GetListePilote()
        {
            return repositoryPilote.GetListePilote();
        }
      
        public List<PiloteDTO> GetListePilote(string grade)
        {
           return repositoryPilote.GetListePilote(grade);
        }
        public void NouveauPilote(PiloteDTO Pilote)
        {

        }
        public void SupprimerPilote(int IdPilote)
        {

        }
        public void ModifierPilote(PiloteDTO Pilote)
        {

        }

    }
}
