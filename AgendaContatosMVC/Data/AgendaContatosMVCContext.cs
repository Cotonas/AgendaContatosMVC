
using Microsoft.EntityFrameworkCore;

namespace AgendaContatosMVC.Data
{
    public class AgendaContatosMVCContext : DbContext
    {
        public AgendaContatosMVCContext (DbContextOptions<AgendaContatosMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Contact> Contact { get; set; }
    }
}
