using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sacar por pantalla el nombre más largo

            string[] nombres = new string[4];

            nombres[0] = "Juan";
            nombres[1] = "Ana";
            nombres[2] = "Pedro";
            nombres[3] = "María";

            int mayor = 0;
            for (int i = 0; i < nombres.Length; i++)
            {
                if (mayor <= nombres[i].Length)
                {
                    mayor = nombres[i].Length;
                }
            }
            Console.WriteLine("El nombre más largo tiene " + mayor + " letras.");
        }
    }
}
