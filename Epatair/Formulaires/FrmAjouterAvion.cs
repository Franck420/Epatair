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
            try
            {
                gestionAvions.NouvelleAvion(TxtNom.Text, Convert.ToInt32(txtIdLogbook.Text));
                MessageBox.Show("L'avion a été ajouté à la base de donnée avec succès!");
            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite pendant la création de l'avion!");
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
