namespace curso_frontend
{
    public class Frigorifico
    {
        public string Marca { get; set; }
        public Motor Motor { get; set; }
        public Frigorifico(string Marca, Motor Motor)
        {
            this.Marca = Marca;
            this.Motor = Motor;
        }
    }
}
