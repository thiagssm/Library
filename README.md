# 📚 Library API – Gerenciamento de Avaliação de Livros

**Library** é uma API REST desenvolvida em **C# com .NET**, voltada para o gerenciamento de avaliação de livros. O sistema permite o cadastro e classificação de livros, controle de usuários e gestão de empréstimos, com foco em arquitetura limpa, escalável e de fácil manutenção.

---

## ✨ Principais Funcionalidades

- 📖 Cadastro, consulta, atualização e remoção de livros  
- 👤 Gerenciamento de usuários (leitores)  
- 🔄 Controle de empréstimos e devoluções com validações de regras de negócio  
- 🧹 Estrutura organizada segundo os princípios de **Clean Architecture**  
- 🧪 Suporte a testes unitários e extensibilidade do código

---

## 🧱 Tecnologias Utilizadas

- .NET (C#)  
- ASP.NET Core Web API  
- Entity Framework Core (acesso a dados)  
- AutoMapper (mapeamento entre DTOs e entidades)  
- Swagger (documentação automática da API)

---

## 🎯 Objetivo do Projeto

Este projeto foi criado como parte do portfólio pessoal, com o objetivo de aprimorar práticas de desenvolvimento backend utilizando C# e Clean Architecture e aplicar os princípios **SOLID**, separação de responsabilidades e testabilidade.

---

## ▶️ Como Executar

```bash
# Restaurar dependências
dotnet restore

# Aplicar migrações (se houver)
dotnet ef database update

# Executar a API
dotnet run --project Library.API
```

---

## 📂 Estrutura das Pastas

```plaintext
Library/
│
├── Library.API/             → Camada de apresentação (controllers, endpoints)  
├── Library.Application/     → Lógica de aplicação, serviços, DTOs  
├── Library.Domain/          → Entidades e regras de negócio  
├── Library.Infrastructure/  → Implementação de repositórios e acesso a dados  
└── Library.Tests/           → Testes automatizados (caso existam)
```

---

## 🔍 Exemplos de Uso

- **Endpoints típicos**:  
  - `GET /api/books` – listar livros  
  - `POST /api/books` – criar novo livro  
  - `PUT /api/books/{id}` – atualizar livro existente  
  - `DELETE /api/books/{id}` – remover livro  

- **Fluxo de arquitetura**:  
  - **Controller** → **Application Layer** → **Infrastructure (Repositório)** → **Banco de Dados via EF Core**

---

## ✅ Contribuição & Contato

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.  
⭐ Se achar útil, deixe uma estrela no repositório!  
📧 Contato: [seuemail@email.com]
