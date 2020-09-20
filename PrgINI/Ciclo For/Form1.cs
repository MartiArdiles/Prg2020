using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclo_For
{
    public partial class frmContador : Form
    {
        public frmContador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btContar_Click(object sender, EventArgs e)
        {
            for (int i = System.Convert.ToInt32(txtDesde.Text); 
                     i <= System.Convert.ToInt32(txtHasta.Text); 
                     i = i + System.Convert.ToInt32(txtPaso.Text))
            {
                lblRes.Text = System.Convert.ToString(i);
                this.Refresh();
            }
        }
    }
}
