using Epatair.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Repository
{
    interface IRepositoryAvion
    {       
        AvionDTO GetAvion(int IdAvion);
        List<AvionDTO> GetListeAvion();
        void NouvealleAvion(string nom);
        void SupprimerAvion(int IdAvion);
        void ModifierAvion(AvionDTO Avion);
    }
}
