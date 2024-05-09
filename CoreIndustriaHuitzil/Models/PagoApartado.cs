using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreIndustriaHuitzil.Models
{
    public partial class PagoApartado
    {
        public int IdPagoApartado { get; set; }
        public int? IdApartado { get; set; }
        public int? IdCaja { get; set; }
        public decimal? Cantidad { get; set; }
        public DateTime? Fecha { get; set; }

        public decimal? Tarjeta { get; set; }

        public decimal? Efectivo { get; set; }

        public String? TipoPago { get; set; }
    }
}
