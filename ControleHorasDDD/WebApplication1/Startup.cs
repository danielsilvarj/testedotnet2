using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleHoras.Dominio.Interfaces.Repositorios;
using ControleHoras.Dominio.Interfaces.Servicos;
using ControleHoras.Dominio.Servicos;
using ControleHorasDDD.Infraestrutura.Persistencia.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<IProjetoServicoDominio, ProjetoServicoDominio>();
            services.AddSingleton<IProjetoRepositorio, ProjetoRepositorio>();

            services.AddSwaggerGen();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSwagger();
            //C:\Users\1511 MXTI\source\repos\danielsilvarj\testedotnet2\ControleHorasDDD\ControleHoras.API\ControleHoras.API.xml
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
