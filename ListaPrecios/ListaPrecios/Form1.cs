using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPrecios
{
    public partial class frmListaPrecios : Form
    {
        private string[,] Producto = new string[3, 2];
        private decimal[] Precio = new decimal[3];

        private int Fila = 0;

        public frmListaPrecios()
        {
            InitializeComponent();
        }
        //TEXT BOX DE CÓDIGO
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
        //BOTON ACEPTAR
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (Fila > 2)
            {
                lblListaPrecios.Text = "Sólo se aceptan 3 productos";
            }
            else
            { 
                Producto[Fila, 0] = txtCodigo.Text;
                Producto[Fila, 1] = txtProducto.Text;

                Precio[Fila] = System.Convert.ToDecimal(txtPrecio.Text);

                Fila = Fila + 1;
            }
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            lblListaPrecios.Text = "LISTA DE PRECIOS \r\n";

            for (int i = 0; i < Precio.Length; i++)
            {
                lblListaPrecios.Text = lblListaPrecios.Text 
                                     + Producto[i, 0] 
                                     + " - " 
                                     + Producto[i, 1] 
                                     + " -- " 
                                     + "$ " + System.Convert.ToInt32(Precio[i])
                                     +"\r\n";
            }
        }
    }
}
