using System;

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Los diez primeros números pares


            for (int i = 1; i <= 20; i = i + 1)
            {
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
            Console.ReadLine();
            */

            // Otra manera más sencilla

            for(int i=0; i<=10;i=i+1)
            {
                Console.WriteLine(i*2);
            }
            Console.ReadLine();
        }
    }
}
