using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Domain.Interfaces;

public interface IClienteRepository
{
    Task<IEnumerable<Cliente>> ObterClientesAsync(int pagina, int tamanhoPagina);
    Task<Cliente?> ObterClientePorIdAsync(Guid id);
    Task<Cliente?> ObterClientePorCpfAsync(string cpf);
    Task<IEnumerable<Cliente>> ObterClientesPorNomeAsync(string nome);
    Task AdicionarClienteAsync(Cliente cliente);
    Task AtualizarClienteAsync(Cliente cliente);
    Task RemoverClienteAsync(Guid id);
}