using MediatR;
using Apolo.Infra.Data.Context;
using Apolo.Infra.Data.UnitOfWork;
using Apolo.Infra.Data.Repositories;
using Apolo.Domain.Interfaces;
using Apolo.Domain.Core.Commands;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using Apolo.Domain.Commands;

namespace Apolo.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services
                .AddDbContext<DataContext>()
                .AddControllers();

            services.AddTransient<IUnitOfWork, UnitOfWork>()
                    .AddTransient<ISongRepository, SongRepository>()
                    .AddMediatR(typeof(CreateSongCommand));
            

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                        new OpenApiInfo
                        {
                            Title = "Apolo",
                            Version = "v1.0",
                            Description = "Exemplo de API REST criada com o ASP.NET Core 3.1 ",
                            Contact = new OpenApiContact
                            {
                                Name = "Ynoa Pedro",
                                Url = new Uri("https://github.com/ypedroo"),
                            }
                        });
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });


            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Apolo"));
        }
    }
}
