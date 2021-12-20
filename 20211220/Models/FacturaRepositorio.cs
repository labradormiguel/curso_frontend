using System.Collections.Generic;

namespace mvc_ajax.Models
{
    public class FacturaRepositorio
    {
        public List<Factura> BuscarTodas()
        {
            Factura f1 = new Factura(1, "Ordenador", 200);
            Factura f2 = new Factura(2, "Tablet", 200);
            Factura f3 = new Factura(3, "Televisor", 200);

            List<Factura> lista = new List<Factura>();

            lista.Add(f1);
            lista.Add(f2);
            lista.Add(f3);

            return lista;
        }
    }
}