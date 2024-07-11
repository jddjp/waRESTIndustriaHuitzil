﻿using System;
using System.Collections.Generic;

namespace CoreIndustriaHuitzil.Models
{
    public partial class User
    {
        public User()
        {
            Cajas = new HashSet<Caja>();
            SolicitudesMateriales = new HashSet<SolicitudesMateriale>();
            MovimientosInventariosEnvio  = new HashSet<MovimientosInventario>();
           // MovimientosInventariosRecibe = new HashSet<MovimientosInventario>();
        }

        public int IdUser { get; set; }
        public string? Usuario { get; set; }
        public string? Password { get; set; }
        public int? IdRol { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Token { get; set; }
        public DateTime? UltimoAcceso { get; set; }
        public bool? Visible { get; set; }
        public string? pc { get; set; }
        public string? ubicacion { get; set; }
        public string? impresora { get; set; }

        public int? IdUbicacion { get; set; }
        public DateTime? ExpiredTime { get; set; }
        public virtual Rol? IdRolNavigation { get; set; }

        public virtual ICollection<Caja> Cajas { get; set; }
        public virtual ICollection<SolicitudesMateriale> SolicitudesMateriales { get; set; }
        public virtual ICollection<MovimientosInventario> MovimientosInventariosEnvio { get; set; }
    }
}
