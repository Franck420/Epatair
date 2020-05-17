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
    //Formulaire qui permet de modifié les avions 
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
            try
            {
                gestionAvions.ModifierAvion(Convert.ToInt32(txtIdAvion.Text), txtNom.Text, Convert.ToInt32(txtIdLogbook.Text));
                MessageBox.Show("L'avion a été modifié dans la base de donnée avec succès!");
            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite pendant la modification de l'avion!");
            }
        }

        private void FrmModifierAvion_Load(object sender, EventArgs e){}

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
