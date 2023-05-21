using Actividad_18.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Actividad_18.Server.Contexto
{
    public class ContextoTienda : DbContext
    {
        public ContextoTienda(DbContextOptions<ContextoTienda>options ) : base(options) 
        {

        }
        public DbSet<Clientes> Clientes { get; set;}
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
    }
}
