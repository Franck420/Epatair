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
    public partial class FrmFacturation : Form
    {
        public FrmFacturation(GestionFacture gestionFacture)
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFacturation_Load(object sender, EventArgs e)
        {

        }
    }
}
