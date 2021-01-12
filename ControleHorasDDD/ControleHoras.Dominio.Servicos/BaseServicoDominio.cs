﻿using ControleHoras.Dominio.Interfaces.Repositorios;
using ControleHoras.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace ControleHoras.Dominio.Servicos
{
    public class BaseServicoDominio<T> : IDisposable, IBaseServicoDominio<T> where T : class
    {

        public readonly IBaseRepositorio<T> _repositorio;

        public BaseServicoDominio(IBaseRepositorio<T> repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(T obj)
        {
            _repositorio.Adicionar(obj);
        }

        public void Atualizar(T obj)
        {
            _repositorio.Atualizar(obj);
        }

        public T DetalharId(int id)
        {
            return _repositorio.DetalharId(id);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }

        public void Excluir(T obj)
        {
            _repositorio.Excluir(obj);
        }

        public IEnumerable<T> Listar()
        {
            return _repositorio.Listar();
        }
    }
}
