using System.ComponentModel.DataAnnotations;


namespace AgendaContatosMVC.Models
{
    public class Fone
    {
        [Display(Name = "Nº Identificação")]
        public int Id { get; set; }
        
        
        [Display(Name = "Telefone Residencial")]
        [StringLength(10)]
        public string Telefone { get; set; }
        
        [Required(ErrorMessage = "Campo {0} deve ser preenchido.")]
        [StringLength(11, ErrorMessage = "Campo {0} deve ser preenchido com 11 espaços.")]
        public string Celular { get; set; }

        [Display(Name = "Cliente")]
        public Contact Contact { get; set; }

        [Required(ErrorMessage = "Campo {0} deve ser preenchido correspondendo ao cliente que deseja cadastrar o contato.")]
        [Display(Name = "Id Cliente")]
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
