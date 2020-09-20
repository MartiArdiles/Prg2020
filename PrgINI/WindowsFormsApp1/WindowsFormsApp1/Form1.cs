using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {

            switch (txtNota.Text)
            {
                case "1":
                    lblRes.Text = "Aplazado";
                    break;
                case "2":
                    lblRes.Text = "Aprobado";
                    break;
                case "3":
                    lblRes.Text = "Promociona";
                    break;
                default:
                    lblRes.Text = "Nota no válida";
                    break;
            }
    }
}