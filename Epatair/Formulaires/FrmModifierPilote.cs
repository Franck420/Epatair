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
    //Formulaire qui permet de modifié les pilotes  
    public partial class FrmModifierPilote : Form
    {
        GestionPilote gestionPilotes;
        public FrmModifierPilote(GestionPilote gestionPilote, PiloteDTO pilote)
        {
            gestionPilotes = gestionPilote;
            InitializeComponent();
            txtId.Text = pilote.IdPilote.ToString();
            txtNom.Text = pilote.Nom;

            if (pilote.Grade == "Pilote")
                cmbGrade.SelectedIndex = 0;
            else if (pilote.Grade == "Instructeur")
                cmbGrade.SelectedIndex = 1;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                gestionPilotes.ModifierPilote(Convert.ToInt32(txtId.Text), txtNom.Text, cmbGrade.SelectedItem.ToString());
                MessageBox.Show("Le pilote a été modifié dans la base de donnée avec succès!");
            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite pendant la modification du pilote!");
            }           
        }

        private void FrmModifierPilote_Load(object sender, EventArgs e){}

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
