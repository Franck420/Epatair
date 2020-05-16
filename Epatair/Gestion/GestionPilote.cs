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
    public class GestionPilote
    {
        IRepositoryPilote repositoryPilote = new RepositoryPilote();
        PiloteDTO Pilote = new PiloteDTO();
        


        public List<PiloteDTO> GetListePilote()
        {
            return repositoryPilote.GetListePilote();
        }
        public PiloteDTO GetPilote(int IdPilote)
        {
            return repositoryPilote.GetPilote(IdPilote);
        }
        public List<PiloteDTO> GetListePilote(string grade)
        {
           return repositoryPilote.GetListePilote(grade);
        }
        public void NouveauPilote(string Nom, string Grade)
        {
            MappeurPilote mappeurPilote = new MappeurPilote();
            mappeurPilote.Map(Nom,Grade,Pilote);
            repositoryPilote.NouveauPilote(Pilote);
        }
        public void SupprimerPilote(int IdPilote)
        {

        }
        public void ModifierPilote(PiloteDTO Pilote)
        {

        }

    }
}
