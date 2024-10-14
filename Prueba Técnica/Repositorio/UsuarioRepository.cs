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
    public class UsuarioRepository: IUsuarioRepository
    {

        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> CrearUsuario(Usuario usuario)
        {
            // Verificar si el usuario ya existe
            var usuarioExistente = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.NombreUsuario == usuario.NombreUsuario || u.CorreoElectronico == usuario.CorreoElectronico);

            if (usuarioExistente != null)
            {
                return null; // El usuario ya existe
            }

            // Aquí deberías hashear la contraseña
            usuario.clave = HashContraseña(usuario.clave); // Asegúrate de que esta función esté definida

            // Agregar el usuario a la base de datos
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();

            return usuario; // Usuario creado exitosamente
        }

        public async Task<Usuario> AutenticarUsuario(string nombreUsuario, string contraseña)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.NombreUsuario == nombreUsuario);

            if (usuario == null)
            {
                return null; // Usuario no encontrado
            }

            // Verificar la contraseña (compara el hash)
            if (!VerificarContraseña(contraseña, usuario.clave))
            {
                return null; // Contraseña incorrecta
            }

            return usuario; // Autenticación exitosa
        }

        private string HashContraseña(string contraseña)
        {
            // Implementa aquí tu lógica de hash para la contraseña
            return contraseña; // Esto es solo un ejemplo, debes usar un algoritmo de hash
        }

        private bool VerificarContraseña(string contraseña, string hash)
        {
            // Aquí implementa la lógica para verificar la contraseña
            return contraseña == hash; // Esta es solo una comparación básica
        }
    }
}
