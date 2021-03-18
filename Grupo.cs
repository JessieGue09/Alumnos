using System;
using System.Collections.Generic;

namespace Alumnos  
{
    class Grupo 
    {
        public string nombre;
        public int semestre;
        public List<Alumno> alumnos = new List<Alumno>();
        public List<Materia> materias = new List<Materia>();

        public Grupo(string nombre, int semestre)
        {
            this.nombre = nombre;
            this.semestre = semestre;
        }

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
            if (materia.semestre != this.semestre)
            {
                throw new ArgumentException("El semestre de una materia debe coincidir con el semestre del grupo al que se agrega");
            }
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
            Console.WriteLine("Alumnos: " + this.alumnos);

            foreach (var materia in materias)
            {
                Console.WriteLine(materia.nombre);
                
            }
        }
    
    }
}