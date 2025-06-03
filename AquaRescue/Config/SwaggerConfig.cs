using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace AquaRescue.Config
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "🌊 AquaRescue API",
                    Version = "v1",
                    Description = "API para monitoramento e previsão de dados hidrometeorológicos para comunidades em situações de urgência.",
                    Contact = new OpenApiContact
                    {
                        Name = "Equipe AquaRescue",
                        Email = "contato@aquarescue.org"
                    }
                });

                // (Opcional) Comentários XML para documentação dos métodos
                /*
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
                */
            });
        }

        public static void UseSwaggerConfiguration(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "AquaRescue API v1");
                c.RoutePrefix = string.Empty; // Swagger direto na raiz
            });
        }
    }
}
