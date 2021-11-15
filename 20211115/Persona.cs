using System;
namespace curso_frontend
{
    public class Persona
    {
        public string Nombre;
        public int Edad;

        // Constructor
        public Persona(string Nombre, int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
        }
        public void andar()
        {
            Console.WriteLine("La persona anda.");
        }
    }
}
