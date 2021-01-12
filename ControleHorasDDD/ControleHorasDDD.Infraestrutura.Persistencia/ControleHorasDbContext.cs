using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Enum;
using ControleHorasDDD.Infraestrutura.Persistencia.Configuracoes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ControleHorasDDD.Infraestrutura.Persistencia
{
    public class ControleHorasDbContext : DbContext
    {

        public ControleHorasDbContext()
        {

        }
        
        public ControleHorasDbContext(DbContextOptions<ControleHorasDbContext> options)
            :base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<UsuarioProjeto> UsuarioProjeto { get; set; }
        public DbSet<HoraTrabalhada> HorasTrabalhadas { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ControleHoras;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;DataBase=ControleHoras;Trusted_Connection=True");
        }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguracao());
            modelBuilder.ApplyConfiguration(new ProjetoConfiguracao());

            modelBuilder.Entity<UsuarioProjeto>().HasKey(u => new { u.IdUsuario, u.IdProjeto });

            modelBuilder.ApplyConfiguration(new TipoUsuarioConfiguracao());
            modelBuilder.ApplyConfiguration(new HoraTrabalhadaConfiguracao());


            modelBuilder.Entity<TipoUsuario>()
                .HasData(
                new TipoUsuario()
                {
                    Id = 1,
                    Nome = "Administrador",
                    Descricao = "Administrador do Sistema",
                    DataCadastro = DateTime.Now
                },
                new TipoUsuario()
                {
                    Id = 2,
                    Nome = "Desenvolvedor",
                    Descricao = "Usuário do Tipo Desenvolvedor",
                    DataCadastro = DateTime.Now
                },
                new TipoUsuario()
                {
                    Id = 3,
                    Nome = "Gerente",
                    Descricao = "Usuário do Tipo Gerente",
                    DataCadastro = DateTime.Now
                }

                );
        }


        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries()
                .Where(e => e.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if(entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            
            return base.SaveChanges();
        }
    
    
    
    }
}
