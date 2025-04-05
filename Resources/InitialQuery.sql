CREATE DATABASE ContactsDb
COLLATE Cyrillic_General_CI_AS;
GO

USE ContactsDb;
GO

CREATE TABLE Contacts (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(100) COLLATE Cyrillic_General_CI_AS NOT NULL,
    Phone NVARCHAR(10) NOT NULL
);
GO

INSERT INTO Contacts(Name, Phone) VALUES
('Петър', '0888776541'),
('Иван', '0899223345'),
('Мария', '0877661245'),
('Гергана', '0898743190'),
('Тодор', '0845678933');
GO

--SELECT * FROM Contacts;
--GO