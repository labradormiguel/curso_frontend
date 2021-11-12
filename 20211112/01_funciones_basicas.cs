using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            hola();
            hola();
            adios();
            hola();
            hola();

            // Función con un argumento
            Console.WriteLine(duplicar(2));

            // Función dentro de un bucle
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(duplicar(i));
            }
        }
        static void hola()
        {
            Console.WriteLine("Hola");
        }
        static void adios()
        {
            Console.WriteLine("Adiós");
        }
        static double duplicar(double numero)
        {
            return numero * 2;
        }
    }
}
