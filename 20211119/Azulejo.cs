namespace curso_frontend
{
    public class Azulejo
    {
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }

        public Azulejo(int Lado1, int Lado2)
        {
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
        }
        public int Area()
        {
            return Lado1 * Lado2;
        }
    }
}