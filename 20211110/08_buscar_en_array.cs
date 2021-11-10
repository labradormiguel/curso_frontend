using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduce un número y dime si está en el array

            int[] lista = new int[3];

            lista[0] = 2;
            lista[1] = 5;
            lista[2] = 7;

            Console.Write("Introduce un número: ");
            string numero = Console.ReadLine();
            int n = Convert.ToInt32(numero);

            int contador = 0;
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == n)
                {
                    Console.WriteLine("Encontrado en lista[" + i + "]");
                    contador++;
                }
            }
            if (contador == 1)
            {
                Console.WriteLine("Encontrado una vez.");
            }
            else if (contador == 0)
            {
                Console.WriteLine("No está.");
            }
            else
            {
                Console.WriteLine("Encontrado " + contador + " veces.");
            }
        }
    }
}
