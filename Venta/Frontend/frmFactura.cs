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
        #region Propiedades

        Factura facturaObj;
        RngFactura rngFacturaObj;
        public decimal TotalAbsoluto;
        #endregion

        #region Constructor
        public frmFactura()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos
        private void btNuevaFactura_Click(object sender, EventArgs e)
        {
            LimpiarControles();

            //limpia el objeto facturaobj y asigna los valores iniciales que trae factura
            NuevaFactura();

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
        private void btCargarProducto_Click(object sender, EventArgs e)
        {
            rngFacturaObj = new RngFactura();
            rngFacturaObj.cantidad = System.Convert.ToDecimal(txtCantidad.Text);
            rngFacturaObj.producto = System.Convert.ToString(txtProducto.Text);
            rngFacturaObj.unitario = System.Convert.ToDecimal(txtUnitario.Text);

            facturaObj.AdicionaRngFactura(rngFacturaObj);


            //Al total lo saco con el método creado en rngfactura
            txtTotalRenglon.Text = rngFacturaObj.Total().ToString();

            //Sumar bruto
            if (lblBruto.Text == "")
            {
                lblBruto.Text = txtTotalRenglon.Text;
            }
            else
            {
                lblBruto.Text = (Convert.ToDecimal(lblBruto.Text) + rngFacturaObj.Total()).ToString();
            }

            //sacar IVA
            lblIVA.Text = ((Convert.ToDecimal(lblBruto.Text) * 21) / 100).ToString();

            //Sumar el total absoluto
            lblTotal.Text = (Convert.ToDecimal(lblBruto.Text) + Convert.ToDecimal(lblIVA.Text)).ToString();

            facturaObj.Neto = (Convert.ToDecimal(lblBruto.Text));
            facturaObj.IVA = (Convert.ToDecimal(lblIVA.Text));
            facturaObj.Total = (Convert.ToDecimal(lblTotal.Text));
            

            MuestraRenglones();

       
        }

        #endregion

        #region Metodos
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

        private void LimpiaBlancosEncabezado()
        {
            txtCliente.Text = txtCliente.Text.Trim();
            txtNFactura.Text = txtNFactura.Text.Trim();
            txtCuit.Text = txtCuit.Text.Trim();
        }

        private void MuestraRenglones()
        {
            //todo:mostrar todos los renglones
            lblRenglones.Text = facturaObj.MuestraRenglones();
        }

        #endregion


    }



}

