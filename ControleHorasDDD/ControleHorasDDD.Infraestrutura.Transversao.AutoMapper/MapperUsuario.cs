using ControleHoras.Dominio.Entidade;
using ControleHOrasDDD.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHorasDDD.Infraestrutura.Transversao.AutoMapper
{



    public class MapperUsuario : IMapperUsuario
    {
        List<UsuarioDTO> usuariosDTO = new List<UsuarioDTO>();

        public IEnumerable<UsuarioDTO> MapperListUsuarios(IEnumerable<Usuario> usuarios)
        {
            foreach(var u in usuarios)
            {
                UsuarioDTO usuarioDTO = new UsuarioDTO
                {
                    Id = u.Id,
                    Nome = u.Nome,
                    CPF = u.CPF,
                    TipoUsuario = u.TipoUsuario,
                    DataCadastro = u.DataCadastro
                };
                usuariosDTO.Add(usuarioDTO);

            }

            return usuariosDTO;

            
        }

        public UsuarioDTO MapperToDTO(Usuario usuario)
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                CPF = usuario.CPF,
                TipoUsuario = usuario.TipoUsuario,
                DataCadastro = usuario.DataCadastro
            };

            return usuarioDTO;
        }

        public Usuario MapperToEntity(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = new Usuario
            {
                Id = usuarioDTO.Id,
                Nome = usuarioDTO.Nome,
                CPF = usuarioDTO.CPF,
                TipoUsuario = usuarioDTO.TipoUsuario,
                DataCadastro = usuarioDTO.DataCadastro
            };

            return usuario;
        }
    }
}
