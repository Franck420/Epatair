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
    //Formulaire qui permet de gérer les RendezVous  (NE FAIT PAS PARTIE DU SPRINT 1)(TODO)
    public partial class FrmGestionRendezVous : Form
    {

        GestionRendezVous gestionRendezVous2;

        public FrmGestionRendezVous(GestionRendezVous gestionRendezVous)
        {
            InitializeComponent();
            gestionRendezVous2 = gestionRendezVous;
        }

     

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifierRDV_Click(object sender, EventArgs e)
        {
            Form ModifierRDV = new FrmModifierRendezVous(gestionRendezVous2);
            ModifierRDV.Show();
        }
    }
}
