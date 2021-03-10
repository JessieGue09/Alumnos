using System;
using System.Collections.Generic;

namespace Alumnos  
{
    class Grupo 
    {
        public string nombre;
        public int semestre;
        List<Alumno> alumnos = new List<Alumno>();
        List<Materia> materias = new List<Materia>();

        public void AgregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        public void QuitarAlumno(Alumno alumno)
        {
            alumnos.Remove(alumno);
        }

        public void AgregarMateria(Materia materia)
        {
            materias.Add(materia);
        }

        public void QuitarMateria(Materia materia)
        {
            materias.Remove(materia);
        }

        public void MostrarInfoGrupo()
        {
            Console.WriteLine($"El nombre del alumno es: {this.nombre}");
            Console.WriteLine($"El semestre en el que el alumno esta es: {this.semestre}");

            foreach (Alumno a in alumnos)
            {
                Console.WriteLine(a);
            }

            foreach (Materia m in materias)
            {
                Console.WriteLine(m);
            }
        }
    
    }
}