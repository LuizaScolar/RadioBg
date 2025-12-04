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
que registra controladores e mecanismos de renderização de páginas. 

builder.Services.AddAuthorization() -> ativa recursos de autenticação e autorização.

Options.UseMySql(connectionString, ...) -> é a instrução que configura a conexão com o banco de dados MySQL, que define o
provedor de dados a ser utilizado.

Middleware app.UseStaticFiles() -> permite a disponibilização de ficheiros estáticos na pasta wwwroot. 

app.MapControllerRoute(...) -> estabelece o roteamento padrão, definindo os controladores e métodos que respondem às requisições.

Ficheiro RadioBG.csproj -> na linha <PackageReference Include="..." Version="8.0.0" /> descreve as dependências externas 
(pacotes NuGet) necessárias para o projeto, incluindo o Entity Framework Core e o provedor MySQL.

----------------------------------------------------------------------------------------------------------------------------------------------------------

AppDbContext.cs:
Esse ficheiro representa a camada de acesso a dados, responsável pela comunicação entre a aplicação e o banco de dados MySQL, 
por meio do Entity Framework Core.

public class AppDbContext : DbContext -> é a classe declarada que indica a herança da classe DbContext, fornece as funcionalidades 
de acesso e manipulação de dados.  

DbContextOptions<AppDbContext> -> tipo de objeto que o construtor recebe, nele contém informações essenciais para a conexão, 
como a string de conexão.

public DbSet<Usuario> Usuarios { get; set; } -> representa a tabela correspondente no banco de dados. 

DbSet<T> -> habilita operações de consulta, inserção, alteração e remoção de registos.

----------------------------------------------------------------------------------------------------------------------------------------------------------

HomeController.cs:
É o ficheiro que implementa a lógica do padrão MVC, sendo responsável pelo processamento das requisições 
e pela ligação entre a interface e a base de dados.

HomeController -> essa classe herda de Controller, o que possibilita o tratamento de requisições HTTP e o retorno de Views. 

privada _context -> váriavel que armazena a instância do AppDbContext, recebida por injeção de dependência no construtor.

[HttpGet] e [HttpPost] -> são os atributos que determinam o tipo de requisição que cada método deve aceitar. 

Método Login(string email, string senha) -> recebe os dados enviados pelo formulário HTML e consulta a base de dados por meio de _context.Usuarios.FirstOrDefault(...), utilizando expressões lambda para localizar o registo correspondente.

ViewBag.Erro. -> Em situações de erro, envia a mensagem para a View.

RedirectToAction("Lista", "Musicas") -> a aplicação redireciona para outra página caso o utilizador seja encontrado.

