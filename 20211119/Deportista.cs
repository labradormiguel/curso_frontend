using System;
namespace curso_frontend
{
    public class Deportista : Persona
    {
        public Deportista(string Nombre) : base(Nombre)
        { // La clase hereda todo por defecto
          // salvo los constructores, hay que pasarle
          // la base para que funcione.

        }
        public void Correr()
        {
            Console.WriteLine("El deportista corre.");
        }
        public override void Andar()
        { // Necesita "virtual" en la clase madre
          // para poder sobreescribir aquí.
            Console.WriteLine("El deportista anda rápido.");
        }
    }
}