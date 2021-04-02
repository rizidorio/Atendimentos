using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infra.Config
{
    public class ServicoConfig : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasMany(s => s.Funcionarios).WithMany(f => f.Servicos);

            builder.Property(s => s.Codigo).HasMaxLength(10).IsRequired();
            builder.Property(s => s.Nome).HasMaxLength(50).IsRequired();
            builder.Property(s => s.Descricao).HasMaxLength(255);
            builder.Property(s => s.Valor).HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(s => s.Alteracao).HasDefaultValue(new DateTime(1900, 01, 01)).IsRequired();
            builder.Property(s => s.Ativo).HasDefaultValue(true).IsRequired();
            builder.Property(s => s.Apagado).HasDefaultValue(false).IsRequired();
        }
    }
}
