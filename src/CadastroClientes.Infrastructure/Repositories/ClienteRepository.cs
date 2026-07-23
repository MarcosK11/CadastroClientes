using CadastroClientes.Domain.Entities;
using CadastroClientes.Domain.Interfaces;
using CadastroClientes.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CadastroClientes.Infrastructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly AppDbContext _context;

    public ClienteRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Cliente?> ObterClientePorIdAsync(Guid id)
    {
        return await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<Cliente?> ObterClientePorCpfAsync(string cpf)
    {
        return await _context.Clientes.FirstOrDefaultAsync(c => c.Cpf == cpf);
    }

    public async Task<IEnumerable<Cliente>> ObterClientesPorNomeAsync(string nome)
    {
        return await _context.Clientes.Where(c => c.NomeCompleto.Contains(nome)).ToListAsync();
    }

    public async Task<IEnumerable<Cliente>> ObterClientesAsync(int pagina, int tamanhoPagina)
    {
        return await _context.Clientes.OrderBy(c => c.NomeCompleto).Skip((pagina - 1) * tamanhoPagina).Take(tamanhoPagina).ToListAsync();
    }

    public async Task AdicionarClienteAsync(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();
    }
    public async Task AtualizarClienteAsync(Cliente cliente)
    {
        _context.Clientes.Update(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task RemoverClienteAsync(Guid id)
    {
        Cliente? clienteEncontrado = await ObterClientePorIdAsync(id);

        if (clienteEncontrado != null)
        {
            _context.Clientes.Remove(clienteEncontrado);
            await _context.SaveChangesAsync();
        }
        throw new KeyNotFoundException("Cliente não encontrado.");
    }
}