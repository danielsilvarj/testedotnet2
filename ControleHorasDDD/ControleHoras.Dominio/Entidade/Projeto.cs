using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHoras.Dominio.Entidade
{
    public class Projeto : BaseEntidade
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public ICollection<UsuarioProjeto> UsuarioProjeto { get; set; }

        public bool EmAndamento()
        {
            return DateTime.Now >= DataInicio && DateTime.Now <= DataFim;
        }


    }
}
