using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class RngComprobante
    {
        #region Propiedades
        public int Cantidad = 0;
        public string Descripción = "";
        public decimal Precio = 0;
        #endregion

        #region Constructor

        #endregion

        #region Métodos
        public decimal CalculoSubtotal()
        {
            
            return Cantidad* Precio;

        }
        public decimal Descuento()
        {

            return (Cantidad * Precio) * 15 / 100;
            
        }
        public decimal Total()
        {
            return CalculoSubtotal() - Descuento();
        }
        #endregion

    }
}
