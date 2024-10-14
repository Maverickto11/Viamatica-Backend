using Microsoft.EntityFrameworkCore;
using Prueba_Técnica.Entidades;
using Prueba_Técnica.TuDbContex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace Prueba_Técnica.Repositorio
{
    public class FacturaRepository : IFacturaRepository
    {
        private readonly AppDbContext _context;

        public FacturaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Factura> GuardarFactura(Factura factura)
        {
            _context.Facturas.Add(factura);
            await _context.SaveChangesAsync();
            return factura;
        }

        public async Task<Factura> ObtenerFactura(int id)
        {
            return await _context.Facturas
                .Include(f => f.Detalles)
                .FirstOrDefaultAsync(f => f.FacturaId == id);
        }
        public Factura GetFacturaById(int id)
        {
            return _context.Facturas
                           .Include(f => f.Detalles)
                           .FirstOrDefault(f => f.FacturaId == id);
        }

        public async Task<IEnumerable<Factura>> ObtenerFacturas()
        {
            return await _context.Facturas
                .Include(f => f.Detalles)
                .ToListAsync();
        }

    }



}
