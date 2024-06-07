# GS---ENTERPRISE

# Marine Pollution Monitoring API

## Escopo 

A Marine Pollution Monitoring API é uma solução desenvolvida para facilitar a coleta e gerenciamento de dados sobre poluição marinha. Utilizando tecnologia de ponta, essa API permite que organizações ambientais, pesquisadores e autoridades governamentais acompanhem em tempo real a quantidade e tipo de poluentes nos corpos d'água.

### Funcionalidades

- **Coleta de Dados**: Registra informações sobre a poluição detectada, como localização, quantidade e data/hora do registro.
- **Consulta de Dados**: Permite a recuperação de todos os registros de poluição armazenados no banco de dados.
- **Integração com Sistemas Externos**: Projetada para ser facilmente integrável com outros sistemas de monitoramento e análise ambiental.

### Endpoints:

GET /pollution
Descrição: Retorna uma lista de todos os registros de poluição.
Resposta Esperada: Lista de registros, cada um contendo Id, Location, Quantity, Timestamp.
POST /pollution

Descrição: Permite adicionar um novo registro de poluição.
Corpo da Requisição: JSON contendo Location, Quantity, Timestamp.
Resposta Esperada: Detalhes do registro criado, incluindo seu Id.

## Como Executar o Projeto

### Pré-requisitos

Antes de iniciar, certifique-se de que você tem o .NET 7 instalado em seu ambiente de desenvolvimento. Além disso, você precisa de acesso a um banco de dados Oracle, configurado com as credenciais adequadas.

### Configuração

1. Clone o repositório do projeto para sua máquina local:

git clone [https://GS---ENTERPRISE.com/marine-pollution-api.git](https://github.com/Seato2/GS---ENTERPRISE.git)
cd marine-pollution-api

2. Instale as dependências necessárias:
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Oracle.EntityFrameworkCore


3. Adicione a string de conexão para o banco de dados no arquivo `appsettings.json`:
json
{
  "ConnectionStrings": {
      "OracleDbConnection": "User Id=USUARIO;Password=SENHA;Data Source=ORACLE_DB_TNS"
  }
}

4. Execute as migrações para configurar o banco de dados (opcional, dependendo se é necessário configurar o banco de dados):

dotnet ef migrations add InitialCreate
dotnet ef database update

5. Inicie a aplicação

dotnet run


