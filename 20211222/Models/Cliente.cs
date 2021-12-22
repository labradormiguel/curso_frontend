namespace mvc_ajax.Models
{
    public class Cliente
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Cliente(string Dni, string Nombre, string Apellido)
        {
            this.Dni = Dni;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }

        public Cliente()
        {
            
        }
    }
}