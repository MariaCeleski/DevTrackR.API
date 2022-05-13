# DevTrackR - Jornada .NET Direto ao Ponto

## Foi desenvolvida uma API REST completa de gerenciamento de pacotes.

### Tecnologias e práticas utilizadas

- ASP.NET Core com .NET 6
- Entity Framework Core
- SQL Server
- Swagger
- Injeção de Dependência
- Programação Orientada a Objetos
- Padrão Repository
- Envio de E-mails com SendGrid
- Clean Code
- Publicação na nuvem com Azure App Service
- Funcionalidades
- Cadastro, Listagem, Detalhes de Pacote
- Cadastro de Atualização de Pacote
  Pacotes instalados:
- Install-Package Microsoft.EntityFrameworkCore.Design
- Install-Package Microsoft.EntityFrameworkCore.SqlServer

- Comandos do Migration executados para criação do banco:
- dotnet user-secrets init
- dotnet user-secrets set "ConnectionStrings:DevTrackRCs"
- dotnet ef migrations add InitialMigration -o Persistence/Migrations
- dotnet ef database update
