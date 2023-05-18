using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreIndustriaHuitzil.ModelsRequest
{
    public partial class MovimientoInvetarioRequest
    {
        public int IdMovimiento { get; set; }
        public string Fecha { get; set; }
        public int Ubicacion { get; set; }
        public int Usuario { get; set; }
        public string Status { get; set; }
        public int Receptor { get; set; }
        public string Direccion { get; set; }
        public string UsuarioRecibe { get; set; }
        public string UsuarioEnvia { get; set; }

    }
}
