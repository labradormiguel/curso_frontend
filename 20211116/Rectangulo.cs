namespace curso_frontend
{
    public class Rectangulo
    {
        public double Lado1;
        public double Lado2;

        public Rectangulo(double Lado1, double Lado2)
        {
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
        }

        public double Area()
        {
            return this.Lado1 * this.Lado2;
        }
        public double Perimetro()
        {
            return (this.Lado1 * 2) + (this.Lado2 * 2);
        }
    }
}
