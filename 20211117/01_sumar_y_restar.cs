using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introducir dos números, sumarlos y restarlos

            Console.WriteLine("La suma es: " + Calculadora.sumar(5, 6));
            Console.WriteLine("La resta es: " + Calculadora.restar(7, 1));
        }
    }
}
