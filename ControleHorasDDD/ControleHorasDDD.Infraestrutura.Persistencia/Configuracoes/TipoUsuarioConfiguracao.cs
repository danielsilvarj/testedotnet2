using ControleHoras.Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ControleHorasDDD.Infraestrutura.Persistencia.Configuracoes
{
    public class TipoUsuarioConfiguracao : IEntityTypeConfiguration<TipoUsuario>
    {

        public void Configure(EntityTypeBuilder<TipoUsuario> builder)
        {
            builder.HasKey(t => t.Id);
            builder.ToTable("TipoUsuario");
            builder.Property(t => t.DataCadastro)
                .IsRequired()
                .HasColumnType("Date")
                .HasDefaultValueSql("GetDate()");
            builder
                .Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}
