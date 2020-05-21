using Epatair.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Repository
{
    //Interface pour le repository des avions
    interface IRepositoryAvion
    {
        //fonctions pour aller chercher et retourner la liste des avions
        List<AvionDTO> GetListeAvion();
        //Fonction pour créé un avion
        void NouvealleAvion(string nom,int IdLogbook, double Tarif);
        //Fonction pour supprimer un avion
        void SupprimerAvion(int IdAvion);
        //Fonction pour modifier un avion
        void ModifierAvion(AvionDTO Avion);

        AvionDTO GetAvion(int IdAvion);

        AvionDTO GetAvion(string NomAvion);
    }
}
