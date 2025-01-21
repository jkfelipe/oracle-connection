# Oracle Connection App

Este projeto � um exemplo de aplica��o em **Windows Forms** desenvolvida em **C#** que realiza a conex�o com um banco de dados **Oracle 19c** utilizando a biblioteca `Oracle.ManagedDataAccess.Client`. Ele inclui funcionalidades para conectar, desconectar e realizar consultas SQL no banco de dados.

---

## Funcionalidades

- Conectar ao banco de dados Oracle utilizando credenciais protegidas.
- Desconectar do banco de dados.
- Executar consultas SQL e exibir os resultados em um componente `DataGridView`.
- Feedback ao usu�rio sobre o status da conex�o e consultas realizadas.

---

## Requisitos

- **.NET Framework ou .NET Core** (vers�o compat�vel com a biblioteca Oracle).
- **Visual Studio** (para desenvolvimento).
- **Biblioteca NuGet**: `Oracle.ManagedDataAccess`.

---

## Configura��o do Ambiente

### 1. **Instale as Depend�ncias**

Instale a biblioteca `Oracle.ManagedDataAccess` via NuGet no Visual Studio:

```bash
Install-Package Oracle.ManagedDataAccess
```

### 2. **Configura��o de Credenciais**

Utilize vari�veis de ambiente para proteger as credenciais do banco de dados. Configure as seguintes vari�veis no sistema:

- `DB_USER`: Usu�rio do banco de dados.
- `DB_PASSWORD`: Senha do banco de dados.
- `DB_HOST`: Host do banco de dados.
- `DB_PORT`: Porta do banco de dados (geralmente `1521`).
- `DB_SERVICE_NAME`: Nome do servi�o ou SID do banco de dados.

### 3. **.gitignore**

Certifique-se de que arquivos sens�veis, como `.env`, est�o no `.gitignore` para evitar vazamento de informa��es.

---

## Uso

### 1. **Interface do Usu�rio**

O aplicativo possui tr�s bot�es principais:

1. **Conectar**: Estabelece uma conex�o com o banco de dados Oracle.
2. **Desconectar**: Encerra a conex�o ativa com o banco de dados.
3. **Ler Dados**: Executa uma consulta SQL (`SELECT`) e exibe os resultados no `DataGridView`.

### 2. **Consulta SQL**

A consulta padr�o exibe 10 registros de uma tabela chamada `coordem`. Voc� pode personalizar o comando SQL diretamente no c�digo:

```sql
SELECT * FROM coordem FETCH FIRST 10 ROWS ONLY;
```

---

## Estrutura do Projeto

- **MainForm.cs**: Cont�m toda a l�gica de intera��o com a interface e o banco de dados.
- **GetConnectionString()**: Fun��o que constr�i dinamicamente a `connectionString` a partir das vari�veis de ambiente.
- **M�todos**:
  - `ConnectToDatabase`: Estabelece a conex�o com o banco.
  - `DisconnectFromDatabase`: Encerra a conex�o.
  - `ReadDataFromDatabase`: Executa a consulta e exibe os resultados.

---

## Contato

Se tiver d�vidas ou sugest�es, entre em contato:
- **Autor**: Kalan Felipe Trentin 
