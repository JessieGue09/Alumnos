using System;

namespace Personas
{
    // Mayuscula al inicio y en singular para todas las clases.
    class Persona
    {
        public string nombre;
        public string apellido;


        // Metodo constructor, sin void/string/int/etc.
        // Se llama igual que la clase.
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public void Presentarse()
        {
            //Console.WriteLine("Hola, mi nombre es: " + this.nombre);

            Console.WriteLine($"Hola, mi nombre es {this.nombre} {this.apellido}");
            
        }
    }
}