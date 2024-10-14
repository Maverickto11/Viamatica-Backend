using Prueba_Técnica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Repositorio
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Categoria>> ObtenerCategorias(); // Método añadido para obtener todas las facturas
        Task<Categoria> ObtenerCategoriasId(int id);

    }
}
