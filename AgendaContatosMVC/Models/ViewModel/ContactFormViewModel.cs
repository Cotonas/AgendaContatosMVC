using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaContatosMVC.Models.ViewModel
{
    public class ContactFormViewModel
    {
        public Endereco Endereco { get; set; }
        public Fone Fone { get; set; }
        public ICollection<Contact> Contacts { get; set; }

    }
}
