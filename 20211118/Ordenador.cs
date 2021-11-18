namespace curso_frontend
{
    public class Ordenador
    {
        public string Marca { get; set; }
        public int Precio { get; set; }
        public Monitor MonitorA { get; set; }

        public Ordenador(string Marca, int Precio, Monitor MonitorA)
        {
            this.Marca = Marca;
            this.Precio = Precio;
            this.MonitorA = MonitorA;
        }
    }
}
