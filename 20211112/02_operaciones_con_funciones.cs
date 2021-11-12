using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Funciones que sumen, resten, multipliquen y dividan

            Console.Write("Escribe un número: ");
            float n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe otro número: ");
            float n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La suma es: " + suma(n1, n2));
            Console.WriteLine("La resta es: " + resta(n1, n2));
            Console.WriteLine("El producto es: " + producto(n1, n2));
            Console.WriteLine("La división es: " + division(n1, n2));
        }
        static float suma(float numero1, float numero2)
        {
            return numero1 + numero2;
        }
        static float resta(float numero1, float numero2)
        {
            return numero1 - numero2;
        }
        static float producto(float numero1, float numero2)
        {
            return numero1 * numero2;
        }
        static float division(float numero1, float numero2)
        {
            return numero1 / numero2;
        }
    }
}
