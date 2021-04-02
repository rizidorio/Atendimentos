using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Config
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.Cep).IsUnique();

            builder.Property(e => e.Cep).HasMaxLength(15).IsRequired();
            builder.Property(e => e.Logradouro).HasMaxLength(80).IsRequired();
            builder.Property(e => e.Bairro).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Localidade).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Uf).HasMaxLength(2).IsRequired();
        }
    }
}
