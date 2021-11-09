using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribir hola cinco veces

            for (int i = 0; i < 5; i = i + 1)
            {
                Console.WriteLine("Hola (" + i + ")");
            }
            Console.ReadLine();
        }
    }
}
