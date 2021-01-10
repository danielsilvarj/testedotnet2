using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHoras.Dominio.Entidade
{
    public class HoraTrabalhada : BaseEntidade
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Usuario Usuario { get; set; }
        public Projeto Projetos { get; set; }


    }
}
