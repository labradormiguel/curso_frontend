using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sumar los 5 primeros números usando un contador

            int total = 0;
            for (int i = 1; i <= 5; i = i + 1)
            {
                total = total + i;
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
