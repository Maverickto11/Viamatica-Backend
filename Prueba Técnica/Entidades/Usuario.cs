using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Entidades
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required]
        public string NombreUsuario { get; set; }

        [Required]
        public string clave { get; set; }

        [Required]
        [EmailAddress]
        public string CorreoElectronico { get; set; }

    }
}
