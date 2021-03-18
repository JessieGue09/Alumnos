using System;
using System.Collections.Generic;

namespace Alumnos
{
    // Mayuscula al inicio y en singular para todas las clases.
    class Alumno : Persona
    {
        public int matricula;

        public Alumno(string nombre, string apellido, int matricula) : base (nombre, apellido) 
        {
            if (matricula <= 0)
            {
                // Arrojar Exepción: La matricula debe ser igual o mayor a 1.
                throw new ArgumentException("La matricula debe ser igual o mayor a 1");
            }
            if (nombre == "") 
            {
                // Arrojar Execpción: El nombre no debe estar vacio.
                throw new ArgumentException("El nombre no debe estar vacio");
            }
            if (apellido == "")
            {
                throw new ArgumentException("El apellido no debe estar vacio");
            }
            if (nombre == null)
            {
                throw new ArgumentException("El nombre no debe estar null");
            }
            if (apellido == null)
            {
                throw new ArgumentException("El apellido no debe estar null");
            }


            this.matricula = matricula;
        }
    }
}