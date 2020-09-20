using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaIf2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            int edad = System.Convert.ToInt32(txtEdad.Text);

            if (edad < 12)
            {
                lblResultado.Text = "NIÑO";
            }
            else if (edad >= 12 && edad < 18)
            {
               lblResultado.Text = "ADOLESCENTE";
            }
            else if (edad >= 18 && edad < 60)
            {
                lblResultado.Text = "ADULTO";
            }
            else
            {
                lblResultado.Text = "ADULTO MAYOR";
            }
        }
    }
}
