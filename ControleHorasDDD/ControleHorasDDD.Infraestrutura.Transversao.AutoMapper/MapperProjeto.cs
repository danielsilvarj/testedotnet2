using ControleHoras.Dominio.Entidade;
using ControleHOrasDDD.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHorasDDD.Infraestrutura.Transversao.AutoMapper
{
    public class MapperProjeto
    {
        List<ProjetoDTO> projetosDTO = new List<ProjetoDTO>();

        public IEnumerable<ProjetoDTO> MapperListProjetos(IEnumerable<Projeto> projetos)
        {
            foreach (var p in projetos)
            {
                ProjetoDTO projetoDTO = new ProjetoDTO
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    DataCadastro = p.DataCadastro,
                    DataInicio = p.DataInicio,
                    DataFim = p.DataFim
                };
                projetosDTO.Add(projetoDTO);

            }

            return projetosDTO;


        }

        public ProjetoDTO MapperToDTO(Projeto projeto)
        {
            ProjetoDTO projetoDTO = new ProjetoDTO
            {
                Id = projeto.Id,
                Nome = projeto.Nome,
                DataCadastro = projeto.DataCadastro,
                DataInicio = projeto.DataInicio,
                DataFim = projeto.DataFim
            };

            return projetoDTO;
        }

        public Projeto MapperToEntity(ProjetoDTO projetoDTO)
        {
            Projeto projeto = new Projeto
            {
                Id = projetoDTO.Id,
                Nome = projetoDTO.Nome,
                DataCadastro = projetoDTO.DataCadastro,
                DataInicio = projetoDTO.DataInicio,
                DataFim = projetoDTO.DataFim
            };

            return projeto;
        }
    }
}
