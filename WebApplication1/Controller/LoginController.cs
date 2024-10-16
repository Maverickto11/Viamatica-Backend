using BackendProyecto.Entidades;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Prueba_Técnica.Entidades;
using Prueba_Técnica.Repositorio;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _usuarioRepository;
        public LoginController(ILoginRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] AutenticacionRespuesta autenticacionRespuesta)
        {
            if (autenticacionRespuesta == null || string.IsNullOrEmpty(autenticacionRespuesta.correo))
            {
                return BadRequest("Información inválida.");
            }



            // Registrar el nuevo usuario.
            await _usuarioRepository.Register(autenticacionRespuesta);
            return Ok("Usuario registrado exitosamente.");
        }


        // Endpoint para el login de usuario.
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AutenticacionRespuesta loginRequest)
        {
            // Verificar si las credenciales son válidas
            if (loginRequest == null || string.IsNullOrEmpty(loginRequest.correo) || string.IsNullOrEmpty(loginRequest.contrasena))
            {
                return BadRequest("Credenciales inválidas.");
            }

            // Busca al usuario por correo y contraseña
            var user = await _usuarioRepository.Logins(loginRequest.correo, loginRequest.contrasena);

            if (user == null)
            {
                return Unauthorized(new { mensaje = "Correo o contraseña incorrectos" });
            }

            // Si el login es exitoso, puedes generar un token JWT aquí si lo deseas.
            return Ok(new { mensaje = "Inicio de sesión exitoso", token = "ejemplo-token" });
        }
    }
}
