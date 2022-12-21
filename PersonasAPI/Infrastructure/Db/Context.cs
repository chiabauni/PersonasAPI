using Microsoft.EntityFrameworkCore;
using PersonasAPI.Model;

namespace PersonasAPI.Infrastructure.Db
{
    public class Context: DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        
        public Context(DbContextOptions<Context> options)
        : base(options)
        {

        }
    }
}
