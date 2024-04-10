using CrudRazor.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CrudRazor.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        // Poner aquí los modelos
        public DbSet<Producto> Producto {  get; set;  }
    }
}
