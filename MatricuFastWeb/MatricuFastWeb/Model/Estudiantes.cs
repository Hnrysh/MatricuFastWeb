using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatricuFastWeb.Model
{
    public class Estudiantes
    {
        public class Estudiante
        {
            public int EstudianteId { get; set; } 
            public string Nombre { get; set; } 
            public string Apellido { get; set; } 
            public string Carrera { get; set; } 
            public int AñoIngreso { get; set; } 
            public string AdicionadoPor { get; set; } 
            public DateTime FechaAdicion { get; set; } 
            public string ModificadoPor { get; set; } 
            public DateTime? FechaModificacion { get; set; } 
        }

    }
}