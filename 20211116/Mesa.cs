namespace curso_frontend
{
    public class Mesa
    {
        public string Color;
        public string TipoMadera;
        public double Peso;
        // Constructor con todos los argumentos
        public Mesa(string Color, string TipoMadera, double Peso)
        {
            this.Color = Color;
            this.TipoMadera = TipoMadera;
            this.Peso = Peso;
        }
        // Mismo constructor con dos argumentos, el tercero es fijo
        public Mesa(string Color, string TipoMadera)
        {
            this.Color = Color;
            this.TipoMadera = TipoMadera;
            this.Peso = 40;
        }
        // Constructor con un solo argumento, los otros son fijos
        public Mesa(string TipoMadera)
        {
            this.Color = "roja";
            this.TipoMadera = TipoMadera;
            this.Peso = 15;
        }
    }
}
