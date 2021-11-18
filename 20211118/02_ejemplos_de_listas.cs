using System;
using System.Collections.Generic; // para importar la lista

namespace curso_frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de lista
            // Una lista es una clase, puede funcionar como un array,
            // se le puede especificar el tipo y no hay límite de items.
            // Lo vamos a usar para relaciones 1->N

            List<string> lista = new List<string>();
            lista.Add("hola");
            lista.Add("qué");
            lista.Add("tal");
            lista.Add("estás");

            for (int i = 0; i < lista.Count; i++) // En las listas se usa Count en vez de Length
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine();
            lista.Remove("hola");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine();

            // Lista con aula y alumnos

            Aula a = new Aula(1);
            a.AddAlumno(new Alumno("Pepe", 15));
            a.AddAlumno(new Alumno("Juan", 16));
            a.AddAlumno(new Alumno("Luis", 18));
            a.AddAlumno(new Alumno("Andrés", 21));
            a.AddAlumno(new Alumno("Jaime", 12));

            for (int i = 0; i < a.Alumnos.Count; i++)
            {
                Console.WriteLine(a.Alumnos[i].Nombre + " " + a.Alumnos[i].Edad);
            }
            Console.WriteLine();

            // Cuál es el alumno más mayor

            Console.WriteLine(a.AlumnoMayor().Nombre + " es el mayor con " + a.AlumnoMayor().Edad + " años.");

            // Lo que hice yo

            string nombreMayor = null;
            int edadMayor = 0;
            for (int i = 0; i < a.Alumnos.Count; i++)
            {
                if (a.Alumnos[i].Edad > edadMayor)
                {
                    nombreMayor = a.Alumnos[i].Nombre;
                    edadMayor = a.Alumnos[i].Edad;
                }
            }
            Console.WriteLine(nombreMayor + " es el mayor con " + edadMayor + " años.");

            Console.WriteLine("La edad media es: " + a.mediaEdad());
        }
    }
}
