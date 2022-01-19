using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AgendaContatosMVC.Models;
using AgendaContatosMVC.Data;
using AgendaContatosMVC.Services;
using AgendaContatosMVC.Services.Exceptions;

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
            return _context.Fone.Include(obj => obj.Contact).FirstOrDefault(obj => obj.Id == id);
        }


        public void Remove(int id)
        {
            var obj = _context.Fone.Find(id);
            _context.Fone.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Fone obj)
        {
            if (!_context.Fone.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id não Encontrado");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }

}
