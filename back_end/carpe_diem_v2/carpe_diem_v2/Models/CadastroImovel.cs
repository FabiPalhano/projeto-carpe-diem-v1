using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carpe_diem_v2.Models
{
    [Table("CadastroImovel")]
    public class CadastroImovel
    {
        [Key]
        public int Id { get; set; }

        [Display (Name = "Inserir Fotos")]
        [Required (ErrorMessage = "Obrigatório Inserir Fotos")]
        public string Fotos { get; set; }

        [Display(Name = "Endereço da sua acomodação")]
        [Required(ErrorMessage = "Obrigatório Informar o Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Tipo de Espaço")]
        [Required(ErrorMessage = "Obrigatório Informar o Tipo de Espaço")]
        public Espaco TipoEspaco { get; set; }

        [Display(Name = "Tipo de Acomodação")]
        [Required(ErrorMessage = "Obrigatório Informar o Tipo de Acomodação")]
        public Acomodacao TipoAcomodacao { get; set; }

        [Display(Name = "Quantidade de Hóspedes")]
        [Required(ErrorMessage = "Obrigatório Selecionar a Quantidade de Hóspedes")]
        public int QuantHospedes { get; set; }

        [Display(Name = "Quantidade de Camas")]
        [Required(ErrorMessage = "Obrigatório Selecionar o Tipo e a Quantidade de Camas")]
        public int QuantCamas { get; set; }

        [Display(Name = "Quantidade de Banheiros")]
        [Required(ErrorMessage = "Obrigatório Selecionar a Quantidade de Banheiros")]
        public int QuantBanheiros { get; set; }

        [Display(Name = "O que o espaço te a oferecer?")]
        [Required(ErrorMessage = "Obrigatório Selecionar as Opções Disponíveis")]
        public string OpOferecer { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar Horário do Check-In")]
        public DateTime HoraCheckin { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar Horário do Check-Out")]
        public DateTime HoraCheckout { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar Distância para a Praia")]
        public int DistPraia { get; set; }

        [Column (TypeName = "decimal(18,2)")]
        public decimal ValorDiaria { get; set; }

        public string InfAdicionais { get; set; }

        [Display(Name = "Disponibilizar Imóvel")]        
        public string DisponibilizarImovel { get; set; }

        [Display(Name = "Desativar Imóvel")]
        public string DesativarImovel { get; set; }

        public int HospedeId { get; set; }
        [ForeignKey("HospedeId")]
        public Hospede Hospede { get; set; }

    }

    public enum Acomodacao
    {
        [Display(Name ="Espaço Completo")]
        EspaçoCompleto,
        [Display(Name = "Quarto Inteiro")]
        QuartoInteiro,
        [Display(Name = "Quarto Compartilhado")]
        QuartoCompartilhado
    }

    public enum Espaco
    {
        Quarto,
        Flat,
        Apartamento,
        Casa,
        Loft
    }
}
