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
    public partial class FrmModifierAvion : Form
    {

        GestionAvion gestionAvions;

        public FrmModifierAvion(GestionAvion gestionAvion, AvionDTO Avion)
        {
            gestionAvions = gestionAvion;

            InitializeComponent();
            txtIdAvion.Text = Avion.IdAvion.ToString();
            txtNom.Text = Avion.Nom;
            txtIdLogbook.Text = Avion.IdLogbook.ToString();

        }
        
        private void btnModifier_Click(object sender, EventArgs e)
        {
            gestionAvions.ModifierAvion(Convert.ToInt32(txtIdAvion.Text), txtNom.Text, Convert.ToInt32(txtIdLogbook.Text));
        }

        private void FrmModifierAvion_Load(object sender, EventArgs e)
        {

        }
    }
}
