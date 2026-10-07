using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Restaurante.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechContratacion { get; set; }
    }
}
