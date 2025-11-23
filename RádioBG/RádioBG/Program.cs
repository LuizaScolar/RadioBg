using Microsoft.EntityFrameworkCore;
using RadioBG.Data;

var builder = WebApplication.CreateBuilder(args);

// ==================================================================
// 1. CONFIGURAÇÃO DOS SERVIÇOS (O que o site precisa para rodar)
// ==================================================================

// Adiciona o suporte para Controladores e Telas (MVC)
builder.Services.AddControllersWithViews();

// Adiciona o serviço de Autorização (Correção do seu erro)
builder.Services.AddAuthorization();

// Adiciona a conexão com o MySQL
// NOTA: Confira se no seu appsettings.json o nome é "ConexaoPadrao" mesmo
var connectionString = builder.Configuration.GetConnectionString("ConexaoPadrao");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// ==================================================================
// 2. CONSTRUÇÃO DO APP
// ==================================================================
var app = builder.Build();

// Configurações para lidar com erros
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Importante para o seu CSS funcionar

app.UseRouting();

// A ordem aqui importa: Routing -> Authorization -> MapController
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

