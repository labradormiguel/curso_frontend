using System;
using net.Models;
using System.Collections.Generic;

namespace net.Models.Repositorios
{
    public class TelefonoRepositorio
    {
        private static List<Telefono> lista { get; set; }

        static TelefonoRepositorio()
        {
            lista = new List<Telefono>();
            Telefono t1 = new Telefono(1, "Xiaomi", "Poco x3 PRO", 260);
            Telefono t2 = new Telefono(2, "Google", "Pixel 4a", 380);
            Telefono t3 = new Telefono(3, "Apple", "iPhone 12", 800);

            lista.Add(t1);
            lista.Add(t2);
            lista.Add(t3);
        }
        public static void Insertar(Telefono tlf)
        {
            lista.Add(tlf);
        }

        public static Telefono BuscarUna(int id)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].ID==id)
                {
                    return lista[i];
                }
            }
            return null;
        }

        public static void Borrar(int id)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].ID==id)
                {
                    lista.Remove(lista[i]);
                    break;
                }
            }
        }
        public static List<Telefono> BuscarTodos()
        {
            return lista;
        }
    }
}