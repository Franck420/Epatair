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
    public partial class FrmGestionPilotes : Form
    {
        GestionPilote gestionPilotes;
        PiloteDTO piloteDTO = new PiloteDTO();

        public FrmGestionPilotes(GestionPilote gestionPilote)
        {
            InitializeComponent();
            gestionPilotes = gestionPilote;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form AjouterPilote = new FrmAjouterPilote(gestionPilotes);
            AjouterPilote.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Form ModifierPilote = new FrmModifierPilote(gestionPilotes, piloteDTO);
            ModifierPilote.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
        }      

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
