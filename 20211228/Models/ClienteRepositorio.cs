using System.Collections.Generic;
namespace mvc_ajax.Models
{

    public class ClienteRepositorio
    {
        static List<Cliente> lista = new List<Cliente>();
        static ClienteRepositorio()
        {

            Cliente c1 = new Cliente("12345678-A", "Carlos Alberto", "Gándara");
            Cliente c2 = new Cliente("23456789-K", "Javier Andrés", "Salcines");
            Cliente c3 = new Cliente("34567890-F", "Macario", "San Emeterio");
            Cliente c4 = new Cliente("87654321-Z", "Juan Luis", "Cano");
            Cliente c5 = new Cliente("87654322-Y", "Pedro Manuel", "Camus");
            Cliente c6 = new Cliente("95481027-D", "Kevin", "Smith");


            lista.Add(c1);
            lista.Add(c2);
            lista.Add(c3);
            lista.Add(c4);
            lista.Add(c5);
            lista.Add(c6);
        }

        public List<Cliente> BuscarTodas()
        {
            return lista;
        }

        public void Insertar(Cliente cliente)
        {
            lista.Add(cliente);

        }

        public void Borrar(Cliente cliente)
        {
            lista.Remove(cliente);

        }

        public List<Cliente> BuscarTodasPorNombre(string nombre)
        {

            List<Cliente> lista2 = new List<Cliente>();

            foreach (Cliente c in lista)
            {
                if (c.Nombre.Contains(nombre) || c.Apellido.Contains(nombre))
                {
                    lista2.Add(c);
                }
            }

            return lista2;

        }

        public Cliente BuscarUno(string dni)
        {
            foreach (Cliente c in lista)
            {
                if (c.Dni == dni)
                {
                    return c;
                }
            }
            
            return null;
        }

    }
}