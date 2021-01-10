using ControleHoras.Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHorasDDD.Infraestrutura.Persistencia.Configuracoes
{
    public class HoraTrabalhadaConfiguracao : IEntityTypeConfiguration<HoraTrabalhada>
    {
        public void Configure(EntityTypeBuilder<HoraTrabalhada> builder)
        {
            builder.HasKey(h => h.Id);
            builder.ToTable("HoraTrabalhada");
            builder.Property(h => h.DataCadastro)
                .IsRequired()
                .HasColumnType("Date")
                .HasDefaultValueSql("GetDate()");

            builder
                .Property(h => h.DataInicio)
                .HasColumnType("Date")
                .IsRequired();
            builder
                .Property(h => h.DataFim)
                .HasColumnType("Date");
        }
    }
}
