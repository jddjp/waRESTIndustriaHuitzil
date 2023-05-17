using System;
using System.Collections.Generic;

namespace CoreIndustriaHuitzil.Models
{
    public partial class MovimientoArticulos
    {
       

        public int IdMovimientoArticulos { get; set; }
        public int idMovimiento { get; set; }
        public int IdArticulo { get; set; }
        public string Sku { get; set; }
        public int IdUbicacion { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdTalla { get; set; }
        public int? Existencia { get; set; }
        public string? Descripcion { get; set; }
        public string? FechaIngreso { get; set; }

    }
}
