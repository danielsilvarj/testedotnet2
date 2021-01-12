using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHorasDDD.Infraestrutura.Persistencia.Repositorio
{
    public class ProjetoRepositorio : BaseRepositorio<Projeto>, IProjetoRepositorio
    {
        public readonly ControleHorasDbContext _contexto;

        public ProjetoRepositorio(ControleHorasDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
