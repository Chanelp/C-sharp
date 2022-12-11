using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine() { }

        public void Inicializar()
        {
            Escuela = new Escuela("ITLA", 2000, TipoEscuela.Secundaria, "República Dominican", "Barahona");
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        /* Por cada Alumno de cada Curso, generar 5 evaluaciones por cada asignatura. 
        La evaluación debe tener una nota entre 0.0 y 5.0 */
        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluación
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(ev);
                        }
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{Nombre="Matemáticas"} ,
                    new Asignatura{Nombre="Educación Física"},
                    new Asignatura{Nombre="Castellano"},
                    new Asignatura{Nombre="Ciencias Naturales"},
                    new Asignatura{Nombre="Historia"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            //Usando LINQ, crear un producto cartesiano con los arreglos anteriores
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.uniqueID).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            //Implementando la colección List para almacenar los objetos
            Escuela.Cursos = new List<Curso>(){
            new Curso(){ Nombre = "101", Jornada = TipoJornada.Mañana },
            new Curso(){ Nombre = "201", Jornada = TipoJornada.Mañana },
            new Curso(){ Nombre = "301", Jornada = TipoJornada.Mañana },
            new Curso(){ Nombre = "401", Jornada = TipoJornada.Tarde },
            new Curso(){ Nombre = "501", Jornada = TipoJornada.Tarde }
            };

            //Generar entre 5 y 20 alumnos que se van a asignar a cada curso
            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                curso.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }
        }
    }
}