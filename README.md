# API de controle de usuário em C#/.NET - JWT

## Descrição

Esta é uma API de usuários desenvolvida em c# utilizando o framework ASP.NET Core, Entity Framework Core para interação com o banco
de dados MySQL. O projeto segue os princípios SOLID para garantir uma arquitetura robusta e escalável. AutoMapper é usado para
mapeamento de entidades e DTOs. O projeto é voltado para a segurança e entendimento do JWT, a lib JWT é utlizado para gerar tokens que são validados para o acesso do usuário em áreas restritas e assim manter a segurança do sistema.
=======

# API de Filmes em C#/.NET com Camada de Serviço

## Estrutura do Projeto

```
project-root/
|   |-- Authorization/
|      |-- AgeAutorization.cs
|      |-- MinimalAge.cs
|  |-- Controllers/
|      |-- AcessController.cs
|      |-- UserController.cs
|  |-- Data/
|      |-- Dtos
|          |-- User
|              |-- CreateUserDto.cs
|              |-- UserSignInDto.cs
|      |-- UserDbContext.cs
|  |-- Migrations
|  |-- Models
|      |-- User.cs
|  |-- Profiles
|      |-- UserProfile.cs
|  |-- Services
|      |-- TokenService.cs
|      |-- UserService.cs
|-- appsettings.json
|-- .env
|-- Program.cs
```

## Funcionalidades Principais

1. **User**
   - Cadastrar, visualizar e fazer login

## Configuração do Ambiente

1. **Instale o .NET SDK:**
   - Certifique-se de ter o .NET SDK instalado na sua máquina.

2. **Configurações do Banco de Dados:**
   - Configure a string de conexão com o banco de dados MySQL e a KEY usada na criação do token no arquivo `.env`. Exemplo:
   ```
   CONNECTION_STRING=MinhaStringDeConexaoDoBancoDeDados
   KEY=MinhaStringKey
   ```
3. **Executando a Aplicação**
   - Execute a aplicação usando o comando:
     ```
     dotnet run
     ```
4. **Documentação da API:**
   -- Acess a documentação da API gerada automaticamente ao executar a aplicação em [hhtp://locahost:5000/swagger]
   (http://locahost:5000/swagger).

## Contribuindo

Sinta-se à vontade para contribuir! Abra uma issue ou envie um pull request.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
