using System.Collections.Generic;
namespace mvc_ajax.Models
{

    public class FacturaRepositorio
    {
        static List<Factura> lista = new List<Factura>();
        static FacturaRepositorio()
        {

            Factura f1 = new Factura(1, "ordenador", 200);
            Factura f2 = new Factura(2, "televisor", 200);
            Factura f4 = new Factura(4, "tele", 500);
            Factura f3 = new Factura(3, "tablet", 200);
            Factura f5 = new Factura(5, "televisorSuper", 700);


            lista.Add(f1);
            lista.Add(f2);
            lista.Add(f3);
            lista.Add(f4);
            lista.Add(f5);
        }

        public List<Factura> BuscarTodas()
        {
            return lista;
        }

        public void Insertar(Factura factura)
        {
            lista.Add(factura);

        }

        public void Borrar(Factura factura)
        {
            lista.Remove(factura);

        }

        public List<Factura> BuscarTodasPorConcepto(string concepto)
        {

            List<Factura> lista2 = new List<Factura>();

            foreach (Factura f in lista)
            {
                if (f.Concepto.StartsWith(concepto))
                {
                    lista2.Add(f);
                }
            }

            return lista2;

        }

        public Factura BuscarUno(int numero)
        {
            foreach (Factura f in lista)
            {
                if (f.Numero == numero)
                {
                    return f;
                }
            }
            
            return null;
        }

    }
}