using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgendaContatosMVC.Models
{
    public class Contact
    {
        [Display(Name = "Nº Identificação")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} deve ser preenchido.")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "RG")]
        [StringLength(7)]
        public string Rg { get; set; }
        [Required(ErrorMessage = "Campo {0} deve ser preenchido.")]
        [Display(Name = "CPF")]
        [StringLength(12, MinimumLength = 11, ErrorMessage ="{0} deve ser preenchido com minimo {2} e máximo {1}")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Campo {0} deve ser preenchido.")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
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
