﻿using AdmUsuarios.Data;
using AdmUsuarios.Service;
using Microsoft.EntityFrameworkCore;

namespace adm_usuarios
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.Configure<UsuarioDbSettings>
                (builder.Configuration.GetSection("AdmUsuariosDatabase"));

            builder.Services.AddSingleton<UsuarioService>();

            builder.Services.Configure<EmpresaDbSettings>
                (builder.Configuration.GetSection("AdmUsuariosDatabase"));

            builder.Services.AddSingleton<EmpresaService>();

            builder.Services.Configure<LogradouroDbSettings>
                (builder.Configuration.GetSection("AdmUsuariosDatabase"));

            builder.Services.AddSingleton<LogradouroService>();

            builder.Services.Configure<CidadeDbSettings>
                (builder.Configuration.GetSection("AdmUsuariosDatabase"));

            builder.Services.AddSingleton<CidadeService>();

            builder.Services.Configure<EstadoDbSettings>
               (builder.Configuration.GetSection("AdmUsuariosDatabase"));

            builder.Services.AddSingleton<EstadoService>();


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "Administração API",
                    Description = "API para Administração de Usuários",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "MAI",
                        Email = "mai@gmail.com",
                    }
                });
            });

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Ativar Swagger no pipeline de requisi��es
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Adiministração API v1");
                });
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
