using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Interfaces.Repositorios;
using ControleHoras.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHoras.Dominio.Servicos
{
    public class HoraTrabalhadaServicoDominio : BaseServicoDominio<HoraTrabalhada>, IHoraTrabalhadaServicoDominio
    {
        public readonly IHorasTrabalhadaRepositorio _horasTrabalhadaRepositorio;

        public HoraTrabalhadaServicoDominio(IHorasTrabalhadaRepositorio horasTrabalhadaRepositorio)
            : base(horasTrabalhadaRepositorio)
        {
            _horasTrabalhadaRepositorio = horasTrabalhadaRepositorio;
        }
    }
}
