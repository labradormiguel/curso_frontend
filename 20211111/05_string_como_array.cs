using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tratar una cadena de texto como un array

            string texto = "hola";

            for (int i = 0; i < texto.Length; i++)
            {
                Console.WriteLine(texto[i]);
            }
        }
    }
}
