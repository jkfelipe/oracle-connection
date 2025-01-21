# Oracle Connection App

Este projeto é um exemplo de aplicação em **Windows Forms** desenvolvida em **C#** que realiza a conexão com um banco de dados **Oracle 19c** utilizando a biblioteca `Oracle.ManagedDataAccess.Client`. Ele inclui funcionalidades para conectar, desconectar e realizar consultas SQL no banco de dados.

---

## Funcionalidades

- Conectar ao banco de dados Oracle utilizando credenciais protegidas.
- Desconectar do banco de dados.
- Executar consultas SQL e exibir os resultados em um componente `DataGridView`.
- Feedback ao usuário sobre o status da conexão e consultas realizadas.

---

## Requisitos

- **.NET Framework ou .NET Core** (versão compatível com a biblioteca Oracle).
- **Visual Studio** (para desenvolvimento).
- **Biblioteca NuGet**: `Oracle.ManagedDataAccess`.

---

## Configuração do Ambiente

### 1. **Instale as Dependências**

Instale a biblioteca `Oracle.ManagedDataAccess` via NuGet no Visual Studio:

```bash
Install-Package Oracle.ManagedDataAccess
```

### 2. **Configuração de Credenciais**

Utilize variáveis de ambiente para proteger as credenciais do banco de dados. Configure as seguintes variáveis no sistema:

- `DB_USER`: Usuário do banco de dados.
- `DB_PASSWORD`: Senha do banco de dados.
- `DB_HOST`: Host do banco de dados.
- `DB_PORT`: Porta do banco de dados (geralmente `1521`).
- `DB_SERVICE_NAME`: Nome do serviço ou SID do banco de dados.

### 3. **.gitignore**

Certifique-se de que arquivos sensíveis, como `.env`, estão no `.gitignore` para evitar vazamento de informações.

---

## Uso

### 1. **Interface do Usuário**

O aplicativo possui três botões principais:

1. **Conectar**: Estabelece uma conexão com o banco de dados Oracle.
2. **Desconectar**: Encerra a conexão ativa com o banco de dados.
3. **Ler Dados**: Executa uma consulta SQL (`SELECT`) e exibe os resultados no `DataGridView`.

### 2. **Consulta SQL**

A consulta padrão exibe 10 registros de uma tabela chamada `coordem`. Você pode personalizar o comando SQL diretamente no código:

```sql
SELECT * FROM coordem FETCH FIRST 10 ROWS ONLY;
```

---

## Estrutura do Projeto

- **MainForm.cs**: Contém toda a lógica de interação com a interface e o banco de dados.
- **GetConnectionString()**: Função que constrói dinamicamente a `connectionString` a partir das variáveis de ambiente.
- **Métodos**:
  - `ConnectToDatabase`: Estabelece a conexão com o banco.
  - `DisconnectFromDatabase`: Encerra a conexão.
  - `ReadDataFromDatabase`: Executa a consulta e exibe os resultados.

---

## Contato

Se tiver dúvidas ou sugestões, entre em contato:
- **Autor**: Kalan Felipe Trentin 
