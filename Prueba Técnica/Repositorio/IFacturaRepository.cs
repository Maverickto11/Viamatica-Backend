using Prueba_Técnica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Repositorio
{
    public interface IFacturaRepository
    {
        Task<Factura> GuardarFactura(Factura factura);
        Task<Factura> ObtenerFactura(int id);

        Task<IEnumerable<Factura>> ObtenerFacturas(); // Método añadido para obtener todas las facturas

        Factura GetFacturaById(int id); // Método añadido para obtener la factura

    }



}
