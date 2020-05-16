using Epatair.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Repository
{
    interface IRepositoryPilote
    {
        List<PiloteDTO> GetListePilote();
        int GetPilote(int IdPilote);
        List<PiloteDTO> GetListePilote(string grade);
        void NouveauPilote(PiloteDTO Pilote);
        void SupprimerPilote(int IdPilote);
        void ModifierPilote(PiloteDTO Pilote);

    }
}
