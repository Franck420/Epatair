using Epatair.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Repository
{
    //Interface pour le repository des pilotes
    interface IRepositoryPilote
    {
        //fonctions pour aller chercher et retourner la liste des pilotes
        List<PiloteDTO> GetListePilote();

        //Fonction pour aller chercher un pilote grâce à son ID
        PiloteDTO GetPilote(int IdPilote);

        //Fonction pour aller chercher une liste de pilotes selon leur grade
        List<PiloteDTO> GetListePilote(string grade);

        //Fonction pour créé un pilote
        void NouveauPilote(PiloteDTO Pilote);

        //Fonction pour supprimer un pilote
        void SupprimerPilote(int IdPilote);

        //Fonction pour modifier un pilote
        void ModifierPilote(PiloteDTO Pilote);

    }
}
