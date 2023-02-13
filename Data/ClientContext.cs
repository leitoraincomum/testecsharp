using Microsoft.EntityFrameworkCore;
using testeMuralis.Model;

namespace testeMuralis.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes  { get; set; }
    }
}