using Epatair.Formulaires;
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

namespace Epatair
{
    public partial class FrmMenuAdmin : Form
    {

        GestionFacture gestionFacture = new GestionFacture();
        GestionFacture gestionFacture2 = new GestionFacture();

        public FrmMenuAdmin()
        {
            InitializeComponent();

        }

        private void btnFacturer_Click(object sender, EventArgs e)
        {

        }

        private void btnCours_Click(object sender, EventArgs e)
        {

        }

        private void btnRemplir_Click(object sender, EventArgs e)
        {

        }

        private void btnPilote_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFacturation_Click(object sender, EventArgs e)
        {
            Form Facturation = new FrmFacturation(gestionFacture);
            Facturation.Show();

        }
    }
}
