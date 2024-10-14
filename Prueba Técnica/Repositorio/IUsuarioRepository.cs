using Prueba_Técnica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Repositorio
{
    public interface IUsuarioRepository
    {
        Task<Usuario> CrearUsuario(Usuario usuario);
        Task<Usuario> AutenticarUsuario(string nombreUsuario, string contraseña);
    }
}
