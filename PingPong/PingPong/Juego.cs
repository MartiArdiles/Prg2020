using System;
using System.Drawing; //para dibujar la posicion de la imagen
using System.Windows.Forms;

namespace PingPong
{
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
        }

        int velocidad = 5;
        int contador = 0; //contar las veces que sube el puntaje para aumentar la velocidad
        int puntaje = 0;

        bool Arriba;
        bool Izquierda;

        private void frmJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmJuego_MouseMove(object sender, MouseEventArgs e)
        {
            imgBarra.Top = e.Y;

        }

        private void imgBarra_Click(object sender, EventArgs e)
        {

        }
    }
}
