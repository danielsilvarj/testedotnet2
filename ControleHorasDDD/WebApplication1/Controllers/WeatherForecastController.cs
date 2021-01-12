using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleHoras.Dominio.Entidade;
using ControleHoras.Dominio.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IProjetoServicoDominio _service;

        // _service;

        //public ValuesController(IProjetoServicoDominio service)
        //{
        //    _service = _service;
        //}
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IProjetoServicoDominio service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Projeto> Get()
        {
            var rng = _service.Listar();
            return rng
            .ToArray();
        }
    }
}
