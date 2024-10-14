using Microsoft.AspNetCore.Mvc;
using Prueba_Técnica.Entidades;
using Prueba_Técnica.Repositorio;

namespace WebApplication1.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    { 
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearUsuario([FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var nuevoUsuario = await _usuarioRepository.CrearUsuario(usuario);

            if (nuevoUsuario == null)
                return Conflict("El nombre de usuario o correo electrónico ya está en uso.");

            return CreatedAtAction(nameof(CrearUsuario), nuevoUsuario);
        }
    }

   
}
