namespace curso_frontend
{
    public class Ordenador
    {
        public string Marca { get; set; }
        public int Precio { get; set; }
        public Ordenador(string Marca, int Precio)
        {
            this.Marca = Marca;
            this.Precio = Precio;
        }
    }
}
