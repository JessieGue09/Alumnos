using System;
using System.Collections.Generic;

namespace Alumnos  
{
    class Grupo 
    {
        public string nombre;
        public int semestre;
        list<Alumno> alumnos = new list<Alumno>();
        list<Alumno> materias = new list<Alumno>();

        public void AgregarAlumno(Alumno alumno)
        {
            alumno.Add(alumno);
        }

        public void QuitarAlumno(Alumno alumno)
        {
            alumnos.Remove(alumno);
        }

        public void AgregarMateria(Materia materias)
        {
            materias.Add(materia);
        }

        public void AgregarMateria(Materia materia)
        {
            materia.Remove(materia);
        }
    
    }
}