using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Interfaces.Repositorios;
using ControleHoras.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleHoras.Dominio.Servicos
{
    public class UsuarioServicoDominio : BaseServicoDominio<Usuario>, IUsuarioServicoDominio
    {
        public IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioServicoDominio(IUsuarioRepositorio usuarioRepositorio)
            :base(usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
    }
}
