// Nombre, Equipo, Nivel(1-5)
// Método lanzar (10 km/h) y otro con parámetro
// Segundo constructor donde el nivel siempre será 1
namespace curso_frontend
{
    public class Futbolista
    {
        public string Nombre { get; set; }
        public string Equipo { get; set; }
        public int Nivel { get; set; }
        public static int Contador { get; set; }
        public Futbolista(string Nombre, string Equipo, int Nivel)
        {
            this.Nombre = Nombre;
            this.Equipo = Equipo;
            this.Nivel = Nivel;
            Contador++;
        }
        public Futbolista(string Nombre, string Equipo)
        {
            this.Nombre = Nombre;
            this.Equipo = Equipo;
            this.Nivel = 1;
            Contador++;
        }
        public int chutar()
        {
            return 10;
        }
        public int chutar(int valor)
        {
            return valor;
        }
    }
}
