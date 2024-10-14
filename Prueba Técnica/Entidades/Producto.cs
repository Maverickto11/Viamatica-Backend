using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Entidades
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        public string? Nombre { get; set; }
        public decimal? Precio { get; set; }

        public int? CategoriaId { get; set; }

        public string? ImagenUrl { get; set; }
 

    }
}
