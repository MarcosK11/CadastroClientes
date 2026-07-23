using System.ComponentModel.DataAnnotations;

namespace CadastroClientes.Application.DTOs;

public class CriarClienteDto
{
    [Required(ErrorMessage = "O nome completo é obrigatório.")]
    [StringLength(80, ErrorMessage = "O nome completo deve ter no máximo 80 caracteres.")]
    public required string NomeCompleto { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter exatamente 11 dígitos.")]
    public required string Cpf { get; set; }

    [Required(ErrorMessage = "O email é obrigatório.")]
    [EmailAddress(ErrorMessage = "O email informado não é válido.")]
    [StringLength(256, ErrorMessage = "O email deve ter no máximo 256 caracteres.")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "O telefone é obrigatório.")]
    [StringLength(11, MinimumLength = 10, ErrorMessage = "O telefone deve ter no minimo 10 caracteres e no maximo 11.")]
    public required string Telefone { get; set; }

    public DateOnly DataNascimento { get; set; }

    [Required(ErrorMessage = "O CEP é obrigatório.")]
    [StringLength(8, MinimumLength = 8, ErrorMessage = "O Cep deve ter exatamente 8 dígitos.")]
    public required string Cep { get; set; }

    [Required(ErrorMessage = "O logradouro é obrigatório.")]
    [StringLength(60, ErrorMessage = "O logradouro deve ter no máximo 60 caracteres")]
    public required string Logradouro { get; set; }

    [Required(ErrorMessage = "O numero é obrigatório.")]
    [StringLength(10, ErrorMessage = "O numero deve ter no máximo 10 caracteres")]
    public required string Numero { get; set; }

    [Required(ErrorMessage = "O bairro é obrigatório.")]
    [StringLength(60, ErrorMessage = "O bairro deve ter no máximo 60 caracteres")]
    public required string Bairro { get; set; }

    [Required(ErrorMessage = "A cidade é obrigatória.")]
    [StringLength(60, ErrorMessage = "A cidade deve ter no máximo 60 caracteres")]
    public required string Cidade { get; set; }

    [Required(ErrorMessage = "O estado é obrigatório.")]
    [StringLength(2, MinimumLength = 2, ErrorMessage = "O estado deve ter exatamente 2 dígitos.")]
    public required string Estado { get; set; }
}