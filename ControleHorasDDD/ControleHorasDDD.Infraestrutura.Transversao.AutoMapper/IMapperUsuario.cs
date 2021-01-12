using ControleHoras.Dominio.Entidade;
using ControleHOrasDDD.Aplicacao.DTO;
using System;
using System.Collections.Generic;

namespace ControleHorasDDD.Infraestrutura.Transversao.AutoMapper
{
    public interface IMapperUsuario
    {
        Usuario MapperToEntity(UsuarioDTO usuarioDTO);
        IEnumerable<UsuarioDTO> MapperListUsuarios(IEnumerable<Usuario> usuarios);
        UsuarioDTO MapperToDTO(Usuario usuario);
    }
}
