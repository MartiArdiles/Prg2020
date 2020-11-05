using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
        //Hago un arreglo con los objetos creados en otro metodo
        public RngFactura[] ListaRngFactura = new RngFactura[10];
        private int indice = 0;
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
        //adiciona un renglon a la lista de productos
        public void AdicionaRngFactura(RngFactura rngFacturaObj)
        {
            //todo: controlar error de exceso de tamaño de arreglo
            ListaRngFactura[indice] = rngFacturaObj;
            indice = indice + 1;
        }

        public string MuestraRenglones()
        {
            string RenglonesTxt = "";
            for (int i = 0; i < indice; i++)
            {
                RenglonesTxt = RenglonesTxt + ListaRngFactura[i].MuestraRenglon() + "\r\n";

            }

            return RenglonesTxt;
        }
        

        


        #endregion

    }
}
