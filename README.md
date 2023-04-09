# VacationManager
```bash
Add-Migration InitialCreate -Context ApplicationDbContext
Update-Database -Context ApplicationDbContext
```

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
ADD CONSTRAINT FK_AppUser_Team FOREIGN KEY (TeamId) REFERENCES Team(Id),
ADD CONSTRAINT FK_AppUser_TeamLed FOREIGN KEY (TeamLedId) REFERENCES Team(Id);

ALTER TABLE Holiday
ADD CONSTRAINT FK_Holiday_AppUser FOREIGN KEY (RequesterId) REFERENCES AppUser(Id);

ALTER TABLE Team
ADD CONSTRAINT FK_Team_AppUser FOREIGN KEY (LeaderId) REFERENCES AppUser(Id),
ADD CONSTRAINT FK_Team_Project FOREIGN KEY (ProjectId) REFERENCES Project(Id);
This SQL code should now work correctly in SQL Server 2019.




kikots@abv.bg
ADD CONSTRAINT FK_AppUser_TeamLed FOREIGN KEY (TeamLedId) REFERENCES Team(Id);
Here is the error unexpected ADD and CONSTRAINT incorrect syntax
I apologize for the confusion. It appears that I have made an error in the placement of the "ADD CONSTRAINT" keyword. Here is the corrected SQL code for creating the tables and foreign key constraints:

sql
Copy code
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