using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreIndustriaHuitzil.ModelsRequest
{
    
        public partial class ApartadosRequest
        {
            public int IdApartado { get; set; }
            public int? IdCliente { get; set; }
            public int? idParent { get; set; }
            public int? total { get; set; }
            public int? resto { get; set; }
            public DateTime Fecha { get; set; }
            public DateTime? FechaEntrega { get; set; }
            public string? Status { get; set; }
            public string? type { get;  set; }
            public string? cliente { get; set;}
            public string? ubicacion { get; set; }
        public List<ApartadoArticuloRequest> articulosApartados { get; set; } = new List<ApartadoArticuloRequest>();
    }

    public class ApartadoArticuloRequest
    {
        public int IdApartadoArticulo { get; set; }
        public int IdApartadp { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public String? Descripcion { get; set; }
        public String? Sku { get; set; }



        public decimal PrecioUnitario { get; set; }
        public decimal? Subtotal { get; set; }

        public virtual ProductoRequest? Articulo { get; set; } = null!;
        public virtual ApartadosRequest? Apartado { get; set; } = null!;
    }

}
