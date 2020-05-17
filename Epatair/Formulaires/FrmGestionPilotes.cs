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
            

            foreach (var Pilote in listePilote)
            {
                lstViewPilote.Items.Add(GetListViewPilote(Pilote));
            }

            lstViewPilote.Sort();
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
            AjouterPilote.Show();
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
                ModifierPilote.Show();
                RemplirListe();
            }
            else
                MessageBox.Show("Veuillez entrez un Id valide svp");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtModifier.Text, out int Id))
            {
                gestionPilotes.SupprimerPilote(Convert.ToInt32(txtSupprimer.Text));
                RemplirListe();
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
            lstViewPilote.Clear();
            ListePilotes = gestionPilotes.GetListePilote();
            InitialiserListViewPilote(ListePilotes);           
        }

    }
}
