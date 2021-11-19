using System;
using System.IO; // para poder leer y escribir ficheros

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leer un archivo de texto

            string fichero = @"facturas.txt";
            string[] lineas = File.ReadAllLines(fichero);

            for (int i = 0; i < lineas.Length; i++)
            {
                Console.WriteLine(lineas[i]);
            }
        }
    }
}