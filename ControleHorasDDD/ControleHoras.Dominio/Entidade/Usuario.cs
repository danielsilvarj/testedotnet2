using ControleHoras.Dominio.Enum;

namespace ControleHoras.Dominio.Entidade
{
    public class Usuario : BaseEntidade
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}