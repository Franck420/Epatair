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
    public partial class FrmAjouterAvion : Form
    {
        GestionAvion gestionAvions;
        public FrmAjouterAvion(GestionAvion gestionAvion)
        {
            InitializeComponent();
            gestionAvions= gestionAvion;
        }

    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            gestionAvions.NouvelleAvion(TxtNom.Text,Convert.ToInt32(txtIdLogbook.Text));
        }
    }
}
