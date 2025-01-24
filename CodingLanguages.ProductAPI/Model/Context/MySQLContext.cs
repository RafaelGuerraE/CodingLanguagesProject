using CodingLanguages.API.Model;
using Microsoft.EntityFrameworkCore;

namespace CodingLanguages.API.Model.Context
{
    public class MySQLContext: DbContext
    {
        public MySQLContext(){ }
        public MySQLContext(DbContextOptions<MySQLContext> options): base(options) { }
        public DbSet<Language> Languages { get; set; }
    }
}
