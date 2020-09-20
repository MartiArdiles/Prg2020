using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargarDatos
{
    
    public partial class Form1 : Form
    {
        string[] Nombres = new string[1];
        string[] Apellidos = new string[1];
        int indice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            if (indice < Nombres.Length)
            {
                CargaDatos();

            }
            else
            {
                //actualizo la dimensión de Nombres
                Nombres = Redimension(Nombres);
                //actualizo la dimensión de Apellidos
                Apellidos = Redimension(Apellidos);

                //Cargo los datos de ambos
                CargaDatos();
            }
            txtNombres.Focus();
            txtNombres.SelectAll();
        }

        private string [] Redimension(string[] Dato)
        {
            string[] temp = new string[Dato.Length + 1];

            for (int i = 0; i < Dato.Length; i++)
            {
                temp[i] = Dato[i];
            }

            Dato = temp;
            return Dato;
        }

        private void CargaDatos()
        {
            Nombres[indice] = txtNombres.Text;
            Apellidos[indice] = txtApellidos.Text;
            indice = indice + 1;
            lblMostrarDatos.Text = lblMostrarDatos.Text + "\r\n" + txtNombres.Text + " " + 
                txtApellidos.Text;
        }


        

        
    }
}
