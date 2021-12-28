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

        public Cliente(string Dni)
        {
            this.Dni = Dni;
        }

        public override bool Equals(object obj)
        {

            Cliente otro = (Cliente)obj;

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (otro.Dni == Dni)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {

            return Dni.GetHashCode();
        }

    }
}