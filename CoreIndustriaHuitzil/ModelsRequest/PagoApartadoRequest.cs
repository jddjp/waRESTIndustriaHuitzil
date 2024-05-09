using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreIndustriaHuitzil.ModelsRequest
{
    public partial class PagoApartadoRequest
    {
        public int IdPagoApartado { get; set; }
        public int? IdApartado { get; set; }
        public int? IdCaja { get; set; }
        public decimal? Cantidad { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? MontoTarjeta { get; set; }
        public decimal? MontoEfectivo { get; set; }
        public String? TipoPagoValida { get; set; }
    }
}
