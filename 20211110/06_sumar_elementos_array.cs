using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[3];

            lista[0] = 2;
            lista[1] = 5;
            lista[2] = 7;

            int suma = 0;
            for (int i = 0; i < lista.Length; i++)
            {
                suma = suma + lista[i];
            }

            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
