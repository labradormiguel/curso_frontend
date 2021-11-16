namespace curso_frontend
{
    public class Persona
    {
        private string nombre; // si es privado solo puede acceder la clase
        public string Nombre // para poder acceder desde el main hay que hacer una pública con get y set
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public static int Contador { get; set; } // forma compacta de hacer una variable privada
        // al poner "static" la variable es de la clase y compartida por todos los objetos
        // al no ponerlo cada persona tendría su propio contador
        private int edad;
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    this.edad = value;
                }
            }
        }
        public Persona(string Nombre, int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            Contador++;
        }
    }
}
