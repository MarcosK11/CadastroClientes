using Microsoft.EntityFrameworkCore;
using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(c => c.Cpf).HasMaxLength(11);
            entity.Property(c => c.Email).HasMaxLength(256);
            entity.Property(c => c.Telefone).HasMaxLength(11);
            entity.Property(c => c.Cep).HasMaxLength(8);
            entity.Property(c => c.Estado).HasMaxLength(2);
            entity.Property(c => c.Logradouro).HasMaxLength(60);
            entity.Property(c => c.Numero).HasMaxLength(10);
            entity.Property(c => c.Bairro).HasMaxLength(60);
            entity.Property(c => c.Cidade).HasMaxLength(60);
            entity.Property(c => c.NomeCompleto).HasMaxLength(80);
            entity.HasIndex(c => c.Cpf).IsUnique();
            entity.HasIndex(c => c.Email).IsUnique();
        });
    }
}