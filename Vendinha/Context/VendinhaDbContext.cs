using Microsoft.EntityFrameworkCore;
using Vendinha.Models;

namespace Vendinha.Context
{
    public class VendinhaDbContext : DbContext
    {
        private const string ConnectionString =
            "Server=localhost;Port=5432;Database=vendinha;User Id=postgres;Password=1234;"; //faço a conexão por connection string

        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<Divida> Dividas => Set<Divida>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entityCliente = modelBuilder.Entity<Cliente>();

            entityCliente.ToTable("clientes");
            entityCliente.Property(c => c.Id).HasColumnName("id");
            entityCliente.Property(c => c.Nome).HasColumnName("nome");
            entityCliente.Property(c => c.Cpf).HasColumnName("cpf");
            entityCliente.Property(c => c.DataNascimento).HasColumnName("datanascimento");
            entityCliente.Property(c => c.Email).HasColumnName("email");
            entityCliente.HasKey(c => c.Id);

            var entityDivida = modelBuilder.Entity<Divida>();

            entityDivida.ToTable("dividas");
            entityDivida.Property(d => d.Id).HasColumnName("id");
            entityDivida.Property(d => d.ClienteId).HasColumnName("clienteid");
            entityDivida.Property(d => d.Valor).HasColumnName("valor");
            entityDivida.Property(d => d.Paga).HasColumnName("paga");
            entityDivida.Property(d => d.DataCriacao).HasColumnName("datacriacao");
            entityDivida.Property(d => d.DataPagamento).HasColumnName("datapagamento");
            entityDivida.HasKey(d => d.Id);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString); //to passando como options o npgsql do postgres

            base.OnConfiguring(optionsBuilder);
        }
    }
}
