using System;
//using System.Linq;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprimir el número mayor del array
            // descomentar using System.Linq para poder usar max();

            int[] lista = new int[3];

            lista[0] = 2;
            lista[1] = 5;
            lista[2] = 7;

            //Console.WriteLine("El número mayor es: "+lista.Max());

            int mayor = 0;
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] > mayor)
                {
                    mayor = lista[i];
                }
            }
            Console.WriteLine("El número mayor es: " + mayor);
        }
    }
}
