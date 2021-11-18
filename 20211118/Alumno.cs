namespace curso_frontend
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Alumno(string Nombre, int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
        }
    }
}
