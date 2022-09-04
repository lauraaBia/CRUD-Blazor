using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Customer
    {
        public Customer()
        {
        }

        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigátorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Telefone é obrigátorio")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Telefone é obrigátorio")]
        public string Endereço { get; set; }

        [Required(ErrorMessage = "Email é obrigátorio")]
        [EmailAddress(ErrorMessage = "Digite um email válido.")]
        public string Email { get; set; }

        public void New()
        {
            Id = Guid.NewGuid();
        }

        public void Save(string name, string email, string telefone, string endereço)
        {
            Name = name;
            Email = email;
            Telefone = telefone;
            Endereço = endereço;            
        }
    }
}
