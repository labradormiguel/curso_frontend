namespace curso_frontend
{
    public class Calculadora
    {
        // Hay que poner static para poder acceder desde
        // el programa principal sin necesidad de crear
        // un objeto nuevo.
        public static int sumar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public static int restar(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
    }
}