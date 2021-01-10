using ControleHoras.Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHorasDDD.Infraestrutura.Persistencia.Configuracoes
{
    public class ProjetoConfiguracao : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("Projetos");
            builder.Property(p => p.DataCadastro)
                .IsRequired()
                .HasColumnType("Date")
                .HasDefaultValueSql("GetDate()");

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.DataInicio)
                .HasColumnType("Date")
                .IsRequired();
            builder
                .Property(p => p.DataFim)
                .HasColumnType("Date");

        }
    }
}
