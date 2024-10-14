using Microsoft.AspNetCore.Mvc;
using Prueba_Técnica.Entidades;
using Prueba_Técnica.Repositorio;

namespace WebApplication1.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarritoController : ControllerBase
    {
        private readonly ICarritoRepository _cartItemRepository;

        public CarritoController(ICarritoRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddProductToCart([FromBody] Carrito cartItem)
        {
            if (cartItem == null)
            {
                return BadRequest("Producto no válido");
            }

            await _cartItemRepository.AddCartItemAsync(cartItem);

            return Ok(cartItem);
        }

        [HttpGet]
        public async Task<IActionResult> GetCartItems()
        {
            var cartItems = await _cartItemRepository.GetAllCartItemsAsync();
            return Ok(cartItems);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCartItemById(int id)
        {
            var cartItem = await _cartItemRepository.GetCartItemByIdAsync(id);

            if (cartItem == null)
            {
                return NotFound();
            }

            return Ok(cartItem);
        }


        // Método para eliminar un elemento del carrito por ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartItem(int id)
        {
            var cartItem = await _cartItemRepository.GetCartItemByIdAsync(id);

            if (cartItem == null)
            {
                return NotFound(); // Devuelve 404 si el elemento no existe
            }

            await _cartItemRepository.DeleteCartItemAsync(id);
            return NoContent(); // Devuelve 204 No Content si la eliminación fue exitosa
        }

    }
}
