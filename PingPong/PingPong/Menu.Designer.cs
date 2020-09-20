namespace PingPong
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MenuPrincipal = new System.Windows.Forms.PictureBox();
            this.btCerrar = new System.Windows.Forms.Button();
            this.btJugar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("MenuPrincipal.Image")));
            this.MenuPrincipal.InitialImage = ((System.Drawing.Image)(resources.GetObject("MenuPrincipal.InitialImage")));
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(638, 527);
            this.MenuPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.TabStop = false;
            // 
            // btCerrar
            // 
            this.btCerrar.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.Location = new System.Drawing.Point(523, 438);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(90, 34);
            this.btCerrar.TabIndex = 1;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // btJugar
            // 
            this.btJugar.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJugar.Location = new System.Drawing.Point(40, 438);
            this.btJugar.Name = "btJugar";
            this.btJugar.Size = new System.Drawing.Size(97, 34);
            this.btJugar.TabIndex = 2;
            this.btJugar.Text = "Jugar";
            this.btJugar.UseVisualStyleBackColor = true;
            this.btJugar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 526);
            this.Controls.Add(this.btJugar);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.MenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MenuPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MenuPrincipal;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Button btJugar;
    }
}

