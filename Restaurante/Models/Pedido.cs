using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Restaurante.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdClient { get; set; }
        public int IdMesa { get; set; }
        public DateTime Fecha { get; set; }
        public string IdFormPago { get; set; }
        public decimal Total { get; set; }
        public int IdEmpleado { get; set; }
    }
}
