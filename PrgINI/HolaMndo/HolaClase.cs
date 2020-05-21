using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMndo
{
    public partial class HolaClase : Form
    {
        public HolaClase()
        {
            InitializeComponent();
        }

        private void HolaClase_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Hola gente de la materia " + txtMateria.Text;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
