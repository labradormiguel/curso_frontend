namespace net.Models
{
    public class Persona
    {
        // He puesto un ? en el tipo de Nombre porque me salía este warning sin él:
        // Non-nullable property 'Nombre' must contain a non-null value when exiting constructor.
        //Consider declaring the property as nullable. [net]
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public bool Jubilado { get; set; }
    }
}
