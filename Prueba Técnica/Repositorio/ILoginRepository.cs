using BackendProyecto.Entidades;
using Microsoft.EntityFrameworkCore;
using Prueba_Técnica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Repositorio
{
    public interface ILoginRepository
    { 

        Task<AutenticacionRespuesta> Logins(string email, string contrasena);

        Task Register(AutenticacionRespuesta nombre);

        Task<AutenticacionRespuesta> ObtenerUsuarioPorCorreo(string email);

    }
}
