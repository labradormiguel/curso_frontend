using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            if (numero >= 0 && numero < 5)
            {
                Console.WriteLine("Has suspendido.");
            }
            else if (numero == 5)
            {
                Console.WriteLine("Has aprobado por los pelos.");
            }
            else
            {
                Console.WriteLine("Has sacado buena nota.");
            }
        }
    }
}
