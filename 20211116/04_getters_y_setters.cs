using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definimos límite con get y set
            // el valor de la edad debe estar entre 0 y 100
            // si está fuera de esos límites saldrá como 0
            Persona persona = new Persona("Juan",26);
            Console.WriteLine(persona.Nombre+" tiene "+persona.Edad+" años.");
            Console.WriteLine();

            // Una nota que podamos subir o bajar de uno en uno y que esté entre 0 y 10
            Nota nota = new Nota(5);
            Console.WriteLine("La nota es: " + nota.Valor);

            //nota.Subir();
            nota.Bajar();
            Console.WriteLine(nota.Valor); // 6 o 4
            //nota.Subir();
            nota.Bajar();
            Console.WriteLine(nota.Valor); // 7 o 3
            //nota.Subir();
            nota.Bajar();
            Console.WriteLine(nota.Valor); // 8 o 2
            //nota.Subir();
            nota.Bajar();
            Console.WriteLine(nota.Valor); // 9 o 1
            //nota.Subir();
            nota.Bajar();
            Console.WriteLine(nota.Valor); // 10 o 0
            //nota.Subir();
            nota.Bajar();
            Console.WriteLine(nota.Valor); // 10 o 0, no puede pasar de aquí
            Console.WriteLine();

            // Un contador para el número de personas
            // Ojo, salen 4 en vez de 3 porque está tomando en cuenta también
            // el objeto persona que creamos al principio del documento

            Persona p1 = new Persona("pepe",-100);
            Persona p2 = new Persona("pepe",-100);
            Persona p3 = new Persona("pepe",-100);
            Console.WriteLine(Persona.Contador);
            Console.WriteLine();

            // Comparar dos notas

            Nota nota1 = new Nota(9);
            Nota nota2 = new Nota(7);
            Console.WriteLine(nota1.esMayor(nota2));
            Console.WriteLine(Nota.esMayor(nota1, nota2));
        }
    }
}
