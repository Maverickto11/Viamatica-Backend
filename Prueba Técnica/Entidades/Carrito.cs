using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Entidades
{
    public class Carrito
    {
        [Key]
        public int CartItemId { get; set; }
        public int? ProductoId { get; set; }
        public string? Nombre { get; set; }
        public decimal? Precio { get; set; }
        public string? ImagenUrl { get; set; }
        public DateTime? FechaAgregado { get; set; } = DateTime.Now;
    }
}
