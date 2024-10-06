using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatricuFastWeb.Model
{
    public class Usuarios
    {
        public class Usuario
        {
            public int UsuarioId { get; set; } 
            public string Nombre { get; set; } 
            public string Apellido { get; set; } 
            public string Email { get; set; } 
            public string Contraseña { get; set; } 
            public string AdicionadoPor { get; set; } 
            public DateTime FechaAdicion { get; set; } 
            public string ModificadoPor { get; set; } 
            public DateTime? FechaModificacion { get; set; } 
        }

    }
}