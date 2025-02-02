# Employee Management System (ASP.NET Core + MongoDB)

This is a simple Employee Management System built with **ASP.NET Core MVC** and **MongoDB**.

## 🚀 Features
- ✅ **CRUD Operations** (Create, Read, Update, Delete) for Employees
- ✅ **MongoDB Integration** (Using `MongoDbContext`)
- ✅ **MVC Views** (Bootstrap UI for Employee Management)
- ✅ **REST API Support** (Accessible via Swagger)
- ✅ **Swagger UI** for API documentation

---

## 📂 Project Structure
```
EmployeeManagement/
│── Controllers/
│   ├── EmployeeController.cs  # Handles MVC Views
│   ├── EmployeeApiController.cs  # Handles REST API
│── Data/
│   ├── MongoDbContext.cs  # MongoDB Connection
│── Models/
│   ├── Employee.cs  # Employee Model
│── Views/
│   ├── Employee/
│   │   ├── Index.cshtml  # Employee List
│   │   ├── Create.cshtml  # Add Employee
│   │   ├── Edit.cshtml  # Edit Employee
│   │   ├── Delete.cshtml  # Delete Employee
│   ├── Shared/
│   │   ├── _Layout.cshtml  # Main Layout
│── wwwroot/  # Static Files (CSS, JS)
│── Program.cs
│── appsettings.json
│── README.md  # Project Documentation
```

---

## 📌 Setup Instructions

### 1️⃣ **Clone the Repository**
```sh
git clone https://github.com/YOUR_GITHUB_USERNAME/EmployeeManagement.git
cd EmployeeManagement
```

### 2️⃣ **Install Dependencies**
```sh
dotnet restore
```

### 3️⃣ **Set Up MongoDB**
Ensure that MongoDB is running locally on **port 27017** or update the connection string in `MongoDbContext.cs`:
```csharp
var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("EmployeeDB");
```

### 4️⃣ **Run the Project**
```sh
dotnet run
```

---

## 🔗 **Endpoints**
| **Type** | **Endpoint** | **Description** |
|----------|-------------|----------------|
| 🌍 **Web UI** | `http://localhost:5000/Employee` | Employee Management Dashboard |
| 📌 **API - Get All** | `http://localhost:5000/api/EmployeeApi` | Get all employees |
| 📌 **API - Get By ID** | `http://localhost:5000/api/EmployeeApi/{id}` | Get employee by ID |
| 📌 **API - Create** | `POST http://localhost:5000/api/EmployeeApi` | Add new employee |
| 📌 **API - Update** | `PUT http://localhost:5000/api/EmployeeApi/{id}` | Update employee |
| 📌 **API - Delete** | `DELETE http://localhost:5000/api/EmployeeApi/{id}` | Delete employee |
| 📌 **Swagger UI** | `http://localhost:5000/swagger` | API Documentation |

---

## 📷 **Screenshots**
### 🎯 **Employee Dashboard**
![Employee List](https://via.placeholder.com/800x400?text=Employee+Dashboard)

### 🎯 **Swagger UI**
![Swagger API](https://via.placeholder.com/800x400?text=Swagger+UI)

---

## 🤝 **Contributing**
Pull requests are welcome! If you find any issues, please open an [issue](https://github.com/YOUR_GITHUB_USERNAME/EmployeeManagement/issues).

