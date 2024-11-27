using System.ComponentModel.DataAnnotations;

namespace fornecedores.Models.MaisFornec;

public class Fornecedor
{
    [Key]
    public long Id { get; set; }

    [Required]
    [Display(Name = "Razão Social")]
    public string RazaoSocial { get; set; }

    [Required]
    [Display(Name = "Nome")]
    public string NomeFantasia { get; set; }

    [Required]
    [Display(Name = "E-mail")]
    public string Email{ get; set; }

    [Required]
    public string Telefone { get; set; }

    [Required]
    public string Logradouro { get; set; }

    [Required]
    public string Bairro { get; set; }

    [Required]
    public string CEP { get; set; }

    [Required]
    public string Cidade { get; set; }

    [Required]
    [Display(Name = "Numero da casa")]
    public int Numero { get; set; }

    [Required]
    [Display(Name = "Nome Responsável")]
    public string Nome { get; set; }
}
