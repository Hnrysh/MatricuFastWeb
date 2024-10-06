using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatricuFastWeb.Model
{
    public class Cursos
    {
        public class Curso
        {
            public int CursoId { get; set; } 
            public string NombreCurso { get; set; } 
            public int Creditos { get; set; } 
            public int Horas { get; set; } 
            public string AdicionadoPor { get; set; } 
            public DateTime FechaAdicion { get; set; } 
            public string ModificadoPor { get; set; } 
            public DateTime? FechaModificacion { get; set; } 
        }

    }
}