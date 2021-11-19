using System;
using System.Collections.Generic;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Añadir azulejos y calcular el área azulejada

            Azulejo a1 = new Azulejo(2, 2);
            Azulejo a2 = new Azulejo(2, 2);
            Suelo suelo = new Suelo();
            suelo.AddAzulejo(a1);
            suelo.AddAzulejo(a2);

            Console.WriteLine("Área total: " + suelo.AreaTotal());
        }
    }
}