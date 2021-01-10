using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Enum;


namespace ControleHoras.Dominio.Entidade
{
    public class TipoUsuario : BaseEntidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhGerente
        {
            get { return Id == (int)ETipoUsuario.Gerente; }
        }

        public bool EhDesenvolvedor
        {
            get { return Id == (int)ETipoUsuario.Desenvolvedor; }
        }
        public bool EhAdministrador
        {
            get { return Id == (int)ETipoUsuario.Administrador; }
        }

    }
}
