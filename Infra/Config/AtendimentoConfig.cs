using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Config
{
    public class AtendimentoConfig : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            builder.HasKey(a => a.Id);
            builder.HasOne(a => a.Cliente);
            builder.HasOne(a => a.Funcionario);
            builder.HasOne(a => a.Servico);
            builder.HasOne(a => a.FormaPagamento);
            builder.Property(a => a.ValorTotal).HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(a => a.Desconto).HasColumnType("decimal(5,2)").IsRequired();
            builder.Property(a => a.ValorComDesconto).HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(a => a.ValorPago).HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(a => a.Troco).HasColumnType("decimal(10,2)").IsRequired();
        }
    }
}
