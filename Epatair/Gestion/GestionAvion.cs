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
    // Classe de Gestion des avions
    public class GestionAvion
    {
        IRepositoryAvion repositoryAvion = new RepositoryAvion();
        AvionDTO Avion = new AvionDTO();
        MappeurAvion mappeurAvion = new MappeurAvion();

        //fonctions pour aller chercher et retourner la liste des avions
        public List<AvionDTO> GetListeAvion()
        {
            return repositoryAvion.GetListeAvion();
        }

        //Fonction pour supprimer un avion
        public void SupprimerAvion(int IdAvion)
        {
            repositoryAvion.SupprimerAvion(IdAvion);
        }

        //Fonction pour créé un avion
        public void NouvelleAvion(string Nom, int IdLogbook, double Tarif)
        {          
            repositoryAvion.NouvealleAvion(Nom, IdLogbook, Tarif);
        }

        //Fonction pour modifier un avion
        public void ModifierAvion(int IdAvion, string Nom, int IdLogbook, double Tarif)
        {
            mappeurAvion.Map(IdAvion, Nom, IdLogbook, Avion, Tarif);
            repositoryAvion.ModifierAvion(Avion);
        }

        public AvionDTO GetAvion(int IdAvion)
        {
            return repositoryAvion.GetAvion(IdAvion);
        }

        public AvionDTO GetAvion(string NomAvion)
        {
            return repositoryAvion.GetAvion(NomAvion);
        }
    }
}
