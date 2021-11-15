namespace curso_frontend
{
    public class Bombilla
    {
        public int Potencia;
        public bool Encendida;
        public void encender()
        {
            Encendida = true;
        }
        public void apagar()
        {
            Encendida = false;
        }
    }
}
