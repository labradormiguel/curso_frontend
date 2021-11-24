using System;
namespace net.Models
{
    public class Factura
    {
        public int Numero { get; set; }
        public string? Nombre { get; set; }
        public double Importe { get; set; }
        public string? TipoIVA { get; set; }
        public bool Pagada { get; set; }
        public Factura(int Numero, string Nombre, double Importe, string TipoIVA, bool Pagada)
        {
            this.Numero = Numero;
            this.Nombre = Nombre;
            this.Importe = Importe;
            this.TipoIVA = TipoIVA;
            this.Pagada = Pagada;
        }
        public Factura()
        {

        }
    }
}