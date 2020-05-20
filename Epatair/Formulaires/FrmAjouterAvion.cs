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
    //Formulaire qui permet de rajouter un avion à la BD

    public partial class FrmAjouterAvion : Form
    {
        GestionAvion gestionAvions;
        public FrmAjouterAvion(GestionAvion gestionAvion)
        {
            InitializeComponent();
            gestionAvions= gestionAvion;
        }   

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdLogbook.Text, out int IdLogbook) && double.TryParse(txtTarif.Text, out double Tarif))
                try
                {
                    gestionAvions.NouvelleAvion(TxtNom.Text, IdLogbook, Tarif);
                    MessageBox.Show("L'avion a été ajouté à la base de donnée avec succès!");
                }
                catch
                {
                    MessageBox.Show("Une erreur s'est produite pendant la création de l'avion!");
                }
            else
                MessageBox.Show("Veuillez entrez des valeurs correct pour continuer!");
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
