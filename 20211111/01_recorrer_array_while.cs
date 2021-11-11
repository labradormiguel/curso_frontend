using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recorrer array con bucle while

            string[] nombres = new string[4];

            nombres[0] = "Juan";
            nombres[1] = "Ana";
            nombres[2] = "Pedro";
            nombres[3] = "María";

            int i = 0;
            while (i < nombres.Length)
            {
                Console.WriteLine(nombres[i]);
                i++;
            }

            // Recorrer el array con while al revés

            i = nombres.Length - 1; // como el array por 0 hay que restar 1 al final
            Console.WriteLine("*****");
            while (i >= 0)
            {
                Console.WriteLine(nombres[i]);
                i--;
            }
        }
    }
}
