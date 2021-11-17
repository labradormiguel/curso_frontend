// Matrícula, marca, velocidad
// Acelerar sube 10
// Decelerar baja 10
namespace curso_frontend
{
    public class Coche
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public int Velocidad { get; set; }
        public Coche(string Matricula, string Marca, int Velocidad)
        {
            this.Matricula = Matricula;
            this.Marca = Marca;
            this.Velocidad = Velocidad;
        }
        public int Acelerar()
        {
            //return Velocidad = Velocidad + 10;
            return Velocidad += 10;
        }
        public int Decelerar()
        {
            //return Velocidad = Velocidad - 10;
            return Velocidad -= 10;
        }
    }
}
