using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Restaurante.Models
{
    public class Reservacion
    {
        public int IdReserv { get; set; }
        public int IdClient { get; set; }
        public int IdMesa { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int CantPers { get; set; }
    }
}