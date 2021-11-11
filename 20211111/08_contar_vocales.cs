using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Un programa recorre una lista de palabras
            // e imprime la lista de vocales

            string[] lista = new string[] { "Pedro", "Juan", "María" };

            for (int i = 0; i < lista.Length; i++)
            {
                int vocal_a = 0;
                int vocal_e = 0;
                int vocal_i = 0;
                int vocal_o = 0;
                int vocal_u = 0;
                for (int j = 0; j < lista[i].Length; j++)
                {
                    if (lista[i][j] == 'a' || lista[i][j] == 'á')
                    {
                        vocal_a++;
                    }
                    else if (lista[i][j] == 'e' || lista[i][j] == 'é')
                    {
                        vocal_e++;
                    }
                    else if (lista[i][j] == 'i' || lista[i][j] == 'í')
                    {
                        vocal_i++;
                    }
                    else if (lista[i][j] == 'o' || lista[i][j] == 'ó')
                    {
                        vocal_o++;
                    }
                    else if (lista[i][j] == 'u' || lista[i][j] == 'ú')
                    {
                        vocal_u++;
                    }
                }
                Console.WriteLine(lista[i] + " tiene la vocal A " + vocal_a + " veces.");
                Console.WriteLine(lista[i] + " tiene la vocal E " + vocal_e + " veces.");
                Console.WriteLine(lista[i] + " tiene la vocal I " + vocal_i + " veces.");
                Console.WriteLine(lista[i] + " tiene la vocal O " + vocal_o + " veces.");
                Console.WriteLine(lista[i] + " tiene la vocal U " + vocal_u + " veces.");
                Console.WriteLine("----");
            }
        }
    }
}
