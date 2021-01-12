using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHorasDDD.Infraestrutura.Persistencia.Repositorio
{
    public class HoraTrabalhadaRepositorio : BaseRepositorio<HoraTrabalhada>, IHorasTrabalhadaRepositorio
    {
        public readonly ControleHorasDbContext _contexto;

        public HoraTrabalhadaRepositorio(ControleHorasDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
