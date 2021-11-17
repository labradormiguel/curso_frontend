using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Coche que aumenta y disminuye la velocidad

            Coche coche = new Coche("50213F", "Toyota", 50);

            Console.WriteLine(coche.Acelerar());
            Console.WriteLine(coche.Acelerar());
            Console.WriteLine(coche.Acelerar());
            Console.WriteLine(coche.Acelerar());
            Console.WriteLine(coche.Decelerar());
            Console.WriteLine(coche.Decelerar());
            Console.WriteLine(coche.Acelerar());
        }
    }
}
