using Microsoft.EntityFrameworkCore;
using Prueba_Técnica.Entidades;
using Prueba_Técnica.TuDbContex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Repositorio
{
    public class CarritoRepository: ICarritoRepository
    {
        private readonly AppDbContext _context;

        public CarritoRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Carrito>> GetAllCartItemsAsync()
        {
            return await _context.Carritos.ToListAsync();
        }

        // Obtener un elemento del carrito por ID
        public async Task<Carrito> GetCartItemByIdAsync(int id)
        {
            return await _context.Carritos.FindAsync(id);
        }

        // Agregar un nuevo elemento al carrito
        public async Task AddCartItemAsync(Carrito cartItem)
        {
            await _context.Carritos.AddAsync(cartItem);
            await _context.SaveChangesAsync();
        }

        // Actualizar un elemento existente del carrito
        public async Task UpdateCartItemAsync(Carrito cartItem)
        {
            _context.Carritos.Update(cartItem);
            await _context.SaveChangesAsync();
        }

        // Eliminar un elemento del carrito por ID
        public async Task DeleteCartItemAsync(int id)
        {
            var cartItem = await _context.Carritos.FindAsync(id);
            if (cartItem != null)
            {
                _context.Carritos.Remove(cartItem);
                await _context.SaveChangesAsync();
            }
        }
    }
}
