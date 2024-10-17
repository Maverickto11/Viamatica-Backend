using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_Técnica.Migrations
{
    /// <inheritdoc />
    public partial class bd1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
        table: "Categorias",
        columns: new[] { "CategoriaId", "Nombre", "imagen" },
        values: new object[,]
        {
            { 1, "Electrodomésticos", "https://assets.energoconsulting.com/site/blog/este-es-el-consumo-de-los-electrodomesticos-mas-comunes.webp" },
            { 2, "Ropa", "https://i.ebayimg.com/thumbs/images/g/61gAAOSwkLNezrbK/s-l640.jpg" },
            { 3, "Alimentos", "https://holausana.com/wp-content/uploads/2024/03/Los-5-Alimentos-mas-Nutritivos.jpg" },
            { 4, "Muebles", "https://imcesa.com.pe/wp-content/uploads/2023/09/muebles-en-lima-de-sala-1-scaled.webp" },
            { 5, "Juguetes", "https://lingokids.com/wp-content/uploads/2020/04/shutterstock_329683400.jpg" },
            { 6, "Libros", "https://climatica.coop/wp-content/uploads/2024/01/1280px-Books_HD_8314929977-900x600.jpg?w=390&q=90" },
            { 7, "Deportes", "https://blog.saludsa.com/hs-fs/hubfs/Imagenes%20Blog/shutterstock_1026630514%20(1).jpg?width=770&height=424&name=shutterstock_1026630514%20(1).jpg" },
            { 8, "Hogar", "https://cdn.prod.website-files.com/6643a82fc46ca462b5ef9921/6643a82fc46ca462b5efa47c_649da5102ac93810b22611b2_27-10-articulos-de-adulto-independiente-que-no-pueden-faltar-en-tu-hogar.webp" }
        });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
       table: "Categorias",
       keyColumn: "CategoriaId",
       keyValues: new object[] { 1, 2, 3, 4, 5, 6, 7, 8 });
        }
    }
}
