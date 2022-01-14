using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
