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

    //Formulaire qui permet de rajouter un pilote à la BD

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
            try
            {
                gestionPilotes.NouveauPilote(txtNom.Text, cmbGrade.SelectedItem.ToString());
                MessageBox.Show("Le pilote a été ajouté à la base de donnée avec succès!");
            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite pendant la création du pilote!");
            }
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
