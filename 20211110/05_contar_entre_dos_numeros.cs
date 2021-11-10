using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir dos números e imprimir todos los números
            // entre los dos

            Console.Write("Introduce un número: ");
            string numero1 = Console.ReadLine();
            int n1 = Convert.ToInt32(numero1);
            Console.Write("Ahora un número más alto: ");
            string numero2 = Console.ReadLine();
            int n2 = Convert.ToInt32(numero2);

            if (n1 < n2)
            {
                for (int i = n1; i <= n2; i = i + 1)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("El segundo número debe ser más alto que el primero.");
            }

            Console.ReadLine();
        }
    }
}
