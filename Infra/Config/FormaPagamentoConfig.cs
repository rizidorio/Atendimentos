using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Config
{
    public class FormaPagamentoConfig : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(s => s.Codigo).HasMaxLength(10).IsRequired();
            builder.Property(f => f.Nome).HasMaxLength(50).IsRequired();
            builder.Property(f => f.Ativo).HasDefaultValue(true).IsRequired();
            builder.Property(f => f.Apagado).HasDefaultValue(false).IsRequired();
        }
    }
}
