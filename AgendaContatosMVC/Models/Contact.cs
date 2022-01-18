using System;
using System.Collections.Generic;

namespace AgendaContatosMVC.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascmento { get; set; }
        public ICollection<Fone> Fones { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }

        public Contact()
        {

        }

        public Contact(int id, string name, string rg, string cpf, DateTime dataNascmento)
        {
            Id = id;
            Name = name;
            Rg = rg;
            Cpf = cpf;
            DataNascmento = dataNascmento;
        }

        public void AddFone(Fone f)
        {
            Fones.Add(f);
        }

        public void RemoveFone(Fone f)
        {
            Fones.Remove(f);
        }

        public void AddEndereco(Endereco end)
        {
            Enderecos.Add(end);
        }
        public void RemoveEndereco(Endereco end)
        {
            Enderecos.Remove(end);
        }
    }
}
