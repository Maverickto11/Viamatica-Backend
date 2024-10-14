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
    public class ProductoRepository: IProductoRepository
    {
        private readonly AppDbContext _context;

        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Categoria>> ObtenerCategorias()
        {
            return await _context.Categorias
                .Include(f => f.Productos)
                .ToListAsync();
        }

        public async Task<Categoria> ObtenerCategoriasId(int id)
        {
            return await _context.Categorias
                .Include(f => f.Productos)
                .FirstOrDefaultAsync(f => f.CategoriaId == id);
        }

    }
}
