using Microsoft.AspNetCore.Mvc;
using Prueba_Técnica.Entidades;
using Prueba_Técnica.Repositorio;

namespace WebApplication1.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;

        public CategoriaController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Categoria>> ObtenerCategorias()
        {
            var categorias = await _productoRepository.ObtenerCategorias();
            return Ok(categorias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Categoria>> ObtenerCategoriasId(int id)
        {
            var categorias = await _productoRepository.ObtenerCategoriasId(id);

            if (categorias == null)
            {
                return NotFound();
            }

            return Ok(categorias);
        }
    }
}
