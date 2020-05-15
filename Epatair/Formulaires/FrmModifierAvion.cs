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
    public partial class FrmModifierAvion : Form
    {
        public FrmModifierAvion(GestionAvion gestionAvion, AvionDTO avionDTO)
        {
            InitializeComponent();
        }
    }
}
