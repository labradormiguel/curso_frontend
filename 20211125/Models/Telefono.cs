using System;
namespace net.Models
{
    public class Telefono
    {
        public int ID { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Precio { get; set; }
        public Telefono(int id, string marca, string modelo, int precio)
        {
            this.ID = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
        }
        public Telefono()
        {

        }
    }
}