using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            Mesa m1 = new Mesa("azul", "caoba", 20);
            Console.Write("La mesa es " + m1.Color + ", es de " + m1.TipoMadera + " y pesa " + m1.Peso + " kilos.");
            Console.WriteLine();
            Mesa m2 = new Mesa("morada", "roble");
            Console.Write("La mesa es " + m2.Color + ", es de " + m2.TipoMadera + " y pesa " + m2.Peso + " kilos.");
            Console.WriteLine();
            Mesa m3 = new Mesa("abedul");
            Console.Write("La mesa es " + m3.Color + ", es de " + m3.TipoMadera + " y pesa " + m3.Peso + " kilos.");
        }
    }
}
