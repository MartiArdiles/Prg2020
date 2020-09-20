using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargarDatos
{
    public partial class Form1 : Form
    {
        string[] Datos;
        int indice = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btDefinir_Click(object sender, EventArgs e)
        {
            Datos = new string[System.Convert.ToInt32(txtCantidad.Text)];
            btCargar.Enabled = true;

            txtDato.Focus();
        }
        private void btCargar_Click(object sender, EventArgs e)
        { 
            if (indice < Datos.Length)
            {
                Datos[indice] = txtDato.Text + "/r/n";
                indice = indice + 1;

            }
            else
            {
                lblMostrarDatos.Text = "El dato " + txtDato.Text + " no se ha cargado porque se excedió el límite";
            }
            txtDato.Clear();
            txtDato.Focus();
            

        }

        
    }
}
