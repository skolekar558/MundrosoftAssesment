Project Title: Employee Management System

- Overview of project

The Employee Management System is a web application designed to streamline the management of employee information within a company. It offers user registration, authentication, password recovery, and CRUD operations for employee management.
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
## Technologies

- .NET Core MVC
- Entity Framework Core (optional)
- Bootstrap (for UI design)
- ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
## Features of Application

### Registration Page

- Users can register with their email address and password.
- Input fields are validated (e.g., email format, password strength).
- User information is securely stored in a database.

### Login Page

- Registered users can sign in using a login form.
- User authentication is performed based on credentials.
- Session management is implemented to maintain user sessions.

### Forgot Password

- Users can reset their password if forgotten.
- A password reset link is sent to the user's email address.
- The reset request is verified, and the password is updated accordingly.

### Add Employee

- A form is provided to add new employee details (e.g., name, email, department).
- Input fields are validated, and appropriate error messages are displayed.
- Employee information is saved to the database.

### List Employee

- All registered employees are listed in the system.
- Options to view employee details and perform actions (edit, delete) are included.

### Delete Employee

- Administrators can delete employee records from the system.
- Deletion is confirmed with a prompt to prevent accidental removal.

### Modify Employee

- Employee details (e.g., name, email, department) can be edited.
- The database is updated with the modified employee information.
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-Database Structure for this project:

To add database information to your ASP.NET Core MVC project, typically configure the database connection string in the appsettings.json or appsettings.Development.json file.
Here's how  can do it:

Open appsettings.json:
Open the appsettings.json file in your ASP.NET Core MVC project. This file typically resides in the root directory of your project.

Add Connection String:
Inside the appsettings.json file, add a section for  database connection string. For example:

json
Copy code
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YourServer;Database=YourDatabase;User=YourUsername;Password=YourPassword;"
  }
}
Replace "YourServer", "YourDatabase", "YourUsername", and "YourPassword" with the appropriate values for your database configuration.

Configure DbContext:
In your ASP.NET Core MVC project, you likely have a DbContext class that represents your database context. In this class, you need to specify how to use the connection string defined in appsettings.json. Here's an example of how you can do it:

csharp
Copy code
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
Ensure that you have the necessary using directives at the top of your file, such as using Microsoft.EntityFrameworkCore; and using Microsoft.Extensions.Configuration;.

Access Database Information:
In your application code, you can access the database connection string using dependency injection. For example, in a controller or service class, you can inject an instance of DbContextOptions<ApplicationDbContext> and use it to configure the DbContext.

Migrate and Update Database:
If you're using Entity Framework Core and Code First approach, you need to run migration commands to create or update the database schema based on your model classes. Use the following commands in the terminal:

sql
Copy code
dotnet ef migrations add InitialCreate
dotnet ef database update
Replace "InitialCreate" with an appropriate migration name
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------## My database structure:
Database Name:MundarisoftAssesment
table structure:for this application i used two tables Employee and User.
# User table structure:
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY,
    Email NVARCHAR(255) NOT NULL,
    Password NVARCHAR(255) NOT NULL
);

#Employee Table Structure:

CREATE TABLE Employees (
    Id INT PRIMARY KEY,
    Name NVARCHAR(MAX) NOT NULL,
    Email NVARCHAR(MAX) NOT NULL,
    Salary BIGINT NOT NULL,
    City NVARCHAR(MAX) NOT NULL
);



## Getting Started




1. Clone this repository.:using the git clone command in the terminal:eg:git clone https://github.com/your-username/employee-management-system.git
2. Open the Project in Visual Studio Code:
Open Visual Studio Code 2022, and use the File > Open Folder option to open the folder containing your Employee Management System project.
3. Install Dependencies:
 project has any dependencies (such as NuGet packages for .NET Core MVC), you need to restore them. Open the integrated terminal in Visual Studio Code and run the following command in the project directory:dotnet restore
4.Configure the Database Connection:
If project uses a database (such as SQL Server), ensure that the database connection string is correctly configured in the appsettings.json or appsettings.Development.json file.
5.Build the Project:
Build the project to ensure that there are no compilation errors. You can build the project using the integrated terminal with the following command:dotnet build
6.Run the Application:
Once the project is built successfully, you can run the application. Use the following command in the integrated terminal:dotnet run

