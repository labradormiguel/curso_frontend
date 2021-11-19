using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            Deportista d1 = new Deportista("Pedro");

            Console.WriteLine("El deportista se llama " + d1.Nombre + ".");
            d1.Andar();
            d1.Correr();
        }
    }
}