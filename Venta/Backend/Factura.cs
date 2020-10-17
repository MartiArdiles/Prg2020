using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Factura
    {
        #region Propiedades
        public DateTime Fecha;

        public string NumeroFactura = "";
        public string Cliente = "";
        public string CUIT = "";

        public decimal Neto = 0;
        public decimal IVA = 0;
        public decimal Total = 0;

        //public ListaRngFactura
        #endregion

        #region Constructor
        public Factura()
        {
            //SE ASIGNA AUTOMÁTICAMENTE LA FECHA DE HOY
            Fecha = DateTime.Now;
            //ToDo: poner nuevo numero de factura
        }
        #endregion

        #region Metodo

        #endregion

    }
}
