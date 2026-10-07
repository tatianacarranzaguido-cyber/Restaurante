using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Restaurante.Models
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdPedido { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal IVA { get; set; }
        public decimal Totalpagar { get; set; }
        public string IdFormPago { get; set; }
        public int IdEmpleado { get; set; }
    }
}
