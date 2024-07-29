using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreIndustriaHuitzil.Models
{
    public partial class Apartados
    {
        public int IdApartado { get; set; }
        public int? IdCliente { get; set; }
        public decimal? total { get; set; } 
        public decimal? resto { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string? Status { get; set; }
        /// <summary>
        /// public string cliene { set; get; }
        /// </summary>
        public string? Type { get; set; }
        public string? ubicacion { get; set; }
        public virtual CatCliente? IdClienteNavigation { get; set; }

        public virtual ICollection<ApartadoArticulo> ApartadoArticulos { get; set; }

    }
}
