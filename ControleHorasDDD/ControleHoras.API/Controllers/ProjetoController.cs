using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Interfaces.Servicos;
using ControleHorasDDD.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;

namespace ControleHoras.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {


        IProjetoServicoDominio _service;

        public ProjetoController(IProjetoServicoDominio service)
        {
            _service = service;
        }

      

       


        [HttpGet]
        [Route("/Lista")]
        [SwaggerOperation("")]
        public RetornoApi Lista()
        {

            var item = _service.Listar();

            RetornoApi retornoApi = new RetornoApi
            {
                resultado = (item != null),
                valor = (item != null) ? item : null

            };
            return retornoApi;
        }

        [HttpPost]
        [Route("/Salvar")]
        [SwaggerOperation("")]
        public RetornoApi Salvar(Projeto objeto)
        {

            _service.Adicionar(objeto);

            RetornoApi retornoApi = new RetornoApi
            {
                resultado = true,
                valor = "Inserido"

            };
            return retornoApi;
        }
    }
}
