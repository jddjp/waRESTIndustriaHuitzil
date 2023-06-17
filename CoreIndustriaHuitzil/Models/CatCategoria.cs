﻿using System;
using System.Collections.Generic;

namespace CoreIndustriaHuitzil.Models
{
    public partial class CatCategoria
    {
        public CatCategoria()
        {
            Articulos = new HashSet<Articulo>();
            MovimientosArticulos = new HashSet<MovimientoArticulos>();
        }

        public int IdCategoria { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }

        public virtual ICollection<MovimientoArticulos> MovimientosArticulos { get; set; }


    }
}
