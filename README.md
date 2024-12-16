# teste_tecnico_Vega

## Passos para Inicializar o Projeto

#### 1. Clone o repositório

Abra um terminal e clone o repositório do seu projeto:

```bash
git clone .....
```

#### 2. Configuração do Projeto ASP.NET Core

- Abra o terminal na pasta do projeto da API.

```bash
cd [seucaminho]/...
```

- Instale as dependências do NuGet e configure a string de conexão:

```bash
dotnet restore
```

- No aquivo ConnectionContext.cs dentro da pasta Infraestrutura, modifique a string de conexão com base na sua conexão MySql

```bash
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
      string stringConexao = "Server=...;Port=...;Database=...;User Id=...;Password=...;";
  
      optionsBuilder.UseMySql(connectionString: stringConexao, serverVersion: ServerVersion.AutoDetect(stringConexao));
  } 
```

- No banco de dados rode o SQL que está no projeto


- Inicie a API:

```bash
dotnet run
```

A API estará acessível em `https://localhost:5266`.
