using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaContatosMVC.Models;
using AgendaContatosMVC.Data;
using AgendaContatosMVC.Services;

namespace AgendaContatosMVC.Services
{
    public class EnderecoService
    {
        private readonly AgendaContatosMVCContext _context;

        public EnderecoService(AgendaContatosMVCContext context)
        {
            _context = context;
        }
        public List<Endereco> FindAll()
        {
            return _context.Endereco.OrderBy(x => x.ContactId).ToList();
        }

        public void Insert(Endereco obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Endereco FindById(int id)
        {
            return _context.Endereco.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Fone.Find(id);
            _context.Fone.Remove(obj);
            _context.SaveChanges();
        }
    }
}
