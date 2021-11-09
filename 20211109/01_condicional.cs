using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
        // Ejemplo de sentencia condicional

        int nota = 2;
        if (nota>5)
        {
            Console.WriteLine("Has aprobado.");
        }
        else if (nota>=0 && nota<3)
        {
            Console.WriteLine("Muy mal.");
        }
        else
        {
            Console.WriteLine("Has suspendido.");
        }
        Console.ReadLine();
        }
    }
}
