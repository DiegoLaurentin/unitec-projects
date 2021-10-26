using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC_APP
{
    class Factura
    {
        private int cliente;
        private int clave;
        private int option = 0;
        private double iva;
        private double total;

        public double Iva { get => iva; set => iva = value; }
        public double Total { get => total; set => total = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public int Clave { get => clave; set => clave = value; }
        public int Option { get => option; set => option = value; }
    }
}
