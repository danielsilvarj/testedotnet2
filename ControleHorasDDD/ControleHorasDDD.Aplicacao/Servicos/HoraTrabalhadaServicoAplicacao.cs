using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Interfaces.Servicos;
using ControleHorasDDD.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHorasDDD.Aplicacao.Servicos
{
    public class HoraTrabalhadaServicoAplicacao : BaseServicoAplicacao<HoraTrabalhada>, IHoraTrabalhadaServicoAplicacao
    {
        public readonly IHoraTrabalhadaServicoDominio _horaTrabalhadaServicoDominio;

        public HoraTrabalhadaServicoAplicacao(IHoraTrabalhadaServicoDominio horaTrabalhadaServicoDominio)
            : base(horaTrabalhadaServicoDominio)
        {
            _horaTrabalhadaServicoDominio = horaTrabalhadaServicoDominio;
        }
    }
}
