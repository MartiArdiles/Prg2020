namespace HolaMndo
{
    partial class HolaClase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MensajeUno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MensajeUno
            // 
            this.MensajeUno.AutoSize = true;
            this.MensajeUno.Location = new System.Drawing.Point(33, 61);
            this.MensajeUno.Name = "MensajeUno";
            this.MensajeUno.Size = new System.Drawing.Size(45, 13);
            this.MensajeUno.TabIndex = 1;
            this.MensajeUno.Text = "Materia:";
            this.MensajeUno.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(36, 136);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(29, 13);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Hola";
            this.lblMensaje.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(39, 87);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(117, 20);
            this.txtMateria.TabIndex = 5;
            // 
            // HolaClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 177);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MensajeUno);
            this.Name = "HolaClase";
            this.Text = "Hola";
            this.Load += new System.EventHandler(this.HolaClase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MensajeUno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtMateria;
    }
}