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

        public Fone FindById(int id)
        {
            return _context.Fone.FirstOrDefault(obj => obj.Id == id);
        }


        public void Remove(int id)
        {
            var obj = _context.Fone.Find(id);
            _context.Fone.Remove(obj);
            _context.SaveChanges();
        }
    }

}
