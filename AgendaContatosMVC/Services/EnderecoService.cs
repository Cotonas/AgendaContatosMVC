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
            return _context.Endereco.Include(obj => obj.Contact).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Endereco.Find(id);
            _context.Endereco.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Endereco obj)
        {
            if (!_context.Endereco.Any(x => x.Id == obj.Id))
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
