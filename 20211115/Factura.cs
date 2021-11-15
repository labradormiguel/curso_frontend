namespace curso_frontend
{
    public class Factura
    {
        public string Concepto;
        public double Importe;
        public int Numero;

        public Factura(int Numero, string Concepto, double Importe)
        {
            // el operador this es un operador de ámbito
            // que lo hace es decirnos que la
            // variable número hace referencia a la de la clase
            this.Numero = Numero;
            this.Concepto = Concepto;
            this.Importe = Importe;
        }

        public double importeConIVA()
        {
            return this.Importe * 1.21;
        }
    }
}
