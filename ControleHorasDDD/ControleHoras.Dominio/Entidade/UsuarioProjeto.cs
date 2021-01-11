using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHoras.Dominio.Entidade
{
    public class UsuarioProjeto
    {
        //public int IdUsuarioProjeto { get; set; }
        public int IdUsuario { get; set; }
        public int IdProjeto { get; set; }

        public virtual Usuario Usuarios { get; set; }
        public virtual Projeto Projetos { get; set; }

    }
}
