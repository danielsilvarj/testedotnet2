using ControleHoras.Dominio.Entidade;
using ControleHOrasDDD.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHorasDDD.Infraestrutura.Transversao.AutoMapper
{
    public interface IMapperProjeto
    {
        Projeto MapperToEntity(ProjetoDTO projetoDTO);
        IEnumerable<ProjetoDTO> MapperListUsuarios(IEnumerable<Projeto> projetos);
        ProjetoDTO MapperToDTO(Projeto projeto);
    }
}
