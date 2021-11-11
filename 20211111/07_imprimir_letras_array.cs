using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprimir cada letra de todos los elementos del array

            string[] lista = new string[] { "Pedro", "Juan", "María" };

            // Es más rápido hacerlo así
            // lista[i][j] apunta a la entrada [i] y la letra en la posición [j]
            // Si i fuera 2 y j fuera 0 mostraría la M de María

            for (int i = 0; i < lista.Length; i++)
            {
                for (int j = 0; j < lista[i].Length; j++)
                {
                    Console.WriteLine(lista[i][j]);
                }
            }

            /* Así lo hice la primera vez


            for (int i = 0; i < lista.Length; i++)
            {
                string texto = lista[i];
                for (int j = 0; j < texto.Length; j++)
                {
                    Console.WriteLine(texto[j]);
                }
            }*/
        }
    }
}
