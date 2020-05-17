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
        AvionDTO avionDTO = new AvionDTO();
        List<AvionDTO> ListeAvions = new List<AvionDTO>();

        public FrmGestionAvion(GestionAvion gestionAvion)
        {
            InitializeComponent();
            gestionAvions = gestionAvion;

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form AjouterAvion = new FrmAjouterAvion(gestionAvions);
            AjouterAvion.ShowDialog();
            lstViewAvion.Items.Clear();
            RemplirListe();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtModifier.Text, out int Id))
            {
                foreach (var Avion in ListeAvions)
                {

                    if (Avion.IdAvion == Id)
                    {
                        avionDTO = Avion;
                        break;
                    }
                }

                Form ModifierAvion = new FrmModifierAvion(gestionAvions, avionDTO);
                ModifierAvion.ShowDialog();
                lstViewAvion.Items.Clear();
                RemplirListe();
                txtModifier.Clear();

            }
            else
                MessageBox.Show("Veuillez entrez un Id valide svp");


            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtSupprimer.Text, out int Id))
            {
                try
                {
                    gestionAvions.SupprimerAvion(Convert.ToInt32(txtSupprimer.Text));
                    lstViewAvion.Items.Clear();
                    RemplirListe();
                    txtSupprimer.Clear();
                    MessageBox.Show("L'avion a été supprimé de la base de donnée avec succès!");
                }
                catch
                {
                    MessageBox.Show("Une erreur s'est produite pendant la supression de l'avion!");
                }
             
            }
            else
                MessageBox.Show("Veuillez entrez un Id valide svp");
        }

        private void btnRevenir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGestionAvion_Load(object sender, EventArgs e)
        {
            ListeAvions = gestionAvions.GetListeAvion();
            InitialiserListViewAvion(ListeAvions);
            RemplirListe();
        }

        private void InitialiserListViewAvion(IEnumerable<AvionDTO> listeAvion)
        {           
            lstViewAvion.View = View.Details;
            lstViewAvion.FullRowSelect = true;
            lstViewAvion.Columns.Add("IdAvion", 50);
            lstViewAvion.Columns.Add("Nom", 90);
            lstViewAvion.Columns.Add("IdLogbook", 65);
            lstViewAvion.Sorting = SortOrder.Ascending;
        }
        private ListViewItem GetListViewAvion(AvionDTO Avion)
        {
            ListViewItem item = new ListViewItem(Avion.IdAvion.ToString());
            item.SubItems.Add(Avion.Nom);
            item.SubItems.Add(Avion.IdLogbook.ToString());
            return item;
        }
        private void RemplirListe()
        {
            
            ListeAvions = gestionAvions.GetListeAvion();

            foreach (var Avion in ListeAvions)
            {
                lstViewAvion.Items.Add(GetListViewAvion(Avion));
            }

            lstViewAvion.Sort();
            
        }



      
    }
}
