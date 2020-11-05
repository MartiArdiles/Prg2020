namespace Frontend
{
    partial class frmFactura
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
            this.paEncabezado = new System.Windows.Forms.Panel();
            this.lblErrorEncabezado = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btNuevaFactura = new System.Windows.Forms.Button();
            this.paPie = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paRenglones = new System.Windows.Forms.Panel();
            this.lblRenglones = new System.Windows.Forms.Label();
            this.txtTotalRenglon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btCargarProducto = new System.Windows.Forms.Button();
            this.paEncabezado.SuspendLayout();
            this.paPie.SuspendLayout();
            this.paRenglones.SuspendLayout();
            this.SuspendLayout();
            // 
            // paEncabezado
            // 
            this.paEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paEncabezado.Controls.Add(this.lblErrorEncabezado);
            this.paEncabezado.Controls.Add(this.btConfirmar);
            this.paEncabezado.Controls.Add(this.txtFecha);
            this.paEncabezado.Controls.Add(this.label4);
            this.paEncabezado.Controls.Add(this.txtCuit);
            this.paEncabezado.Controls.Add(this.label3);
            this.paEncabezado.Controls.Add(this.txtCliente);
            this.paEncabezado.Controls.Add(this.label2);
            this.paEncabezado.Controls.Add(this.txtNFactura);
            this.paEncabezado.Controls.Add(this.label1);
            this.paEncabezado.Controls.Add(this.btNuevaFactura);
            this.paEncabezado.Location = new System.Drawing.Point(13, 12);
            this.paEncabezado.Name = "paEncabezado";
            this.paEncabezado.Size = new System.Drawing.Size(775, 114);
            this.paEncabezado.TabIndex = 0;
            // 
            // lblErrorEncabezado
            // 
            this.lblErrorEncabezado.AutoSize = true;
            this.lblErrorEncabezado.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEncabezado.Location = new System.Drawing.Point(68, 81);
            this.lblErrorEncabezado.Name = "lblErrorEncabezado";
            this.lblErrorEncabezado.Size = new System.Drawing.Size(0, 13);
            this.lblErrorEncabezado.TabIndex = 10;
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(660, 81);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(85, 23);
            this.btConfirmar.TabIndex = 9;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(660, 48);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(85, 20);
            this.txtFecha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(360, 48);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CUIT";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(68, 48);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(232, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // txtNFactura
            // 
            this.txtNFactura.Location = new System.Drawing.Point(660, 6);
            this.txtNFactura.Name = "txtNFactura";
            this.txtNFactura.Size = new System.Drawing.Size(85, 20);
            this.txtNFactura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° Factura";
            // 
            // btNuevaFactura
            // 
            this.btNuevaFactura.Location = new System.Drawing.Point(3, 3);
            this.btNuevaFactura.Name = "btNuevaFactura";
            this.btNuevaFactura.Size = new System.Drawing.Size(102, 23);
            this.btNuevaFactura.TabIndex = 0;
            this.btNuevaFactura.Text = "Nueva Factura";
            this.btNuevaFactura.UseVisualStyleBackColor = true;
            this.btNuevaFactura.Click += new System.EventHandler(this.btNuevaFactura_Click);
            // 
            // paPie
            // 
            this.paPie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paPie.Controls.Add(this.lblTotal);
            this.paPie.Controls.Add(this.lblIVA);
            this.paPie.Controls.Add(this.lblBruto);
            this.paPie.Controls.Add(this.label11);
            this.paPie.Controls.Add(this.label10);
            this.paPie.Controls.Add(this.label9);
            this.paPie.Location = new System.Drawing.Point(12, 338);
            this.paPie.Name = "paPie";
            this.paPie.Size = new System.Drawing.Size(776, 100);
            this.paPie.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(670, 64);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIVA
            // 
            this.lblIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(671, 38);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(100, 23);
            this.lblIVA.TabIndex = 7;
            this.lblIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBruto
            // 
            this.lblBruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto.Location = new System.Drawing.Point(671, 12);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(100, 23);
            this.lblBruto.TabIndex = 6;
            this.lblBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(626, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "TOTAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "IVA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(623, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "BRUTO";
            // 
            // paRenglones
            // 
            this.paRenglones.Controls.Add(this.lblRenglones);
            this.paRenglones.Controls.Add(this.txtTotalRenglon);
            this.paRenglones.Controls.Add(this.label8);
            this.paRenglones.Controls.Add(this.txtUnitario);
            this.paRenglones.Controls.Add(this.label7);
            this.paRenglones.Controls.Add(this.txtProducto);
            this.paRenglones.Controls.Add(this.label6);
            this.paRenglones.Controls.Add(this.txtCantidad);
            this.paRenglones.Controls.Add(this.label5);
            this.paRenglones.Controls.Add(this.btCargarProducto);
            this.paRenglones.Enabled = false;
            this.paRenglones.Location = new System.Drawing.Point(13, 132);
            this.paRenglones.Name = "paRenglones";
            this.paRenglones.Size = new System.Drawing.Size(775, 200);
            this.paRenglones.TabIndex = 2;
            // 
            // lblRenglones
            // 
            this.lblRenglones.AutoSize = true;
            this.lblRenglones.Location = new System.Drawing.Point(24, 116);
            this.lblRenglones.Name = "lblRenglones";
            this.lblRenglones.Size = new System.Drawing.Size(0, 13);
            this.lblRenglones.TabIndex = 18;
            // 
            // txtTotalRenglon
            // 
            this.txtTotalRenglon.Location = new System.Drawing.Point(670, 49);
            this.txtTotalRenglon.Name = "txtTotalRenglon";
            this.txtTotalRenglon.ReadOnly = true;
            this.txtTotalRenglon.Size = new System.Drawing.Size(100, 20);
            this.txtTotalRenglon.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(667, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "$ Total";
            // 
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(554, 49);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtUnitario.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "$ Unitario";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(126, 49);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(413, 20);
            this.txtProducto.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(20, 49);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // btCargarProducto
            // 
            this.btCargarProducto.Location = new System.Drawing.Point(670, 75);
            this.btCargarProducto.Name = "btCargarProducto";
            this.btCargarProducto.Size = new System.Drawing.Size(100, 23);
            this.btCargarProducto.TabIndex = 9;
            this.btCargarProducto.Text = "Cargar Producto";
            this.btCargarProducto.UseVisualStyleBackColor = true;
            this.btCargarProducto.Click += new System.EventHandler(this.btCargarProducto_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paRenglones);
            this.Controls.Add(this.paPie);
            this.Controls.Add(this.paEncabezado);
            this.Name = "frmFactura";
            this.Text = "Form1";
            this.paEncabezado.ResumeLayout(false);
            this.paEncabezado.PerformLayout();
            this.paPie.ResumeLayout(false);
            this.paPie.PerformLayout();
            this.paRenglones.ResumeLayout(false);
            this.paRenglones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paEncabezado;
        private System.Windows.Forms.Panel paPie;
        private System.Windows.Forms.Panel paRenglones;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNuevaFactura;
        private System.Windows.Forms.Button btCargarProducto;
        private System.Windows.Forms.TextBox txtTotalRenglon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnitario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblRenglones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Label lblErrorEncabezado;
    }
}

