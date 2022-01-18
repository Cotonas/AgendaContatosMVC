using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaContatosMVC.Models;
using AgendaContatosMVC.Data;
using AgendaContatosMVC.Services;

namespace AgendaContatosMVC.Services
{
    public class FoneService
    {

        private readonly AgendaContatosMVCContext _context;

        public FoneService(AgendaContatosMVCContext context)
        {
            _context = context;
        }

        public List<Fone> FindAll()
        {
            return _context.Fone.OrderBy(x => x.ContactId).ToList();
        }

        public void Insert(Fone obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }

}
