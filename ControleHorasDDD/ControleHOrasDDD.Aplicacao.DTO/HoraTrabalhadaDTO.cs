using ControleHoras.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHOrasDDD.Aplicacao.DTO
{
    public class HoraTrabalhadaDTO
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Usuario Usuario { get; set; }
        public Projeto Projetos { get; set; }
    }
}
