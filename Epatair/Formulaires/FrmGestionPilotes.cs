﻿using Epatair.Dto;
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
        }
        private void InitialiserListViewPilote(IEnumerable<PiloteDTO> listePilote)
        {
            lstViewPilote.View = View.Details;
            lstViewPilote.FullRowSelect = true;
            lstViewPilote.Columns.Add("IdPilote", 3);
            lstViewPilote.Columns.Add("Nom", 50);
            lstViewPilote.Columns.Add("Grade", 25);
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

        private PiloteDTO GetPilote(ListViewItem item)
        {
            return ListePilotes.First(a => a.IdPilote.ToString() == item.SubItems[0].Text);
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form AjouterPilote = new FrmAjouterPilote(gestionPilotes);
            AjouterPilote.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Form ModifierPilote = new FrmModifierPilote(gestionPilotes, piloteDTO);
            ModifierPilote.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
        }      

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
