using AgendaContatosMVC.Data;
using AgendaContatosMVC.Models;
using System.Collections.Generic;
using System.Linq;


namespace AgendaContatosMVC.Services
{
    public class ContactService
    {
        private readonly AgendaContatosMVCContext _context;

        public ContactService(AgendaContatosMVCContext context)
        {
            _context = context;
        }

        public List<Contact> FindAll()
        {
            return _context.Contact.OrderBy(x => x.Name).ToList();
        }

        public Contact FindById(int id)
        {
            return _context.Contact.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove( int id)
        {
            var obj = _context.Contact.Find(id);
            _context.Contact.Remove(obj);
            _context.SaveChanges();
        }
    }
}
