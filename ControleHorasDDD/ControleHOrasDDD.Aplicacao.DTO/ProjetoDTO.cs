using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHOrasDDD.Aplicacao.DTO
{
    public class ProjetoDTO
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
