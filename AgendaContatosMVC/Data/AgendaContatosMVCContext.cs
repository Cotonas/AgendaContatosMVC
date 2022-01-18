
using Microsoft.EntityFrameworkCore;
using AgendaContatosMVC.Models;

namespace AgendaContatosMVC.Data
{
    public class AgendaContatosMVCContext : DbContext
    {
        public AgendaContatosMVCContext (DbContextOptions<AgendaContatosMVCContext> options)
            : base(options)
        {
        }
        public DbSet<AgendaContatosMVC.Models.Contact> Contact { get; set; }
        public DbSet<AgendaContatosMVC.Models.Fone> Fone { get; set; }
        public DbSet<AgendaContatosMVC.Models.Endereco> Endereco { get; set; }

        
    }
}
