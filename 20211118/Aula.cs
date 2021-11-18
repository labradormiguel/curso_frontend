using System.Collections.Generic;
namespace curso_frontend
{
    public class Aula
    {
        public int Numero { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Aula(int Numero)
        {
            this.Numero = Numero;
            this.Alumnos = new List<Alumno>();
        }
        // Creamos una función que añada alumnos
        // en vez de poner a.Alumnos.Add(new Alumno("Jaime"));
        // en el programa principal, bastaría con
        // a.AddAlumno(new Alumno("Jaime"));
        public void AddAlumno(Alumno alumno)
        {
            this.Alumnos.Add(alumno);
        }
        public Alumno AlumnoMayor()
        {
            Alumno mayor = Alumnos[0];
            for (int i = 0; i < Alumnos.Count; i++)
            {
                if (mayor.Edad < Alumnos[i].Edad)
                {
                    mayor = Alumnos[i];
                }
            }
            return mayor;
        }
        public double mediaEdad()
        {
            double edades = 0;
            for (int j = 0; j < Alumnos.Count; j++)
            {
                edades = edades+Alumnos[j].Edad;
            }
            return edades / Alumnos.Count;
        }
    }
}
