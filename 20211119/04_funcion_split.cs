using System;
using System.IO; // para poder leer y escribir ficheros

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sumatorio con IVA de todas las facturas

            string fichero = @"facturas.txt";
            string[] lineas = File.ReadAllLines(fichero);
            double total = 0;

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] propiedad = lineas[i].Split(",");
                int numero = Convert.ToInt32(propiedad[0]);
                string concepto = propiedad[1];
                int importe = Convert.ToInt32(propiedad[2]);

                Factura factura = new Factura(numero, concepto, importe);
                total = total + factura.ImporteIVA();

                Console.WriteLine(total);
            }
        }
    }
}