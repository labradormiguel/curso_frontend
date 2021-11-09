using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
        // Comparación de dos números

        Console.WriteLine("Introduce un número:");
        string numero1 = Console.ReadLine();
        Console.WriteLine("Y ahora otro:");
        string numero2 = Console.ReadLine();

        int n1 = Convert.ToInt32(numero1);
        int n2 = Convert.ToInt32(numero2);

        if (n1 > n2)
        {
            Console.WriteLine("El " + numero1 + " es mayor que el " + numero2 + ".");
        } else if (n1 == n2) {
            Console.WriteLine("Los dos números son iguales.");
        } else
        {
            Console.WriteLine("El " + numero2 + " es mayor que el " + numero1 + ".");
        }
        Console.ReadLine();
        }
    }
}
