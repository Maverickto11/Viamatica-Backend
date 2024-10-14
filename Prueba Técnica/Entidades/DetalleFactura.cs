using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Prueba_Técnica.Entidades
{
    public class DetalleFactura
    {
        [Key]
        public int DetalleId { get; set; }
        public string? Descripcion { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? IVA { get; set; } // 0 o 12
        public decimal? Subtotal { get; set; }
        public int? FacturaId { get; set; }
    }

}
