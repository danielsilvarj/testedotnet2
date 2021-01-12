using ControleHoras.Dominio.Entidade;
using ControleHOrasDDD.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHorasDDD.Infraestrutura.Transversao.AutoMapper
{
    public class MapperHoraTrabalhada
    {
        List<HoraTrabalhadaDTO> horasTrabalhadasDTO = new List<HoraTrabalhadaDTO>();

        public IEnumerable<HoraTrabalhadaDTO> MapperListProjetos(IEnumerable<HoraTrabalhada> HorasTrabalhadas)
        {
            foreach (var h in HorasTrabalhadas)
            {
                HoraTrabalhadaDTO horaTrabalhadaDTO = new HoraTrabalhadaDTO
                {
                    Id = h.Id,
                    DataCadastro = h.DataCadastro,
                    DataInicio = h.DataInicio,
                    DataFim = h.DataFim,
                    Usuario = h.Usuario,
                    Projetos = h.Projetos
                };
                horasTrabalhadasDTO.Add(horaTrabalhadaDTO);

            }

            return horasTrabalhadasDTO;


        }

        public HoraTrabalhadaDTO MapperToDTO(HoraTrabalhada horaTrabalhada)
        {
            HoraTrabalhadaDTO horaTrabalhadaDTO = new HoraTrabalhadaDTO
            {
                Id = horaTrabalhada.Id,
                DataCadastro = horaTrabalhada.DataCadastro,
                DataInicio = horaTrabalhada.DataInicio,
                DataFim = horaTrabalhada.DataFim,
                Usuario = horaTrabalhada.Usuario,
                Projetos = horaTrabalhada.Projetos
            };

            return horaTrabalhadaDTO;
        }

        public HoraTrabalhada MapperToEntity(HoraTrabalhadaDTO horaTrabalhadaDTO)
        {
            HoraTrabalhada horaTrabalhada = new HoraTrabalhada
            {
                Id = horaTrabalhadaDTO.Id,
                DataCadastro = horaTrabalhadaDTO.DataCadastro,
                DataInicio = horaTrabalhadaDTO.DataInicio,
                DataFim = horaTrabalhadaDTO.DataFim,
                Usuario = horaTrabalhadaDTO.Usuario,
                Projetos = horaTrabalhadaDTO.Projetos
            };

            return horaTrabalhada;
        }
    }
}
