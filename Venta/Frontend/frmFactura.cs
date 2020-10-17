using System;
using Backend;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class frmFactura : Form
    {
        Factura facturaObj;
        public frmFactura()
        {
            InitializeComponent();
        }

        private void btNuevaFactura_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            NuevaFactura();
            
        }

        private void LimpiarControles()
        {
            lblBruto.Text = "";
            txtCliente.Text = "";
            txtCuit.Text = "";
            txtFecha.Text = "";
            txtNFactura.Text = "";
            lblTotal.Text = "";
            lblIVA.Text = "";

            paRenglones.Enabled = false;
        }

        private void NuevaFactura()
        {
            facturaObj = new Factura();
            txtFecha.Text = facturaObj.Fecha.ToString("dd/MM/yyyy");
            //todo: ACTUALIZAR NUMERO DE FACTURA

            txtNFactura.Focus();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            LimpiaBlancosEncabezado();
            //validar datos de encabezado
            if (txtNFactura.Text.Trim() == "" || txtCuit.Text.Trim() == "" || txtCliente.Text.Trim() == "")
            {
                lblErrorEncabezado.Text = "Faltan datos en el encabezado";
            }
            else
            {
                //llenar propiedades del encabezado

                facturaObj.NumeroFactura = txtNFactura.Text;
                facturaObj.Cliente = txtCliente.Text;
                facturaObj.CUIT = txtCuit.Text;
                facturaObj.Fecha = System.Convert.ToDateTime(txtFecha.Text);

                //continuar
                paRenglones.Enabled = true;
                txtCantidad.Focus();
                lblErrorEncabezado.Text = "";
            }
            

            
        }
    
        private void LimpiaBlancosEncabezado()
        {
            txtCliente.Text = txtCliente.Text.Trim();
            txtNFactura.Text = txtNFactura.Text.Trim();
            txtCuit.Text = txtCuit.Text.Trim();
        }
    
    
    
    }



}

