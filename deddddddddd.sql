CREATE DATABASE FORGODSAKE
GO

USE FORGODSAKE
GO

CREATE TABLE Rolee (
	ID_Rolee int primary key identity(1,1),
	CName varchar(30)
);
GO

CREATE TABLE LoginGORE (
	ID_LoginGORE int primary key identity(1,1),
	GORELogin varchar(30),
	GOREPassword varchar(30),
	GORERoleId int
);

INSERT INTO Rolee(CName)
VALUES
('Администратор'),
('Продавец');
GO

INSERT INTO LoginGORE(GORELogin, GOREPassword, GORERoleId)
VALUES
('admin', 'admin', 1),
('kassa', 'kassa', 2);
GO