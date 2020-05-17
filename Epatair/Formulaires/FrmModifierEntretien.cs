using Epatair.Dto;
using Epatair.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epatair.Formulaires
{
    //Formulaire qui permet de modifié les Entretiens  (NE FAIT PAS PARTIE DU SPRINT 1)(TODO)
    public partial class FrmModifierEntretien : Form
    {
        public FrmModifierEntretien(GestionLogbook gestionLogbook, LogbookDTO logbookDTO)
        {
            InitializeComponent();
        }
    }
}
