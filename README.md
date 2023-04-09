# VacationManager :palm_tree: :airplane:

VacationManager is an ASP.Net web application that allows employees in a company to submit, edit, and manage their vacation requests. The application also facilitates the management of employee roles, team assignments, and project information.

## Table of Contents :open_book:

- [Features](#features-rocket)
- [Technologies Used](#technologies-used-computer)
- [Installation](#installation-wrench)
- [Usage](#usage-arrow_forward)
- [Contributors](#contributors-busts_in_silhouette)
- [References](#references-books)

## Features :rocket:

- Employees can submit, edit, and delete their vacation requests.
- Managers can review, approve, or reject vacation requests from their team members.
- Admins can manage employee roles, team assignments, and project information.
- Role-based authorization to ensure appropriate access to features.

## Technologies Used :computer:

- ASP.Net Core
- C#
- Entity Framework
- MVC
- Razor Pages

## Installation :wrench:

1. Install the latest version of [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core).
2. Clone the repository.
3. Open the project in your preferred IDE (e.g., Visual Studio, Visual Studio Code).
4. Install the necessary NuGet packages.
5. Configure your database connection in the `appsettings.json` file.

### Automatic installation
In the NuGet Package Manager Console, run the following command:
```bash
Update-Database
```

### Manual installation
In the NuGet Package Manager Console, run the following commands:
```bash
Add-Migration InitialCreate -Context ApplicationDbContext
Update-Database -Context ApplicationDbContext
```

Alternatively, execute the following SQL commands in your SQL Server Management Studio or any other SQL client:

```SQL
CREATE TABLE AppUser (
    Id NVARCHAR(450) PRIMARY KEY,
    FirstName NVARCHAR(70) NOT NULL,
    LastName NVARCHAR(70) NOT NULL,
    TeamId INT,
    TeamLedId INT,
    UserName NVARCHAR(256) NULL,
    NormalizedUserName NVARCHAR(256) NULL,
    Email NVARCHAR(256) NULL,
    NormalizedEmail NVARCHAR(256) NULL,
    EmailConfirmed BIT NOT NULL,
    PasswordHash NVARCHAR(MAX) NULL,
    SecurityStamp NVARCHAR(MAX) NULL,
    ConcurrencyStamp NVARCHAR(MAX) NULL,
    PhoneNumber NVARCHAR(MAX) NULL,
    PhoneNumberConfirmed BIT NOT NULL,
    TwoFactorEnabled BIT NOT NULL,
    LockoutEnd DATETIMEOFFSET NULL,
    LockoutEnabled BIT NOT NULL,
    AccessFailedCount INT NOT NULL
);

CREATE TABLE Holiday (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    DateOfRequest DATE NOT NULL,
    IsHalfDay BIT NOT NULL,
    IsApproved BIT NOT NULL,
    Type INT NOT NULL,
    PatientNote NVARCHAR(MAX) NULL,
    RequesterId NVARCHAR(450) NOT NULL
);

CREATE TABLE Project (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(70) NOT NULL,
    Description NVARCHAR(200) NULL
);

CREATE TABLE Team (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    LeaderId NVARCHAR(450) NULL,
    ProjectId INT NULL
);

ALTER TABLE AppUser
ADD CONSTRAINT FK_AppUser_Team FOREIGN KEY (TeamId) REFERENCES Team(Id);
ALTER TABLE AppUser
ADD CONSTRAINT FK_AppUser_TeamLed FOREIGN KEY (TeamLedId) REFERENCES Team(Id);

ALTER TABLE Holiday
ADD CONSTRAINT FK_Holiday_AppUser FOREIGN KEY (RequesterId) REFERENCES AppUser(Id);

ALTER TABLE Team
ADD CONSTRAINT FK_Team_AppUser FOREIGN KEY (LeaderId) REFERENCES AppUser(Id);
ALTER TABLE Team
ADD CONSTRAINT FK_Team_Project FOREIGN KEY (ProjectId) REFERENCES Project(Id);
```

6. Run the application.

## Usage :arrow_forward:

1. Register as a new user or log in with an existing account.
2. Submit, edit, or delete vacation requests.
3. For managers and admins, review and manage vacation requests, employee roles, and team assignments through their respective interfaces.

## Contributors :busts_in_silhouette:

- Kiril: Responsible for the Employee, Holidays, and HomeController components, as well as the AppUser and Holiday models.
- Ivan: In charge of the Teams, Roles, and ProjectController components, and the Project and Teams models.

## References :books:

- [ASP.NET Documentation](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/)
- [UserManager Class](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.usermanager-1?view=aspnetcore-6.0)
- [RoleManager Class](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.rolemanager-1?view=aspnetcore-6.0)