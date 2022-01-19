using System.ComponentModel.DataAnnotations;

namespace AgendaContatosMVC.Models
{
    public class Endereco
    {
        [Display(Name = "Nº Identificação")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo {0} deve ser preenchido.")]
        [Display(Name = "Endereço")]
        public string Enderecos { get; set; }

        [Display(Name = "Cliente")]
        public Contact Contact { get; set; }

        [Required(ErrorMessage = "Campo {0} deve ser preenchido correspondendo ao cliente que deseja cadastrar o endereço.")]
        [Display(Name = "Id do cliente")]
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
