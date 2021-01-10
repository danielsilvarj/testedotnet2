using System.Collections.Generic;

namespace ControleHoras.Dominio.Entidade
{
    public class Usuario : BaseEntidade
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool EhAdministrador { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public ICollection<UsuarioProjeto> UsuarioProjeto{ get; set; }
    }
}