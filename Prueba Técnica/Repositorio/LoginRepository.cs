using BackendProyecto.Entidades;
using Microsoft.AspNetCore.Mvc;
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
    public class LoginRepository : ILoginRepository
    {

        private readonly AppDbContext _context;
        public LoginRepository(AppDbContext context)
        {
            _context = context; 
        }

        public async Task<AutenticacionRespuesta> Logins(string correo, string contrasena)
        {
            return await _context.AutenticacionRespuestas
                                 .FirstOrDefaultAsync(u => u.correo == correo &&  u.contrasena == contrasena);
        }


        public async Task Register([FromBody] AutenticacionRespuesta nombre)
        {
            _context.AutenticacionRespuestas.Add(nombre);
            await _context.SaveChangesAsync();

        }





    }
}