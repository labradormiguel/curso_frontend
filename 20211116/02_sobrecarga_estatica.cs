using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprimir texto y versión

            double v = 1.0;
            string t = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
            Documento doc = new Documento(v, t);

            doc.Imprimir();

            // Imprimir la página pasando un argumento a Imprimir()

            Console.Write("¿Qué página? ");
            int p = Convert.ToInt32(Console.ReadLine());
            doc.Imprimir(p);

            // Imprimir la página de inicio y la de fin pasando dos argumentos

            Console.Write("¿Página de inicio? ");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("¿Página de fin? ");
            int p2 = Convert.ToInt32(Console.ReadLine());
            doc.Imprimir(p1, p2);

            // Imprimir texto y versión, solo se pasa argumento para el texto

            Documento doc2 = new Documento(t);
            doc2.Imprimir();
        }
    }
}
