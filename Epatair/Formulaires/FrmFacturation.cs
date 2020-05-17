using Epatair.Dto;
using Epatair.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epatair.Formulaires
{
    //Formulaire qui permet de gérer la facturation
    public partial class FrmFacturation : Form
    {
        GestionFacture GestionFacture;
        Validation.ValidationFacture validationFacture = new Validation.ValidationFacture();
        
        public FrmFacturation(GestionFacture gestionFacture)
        {
            InitializeComponent();
            GestionFacture = gestionFacture;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFacturation_Load(object sender, EventArgs e)
        {

        }

        private void btnaccepterFacture_Click(object sender, EventArgs e)
        {
            GestionFacture.NouvelleFacture(cmbAvionUtiliser.SelectedIndex, cmbinstruteur.SelectedItem.ToString(), cmbClien.SelectedItem.ToString(), Convert.ToDouble(txtHeureVol.Text), Convert.ToDouble(txtHeureSol.Text), Convert.ToDateTime(txtDemarage.Text), Convert.ToDateTime(txtHArret.Text), Convert.ToDateTime(txtHAtterissage.Text), Convert.ToDateTime(txtHDecolage.Text));
            GRBinformation.Enabled = false;
            btnaccepterFacture.Visible = false;
            btnvalidation.Visible = true;
        }

        private void afficherListeview()
        {
            lstviewFacture.Clear();
            InitialiserListViewFacturation(GestionFacture.getliste());
        
        }

        private void InitialiserListViewFacturation(IEnumerable<FactureDto> listeFacture)
        {
            lstviewFacture.View = View.Details;
            lstviewFacture.FullRowSelect = true;
            lstviewFacture.Columns.Add("IdFacture", 3);
            lstviewFacture.Columns.Add("IdAvion", 3);
            lstviewFacture.Columns.Add("IdPilote", 3);
            lstviewFacture.Columns.Add("Nom Pilote", 50);
            lstviewFacture.Sorting = SortOrder.Ascending;

            foreach (var facture in listeFacture)
            {
                lstviewFacture.Items.Add(GetListViewFacture(facture));
            }

            lstviewFacture.Sort();
        }
        private ListViewItem GetListViewFacture(FactureDto Facture)
        {
            ListViewItem item = new ListViewItem(Facture.Idfacture.ToString());
            item.SubItems.Add(Facture.IdAvion.ToString());
            item.SubItems.Add(Facture.Pilote.IdPilote.ToString());
            item.SubItems.Add(Facture.Pilote.Nom);
            return item;
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            GRBinformation.Enabled = true;
        }

        private void btnvalidation_Click(object sender, EventArgs e)
        {
            bool erreur = false;

            if (!validationFacture.validationDouble(txtHeureVol.Text))
            {
                erreur = true;
                MessageBox.Show("Heure de vol doit etre un nombre positif");
            }
            if (!validationFacture.validationDouble(txtHeureSol.Text))
            {
                erreur = true;
                MessageBox.Show("Heure au sol doit etre un nombre positif");
            }


            if (!validationFacture.ValidationDatetime(txtDemarage.Text))
            {
                erreur = true;
                MessageBox.Show("Demarage doit etre dans un forma valide (YYYY-MM-JJ-HH)");
            }
            if (!validationFacture.ValidationDatetime(txtHArret.Text))
            {
                erreur = true;
                MessageBox.Show("Arret doit etre dans un forma valide (YYYY-MM-JJ-HH)");
            }

            if (!validationFacture.ValidationDatetime(txtHAtterissage.Text))
            {
                erreur = true;
                MessageBox.Show("Atterissage doit etre dans un forma valide (YYYY-MM-JJ-HH)");
            }
            if (!validationFacture.ValidationDatetime(txtHDecolage.Text))
            {
                erreur = true;
                MessageBox.Show("Decolage doit etre dans un forma valide (YYYY-MM-JJ-HH)");
            }



            if (!erreur)
            {
                GestionFacture.calculertotal(Convert.ToDouble(txtHeureVol.Text),Convert.ToDouble(txtHeureSol.Text));
                btnaccepterFacture.Visible = true;
                btnvalidation.Visible = false;
            }
            
        }
    }
}
