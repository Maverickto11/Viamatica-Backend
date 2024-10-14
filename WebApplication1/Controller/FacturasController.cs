using Azure;
using Microsoft.AspNetCore.Mvc;
using Prueba_Técnica.Entidades;
using Prueba_Técnica.Repositorio;
using System.Threading.Tasks;

namespace WebApplication1.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaRepository _facturaRepository;

        public FacturaController(IFacturaRepository facturaRepository)
        {
            _facturaRepository = facturaRepository;
        }

        [HttpPost]
        public async Task<ActionResult<Factura>> GuardarFactura(Factura factura)
        {
            var nuevaFactura = await _facturaRepository.GuardarFactura(factura);
            return Ok(nuevaFactura);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Factura>> ObtenerFactura(int id)
        {
            var factura = await _facturaRepository.ObtenerFactura(id);

            if (factura == null)
            {
                return NotFound();
            }

            return Ok(factura);
        }

        [HttpGet]
        public async Task<ActionResult<Factura>> ObtenerFacturas()
        {
            var facturas = await _facturaRepository.ObtenerFacturas();
            return Ok(facturas);
        }
    }
    
}
