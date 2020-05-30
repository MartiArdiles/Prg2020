namespace EjemploConversion
{
    partial class frmConvertir
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
            this.txtOper1 = new System.Windows.Forms.TextBox();
            this.txtOper2 = new System.Windows.Forms.TextBox();
            this.btSuma = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOper1
            // 
<<<<<<< HEAD
            this.txtOper1.Location = new System.Drawing.Point(59, 50);
            this.txtOper1.Name = "txtOper1";
            this.txtOper1.Size = new System.Drawing.Size(100, 20);
            this.txtOper1.TabIndex = 0;
            this.txtOper1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtOper2
            // 
            this.txtOper2.Location = new System.Drawing.Point(223, 50);
            this.txtOper2.Name = "txtOper2";
            this.txtOper2.Size = new System.Drawing.Size(100, 20);
            this.txtOper2.TabIndex = 1;
=======
            this.txtOper1.Location = new System.Drawing.Point(56, 53);
            this.txtOper1.Name = "txtOper1";
            this.txtOper1.Size = new System.Drawing.Size(100, 20);
            this.txtOper1.TabIndex = 0;
            // 
            // txtOper2
            // 
            this.txtOper2.Location = new System.Drawing.Point(190, 53);
            this.txtOper2.Name = "txtOper2";
            this.txtOper2.Size = new System.Drawing.Size(100, 20);
            this.txtOper2.TabIndex = 1;
            this.txtOper2.TextChanged += new System.EventHandler(this.txtOper2_TextChanged);
>>>>>>> a94fff4a7b207c1d2a8137fb7dc72ad34ba1e692
            // 
            // btSuma
            // 
            this.btSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btSuma.Location = new System.Drawing.Point(339, 50);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(39, 23);
            this.btSuma.TabIndex = 2;
            this.btSuma.Text = "=";
            this.btSuma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
=======
            this.btSuma.Location = new System.Drawing.Point(296, 46);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(42, 35);
            this.btSuma.TabIndex = 2;
            this.btSuma.Text = "=";
>>>>>>> a94fff4a7b207c1d2a8137fb7dc72ad34ba1e692
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.btSuma_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
<<<<<<< HEAD
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(181, 46);
=======
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblSuma.Location = new System.Drawing.Point(162, 49);
>>>>>>> a94fff4a7b207c1d2a8137fb7dc72ad34ba1e692
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(22, 24);
            this.lblSuma.TabIndex = 3;
            this.lblSuma.Text = "+";
<<<<<<< HEAD
            this.lblSuma.Click += new System.EventHandler(this.label1_Click);
=======
>>>>>>> a94fff4a7b207c1d2a8137fb7dc72ad34ba1e692
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblRes.Location = new System.Drawing.Point(414, 50);
=======
            this.lblRes.Location = new System.Drawing.Point(377, 51);
>>>>>>> a94fff4a7b207c1d2a8137fb7dc72ad34ba1e692
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 24);
            this.lblRes.TabIndex = 4;
            // 
            // frmConvertir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(566, 155);
=======
            this.ClientSize = new System.Drawing.Size(508, 127);
>>>>>>> a94fff4a7b207c1d2a8137fb7dc72ad34ba1e692
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.txtOper2);
            this.Controls.Add(this.txtOper1);
            this.Name = "frmConvertir";
            this.Text = "Form1";
<<<<<<< HEAD
=======
            this.Load += new System.EventHandler(this.frmConvertir_Load);
>>>>>>> a94fff4a7b207c1d2a8137fb7dc72ad34ba1e692
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOper1;
        private System.Windows.Forms.TextBox txtOper2;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblRes;
    }
}

