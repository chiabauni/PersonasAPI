using Microsoft.Build.Framework;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().Property(u => u.Categoria).HasComputedColumnSql("CASE\r\n\tWHEN FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) < 11 THEN 'Niños' \t\r\n\tWHEN FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) >=11 AND FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) < 18 THEN 'Adolescentes'\r\n\tWHEN FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25)>=18 AND FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) < 80 THEN 'Adultos'\r\n\tWHEN FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) >=80 THEN 'Octogenario'\r\nEND ");
            base.OnModelCreating(modelBuilder);
        }
    }
}
