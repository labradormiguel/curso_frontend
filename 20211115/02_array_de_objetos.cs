using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un array con tres bombillas

            Bombilla bombilla = new Bombilla();

            Bombilla[] pasillo = new Bombilla[3];

            Bombilla b1 = new Bombilla();
            b1.Potencia = 20;
            pasillo[0] = b1;

            Bombilla b2 = new Bombilla();
            b2.Potencia = 30;
            pasillo[1] = b2;

            Bombilla b3 = new Bombilla();
            b3.Potencia = 60;
            pasillo[2] = b3;

            for (int i = 0; i < pasillo.Length; i++)
            {
                Console.WriteLine(pasillo[i].Potencia);
            }
        }
    }
}
