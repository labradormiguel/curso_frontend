using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace mvc_ajax.Models
{
    public class ClienteRepositorio
    {
        public List<Cliente> BuscarTodas()
        {

            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=negocio;";

            string query = "SELECT * FROM clientes";

            List<Cliente> lista = new List<Cliente>();

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {

                Cliente cliente = new Cliente(reader.GetString("dni"),
                 reader.GetString("nombre"), reader.GetString("apellido"));
                lista.Add(cliente);
            }

            return lista;
        }

        public List<Cliente> BuscarTodasPorNombre(string nombre)
        {

            string connectionString =
             "datasource=localhost;port=3306;username=root;password=;database=negocio;";

            string query =
             "SELECT * FROM clientes WHERE nombre LIKE '%" +
             nombre + "%' OR apellido LIKE '%" + nombre + "%'";

            List<Cliente> lista = new List<Cliente>();

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            lista = new List<Cliente>();
            while (reader.Read())
            {

                Cliente cliente = new Cliente(reader.GetString("dni"),
                 reader.GetString("nombre"), reader.GetString("apellido"));
                lista.Add(cliente);

            }

            databaseConnection.Close();
            return lista;

        }

        public void Insertar(Cliente c)
        {

            string connectionString =
             "datasource=localhost;port=3306;username=root;password=;database=negocio;";

            string query =
             "INSERT INTO `clientes`(`dni`, `nombre`, `apellido`) VALUES ('" + c.Dni +
             "','" + c.Nombre + "','" + c.Apellido + "');";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();

            databaseConnection.Close();

        }

        public void Editar(Cliente c)
        {

            string connectionString =
             "datasource=localhost;port=3306;username=root;password=;database=negocio;";

            string query =
             //"UPDATE clientes SET dni = " + c.Dni + " , nombre = "
             //+ c.Nombre + ", apellido = " + c.Apellido + " WHERE dni = " + c.Dni + ";";
             "SELECT dni FROM clientes;";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();

            databaseConnection.Close();

        }
    }
}