using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Velocidad a la que chutan los futbolistas el balón

            Futbolista fut1 = new Futbolista("Pedri", "Barcelona", 5);
            Futbolista fut2 = new Futbolista("Pepe", "Perines");

            Console.WriteLine(fut2.Nombre + " juega en el " + fut2.Equipo + " y es de nivel " + fut2.Nivel + ".");
            Console.WriteLine(fut1.Nombre + " juega en el " + fut1.Equipo + " y es de nivel " + fut1.Nivel + ".");
            Console.WriteLine("El balón va a " + fut1.chutar() + " km/h"); // Por defecto devuelve 10
            Console.WriteLine("El balón va a " + fut2.chutar(40) + " km/h");
            Console.WriteLine("Hay " + Futbolista.Contador + " futbolistas registrados."); // fut1 y fut2
        }
    }
}
