namespace CadastroClientes.Domain.Entities;

public class Cliente
{
    public Guid Id { get; private set; }
    public string NomeCompleto { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public DateOnly DataNascimento { get; set; }
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public DateTime DataCadastro { get; private set; }

    public Cliente(string nomeCompleto, string cpf, string email, string telefone, DateOnly dataNascimento, string cep, string logradouro, string numero, string bairro, string cidade, string estado)
    {
        NomeCompleto = nomeCompleto;
        Cpf = cpf;
        Email = email;
        Telefone = telefone;
        DataNascimento = dataNascimento;
        Cep = cep;
        Logradouro = logradouro;
        Numero = numero;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
        Id = Guid.NewGuid();
        DataCadastro = DateTime.Now;
    }
    public bool EhMaiorDeIdade()
    {
        DateOnly dataAtual = DateOnly.FromDateTime(DateTime.Now);
        DateOnly  aniversarioEsteAno = new DateOnly(dataAtual.Year, DataNascimento.Month, DataNascimento.Day);

        int idade = dataAtual.Year - DataNascimento.Year;

        if (dataAtual < aniversarioEsteAno )
        {
            idade--;
        }
        if (idade >= 18)
        {
            return true;
        }
        return false;
    }
}