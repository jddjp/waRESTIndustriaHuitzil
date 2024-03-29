﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreIndustriaHuitzil.ModelsRequest
{
    public partial class MovimientoArticulosRequest
    {
        public int IdMovimientoArticulos { get; set; }
        public int idMovimiento { get; set; }
        public int IdArticulo { get; set; }
        public string? Status { get; set; }
        public string? Existencia { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public int? IdUbicacion { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdTalla { get; set; }
        public string talla { get; set; }
        public string categoria { get; set; }
        public string ubicacion { get; set; }
        public string? Imagen { get; set; }
        public string? Sku { get; set; }
        public decimal? Precio { get; set; }
        public int? CantMovimiento { get; set; }
    }
}
