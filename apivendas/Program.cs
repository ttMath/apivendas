using apivendas.Data;
using apivendas.Data.Map.Automap;
using apivendas.Repositorios;
using apivendas.Repositorios.Interfaces;
using apivendas.Servicos;
using apivendas.Servicos.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ApiVendasCs");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApiVendasDbContext>(d => d.UseSqlServer(connectionString));
builder.Services.AddScoped<IProdutoServico, ProdutoServico>();
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

builder.Services.AddAutoMapper(typeof(ServicoParaDtos));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
