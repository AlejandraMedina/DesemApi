
using Dominio.EntidadesNegocio;
using Domino.EntidadesNegocio;
using Microsoft.EntityFrameworkCore;


namespace DesemApi
{
    public class DesemContext : DbContext
    {
        public DbSet<Programa> Programas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DesemContext(DbContextOptions<DesemContext> options) : base(options)
        {

        }




    }
}
