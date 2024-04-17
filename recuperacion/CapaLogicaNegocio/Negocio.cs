using System;
using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class Negocio
    {
        public double CalcularImportePago(int cantidadPersonas, double precioRuta, string tipoCliente)
        {
           
            double importePago = 0.0;


            double descuento = 0.0;
            if (cantidadPersonas >= 1 && cantidadPersonas <= 7)
            {
                descuento = 0.08; // 8% de descuento
            }
            else if (cantidadPersonas >= 8 && cantidadPersonas <= 16)
            {
                descuento = 0.13; // 13% de descuento
            }
            else if (cantidadPersonas >= 17)
            {
                descuento = 0.15; // 15% de descuento
            }

            
            if (tipoCliente == "Promoción de colegios")
            {
                descuento += 0.07; // 7% de descuento adicional
            }
            else if (tipoCliente == "Adultos mayores de 60 años")
            {
                descuento += 0.05; // 5% de descuento adicional
            }

            // Calcular el importe total a pagar
            double importeTotal = cantidadPersonas * precioRuta;
            double descuentoAplicado = importeTotal * descuento;
            importePago = importeTotal - descuentoAplicado;

            return importePago;
        }

    
    }
}
