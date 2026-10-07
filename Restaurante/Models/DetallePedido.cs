using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Models
{
    public class DetallePedido
    {
        public int IdProduc { get; set; }
        public int Idpedido { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
