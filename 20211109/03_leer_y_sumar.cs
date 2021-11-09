using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
        // Leer dos números y sumarlos

        string numero1 = Console.ReadLine();
        string numero2 = Console.ReadLine();

        //Hay que pasarlos a int para poder operar con ellos
        int n1 = Convert.ToInt32(numero1);
        int n2 = Convert.ToInt32(numero2);

        Console.WriteLine("El primer número es: " + numero1);
        //Console.WriteLine(numero1);
        Console.WriteLine("El segundo número es: " + numero2);
        //Console.WriteLine(numero2);
        //Console.WriteLine(n1 + n2); // 3 + 7 = 10
        Console.WriteLine("La suma es: " + (n1 + n2));
        //Si los hubiéramos dejado como strings la "suma" juntaría los dos números
        //Console.WriteLine(numero1 + numero2); 3 + 7 = 37

        Console.ReadLine();
        }
    }
}
