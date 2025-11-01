# 🧩 Task Management Web API

This is a simple **modern ASP.NET Web API** project built with **Entity Framework Core** and **SQL Server**.  
It demonstrates clean architecture principles with a separate **Infrastructure Layer**, proper database context management, and a **To-Do management system** to showcase backend development skills in C# and .NET.

---


## 🚀 Purpose:

The purpose of this project is to showcase the ability to design and build a **RESTful API** using **C# and ASP.NET Core**, applying industry best practices such as:

- Layered architecture (API + Infrastructure)
- Dependency Injection
- Entity Framework Core for ORM and migrations
- SQL Server integration
- Controller-based routing
- CRUD endpoints for managing tasks

This API can be expanded to support various systems, such as project management tools, productivity dashboards, or any system that requires backend data management.

---


## 🛠️ Tech Stack:

| Category | Technology |
|-----------|-------------|
| Language | C# |
| Framework | .NET 8 (ASP.NET Core Web API) |
| ORM | Entity Framework Core |
| Database | Microsoft SQL Server |
| IDE | Visual Studio 2022 |
| Containerization | Docker |

---


## 🧱 Architecture Overview:

The project follows a **clean and modular structure**:

```
TaskManagementAPI/
│
├── TaskManagementAPI/                 # Main Web API
│   ├── Controllers/
│   │   └── ToDoItemController.cs      # Handles API endpoints
│   ├── Program.cs                     # App entry point & configuration
│   └── appsettings.json               # DB connection strings and settings
│
├── TaskManagementAPI.Infrastructure/  # Data access & EF Core setup
│   ├── Models/
│   │   ├── ToDoItem.cs                # Entity models
│   │   ├── Project.cs
│   │   ├── Category.cs
│   │   └── User.cs
│   ├── DBContext.cs                   # EF Core DB context
│   └── ServiceCollectionExtensions.cs # Extension for DI setup
│
└── README.md
```

---


## ⚙️ Features:

✅ **Create, Read, Update, Delete (CRUD)** operations for To-Do items  
✅ **Entity Framework Core** for object-relational mapping  
✅ **SQL Server integration** using migrations and connection strings  
✅ **Dependency Injection** via ServiceCollection extensions  
✅ **Docker support** for deployment (optional)  
✅ **RESTful routing** conventions (`/api/todoitems`)  

---


## 🧾 API Endpoints:

| Method | Endpoint | Description |
|--------|-----------|-------------|
| `GET` | `/api/todoitems` | Retrieve all To-Do items |
| `GET` | `/api/todoitems/{id}` | Retrieve a specific item |
| `POST` | `/api/todoitems` | Create a new item |
| `PUT` | `/api/todoitems/{id}` | Update an existing item |
| `DELETE` | `/api/todoitems/{id}` | Delete an item |

---


## 🧩 How It Works:

- The **API Layer** exposes HTTP endpoints through controllers.  
- The **Infrastructure Layer** handles all data access and Entity Framework configurations.  
- The **DBContext** connects the application to SQL Server.  
- **Dependency Injection** links the Infrastructure services into the API layer for cleaner architecture.

---


## 📜 License:
**Maselaelo Glen - Software Engineering Student**

Feel free to fork, modify, and use it for learning or professional demonstration purposes.
