using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carpe_diem_v1.Models
{
    [Table("Hospedes")]
    public class Hospede
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome Completo!")]
        public string NomeCompHospede { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o CPF!")]
        public char Cpf { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Data de Nascimento!")]
        public int DataNascimento { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Endereço!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Telefone!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Email!")]
        public string EmailHospede { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Senha!")]
        public string Senha { get; set; }        
    }
}
