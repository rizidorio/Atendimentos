using Dominio.Entidades;
using Infra.Config;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infra.Contexto
{
    public class SqlServerContexto : DbContext
    {
        public DbSet<Atendimento> Atendimento { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public SqlServerContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtendimentoConfig());
            modelBuilder.ApplyConfiguration(new ClienteConfig());
            modelBuilder.ApplyConfiguration(new EnderecoConfig());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfig());
            modelBuilder.ApplyConfiguration(new FuncionarioConfig());
            modelBuilder.ApplyConfiguration(new ServicoConfig());

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior.Equals(DeleteBehavior.Cascade))
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
