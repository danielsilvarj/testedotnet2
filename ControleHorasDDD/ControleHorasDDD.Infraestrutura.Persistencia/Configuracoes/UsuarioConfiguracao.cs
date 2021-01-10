using ControleHoras.Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHorasDDD.Infraestrutura.Persistencia.Configuracoes
{
    public class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder.ToTable("Usuarios");
            builder.Property(u => u.DataCadastro)
                .IsRequired()
                .HasColumnType("Date")
                .HasDefaultValueSql("GetDate()");

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}
