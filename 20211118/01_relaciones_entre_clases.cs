using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Relaciones entre clases

            Monitor m1 = new Monitor("Samsung", 30);
            Ordenador pc = new Ordenador("Lenovo", 400, m1);

            Console.WriteLine("Marca del PC: " + pc.Marca);
            Console.WriteLine("Marca del monitor: " + pc.MonitorA.Marca);
            Console.WriteLine();

            Motor motor = new Motor(4000);
            Frigorifico nevera = new Frigorifico("LG", motor);

            Console.WriteLine("Potencia del motor: " + nevera.Motor.Potencia);
        }
    }
}
