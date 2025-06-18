# SynergyERP Lite

**SynergyERP Lite** is a lightweight enterprise-level ERP system developed in ASP.NET Core and Blazor WebAssembly. It provides basic modules for managing employees, departments, and expenses, with clean architecture, modularity, and extensibility in mind.


##  Features

- ✅ RESTful API with ASP.NET Core
- ✅ Blazor WebAssembly frontend
- ✅ Entity Framework Core with SQL Server
- ✅ JWT Authentication and Authorization
- ✅ Modular architecture with DTOs and Repository pattern
- ✅ Global error-handling middleware
- ✅ GitHub Actions-based CI/CD pipeline



##  Project Structure
SynergyERP/
- SynergyERP.API/ # Backend - ASP.NET Core Web API
- - Controllers/ # API endpoint controllers
- - Data/ # EF Core DbContext and repositories
- - DTOs/ # Data transfer objects
- - Middleware/ # Custom middleware (e.g., error handling)
- - Models/ # Domain models (Employee, Department, Expense)
- - Startup.cs # Application setup and configuration
- SynergyERP.Web/ # Frontend - Blazor WebAssembly
- - Pages/ # Razor components (EmployeeList.razor, etc.)
- SynergyERP.Tests/ # Test project (unit/integration tests)
- .github/workflows/ # GitHub Actions workflow for CI/CD
- - README.md # Project readme
