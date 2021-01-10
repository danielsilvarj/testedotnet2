using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Enum;
using System;
using System.Collections.Generic;

namespace ControleHOrasDDD.Aplicacao.DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public ICollection<Projeto> Projetos { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
