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
    public partial class FrmAjouterPilote : Form
    {

        GestionPilote gestionPilotes;
        public FrmAjouterPilote(GestionPilote gestionPilote)
        {
            InitializeComponent();
            gestionPilotes = gestionPilote;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            gestionPilotes.NouveauPilote(txtNom.Text, cmbGrade.SelectedItem.ToString());
        }
    }
}
