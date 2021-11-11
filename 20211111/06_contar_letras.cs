using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cuantas letras "a" hay en el texto

            string texto = "hola qué tal";

            int contador = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == 'a') // Importante comillas simples en vez de dobles
                {
                    contador++;
                }
            }
            Console.WriteLine("Hay " + contador + " letras 'a'.");
        }
    }
}
