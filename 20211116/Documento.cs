using System;
namespace curso_frontend
{
    public class Documento
    {
        public string Texto;
        public double Version;
        public Documento(double Version, string Texto)
        {
            this.Version = Version;
            this.Texto = Texto;
        }
        public void Imprimir()
        {
            Console.Write("Versión: " + this.Version);
            Console.WriteLine();
            Console.WriteLine(this.Texto);
        }
        /*
        public void ImprimirPagina(int Pagina)
        {
            Console.WriteLine("Estás en la página: " + Pagina);
        }
        */

        // Se pueden tener varias funciones con el mismo nombre
        // si se le pasan diferentes números de argumentos.
        // A esto se le llama sobrecarga estática
        public void Imprimir(int Pagina)
        {
            Console.WriteLine("Estás en la página: " + Pagina);
        }
        public void Imprimir(int PaginaInicio, int PaginaFin)
        {
            Console.WriteLine("Empieza en la página " + PaginaInicio + " y termina en la " + PaginaFin + ".");
        }
        // La sobrecarga también se puede usar con constructores
        // En este caso le pasamos solo un argumento porque asumimos
        // que la versión será siempre la 3.
        public Documento(string Texto)
        {
            this.Version = 3;
            this.Texto = Texto;
        }
    }
}
