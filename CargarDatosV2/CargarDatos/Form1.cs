using Lib;
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
        //string[] Nombres = new string[1];
        //string[] Apellidos = new string[1];

        private Lista nombres = new Lista();
        private Lista apellidos = new Lista();
        

        //int indice = 0;
        public Form1()  //constructor
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            nombres.CargaDatos(txtNombres.Text);
            apellidos.CargaDatos(txtApellidos.Text);
            
            //if (indice < Nombres.Length)
            //{
                //nombres.CargaDatos(txtNombres.Text);
                //apellidos.CargaDatos(txtApellidos.Text);
                //CargaDatos();

            //}
            //else
            //{
                //actualizo la dimensión de Nombres
                //Nombres = Redimension(Nombres);
                //actualizo la dimensión de Apellidos
                //Apellidos = Redimension(Apellidos);

                //nombres.CargaDatos(txtNombres.Text);
                //apellidos.CargaDatos(txtApellidos.Text);


                //Cargo los datos de ambos
                //CargaDatos();
            //}
            lblMostrarDatos.Text = lblMostrarDatos.Text + "\r\n" + txtNombres.Text + " " + 
            txtApellidos.Text;

            txtNombres.Focus();
            txtNombres.SelectAll();
        }

        //private string[] Redimension(string[] Dato)
        //{
        //    string[] temp = new string[Dato.Length + 1];

          //  for (int i = 0; i < Dato.Length; i++)
            //{
              //  temp[i] = Dato[i];
            //}

            //Dato = temp;
            //return Dato;
        //}

        //private void CargaDatos()
        //{
          //  Nombres[indice] = txtNombres.Text;
            //Apellidos[indice] = txtApellidos.Text;
            //indice = indice + 1;
            //lblMostrarDatos.Text = lblMostrarDatos.Text + "\r\n" + txtNombres.Text + " " + 
              //  txtApellidos.Text;
        //}
   
    }
}
