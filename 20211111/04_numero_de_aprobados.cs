using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sacar por pantalla el número total de aprobados

            int[] notas = new int[8];

            notas[0] = 6;
            notas[1] = 8;
            notas[2] = 1;
            notas[3] = 3;
            notas[4] = 4;
            notas[5] = 9;
            notas[6] = 5;
            notas[7] = 4;

            int contador = 0;
            int i = 0;
            while (i < notas.Length)
            {
                if (notas[i] >= 5)
                {
                    contador++;
                }
                i++;
            }
            Console.WriteLine("Han aprobado " + contador + " alumnos.");
        }
    }
}
