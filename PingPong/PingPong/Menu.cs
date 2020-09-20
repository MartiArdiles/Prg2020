using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmJuego ventanajuego = new frmJuego();

            ventanajuego.Show(this);
            this.Hide();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
