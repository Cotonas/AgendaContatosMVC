using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaContatosMVC.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Enderecos { get; set; }
        public Contact Contact { get; set; }
        public int ContactId { get; set; }

        public Endereco()
        {

        }

        public Endereco(int id, string enderecos, Contact contact, int contactId)
        {
            Id = id;
            Enderecos = enderecos;
            Contact = contact;
            ContactId = contactId;
        }
    }
}
