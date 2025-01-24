using CodingLanguages.API.Model;
using Microsoft.EntityFrameworkCore;

namespace CodingLanguages.API.Model.Context
{
    public class MySQLContext: DbContext
    {
        public MySQLContext(){ }
        public MySQLContext(DbContextOptions<MySQLContext> options): base(options) { }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(new Language
            {
                Id = 1,
                Name = "C#",
                Description = "A modern, object-oriented programming language widely used for building Windows applications, web services, and game development with Unity.",
                Category = "CODING LANGUAGE",
                ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/csharp.png?raw=true"
            });

            modelBuilder.Entity<Language>().HasData(new Language
            {
                Id = 2,
                Name = "Python",
                Description = "A versatile, high-level programming language known for its readability and wide application in data science, web development, and automation.",
                Category = "CODING LANGUAGE",
                ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/python.png?raw=true"
            });

            modelBuilder.Entity<Language>().HasData(new Language
            {
                Id = 3,
                Name = "Ruby",
                Description = "A dynamic, object-oriented language popular for web development, especially with the Ruby on Rails framework.",
                Category = "CODING LANGUAGE",
                ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/ruby.png?raw=true"
            });

            modelBuilder.Entity<Language>().HasData(new Language
            {
                Id = 4,
                Name = "PHP",
                Description = "A server-side scripting language designed for building dynamic web pages and backend services.",
                Category = "CODING LANGUAGE",
                ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/php.png?raw=true"
            });

            modelBuilder.Entity<Language>().HasData(new Language
            {
                Id = 5,
                Name = "HTML",
                Description = "The standard markup language used for structuring and displaying content on the web.",
                Category = "CODING LANGUAGE",
                ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/html.png?raw=true"
            });

            modelBuilder.Entity<Language>().HasData(new Language
            {
                Id = 6,
                Name = "CSS",
                Description = "A style sheet language used to control the appearance and layout of web pages.",
                Category = "CODING LANGUAGE",
                ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/css.png?raw=true"
            });

            modelBuilder.Entity<Language>().HasData(new Language
            {
                Id = 7,
                Name = "Go",
                Description = " A statically typed, compiled language by Google, built for performance and scalability in modern applications.",
                Category = "CODING LANGUAGE",
                ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/go.png?raw=true"
            });

            modelBuilder.Entity<Language>().HasData(new Language
            {
                Id = 8,
                Name = "Kotlin",
                Description = "A modern, JVM-compatible language designed for Android development and cross-platform applications.",
                Category = "CODING LANGUAGE",
                ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/kotlin.png?raw=true"
            });

        }
    }
}
