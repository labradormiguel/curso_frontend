namespace curso_frontend
{
    public class Monitor
    {
        public string Marca { get; set; }
        public int Pulgadas { get; set; }

        public Monitor(string Marca, int Pulgadas)
        {
            this.Marca = Marca;
            this.Pulgadas = Pulgadas;
        }
    }
}
