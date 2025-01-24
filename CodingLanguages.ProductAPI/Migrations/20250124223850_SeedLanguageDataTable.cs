using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingLanguages.API.Migrations
{
    public partial class SeedLanguageDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "language",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image_url = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_language", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "language",
                columns: new[] { "id", "category", "description", "image_url", "name" },
                values: new object[,]
                {
                    { 1L, "CODING LANGUAGE", "A modern, object-oriented programming language widely used for building Windows applications, web services, and game development with Unity.", "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/csharp.png?raw=true", "C#" },
                    { 2L, "CODING LANGUAGE", "A versatile, high-level programming language known for its readability and wide application in data science, web development, and automation.", "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/python.png?raw=true", "Python" },
                    { 3L, "CODING LANGUAGE", "A dynamic, object-oriented language popular for web development, especially with the Ruby on Rails framework.", "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/ruby.png?raw=true", "Ruby" },
                    { 4L, "CODING LANGUAGE", "A server-side scripting language designed for building dynamic web pages and backend services.", "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/php.png?raw=true", "PHP" },
                    { 5L, "CODING LANGUAGE", "The standard markup language used for structuring and displaying content on the web.", "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/html.png?raw=true", "HTML" },
                    { 6L, "CODING LANGUAGE", "A style sheet language used to control the appearance and layout of web pages.", "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/css.png?raw=true", "CSS" },
                    { 7L, "CODING LANGUAGE", " A statically typed, compiled language by Google, built for performance and scalability in modern applications.", "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/go.png?raw=true", "Go" },
                    { 8L, "CODING LANGUAGE", "A modern, JVM-compatible language designed for Android development and cross-platform applications.", "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/kotlin.png?raw=true", "Kotlin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "language");
        }
    }
}
