using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leer 3 números y sacar la media

            Console.WriteLine("Introduce un número:");
            string numero1 = Console.ReadLine();
            Console.WriteLine("Introduce otro número:");
            string numero2 = Console.ReadLine();
            Console.WriteLine("Introduce el tercer número:");
            string numero3 = Console.ReadLine();

            float n1 = Convert.ToInt32(numero1);
            float n2 = Convert.ToInt32(numero2);
            float n3 = Convert.ToInt32(numero3);

            Console.WriteLine("La media es: " + ((n1 + n2 + n3) / 3));
            Console.ReadLine();
        }
    }
}
