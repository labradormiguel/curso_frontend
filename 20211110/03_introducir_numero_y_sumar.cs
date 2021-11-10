using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedimos un número en pantalla y sumará
            // todos los números hasta llegar a él

            Console.Write("Introduce un número: ");
            string numero = Console.ReadLine();
            int n = Convert.ToInt32(numero);

            int suma = 0;
            for (int i = 0; i <= n; i = i + 1)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma es: " + suma);
            Console.ReadLine();
        }
    }
}
