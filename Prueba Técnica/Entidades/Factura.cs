using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Prueba_Técnica.Entidades
{
    public class Factura
    {
        public int FacturaId { get; set; }
        public string ClienteNombre { get; set; }
        public decimal BaseImponibleIVA0 { get; set; }
        public decimal BaseImponibleIVA12 { get; set; }
        public decimal IVA { get; set; }
        public decimal TotalPagar { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
    }

}
