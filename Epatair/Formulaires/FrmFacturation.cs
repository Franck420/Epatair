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
        GestionAvion gestionAvion;
        GestionPilote gestionPilote;
        Validation.ValidationFacture validationFacture = new Validation.ValidationFacture();
        List<AvionDTO> listeAvion = new List<AvionDTO>();

        public FrmFacturation(GestionFacture gestionFacture,GestionPilote gestionPilotes,GestionAvion gestionAvions)
        {
            InitializeComponent();
            GestionFacture = gestionFacture;
            gestionPilote = gestionPilotes;
            gestionAvion = gestionAvions;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFacturation_Load(object sender, EventArgs e)
        {
            remplirecmbAvion(cmbAvionUtiliser);
            remplirecmbPilote(cmbClien,"Pilote");
            remplirecmbPilote(cmbinstruteur,"Instructeur");
            afficherListeview();
        }

        private void btnaccepterFacture_Click(object sender, EventArgs e)
        {
            
           txtTotal.Text=GestionFacture.NouvelleFacture(gestionAvion.GetAvion(cmbAvionUtiliser.SelectedItem.ToString()),gestionPilote.GetPilote(cmbinstruteur.SelectedItem.ToString()), gestionPilote.GetPilote(cmbClien.SelectedItem.ToString()), Convert.ToDateTime(txtDemarage.Text), Convert.ToDateTime(txtHArret.Text), Convert.ToDateTime(txtHAtterissage.Text), Convert.ToDateTime(txtHDecolage.Text),Convert.ToDouble(txtTarifAvion.Text)).ToString("C");
           
            GRBinformation.Enabled = false;
            btnaccepterFacture.Visible = false;
            btnvalidation.Visible = true;

            afficherListeview();

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
            lstviewFacture.Columns.Add("IdFacture", 60);
            lstviewFacture.Columns.Add("IdAvion", 50);
            lstviewFacture.Columns.Add("IdInstructeur", 80);
            lstviewFacture.Columns.Add("IdPilote", 50);
            lstviewFacture.Columns.Add("Nom Pilote", 80);
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
            
            item.SubItems.Add(Facture.avion.ToString());
            item.SubItems.Add(Facture.Instructeur.ToString());
            item.SubItems.Add(Facture.Pilote.ToString());
            item.SubItems.Add(gestionPilote.GetPilote(Facture.Pilote).Nom);
            return item;
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            GRBinformation.Enabled = true;
            txtDemarage.Text = "";
            txtHArret.Text = "";
            txtHAtterissage.Text = "";
            txtHDecolage.Text = "";
            txtTarifAvion.Text = "";
            txtTotal.Text = "";
            cmbAvionUtiliser.SelectedIndex = 0;
            cmbClien.SelectedIndex = -1;
            cmbinstruteur.SelectedIndex = -1;
        }

        private void btnvalidation_Click(object sender, EventArgs e)
        {
            bool erreur = false;


            if (!validationFacture.validationDouble(txtTarifAvion.Text))
                {
                
                MessageBox.Show("appuier sur l avion pour avoir le tarif "); 
            
                }

            if (!validationFacture.ValidationDatetime(txtDemarage.Text))
            {
                erreur = true;
                MessageBox.Show("Demarage doit etre dans un forma valide (HH:mm)");
            }
            if (!validationFacture.ValidationDatetime(txtHArret.Text))
            {
                erreur = true;
                MessageBox.Show("Arret doit etre dans un forma valide (HH:mm)");
            }

            if (!validationFacture.ValidationDatetime(txtHAtterissage.Text))
            {
                erreur = true;
                MessageBox.Show("Atterissage doit etre dans un forma valide (HH:mm)");
            }
            if (!validationFacture.ValidationDatetime(txtHDecolage.Text))
            {
                erreur = true;
                MessageBox.Show("Decolage doit etre dans un forma valide (HH:mm)");
            }



            if (!erreur)
            {
                
                btnaccepterFacture.Visible = true;
                btnvalidation.Visible = false;
            }
            
        }
        private void remplirecmbPilote(ComboBox cmb,string grade)
        {
            List<PiloteDTO> listePilote = new List<PiloteDTO>();
            listePilote=gestionPilote.GetListePilote(grade);

            foreach (PiloteDTO Pilote in listePilote)
                cmb.Items.Add(Pilote.Nom);
        }

        private void remplirecmbAvion(ComboBox cmb)
        {
            
            listeAvion = gestionAvion.GetListeAvion();
            foreach (AvionDTO Avion in listeAvion)
                cmbAvionUtiliser.Items.Add(Avion.Nom);
        }

        private void cmbAvionUtiliser_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtTarifAvion.Text = Convert.ToString(gestionAvion.GetAvion(cmbAvionUtiliser.SelectedItem.ToString()).Tarif.ToString());
        }

        private void lstviewFacture_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        { }

        private void Btnannuler_Click(object sender, EventArgs e)
        {
            GRBinformation.Enabled = false;
        }
    }
}
