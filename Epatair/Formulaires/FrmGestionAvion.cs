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
    public partial class FrmGestionAvion : Form
    {
        GestionAvion gestionAvions;
        AvionDTO piloteDTO = new AvionDTO();

        public FrmGestionAvion(GestionAvion gestionAvion)
        {
            InitializeComponent();
            gestionAvions = gestionAvion;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form AjouterAvion = new FrmAjouterAvion(gestionAvions);
            AjouterAvion.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Form ModifierAvion = new FrmModifierAvion(gestionAvions, piloteDTO);
            ModifierAvion.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnRevenir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
