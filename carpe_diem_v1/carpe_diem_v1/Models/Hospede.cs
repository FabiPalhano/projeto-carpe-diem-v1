using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carpe_diem_v1.Models
{
    [Table("Hospedes")]
    public class Hospede
    {
        
        public int Id { get; set; }

        [Key]
        public char Cpf { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Telefone!")]
        public char Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Email!")]
        public char EmailHospede { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Senha!")]
        public char Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Endereço!")]
        public char Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome Completo!")]
        public char NomeCompHospede { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Data de Nascimento!")]
        public int DataNascimento { get; set; }
    }
}
