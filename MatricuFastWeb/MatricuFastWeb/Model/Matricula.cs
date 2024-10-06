using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static MatricuFastWeb.Model.Cursos;
using static MatricuFastWeb.Model.Estudiantes;

namespace MatricuFastWeb.Model
{
    public class Matricula
    {
        public class Matriculas
        {
            public int MatriculaId { get; set; } 
            public int EstudianteId { get; set; } 
            public int CursoId { get; set; } 
            public DateTime FechaMatricula { get; set; } 
            public Estudiante Estudiante { get; set; } 
            public Curso Curso { get; set; } 
            public string AdicionadoPor { get; set; } 
            public DateTime FechaAdicion { get; set; } 
            public string ModificadoPor { get; set; } 
            public DateTime? FechaModificacion { get; set; } 
        }

    }
}