using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Interfaces.Repositorios;

namespace ControleHorasDDD.Infraestrutura.Persistencia.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public readonly ControleHorasDbContext _contexto;
        public UsuarioRepositorio(ControleHorasDbContext contexto)
            :base(contexto)
        {
            _contexto = contexto;
        }
    }
}
