using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clases, objetos y propiedades

            Telefono t1 = new Telefono();
            t1.marca = "Samsung";
            t1.numero = 123456789;
            Console.WriteLine(t1.marca);
            Console.WriteLine(t1.numero);
            t1.llamar();
        }
    }
}
