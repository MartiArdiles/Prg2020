using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class RngFactura
    {
        #region Propiedades
        public decimal cantidad = 0;
        public string producto = "";
        public decimal unitario = 0;



        #endregion

        #region Constructor

        #endregion

        #region Metodos
        public decimal Total()
        {
            return cantidad * unitario;
        }
        #endregion


    }
}
