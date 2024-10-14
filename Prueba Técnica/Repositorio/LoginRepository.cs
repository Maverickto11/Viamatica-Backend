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
    public class LoginRepository: ILoginRepository
    {
        public readonly AppDbContext _context;

        public LoginRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Usuario> AutenticarUsuario(string nombreUsuario, string contraseña)
        {
            // Busca el usuario en la base de datos
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.NombreUsuario == nombreUsuario);

            if (usuario == null)
            {
                return null; // Usuario no encontrado
            }

            // Aquí deberías verificar la contraseña (por ejemplo, usando hash)
            // Supongamos que tienes una función para verificar el hash
            if (!VerificarContraseña(contraseña, usuario.clave))
            {
                return null; // Contraseña incorrecta
            }

            return usuario; // Autenticación exitosa
        }

        private bool VerificarContraseña(string contraseña, string hash)
        {
            // Aquí implementa la lógica para verificar la contraseña
            // Ejemplo: usar un algoritmo de hash para comparar
            return contraseña == hash; // Esta es solo una comparación básica
        }
    }
}

