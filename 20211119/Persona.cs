using System;
namespace curso_frontend
{
    public class Persona
    {
        public string Nombre { get; set; }
        public Persona(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public virtual void Andar()
        { // Con virtual se puede modificar
          // el método en la clase hija
            Console.WriteLine("La persona anda.");
        }
    }
}