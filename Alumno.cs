using System;

namespace Alumnos
{
    // Mayuscula al inicio y en singular para todas las clases.
    class Alumno : Persona
    {
        public int matricula;

        public Alumno(string nombre, string apellido, int matricula) : base (nombre, apellido) {

            this.matricula = matricula;
        }
    }
}