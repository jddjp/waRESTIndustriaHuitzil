using System;
using System.Collections.Generic;

namespace CoreIndustriaHuitzil.Models
{
    public partial class MovimientosInventario
    {
       

        public int IdMovimiento { get; set; }
        public string  Fecha { get; set; }
        public int Ubicacion { get; set; }
        public int Usuario { get; set; }
        public string Status { get; set; }
        public int Receptor { get; set; }

        public int? UbicacionDestino { get; set; }

        public string? TipoPaquete { get; set; }

        public virtual CatUbicacione? IdUbicacionNavigation { get; set; }

        public virtual CatUbicacione? IdUbicacionDestinoNavigation { get; set; }


        public virtual User? IdUserEnvioNavigation { get; set; }
        public virtual User? IdUserRecibeNavigation { get; set; }
    }
}
