using Microsoft.EntityFrameworkCore;
using AquaRescue.Config;
using AquaRescue.Data;
using AquaRescue.Exception;
using AquaRescue.Repository;
using AquaRescue.Repository.Interfaces;
using AquaRescue.Services;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

var oracleConnectionString = configuration.GetSection("ConnectionStrings")["OracleDb"];

builder.Services.AddDbContext<AquaRescueDbContext>(options =>
    options.UseOracle(oracleConnectionString));

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


// 🔧 Controllers e Swagger
builder.Services.AddControllers(options =>
{
    options.Filters.Add<GlobalExceptionHandler>();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerConfiguration();

// 🔧 Repositórios
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IComunidadeRepository, ComunidadeRepository>();
builder.Services.AddScoped<IDadosMeteorologicosRepository, DadosMeteorologicosRepository>();
builder.Services.AddScoped<ILogCalculoRepository, LogCalculoRepository>();
builder.Services.AddScoped<IPrevisaoRepository, PrevisaoRepository>();

// 🔧 Serviços
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<ComunidadeService>();
builder.Services.AddScoped<DadosMeteorologicosService>();
builder.Services.AddScoped<LogCalculoService>();
builder.Services.AddScoped<PrevisaoService>();

var app = builder.Build();

// 🌐 Middlewares e Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "AquaRescue API V1");
        c.RoutePrefix = string.Empty; // Swagger na raiz
    });
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
