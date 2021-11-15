using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea un objeto persona e
            // inicializa las propiedades
            Persona p1 = new Persona("Pedro", 20);
            // Imprime las propiedades
            Console.WriteLine("Nombre: " + p1.Nombre); // Las propiedades van en mayúscula en C#
            Console.WriteLine("Edad: " + p1.Edad);
            // Invoca a la funcionalidad
            p1.andar();

            Console.WriteLine("********");

            Bombilla bombilla = new Bombilla();
            bombilla.Potencia = 50;
            bombilla.Encendida = true;
            Console.WriteLine("Potencia: " + bombilla.Potencia);
            Console.WriteLine("¿Está encendida?: " + bombilla.Encendida);
            Console.WriteLine("¿Quieres tocar el interruptor? (s/n)");
            string respuesta = Console.ReadLine();
            while (respuesta != "s" && respuesta != "n")
            {
                Console.WriteLine("¿Quieres tocar el interruptor? (s/n)");
                respuesta = Console.ReadLine();
            }
            if (respuesta == "s")
            {
                if (bombilla.Encendida == false)
                {
                    bombilla.encender();
                    Console.WriteLine("¿Está encendida?: " + bombilla.Encendida);
                }
                else if (bombilla.Encendida == true)
                {
                    bombilla.apagar();
                    Console.WriteLine("¿Está encendida?: " + bombilla.Encendida);
                }
            }
            else
            {
                Console.WriteLine("¿Está encendida?: " + bombilla.Encendida);
            }
        }
    }
}
