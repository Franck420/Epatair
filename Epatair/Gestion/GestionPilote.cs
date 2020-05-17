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
    // Classe de Gestion des pilotes
    public class GestionPilote
    {
        IRepositoryPilote repositoryPilote = new RepositoryPilote();
        PiloteDTO Pilote = new PiloteDTO();
        MappeurPilote mappeurPilote = new MappeurPilote();


        //fonctions pour aller chercher et retourner la liste des pilotes
        public List<PiloteDTO> GetListePilote()
        {
            return repositoryPilote.GetListePilote();
        }

        //Fonction pour aller chercher un pilote grâce à son ID
        public PiloteDTO GetPilote(int IdPilote)
        {
            return repositoryPilote.GetPilote(IdPilote);
        }

        //Fonction pour aller chercher une liste de pilotes selon leur grade
        public List<PiloteDTO> GetListePilote(string grade)
        {
           return repositoryPilote.GetListePilote(grade);
        }

        //Fonction pour créé un pilote
        public void NouveauPilote(string Nom, string Grade)
        {            
            mappeurPilote.Map(Nom,Grade,Pilote);
            repositoryPilote.NouveauPilote(Pilote);
        }

        //Fonction pour supprimer un pilote
        public void SupprimerPilote(int IdPilote)
        {           
            repositoryPilote.SupprimerPilote(IdPilote);
        }

        //Fonction pour modifier un pilote
        public void ModifierPilote(int ID, string Nom, string Grade)
        {            
            mappeurPilote.Map(ID,Nom, Grade, Pilote);
            repositoryPilote.ModifierPilote(Pilote);
        }

    }
}
