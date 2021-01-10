using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHoras.Dominio.Entidade
{
    public class UsuarioProjeto : BaseEntidade
    {
        public int IdUsuario { get; set; }
        public int IdProjeto { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Projeto> Projetos { get; set; }

    }
}
