using System;
using System.Collections.Generic;
using System.ServiceModel;
using CapaDatos;

namespace CapaServiciosWeb
{
    [ServiceContract]
    public interface IServiciosWeb
    {
        [OperationContract]
        List<Cliente> ObtenerClientes();
    }

    public class ServiciosWeb : IServiciosWeb
    {
        public List<Cliente> ObtenerClientes()
        {
            try
            {
              
                using (ConexionBD conexionBD = new ConexionBD())
                {
                    return conexionBD.ObtenerClientes();
                }
            }
            catch (Exception ex)
            {
                
                throw new FaultException($"Error al obtener clientes: {ex.Message}");
            }
        }
    }
}
