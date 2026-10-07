using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Models
{
    public class Producto
    {
        public int IdProduc { get; set; }
        public string Nombre { get; set; }
        public string Descrip { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
    }
}
