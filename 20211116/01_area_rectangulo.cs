using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perímetro y área de un rectángulo

            Console.Write("¿Cuánto mide la base? ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("¿Cuánto mide la altura? ");
            double a = Convert.ToDouble(Console.ReadLine());

            Rectangulo r = new Rectangulo(b, a);
            Console.WriteLine("El área es: " + r.Area());
            Console.WriteLine("El perímetro es: " + r.Perimetro());
        }
    }
}
