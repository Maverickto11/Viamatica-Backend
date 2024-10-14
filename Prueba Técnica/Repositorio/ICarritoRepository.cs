using Prueba_Técnica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Repositorio
{
    public interface ICarritoRepository
    {
        Task<IEnumerable<Carrito>> GetAllCartItemsAsync();
        Task<Carrito> GetCartItemByIdAsync(int id);
        Task AddCartItemAsync(Carrito cartItem);
        Task UpdateCartItemAsync(Carrito cartItem);
        Task DeleteCartItemAsync(int id);
    }
}
