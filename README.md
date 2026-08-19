# 📚 Library API

RESTful API for library management, developed with .NET.

This project is being built as a practical backend engineering project, focusing on software architecture, clean code, design patterns, testing and scalable API development.

The application will evolve incrementally through development sprints, introducing new features and architectural improvements over time.

---


## 🎯 Project Objective

The main objective of this project is to develop a library management API while applying software engineering practices commonly used in modern .NET backend applications.

The project will cover concepts such as:

- RESTful API
- Clean Architecture
- SOLID principles
- Domain-Driven Design concepts
- CQRS
- Design Patterns
- Entity Framework Core
- SQL Server
- Automated Testing
- Docker
- Authentication and Authorization
- Messaging
- Logging and Observability

The project is intentionally being developed incrementally, allowing architectural decisions to evolve according to the application's requirements.

---

## 🚧 Project Status

The project is currently in **Sprint 0 — Foundation**.

### Sprint 0

- [ x ] Create GitHub repository
- [ x ] Create .NET solution
- [ x ] Create initial ASP.NET Core API
- [ x ] Configure Git
- [ x ] Create initial project documentation

### Next Sprints

- [ ] Define the core domain
- [ ] Implement Books
- [ ] Implement Users
- [ ] Implement Loans
- [ ] Add database persistence
- [ ] Introduce Clean Architecture
- [ ] Introduce CQRS
- [ ] Add automated tests
- [ ] Add authentication and authorization
- [ ] Add Docker
- [ ] Introduce messaging
- [ ] Add observability

---

## 🛠️ Technologies

### Backend

- C#
- .NET
- ASP.NET Core

### Database

- SQL Server
- Entity Framework Core

### Tools

- Git
- GitHub
- Docker

Additional technologies will be introduced as the project evolves.

---

## 🏗️ Planned Architecture

The project starts with a simple structure and will progressively evolve into a more structured architecture.

The planned architecture is based on the following layers:

```text
┌───────────────────────────┐
│           API             │
├───────────────────────────┤
│       Application         │
├───────────────────────────┤
│          Domain           │
├───────────────────────────┤
│      Infrastructure       │
└───────────────────────────┘
```

## 📂 Project Structure

Current project structure:

```text
LibraryApi/
│
├── LibraryAPI/
│   ├── Properties/
│   ├── Program.cs
│   ├── appsettings.json
│   ├── appsettings.Development.json
│   ├── LibraryAPI.csproj
│   └── LibraryAPI.http
│
├── LibraryApi.sln
├── .gitignore
└── README.md
```

The project structure will evolve as new architectural layers and features are introduced.

---

## 👨‍💻 Author

**Paulo Ricardo**

.NET Backend Developer
