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
            AjouterAvion.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Form ModifierAvion = new FrmModifierAvion(gestionAvions, avionDTO);
            ModifierAvion.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            gestionAvions.SupprimerAvion(Convert.ToInt32(txtSupprimer.Text));
        }

        private void btnRevenir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGestionAvion_Load(object sender, EventArgs e)
        {
            RemplirListe();
        }

        private void InitialiserListViewAvion(IEnumerable<AvionDTO> listeAvion)
        {           
            lstViewAvion.View = View.Details;
            lstViewAvion.FullRowSelect = true;
            lstViewAvion.Columns.Add("IdAvion", 3);
            lstViewAvion.Columns.Add("Nom", 50);
            lstViewAvion.Columns.Add("IdLogbook", 3);
            lstViewAvion.Sorting = SortOrder.Ascending;

            foreach (var Avion in listeAvion)
            {
                lstViewAvion.Items.Add(GetListViewAvion(Avion));
            }

            lstViewAvion.Sort();
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
            InitialiserListViewAvion(ListeAvions);
        }

    }
}
