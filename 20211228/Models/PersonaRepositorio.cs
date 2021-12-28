using System.Collections.Generic;

namespace mvc_ajax.Models
{
    public class PersonaRepositorio
    {
        public List<Persona> BuscarTodas()
        {
            Persona p1 = new Persona("Juan", "Pérez");
            Persona p2 = new Persona("Pedro", "Lapiedra");
            Persona p3 = new Persona("Luis", "XV");

            List<Persona> lista = new List<Persona>();

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);

            return lista;
        }
    }
}
