namespace ControlStock
{
    partial class Comprobante
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBienvenida = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btNuevoComprobante = new System.Windows.Forms.Button();
            this.paDatosComp = new System.Windows.Forms.Panel();
            this.lblErrorEncabezado = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumeroComprobante = new System.Windows.Forms.Label();
            this.txtNumComprobante = new System.Windows.Forms.TextBox();
            this.gboxTipoCliente = new System.Windows.Forms.GroupBox();
            this.rbuConsuFinal = new System.Windows.Forms.RadioButton();
            this.rbuVentaMayor = new System.Windows.Forms.RadioButton();
            this.btCargar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.paMedio = new System.Windows.Forms.Panel();
            this.ListaProductos = new System.Windows.Forms.ListView();
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripción = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblErrorRenglon = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAclaración = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTipoVenta = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btGrabarXml = new System.Windows.Forms.Button();
            this.btLeerXml = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBienvenida.SuspendLayout();
            this.paDatosComp.SuspendLayout();
            this.gboxTipoCliente.SuspendLayout();
            this.paMedio.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBienvenida
            // 
            this.pnlBienvenida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBienvenida.Controls.Add(this.label1);
            this.pnlBienvenida.Location = new System.Drawing.Point(9, 11);
            this.pnlBienvenida.Name = "pnlBienvenida";
            this.pnlBienvenida.Size = new System.Drawing.Size(783, 50);
            this.pnlBienvenida.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENERAR COMPROBANTE";
            // 
            // btNuevoComprobante
            // 
            this.btNuevoComprobante.Location = new System.Drawing.Point(140, 41);
            this.btNuevoComprobante.Name = "btNuevoComprobante";
            this.btNuevoComprobante.Size = new System.Drawing.Size(114, 23);
            this.btNuevoComprobante.TabIndex = 1;
            this.btNuevoComprobante.Text = "Nuevo comprobante";
            this.btNuevoComprobante.UseVisualStyleBackColor = true;
            this.btNuevoComprobante.Click += new System.EventHandler(this.btNuevoComprobante_Click);
            // 
            // paDatosComp
            // 
            this.paDatosComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paDatosComp.Controls.Add(this.lblErrorEncabezado);
            this.paDatosComp.Controls.Add(this.txtCUIT);
            this.paDatosComp.Controls.Add(this.label10);
            this.paDatosComp.Controls.Add(this.btAceptar);
            this.paDatosComp.Controls.Add(this.txtFecha);
            this.paDatosComp.Controls.Add(this.label3);
            this.paDatosComp.Controls.Add(this.lblNumeroComprobante);
            this.paDatosComp.Controls.Add(this.txtNumComprobante);
            this.paDatosComp.Enabled = false;
            this.paDatosComp.Location = new System.Drawing.Point(294, 79);
            this.paDatosComp.Name = "paDatosComp";
            this.paDatosComp.Size = new System.Drawing.Size(498, 108);
            this.paDatosComp.TabIndex = 1;
            // 
            // lblErrorEncabezado
            // 
            this.lblErrorEncabezado.AutoSize = true;
            this.lblErrorEncabezado.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEncabezado.Location = new System.Drawing.Point(290, 77);
            this.lblErrorEncabezado.Name = "lblErrorEncabezado";
            this.lblErrorEncabezado.Size = new System.Drawing.Size(0, 13);
            this.lblErrorEncabezado.TabIndex = 19;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(61, 77);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(194, 20);
            this.txtCUIT.TabIndex = 18;
            this.txtCUIT.Visible = false;
            this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "CUIT";
            this.label10.Visible = false;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(343, 41);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 16;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(127, 43);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(128, 20);
            this.txtFecha.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha";
            // 
            // lblNumeroComprobante
            // 
            this.lblNumeroComprobante.AutoSize = true;
            this.lblNumeroComprobante.Location = new System.Drawing.Point(11, 15);
            this.lblNumeroComprobante.Name = "lblNumeroComprobante";
            this.lblNumeroComprobante.Size = new System.Drawing.Size(110, 13);
            this.lblNumeroComprobante.TabIndex = 12;
            this.lblNumeroComprobante.Text = "Número Comprobante";
            // 
            // txtNumComprobante
            // 
            this.txtNumComprobante.Location = new System.Drawing.Point(127, 15);
            this.txtNumComprobante.Name = "txtNumComprobante";
            this.txtNumComprobante.Size = new System.Drawing.Size(128, 20);
            this.txtNumComprobante.TabIndex = 11;
            // 
            // gboxTipoCliente
            // 
            this.gboxTipoCliente.Controls.Add(this.rbuConsuFinal);
            this.gboxTipoCliente.Controls.Add(this.rbuVentaMayor);
            this.gboxTipoCliente.Location = new System.Drawing.Point(21, 22);
            this.gboxTipoCliente.Name = "gboxTipoCliente";
            this.gboxTipoCliente.Size = new System.Drawing.Size(113, 68);
            this.gboxTipoCliente.TabIndex = 13;
            this.gboxTipoCliente.TabStop = false;
            this.gboxTipoCliente.Text = "Elija tipo de cliente";
            // 
            // rbuConsuFinal
            // 
            this.rbuConsuFinal.AutoSize = true;
            this.rbuConsuFinal.Checked = true;
            this.rbuConsuFinal.Location = new System.Drawing.Point(6, 19);
            this.rbuConsuFinal.Name = "rbuConsuFinal";
            this.rbuConsuFinal.Size = new System.Drawing.Size(102, 17);
            this.rbuConsuFinal.TabIndex = 9;
            this.rbuConsuFinal.TabStop = true;
            this.rbuConsuFinal.Text = "Consumidor final";
            this.rbuConsuFinal.UseVisualStyleBackColor = true;
            // 
            // rbuVentaMayor
            // 
            this.rbuVentaMayor.AutoSize = true;
            this.rbuVentaMayor.Location = new System.Drawing.Point(6, 42);
            this.rbuVentaMayor.Name = "rbuVentaMayor";
            this.rbuVentaMayor.Size = new System.Drawing.Size(102, 17);
            this.rbuVentaMayor.TabIndex = 10;
            this.rbuVentaMayor.Text = "Venta por mayor";
            this.rbuVentaMayor.UseVisualStyleBackColor = true;
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(603, 22);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(75, 23);
            this.btCargar.TabIndex = 7;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(106, 24);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(386, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(18, 24);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(103, 8);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(80, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "DESCRIPCIÓN";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(15, 8);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(62, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "CANTIDAD";
            // 
            // paMedio
            // 
            this.paMedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paMedio.Controls.Add(this.ListaProductos);
            this.paMedio.Controls.Add(this.lblErrorRenglon);
            this.paMedio.Controls.Add(this.lblPrecioTotal);
            this.paMedio.Controls.Add(this.txtPrecio);
            this.paMedio.Controls.Add(this.btCargar);
            this.paMedio.Controls.Add(this.txtDescripcion);
            this.paMedio.Controls.Add(this.lbl1);
            this.paMedio.Controls.Add(this.lbl2);
            this.paMedio.Controls.Add(this.txtCantidad);
            this.paMedio.Enabled = false;
            this.paMedio.Location = new System.Drawing.Point(9, 193);
            this.paMedio.Name = "paMedio";
            this.paMedio.Size = new System.Drawing.Size(782, 247);
            this.paMedio.TabIndex = 2;
            // 
            // ListaProductos
            // 
            this.ListaProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cantidad,
            this.Descripción,
            this.PrecioUnitario});
            this.ListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaProductos.HideSelection = false;
            this.ListaProductos.Location = new System.Drawing.Point(19, 62);
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.Size = new System.Drawing.Size(733, 167);
            this.ListaProductos.TabIndex = 14;
            this.ListaProductos.UseCompatibleStateImageBehavior = false;
            this.ListaProductos.View = System.Windows.Forms.View.Details;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 69;
            // 
            // Descripción
            // 
            this.Descripción.Text = "Descripción";
            this.Descripción.Width = 556;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.Text = "Precio Unitario";
            this.PrecioUnitario.Width = 102;
            // 
            // lblErrorRenglon
            // 
            this.lblErrorRenglon.AutoSize = true;
            this.lblErrorRenglon.Location = new System.Drawing.Point(540, 264);
            this.lblErrorRenglon.Name = "lblErrorRenglon";
            this.lblErrorRenglon.Size = new System.Drawing.Size(0, 13);
            this.lblErrorRenglon.TabIndex = 13;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(508, 8);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(47, 13);
            this.lblPrecioTotal.TabIndex = 11;
            this.lblPrecioTotal.Text = "PRECIO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(511, 24);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(75, 20);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor total";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblAclaración);
            this.panel3.Controls.Add(this.lblDescuento);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblTipoVenta);
            this.panel3.Controls.Add(this.lblValorTotal);
            this.panel3.Controls.Add(this.lblSubtotal);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(9, 446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 110);
            this.panel3.TabIndex = 9;
            // 
            // lblAclaración
            // 
            this.lblAclaración.AutoSize = true;
            this.lblAclaración.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAclaración.Location = new System.Drawing.Point(15, 50);
            this.lblAclaración.Name = "lblAclaración";
            this.lblAclaración.Size = new System.Drawing.Size(0, 13);
            this.lblAclaración.TabIndex = 14;
            // 
            // lblDescuento
            // 
            this.lblDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(669, 41);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(100, 23);
            this.lblDescuento.TabIndex = 13;
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(595, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Descuento";
            // 
            // lblTipoVenta
            // 
            this.lblTipoVenta.AutoSize = true;
            this.lblTipoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVenta.Location = new System.Drawing.Point(12, 2);
            this.lblTipoVenta.Name = "lblTipoVenta";
            this.lblTipoVenta.Size = new System.Drawing.Size(94, 13);
            this.lblTipoVenta.TabIndex = 11;
            this.lblTipoVenta.Text = "Tipo de venta: ";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(669, 74);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(100, 23);
            this.lblValorTotal.TabIndex = 10;
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(669, 9);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btNuevoComprobante);
            this.panel2.Controls.Add(this.gboxTipoCliente);
            this.panel2.Location = new System.Drawing.Point(9, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 108);
            this.panel2.TabIndex = 10;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(550, 129);
            this.dgv.TabIndex = 15;
            this.dgv.Visible = false;
            // 
            // btGrabarXml
            // 
            this.btGrabarXml.Enabled = false;
            this.btGrabarXml.Location = new System.Drawing.Point(576, 20);
            this.btGrabarXml.Name = "btGrabarXml";
            this.btGrabarXml.Size = new System.Drawing.Size(100, 27);
            this.btGrabarXml.TabIndex = 16;
            this.btGrabarXml.Text = "Grabar en Xml";
            this.btGrabarXml.UseVisualStyleBackColor = true;
            this.btGrabarXml.Click += new System.EventHandler(this.btGrabarXml_Click);
            // 
            // btLeerXml
            // 
            this.btLeerXml.Enabled = false;
            this.btLeerXml.Location = new System.Drawing.Point(576, 79);
            this.btLeerXml.Name = "btLeerXml";
            this.btLeerXml.Size = new System.Drawing.Size(100, 23);
            this.btLeerXml.TabIndex = 17;
            this.btLeerXml.Text = "Leer Xml";
            this.btLeerXml.UseVisualStyleBackColor = true;
            this.btLeerXml.Click += new System.EventHandler(this.btLeerXml_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(573, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.btGrabarXml);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btLeerXml);
            this.panel1.Location = new System.Drawing.Point(12, 562);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 138);
            this.panel1.TabIndex = 19;
            // 
            // Comprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(802, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paMedio);
            this.Controls.Add(this.paDatosComp);
            this.Controls.Add(this.pnlBienvenida);
            this.Controls.Add(this.panel1);
            this.Name = "Comprobante";
            this.Text = "Zafiro Pet Shop";
            this.pnlBienvenida.ResumeLayout(false);
            this.pnlBienvenida.PerformLayout();
            this.paDatosComp.ResumeLayout(false);
            this.paDatosComp.PerformLayout();
            this.gboxTipoCliente.ResumeLayout(false);
            this.gboxTipoCliente.PerformLayout();
            this.paMedio.ResumeLayout(false);
            this.paMedio.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paDatosComp;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel paMedio;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbuVentaMayor;
        private System.Windows.Forms.RadioButton rbuConsuFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gboxTipoCliente;
        private System.Windows.Forms.Label lblNumeroComprobante;
        private System.Windows.Forms.TextBox txtNumComprobante;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btNuevoComprobante;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label lblTipoVenta;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblErrorEncabezado;
        private System.Windows.Forms.Label lblAclaración;
        private System.Windows.Forms.Label lblErrorRenglon;
        private System.Windows.Forms.ListView ListaProductos;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Descripción;
        private System.Windows.Forms.ColumnHeader PrecioUnitario;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btGrabarXml;
        private System.Windows.Forms.Button btLeerXml;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}

