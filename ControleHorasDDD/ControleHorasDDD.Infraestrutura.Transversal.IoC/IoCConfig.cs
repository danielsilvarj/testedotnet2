using Autofac;
using ControleHoras.Dominio.Interfaces.Repositorios;
using ControleHoras.Dominio.Interfaces.Servicos;
using ControleHoras.Dominio.Servicos;
using ControleHorasDDD.Aplicacao.Interfaces;
using ControleHorasDDD.Aplicacao.Servicos;
using ControleHorasDDD.Infraestrutura.Persistencia.Repositorio;

namespace ControleHorasDDD.Infraestrutura.Transversal.IoC
{
    public class IoCConfig
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProjetoServicoAplicacao>().As<IProjetoServicoAplicacao>();
            builder.RegisterType<UsuarioServicoAplicacao>().As<IUsuarioServicoAplicacao>();
            builder.RegisterType<HoraTrabalhadaServicoAplicacao>().As<IHoraTrabalhadaServicoAplicacao>();


            builder.RegisterType<ProjetoServicoDominio>().As<IProjetoServicoDominio>();
            builder.RegisterType<UsuarioServicoDominio>().As<IUsuarioServicoDominio>();
            builder.RegisterType<HoraTrabalhadaServicoDominio>().As<IHoraTrabalhadaServicoDominio>();


            builder.RegisterType<ProjetoRepositorio>().As<IProjetoRepositorio>();
            builder.RegisterType<UsuarioRepositorio>().As<IUsuarioRepositorio>();
            builder.RegisterType<HoraTrabalhadaRepositorio>().As<IHorasTrabalhadaRepositorio>();

        }
    }
}
