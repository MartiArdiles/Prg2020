using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Backend;

namespace ControlStock
{
    public partial class Comprobante : Form
    {
        #region Constructor
        public Comprobante()
        {
            InitializeComponent();
        }

        #endregion

        #region Propiedades
        claseComprobante comprobanteObj;
        RngComprobante rngComprobanteObj;
        public int indice = 0;
        public decimal total = 0;
        public decimal subtotal = 0;
        public decimal descuento = 0;
        ListViewItem producto = new ListViewItem();
        DataTable tabla = new DataTable();
        #endregion

        #region Eventos
        private void btNuevoComprobante_Click(object sender, EventArgs e)
        {
            btGrabarXml.Enabled = false;
            LimpiarControles();
            NuevoComprobante();
            paDatosComp.Enabled = true;
            txtNumComprobante.Focus();
            ListaProductos.Items.Clear();


            //CREO LA TABLA DONDE SE VAN A GUARDAR LOS DATOS EN XML CON EL METODO
            CrearTabla();


            //CHEQUEO TIPO DE CLIENTE
            if (rbuVentaMayor.Checked)
            {
                label10.Visible = true;
                txtCUIT.Visible = true;
                lblTipoVenta.Text = "Venta por mayor al cliente ";
                //ASIGNO EL TIPO CLIENTE AL OBJETO COMPROBANTE
                comprobanteObj.TipoCliente = rbuVentaMayor.Text;
                lblAclaración.Text = "Se aplica un 15% de dto. sobre el subtotal de la compra";
            }
            if (rbuConsuFinal.Checked)
            {
                label10.Visible = false;
                txtCUIT.Visible = false;
                txtCUIT.Text = "0";
                lblTipoVenta.Text = "Venta a consumidor final";
                //ASIGNO EL TIPO CLIENTE AL OBJETO COMPROBANTE
                comprobanteObj.TipoCliente = rbuConsuFinal.Text;
            }
        }
        private void btAceptar_Click(object sender, EventArgs e)
        {
            LimpiaBlancosEncabezado();

            //CONTROL DE ERRORES EN ENCABEZADO
            if (txtNumComprobante.Text == "" || txtCUIT.Text == "")
            {
                txtNumComprobante.Focus();
                lblErrorEncabezado.Text = "Por favor llene todos los datos requeridos";
            }
            else
            {
                lblErrorEncabezado.Text = "";
                paMedio.Enabled = true;
                txtCantidad.Focus();
                if (rbuVentaMayor.Checked)
                {
                    lblTipoVenta.Text = "Venta por mayor al cliente " + txtCUIT.Text;
                }
                //ASIGNO TODOS LOS VALORES AL OBJETO COMPROBANTE
                comprobanteObj.NumComprobante = txtNumComprobante.Text;
                comprobanteObj.CUIT = txtCUIT.Text.ToString();
                comprobanteObj.Fecha = System.Convert.ToDateTime(txtFecha.Text);
            }
        }
        private void btCargar_Click(object sender, EventArgs e)
        {
            indice++;
            txtCantidad.Focus();

            if (txtCantidad.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "")
            {
                lblErrorRenglon.Text = "Por favor ingrese todos los datos";
            }
            else
            {
                rngComprobanteObj = new RngComprobante();
                rngComprobanteObj.Cantidad = System.Convert.ToInt32(txtCantidad.Text);
                rngComprobanteObj.Descripción = txtDescripcion.Text;
                rngComprobanteObj.Precio = System.Convert.ToDecimal(txtPrecio.Text);

                producto = ListaProductos.Items.Add(txtCantidad.Text);
                producto.SubItems.Add(txtDescripcion.Text);
                producto.SubItems.Add(txtPrecio.Text);

                subtotal = subtotal + rngComprobanteObj.CalculoSubtotal();
                lblSubtotal.Text = subtotal.ToString();

                try
                {
                    //ACA VOY LLENANDO LOS DATOS EN LA DATAGRIEDVIEW
                    tabla.Rows.Add();

                    tabla.Rows[tabla.Rows.Count - 1]["Cantidad"] = System.Convert.ToInt32(txtCantidad.Text);
                    tabla.Rows[tabla.Rows.Count - 1]["Descripción"] = System.Convert.ToString(txtDescripcion.Text);
                    tabla.Rows[tabla.Rows.Count - 1]["Precio"] = System.Convert.ToDecimal(txtPrecio.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error Overflow");
                }
                
                if (rbuVentaMayor.Checked)
                {
                    descuento = descuento + rngComprobanteObj.Descuento();
                    lblDescuento.Text = descuento.ToString();

                    total = subtotal - descuento;
                    lblValorTotal.Text = total.ToString();
                }
                else lblValorTotal.Text = subtotal.ToString();

                txtCantidad.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                txtPrecio.Text = string.Empty;

                btGrabarXml.Enabled = true;
            }
        }
        //EVENTOS PARA CONTROLAR QUE SE CARGUEN NUMEROS O LETRAS DONDE CORRESPONDA
        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumerosDecimal(e);
        }
        private void btGrabarXml_Click(object sender, EventArgs e)
        {
            tabla.WriteXml(@"ListaProductosComprobante.xml");
            label5.Text = "Documento Xml guardado con éxito!";
            btLeerXml.Enabled = true;
        }
        private void btLeerXml_Click(object sender, EventArgs e)
        {
            tabla.Clear();
            dgv.Visible = true;
            tabla.ReadXml(@"ListaProductosComprobante.xml");
            dgv.DataSource = tabla;
        }
        #endregion

        #region Métodos
        private void LimpiarControles()
        {
            txtNumComprobante.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            lblValorTotal.Text = "";
            lblDescuento.Text = "";
            lblSubtotal.Text = "";
            txtFecha.Text = "";
            txtCUIT.Text = "";

            paMedio.Enabled = false;
        }
        private void NuevoComprobante()
        {
            comprobanteObj = new claseComprobante();
            txtFecha.Text = comprobanteObj.Fecha.ToString();
            //todo: actualizar numero factura

            txtNumComprobante.Focus();
        }
        //limpio espacios en blanco antes y después
        private void LimpiaBlancosEncabezado()        
        {
            txtNumComprobante.Text = txtNumComprobante.Text.Trim();
            txtCUIT.Text = txtCUIT.Text.Trim();
        }

        //METODO PARA VALIDAR QUE SOLO SE PONGAN LETRAS
        public static void SoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //METODO PARA QUE SE ESCRIBAN SOLO NÚMEROS
        public static void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //METODO PARA QUE SE ESCRIBAN NUMEROS CON DECIMALES
        public static void NumerosDecimal(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals(","))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void CrearTabla()
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();


            tabla.TableName = "Lista Productos";
            tabla.Columns.Add("Cantidad", typeof(int));
            tabla.Columns.Add("Descripción", typeof(string));
            tabla.Columns.Add("Precio", typeof(decimal));

            dgv.DataSource = tabla;
        }
        #endregion
    }
}
