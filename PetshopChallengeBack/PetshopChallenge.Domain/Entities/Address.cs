using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetshopChallenge.Domain.Entities
{
    public class Address
    {
        public Address()
        {
        }

        public Address(int addressid, string cep, string endereco, 
                        int complemento, string complemento2, 
                        string bairro, string cidade, int estado)
        {
            AddressId = addressid;
            CEP = cep;
            Endereco = endereco;
            Complemento = complemento;
            Complemento2 = complemento2;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        [Key]
        [Required]
        public int AddressId { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public int Complemento { get; set; }
        public string Complemento2 { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Estado { get; set; }

    }   
}
