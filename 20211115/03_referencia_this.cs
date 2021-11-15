using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura(1, "Tornillos", 40);

            Console.WriteLine("Número: " + f1.Numero);
            Console.WriteLine("Concepto: " + f1.Concepto);
            Console.WriteLine("Importe: " + f1.importeConIVA());
        }
    }
}
