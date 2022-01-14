using System;

namespace AgendaContatosMVC.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rg { get; set; }
        public int Cpf { get; set; }
        public DateTime DataNascmento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
    }
}
