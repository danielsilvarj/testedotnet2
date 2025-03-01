﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ControleHoras.Dominio.Interfaces.Servicos;
using ControleHoras.Dominio.Servicos;
using ControleHoras.Dominio.Interfaces.Repositorios;
using ControleHorasDDD.Infraestrutura.Persistencia.Repositorio;
using Autofac;
using ControleHorasDDD.Infraestrutura.Transversal.IoC;
using Autofac.Extensions.DependencyInjection;
using ControleHorasDDD.Infraestrutura.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace ControleHoras.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public ILifetimeScope AutofacContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ControleHorasDbContext>(o => o.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;DataBase=ControleHoras;Trusted_Connection=True"));

            services.AddTransient<IProjetoServicoDominio, ProjetoServicoDominio>();
            services.AddTransient<IProjetoRepositorio, ProjetoRepositorio>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen();
        }

        /*public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new IoCModulo());
        }*/

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            //app.UseMvc();

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

            //this.AutofacContainer = app.ApplicationServices.GetAutofacRoot();
        }
    }
}
