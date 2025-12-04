DUPLA: 
RAFAEL AUGUSTO BARBOSA 2 DS
LUIZA SCOLAR PEREIRA DE SOUZA 2 DS

CÓDIGO EXPLICAÇÃO:

Program.cs e .csproj:
É onde ocorre a configuração inicial da aplicação, definindo serviços, dependências e comportamentos essenciais do projeto.

Ficheiro Program.cs -> utiliza o comando using para importar bibliotecas externas, como Microsoft.EntityFrameworkCore, que 
habilita o uso do Entity Framework Core. 

WebApplication.CreateBuilder(args) -> carrega configurações básicas como serviços, variáveis de ambiente e ficheiros de configuração.

Padrão arquitetural MVC (Model-View-Controller) -> é habilitado com o comando builder.Services.AddControllersWithViews(), 
que registra controladores e mecanismos de renderização de páginas. Recursos de autenticação e autorização são ativados 
com builder.Services.AddAuthorization().

Options.UseMySql(connectionString, ...) -> é a instrução que configura a conexão com o banco de dados MySQL, que define o
provedor de dados a ser utilizado.

Middleware app.UseStaticFiles() -> permite a disponibilização de ficheiros estáticos na pasta wwwroot. 

app.MapControllerRoute(...) -> estabelece o roteamento padrão, definindo os controladores e métodos que respondem às requisições.

Ficheiro RadioBG.csproj -> na linha <PackageReference Include="..." Version="8.0.0" /> descreve as dependências externas 
(pacotes NuGet) necessárias para o projeto, incluindo o Entity Framework Core e o provedor MySQL.
