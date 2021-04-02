using Dominio.Entidades;
using Dominio.Enumerators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infra.Config
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.Endereco);

            builder.HasIndex(c => c.Cpf).IsUnique();
            builder.HasIndex(c => c.Email).IsUnique();

            builder.Property(s => s.Codigo).HasMaxLength(10).IsRequired();
            builder.Property(c => c.Nome).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Cpf).HasMaxLength(15).IsRequired();
            builder.Property(c => c.Rg).HasMaxLength(15).IsRequired();
            builder.Property(c => c.Sexo).HasMaxLength(1).HasDefaultValue((int)Sexo.NaoInformado).IsRequired();
            builder.Property(c => c.EstadoCivil).HasMaxLength(1).HasDefaultValue((int)EstadoCivil.NaoInformado).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Telefone1).HasMaxLength(20).IsRequired();
            builder.Property(c => c.TipoTelefone1).HasMaxLength(1).HasDefaultValue((int)TipoTelefone.NaoInformado).IsRequired();
            builder.Property(c => c.Telefone2).HasMaxLength(20).IsRequired();
            builder.Property(c => c.TipoTelefone2).HasMaxLength(1).HasDefaultValue((int)TipoTelefone.NaoInformado).IsRequired();
            builder.Property(c => c.Nascimento).HasDefaultValue(new DateTime(1900, 01, 01)).IsRequired();
            builder.Property(c => c.Alteracao).HasDefaultValue(new DateTime(1900, 01, 01)).IsRequired();
            builder.Property(c => c.UltimoAtendimento).HasDefaultValue(new DateTime(1900, 01, 01)).IsRequired();
            builder.Property(c => c.Apagado).HasDefaultValue(false).IsRequired();
        }
    }
}
