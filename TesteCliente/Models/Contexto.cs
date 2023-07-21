using Microsoft.EntityFrameworkCore;


namespace TesteCliente.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }


        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
