using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sacar la longitud de cada texto

            string[] nombres = new string[4];

            nombres[0] = "Juan";
            nombres[1] = "Ana";
            nombres[2] = "Pedro";
            nombres[3] = "María";

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i] + " tiene " + nombres[i].Length + " letras.");
            }
        }
    }
}
