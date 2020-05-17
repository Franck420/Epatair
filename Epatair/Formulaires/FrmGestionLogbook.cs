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
    //Formulaire qui permet de gérer les logbooks  (NE FAIT PAS PARTIE DU SPRINT 1)(TODO)
    public partial class FrmGestionLogbook : Form
    {

        GestionLogbook gestionLogbooks;
        LogbookDTO logbookDTO = new LogbookDTO();
        public FrmGestionLogbook(GestionLogbook gestionLogbook)
        {
            InitializeComponent();
            gestionLogbooks = gestionLogbook;
        }      

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Form ModifierEntretien= new FrmModifierEntretien(gestionLogbooks, logbookDTO);
            ModifierEntretien.Show();
        }

        private void btnRemplir_Click(object sender, EventArgs e)
        {
            Form AjouterAvion = new FrmRemplirHeures(gestionLogbooks);
            AjouterAvion.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
