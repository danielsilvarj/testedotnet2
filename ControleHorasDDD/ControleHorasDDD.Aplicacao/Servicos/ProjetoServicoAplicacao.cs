using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Interfaces.Servicos;
using ControleHorasDDD.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHorasDDD.Aplicacao.Servicos
{
    public class ProjetoServicoAplicacao : BaseServicoAplicacao<Projeto>, IProjetoServicoAplicacao
    {
        public readonly IProjetoServicoDominio _projetoServicoDominio;

        public ProjetoServicoAplicacao(IProjetoServicoDominio projetoServicoDominio)
            : base(projetoServicoDominio)
        {
            _projetoServicoDominio = projetoServicoDominio;
        }
    }
}
