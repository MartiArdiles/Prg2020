using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace EjemploWhile
{
    public partial class EjemploWhile : Form
    {
        public EjemploWhile()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            //Random Generador = new Random();

            int AnchoFormulario;
            int AnchoLabel;
            int AnchoBorde;
            int X;
            int Paso;
            int Repetición = 0;
            int TotalRepeticiones = 5;
            lbl.Width = 106;
            lbl.Height = 15;

            do
            {
                AnchoFormulario = this.Width;
                AnchoLabel = lbl.Width;
                AnchoBorde = 0;
                X = 0;
                Paso = 10;
                Repetición = Repetición + 1;



                while (X < (AnchoFormulario - AnchoLabel - AnchoBorde))
                {
                    lbl.Left = X;
                    this.Refresh();
                    X = X + Paso;
                    
                }
                //lbl.Width = Generador.Next(2,100);
                //lbl.Height = Generador.Next(2,100);
                //lbl.Width = System.Convert.ToInt32(0.7 * lbl.Width);
                //lbl.Height = lbl.Height * 2;
            } while (Repetición < TotalRepeticiones);
	    }        
    }
}
