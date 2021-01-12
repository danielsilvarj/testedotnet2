using ControleHoras.Dominio.Entidade;
using ControleHOrasDDD.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHorasDDD.Infraestrutura.Transversao.AutoMapper
{
    public interface IMapperHoraTrabalhada
    {
        HoraTrabalhada MapperToEntity(HoraTrabalhadaDTO horaTrabalhadaDTO);
        IEnumerable<HoraTrabalhadaDTO> MapperListUsuarios(IEnumerable<HoraTrabalhada> HorasTrabalhadas);
        HoraTrabalhadaDTO MapperToDTO(HoraTrabalhada horaTrabalhada);
    }
}
