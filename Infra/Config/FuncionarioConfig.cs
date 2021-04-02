using Dominio.Entidades;
using Dominio.Enumerators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infra.Config
{
    public class FuncionarioConfig : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(f => f.Id);
            builder.HasOne(f => f.Endereco);
            builder.HasMany(f => f.Servicos).WithMany(s => s.Funcionarios);

            builder.HasIndex(f => f.Cpf).IsUnique();
            builder.HasIndex(f => f.Email).IsUnique();

            builder.Property(s => s.Codigo).HasMaxLength(10).IsRequired();
            builder.Property(f => f.Nome).HasMaxLength(100).IsRequired();
            builder.Property(f => f.Cpf).HasMaxLength(15).IsRequired();
            builder.Property(f => f.Rg).HasMaxLength(15).IsRequired();
            builder.Property(f => f.Sexo).HasMaxLength(1).HasDefaultValue((int)Sexo.NaoInformado).IsRequired();
            builder.Property(f => f.EstadoCivil).HasMaxLength(1).HasDefaultValue((int)EstadoCivil.NaoInformado).IsRequired();
            builder.Property(f => f.Email).HasMaxLength(100).IsRequired();
            builder.Property(f => f.Telefone1).HasMaxLength(20).IsRequired();
            builder.Property(f => f.TipoTelefone1).HasMaxLength(1).HasDefaultValue((int)TipoTelefone.NaoInformado).IsRequired();
            builder.Property(f => f.Telefone2).HasMaxLength(20).IsRequired();
            builder.Property(f => f.TipoTelefone2).HasMaxLength(1).HasDefaultValue((int)TipoTelefone.NaoInformado).IsRequired();
            builder.Property(f => f.Funcao).HasMaxLength(30).IsRequired();
            builder.Property(f => f.Nascimento).HasDefaultValue(new DateTime(1900, 01, 01)).IsRequired();
            builder.Property(f => f.Alteracao).HasDefaultValue(new DateTime(1900, 01, 01)).IsRequired();
            builder.Property(f => f.Ativo).HasDefaultValue(true).IsRequired();
            builder.Property(f => f.Apagado).HasDefaultValue(false).IsRequired();
        }
    }
}
