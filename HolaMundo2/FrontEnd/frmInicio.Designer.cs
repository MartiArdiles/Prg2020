namespace FrontEnd
{
    partial class frmInicio
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
            this.lblHola = new System.Windows.Forms.Label();
            this.btListo = new System.Windows.Forms.Button();
            this.textNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHola.Location = new System.Drawing.Point(135, 108);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(242, 41);
            this.lblHola.TabIndex = 0;
            this.lblHola.Text = "HOLA MUNDO";
            // 
            // btListo
            // 
            this.btListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListo.Location = new System.Drawing.Point(326, 41);
            this.btListo.Name = "btListo";
            this.btListo.Size = new System.Drawing.Size(75, 23);
            this.btListo.TabIndex = 1;
            this.btListo.Text = "Listo!";
            this.btListo.UseVisualStyleBackColor = true;
            this.btListo.Click += new System.EventHandler(this.btListo_Click);
            // 
            // textNombreUsuario
            // 
            this.textNombreUsuario.Location = new System.Drawing.Point(122, 44);
            this.textNombreUsuario.Name = "textNombreUsuario";
            this.textNombreUsuario.Size = new System.Drawing.Size(187, 20);
            this.textNombreUsuario.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(122, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(119, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Ingrese aquí su nombre";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textNombreUsuario);
            this.Controls.Add(this.btListo);
            this.Controls.Add(this.lblHola);
            this.Name = "frmInicio";
            this.Text = "Hola Gente";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHola;
        private System.Windows.Forms.Button btListo;
        private System.Windows.Forms.TextBox textNombreUsuario;
        private System.Windows.Forms.Label lblNombre;
    }
}

