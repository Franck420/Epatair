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
        GestionPilote gestionPilote = new GestionPilote();
        GestionAvion gestionAvion = new GestionAvion();
        GestionRendezVous gestionRendezVous = new GestionRendezVous();
        GestionLogbook gestionLogbook = new GestionLogbook();

        public FrmMenuAdmin()
        {
            InitializeComponent();

        }
        private void btnFacturation_Click(object sender, EventArgs e)
        {
            Form Facturation = new FrmFacturation(gestionFacture);
            Facturation.Show();
        }         

        private void btnAvion_Click(object sender, EventArgs e)
        {
            Form Avion = new FrmGestionAvion(gestionAvion);
            Avion.Show();
        }

        private void btnPilote_Click(object sender, EventArgs e)
        {
            Form Pilote = new FrmGestionPilotes(gestionPilote);
            Pilote.Show();
        }

        private void btnLogbook_Click(object sender, EventArgs e)
        {
            Form Logbook = new FrmGestionLogbook(gestionLogbook);
            Logbook.Show();
        }

        private void btnRendezVous_Click(object sender, EventArgs e)
        {
            Form RendezVous = new FrmGestionRendezVous(gestionRendezVous);
            RendezVous.Show();
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
