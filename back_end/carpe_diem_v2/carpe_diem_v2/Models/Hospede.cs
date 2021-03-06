using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carpe_diem_v2.Models
{
    [Table("Hospedes")]
    public class Hospede
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Selecionar uma opção!")]
        public Usuario TipoUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome Completo!")]
        public string NomeCompHospede { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o CPF!")]
        public int Cpf { get; set; }

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

        [Required(ErrorMessage = "Obrigatório Confirmar a Senha!")]
        public string ConfirmarSenha { get; set; }

        public ICollection<CadastroImovel> CadastroImovel { get; set; }
    }

    public enum Usuario
    {
        Hóspede,
        Anfitrião,
        Administrador        
    }
}
