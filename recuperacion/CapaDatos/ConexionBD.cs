using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionBD
    {
  
        private string connectionString = "Data Source=CARLOS;Initial Catalog=RutasTuristicas;User Id=sa;Password=123456;";

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = "SELECT Id, Nombre, Email, Edad, Tipo FROM Clientes";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Abrimos la conexión
                    connection.Open();

                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                       
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = reader["Nombre"].ToString(),
                                Email = reader["Email"].ToString(),
                                Edad = Convert.ToInt32(reader["Edad"]),
                                Tipo = reader["Tipo"].ToString()
                            };

                            clientes.Add(cliente);
                        }
                    }
                }
            }

            return clientes;
        }

        
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }
        public string Tipo { get; set; }
       
    }
}
