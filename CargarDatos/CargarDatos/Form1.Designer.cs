namespace CargarDatos
{
    partial class Form1
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
            this.btCargar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.lblMostrarDatos = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btDefinir = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDefinido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCargar
            // 
            this.btCargar.Enabled = false;
            this.btCargar.Location = new System.Drawing.Point(307, 97);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(75, 23);
            this.btCargar.TabIndex = 0;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(15, 99);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(271, 20);
            this.txtDato.TabIndex = 1;
            // 
            // lblMostrarDatos
            // 
            this.lblMostrarDatos.AutoSize = true;
            this.lblMostrarDatos.Location = new System.Drawing.Point(12, 137);
            this.lblMostrarDatos.Name = "lblMostrarDatos";
            this.lblMostrarDatos.Size = new System.Drawing.Size(41, 13);
            this.lblMostrarDatos.TabIndex = 2;
            this.lblMostrarDatos.Text = "Datos: ";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(15, 43);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(28, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // btDefinir
            // 
            this.btDefinir.Location = new System.Drawing.Point(61, 41);
            this.btDefinir.Name = "btDefinir";
            this.btDefinir.Size = new System.Drawing.Size(75, 23);
            this.btDefinir.TabIndex = 4;
            this.btDefinir.Text = "Definir";
            this.btDefinir.UseVisualStyleBackColor = true;
            this.btDefinir.Click += new System.EventHandler(this.btDefinir_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(15, 13);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(205, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Ingrese la cantidad de elementos a cargar";
            // 
            // lblDefinido
            // 
            this.lblDefinido.AutoSize = true;
            this.lblDefinido.Location = new System.Drawing.Point(15, 80);
            this.lblDefinido.Name = "lblDefinido";
            this.lblDefinido.Size = new System.Drawing.Size(0, 13);
            this.lblDefinido.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.lblDefinido);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btDefinir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblMostrarDatos);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label lblMostrarDatos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btDefinir;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDefinido;
    }
}

