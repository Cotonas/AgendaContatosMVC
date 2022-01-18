using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaContatosMVC.Models
{
    public class Fone
    {
        public int Id { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public Contact Contact { get; set; }
        public int ContactId { get; set; }

        public Fone()
        {

        }

        public Fone(int id, string telefone, string celular, Contact contact, int contactId)
        {
            Id = id;
            Telefone = telefone;
            Celular = celular;
            Contact = contact;
            ContactId = contactId;
        }
    }
}
