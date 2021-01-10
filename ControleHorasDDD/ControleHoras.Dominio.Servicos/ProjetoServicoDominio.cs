using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Interfaces.Repositorios;
using ControleHoras.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHoras.Dominio.Servicos
{
    public class ProjetoServicoDominio : BaseServicoDominio<Projeto>, IProjetoServicoDominio
    {

        public readonly IProjetoRepositorio _projetoRepositorio;

        public ProjetoServicoDominio(IProjetoRepositorio projetoRepositorio)
            :base(projetoRepositorio)
        {
            _projetoRepositorio = projetoRepositorio;
        }
    }
}
