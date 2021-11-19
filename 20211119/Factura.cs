namespace curso_frontend
{
    public class Factura
    {
        public int Numero { get; set; }
        public string Concepto { get; set; }
        public int Importe { get; set; }
        public Factura(int Numero, string Concepto, int Importe)
        {
            this.Numero = Numero;
            this.Concepto = Concepto;
            this.Importe = Importe;
        }
        public double ImporteIVA()
        {
            return Importe * 1.21;
        }
    }
}