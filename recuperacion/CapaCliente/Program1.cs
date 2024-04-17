using System;
using CapaDatos;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
          
            ConexionBD conexionBD = new ConexionBD();

          
            var clientes = conexionBD.ObtenerClientes();

           
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id}, Nombre: {cliente.Nombre}, Email: {cliente.Email}, Edad: {cliente.Edad}, Tipo: {cliente.Tipo}");
            }
        }
    }
}
