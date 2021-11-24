using System;
using net.Models;
using System.Collections.Generic;

namespace net.Models.Repositorios
{
    public class FacturaRepositorio
    {
        public static List<Factura> lista { get; set; }

        static FacturaRepositorio()
        {
            lista = new List<Factura>();
            Factura f1 = new Factura(1, "Tablet", 300, "Sin IVA", true);
            Factura f2 = new Factura(2, "PC", 600, "IVA", false);

            lista.Add(f1);
            lista.Add(f2);
        }
        public static void Insertar(Factura f)
        {
            lista.Add(f);
        }

        public static Factura BuscarUna(int numero)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Numero==numero)
                {
                    return lista[i];
                }
            }
            return null;
        }
    }
}