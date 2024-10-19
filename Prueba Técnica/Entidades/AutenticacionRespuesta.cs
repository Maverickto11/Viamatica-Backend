using Prueba_Técnica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProyecto.Entidades
{
    public class AutenticacionRespuesta
    {
        [Key]
        public int id { get; set; }

        public string? nombre { get; set; }
        
        [EmailAddress]
        public string? correo { get; set; }
        public string contrasena { get; set; }
    }

}
