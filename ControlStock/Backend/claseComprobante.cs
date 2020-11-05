using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class claseComprobante
    {
        #region Propiedades
        public DateTime Fecha;

        public string NumComprobante = "";
        public string TipoCliente = "";
        public string CUIT = "";

        public decimal Subtotal = 0;
        public decimal Total = 0;
        public decimal Descuento = 0;
        #endregion

        #region Constructor
        public claseComprobante()
        {
            Fecha = DateTime.Now;
        }
        #endregion

        #region Métodos

        #endregion

    }
}
