using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Entidades
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? Nombre { get; set; }

        public string? imagen { get; set; }

        // Relación con Producto
        public List<Producto> Productos { get; set; }


    }
}
