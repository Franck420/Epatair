using Epatair.Dto;
using Epatair.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epatair.Formulaires
{
    public partial class FrmGestionPilotes : Form
    {
        GestionPilote gestionPilotes;
        PiloteDTO piloteDTO = new PiloteDTO();
        List<PiloteDTO> ListePilotes = new List<PiloteDTO>();

        public FrmGestionPilotes(GestionPilote gestionPilote)
        {
            InitializeComponent();
            gestionPilotes = gestionPilote;
        }
        private void FrmGestionPilotes_Load(object sender, EventArgs e)
        {
            ListePilotes = gestionPilotes.GetListePilote();
            InitialiserListViewPilote(ListePilotes);
            RemplirListe();
        }
        private void InitialiserListViewPilote(IEnumerable<PiloteDTO> listePilote)
        {
            lstViewPilote.View = View.Details;
            lstViewPilote.FullRowSelect = true;
            lstViewPilote.Columns.Add("IdPilote", 50);
            lstViewPilote.Columns.Add("Nom", 100);
            lstViewPilote.Columns.Add("Grade", 100);
            lstViewPilote.Sorting = SortOrder.Ascending;           
        }
        private ListViewItem GetListViewPilote(PiloteDTO Pilote)
        {
            ListViewItem item = new ListViewItem(Pilote.IdPilote.ToString());
            item.SubItems.Add(Pilote.Nom);
            item.SubItems.Add(Pilote.Grade);
            return item;
        }      
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form AjouterPilote = new FrmAjouterPilote(gestionPilotes);
            AjouterPilote.ShowDialog();
            lstViewPilote.Items.Clear();
            RemplirListe();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtModifier.Text, out int Id))
            {
                foreach (var Pilote in ListePilotes)
                {

                    if (Pilote.IdPilote == Id)
                    {
                        piloteDTO = Pilote;
                        break;
                    }
                }

                Form ModifierPilote = new FrmModifierPilote(gestionPilotes, piloteDTO);
                ModifierPilote.ShowDialog();
                lstViewPilote.Items.Clear();
                RemplirListe();
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
                    gestionPilotes.SupprimerPilote(Convert.ToInt32(txtSupprimer.Text));
                    lstViewPilote.Items.Clear();
                    RemplirListe();
                    txtSupprimer.Clear();
                    MessageBox.Show("Le pilote a été supprimé de la base de donnée avec succès!");
                }
                catch
                {
                    MessageBox.Show("Une erreur s'est produite pendant la supression du pilote!");
                }               
            }
            else
                MessageBox.Show("Veuillez entrez un Id valide svp");
        }      

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemplirListe()
        {
            
            ListePilotes = gestionPilotes.GetListePilote();      

            foreach (var Pilote in ListePilotes)
            {
                lstViewPilote.Items.Add(GetListViewPilote(Pilote));
            }

            lstViewPilote.Sort();
        }

    }
}
