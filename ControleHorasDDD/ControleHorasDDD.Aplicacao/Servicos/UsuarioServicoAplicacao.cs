using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Interfaces.Servicos;
using ControleHorasDDD.Aplicacao.Interfaces;


namespace ControleHorasDDD.Aplicacao.Servicos
{
    public class UsuarioServicoAplicacao : BaseServicoAplicacao<Usuario>, IUsuarioServicoAplicacao
    {
        public readonly IUsuarioServicoDominio _usuarioServicoDominio;

        public UsuarioServicoAplicacao(IUsuarioServicoDominio usuarioServicoDominio) 
            : base(usuarioServicoDominio)
        {
            _usuarioServicoDominio = usuarioServicoDominio;
        }
    }
}
