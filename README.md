
# AquaRescue - API REST ASP.NET Core

**AquaRescue** é uma solução inovadora desenvolvida para mitigar os impactos dos eventos climáticos extremos em comunidades vulneráveis, através do monitoramento, previsão e gestão inteligente de dados hidrometeorológicos. A aplicação conta com uma API RESTful desenvolvida com ASP.NET Core, integrada ao banco Oracle, autenticação JWT e documentação via Swagger.

---

## 👥 Desenvolvedores

- Leticia Cristina Dos Santos Passos - RM: 555241  
- André Rogério Vieira Pavanela Altobelli Antunes - RM: 554764  
- Enrico Figueiredo Del Guerra - RM: 558604

---

## 🌟 Tecnologias Utilizadas

- .NET 7 / ASP.NET Core Web API  
- Entity Framework Core  
- Oracle Database  
- JWT (JSON Web Token)  
- Swagger / Swashbuckle  
- Deploy em Nuvem (Azure, Render, etc.)

---

## ✉️ Objetivo do Projeto

O objetivo do AquaRescue é fornecer uma API centralizada para coleta, cálculo e previsão de dados meteorológicos, permitindo que ONGs e comunidades acompanhem condições climáticas e tomem decisões baseadas em dados precisos e confiáveis.

---

## 🔧 Como Rodar o Projeto Localmente

### 1. Pré-requisitos

- .NET SDK 7.0 ou superior  
- Oracle Database (com as tabelas do projeto criadas)  
- Visual Studio ou VS Code  

### 2. Clonar o repositório

```bash
git clone https://github.com/usuario/aquarescue-dotnet.git
cd aquarescue-dotnet
```

### 3. Configurar o `appsettings.json`

```json
"ConnectionStrings": {
  "OracleDb": "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));User Id=rm555241;Password=230205;"
}
```

### 4. Restaurar pacotes

```bash
dotnet restore
```

### 5. Executar a aplicação

```bash
dotnet run
```

### 6. Acessar o Swagger

- http://localhost:5000/swagger  
  ou  
- http://localhost:port/swagger/index.html

---

## 🔐 Autenticação

### 1. Cadastro de Usuário  
**POST /usuarios**

```json
{
  "nome": "leticia",
  "email": "lele@gmail.com",
  "senha": "123456",
  "tipo": "ONG"
}
```

### 2. Login  
**POST /login**

```json
{
  "email": "lele@gmail.com",
  "senha": "123456"
}
```

---

## 👤 Perfis de Acesso

- **COMUM**: acesso limitado a visualização de dados  
- **COMUNIDADE**: pode registrar dados e acompanhar indicadores  
- **ONG**: acesso completo (comunidades, previsões, cálculos)

---

## 📚 Estrutura da API

### Controllers

- `AuthController.cs`: login de usuários e geração de token  
- `UsuarioController.cs`: cadastro e listagem de usuários  
- `ComunidadeController.cs`: cadastro e manutenção de comunidades  
- `DadosMeteorologicosController.cs`: entrada e consulta de dados climáticos  
- `LogCalculoController.cs`: registros de cálculo de consumo de água  
- `PrevisaoController.cs`: previsões meteorológicas por comunidade

---

### DTOs

- `UsuarioDTO`, `LoginDTO`, `ComunidadeDTO`, `DadosMeteorologicosDTO`, `LogCalculoDTO`, `PrevisaoDTO`

---

### Entidades

- `Usuario.cs`, `Comunidade.cs`, `DadosMeteorologicos.cs`, `LogCalculo.cs`, `Previsao.cs`

---

### Repositórios

- `UsuarioRepository.cs`  
- `ComunidadeRepository.cs`  
- `DadosMeteorologicosRepository.cs`  
- `LogCalculoRepository.cs`  
- `PrevisaoRepository.cs`

---

### Tratamento Global de Erros

- `GlobalExceptionHandler.cs`: centralização de exceções (validação, regras de negócio, erros 404)

---

## 📘 Exemplos de Payloads

### Comunidade

```json
{
  "nome": "A COMUNIDADE",
  "latitude": 0.14000,
  "longitude": 0.1234234,
  "qtHabitantes": 2000
}
```

### Dados Meteorológicos

```json
{
  "comunidadeId": 1,
  "dataHora": "2025-06-02T16:40:55.129Z",
  "temperatura": 25.1,
  "umidade": 80.0,
  "ptoOrvalho": 18.2,
  "pressao": 1013.2,
  "ventoVeloc": 2.5,
  "ventoDirecao": 180,
  "ventoRajada": 3.8,
  "radiacao": 450,
  "chuva": 0
}
```

### Log de Cálculo

```json
{
  "comunidadeId": 1,
  "qtHabitantes": 2000,
  "consumoPorPessoa": 100.0,
  "totalVolume": 200000,
  "dataCalculo": "2025-06-02T16:41:28.620Z"
}
```

### Previsão

```json
{
  "comunidadeId": 1,
  "temperatura": 30.0,
  "umidade": 70.0,
  "volumePrevisto": 120.0,
  "dataPrevisao": "2025-06-02T04:26:46"
}
```

---

## 🚀 Deploy na Nuvem

> [Inserir link do ambiente de produção aqui]

---

## 📑 Documentação da API

- Documentação Swagger disponível em:  
  http://localhost:5000/swagger

---

## 🎥 Vídeos

- **Demonstração completa**: [link para vídeo de até 10 minutos]  
- **Pitch**: [link para vídeo de até 3 minutos]

---

## ✅ Critérios Atendidos

- API RESTful com boas práticas de arquitetura  
- Conexão com banco Oracle via Entity Framework Core  
- Relacionamentos mapeados entre entidades  
- Validação de dados com DataAnnotations  
- Swagger funcional  
- Autenticação JWT implementada  
- Deploy configurado  
- Tratamento global de exceções

---

## 📅 Desenvolvido por

**Equipe AquaRescue**  
FIAP - Java & .NET Advanced | 2025
