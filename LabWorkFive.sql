Drop Database ARGH

CREATE DATABASE ARGH
GO

USE ARGH
GO

CREATE TABLE Animals(
	ID_Animals int primary key identity(1,1),
	WType varchar(30),
	HowMuch int
);
GO

CREATE TABLE CATS(
	ID_Cats int primary key identity(1,1),
	CatName varchar(30),
	CatAge int,
	CatColor varchar(30),
	CatType varchar(30),
	Typey_ID int not null foreign key references Animals(ID_Animals)
);
GO

CREATE TABLE DOGS(
	ID_Dogs int primary key identity(1,1),
	DogName varchar(30),
	DogAge int,
	DogColor varchar(30),
	DogType varchar(30),
	Typey_ID int not null foreign key references Animals(ID_Animals)
);
GO

CREATE TABLE RATS(
	ID_Rats int primary key identity(1,1),
	RatName varchar(30),
	RatAge int,
	RatColor varchar(30),
	RatType varchar(30),
	Typey_ID int not null foreign key references Animals(ID_Animals)
);
GO

CREATE TABLE BIRDS(
	ID_Birds int primary key identity(1,1),
	BirdName varchar(30),
	BirdAge int,
	BirdColor varchar(30),
	BirdType varchar(30),
	Typey_ID int not null foreign key references Animals(ID_Animals)
);
GO

CREATE TABLE FROGS(
	ID_Frogs int primary key identity(1,1),
	FrogName varchar(30),
	FrogAge int,
	FrogColor varchar(30),
	FrogType varchar(30),
	Typey_ID int not null foreign key references Animals(ID_Animals)
);
GO

CREATE TABLE FOOD(
	ID_FOOD int primary key identity(1,1),
	FoodName varchar(30),
	FoodType varchar(30),
	HowMuch varchar(30)
);
GO

CREATE TABLE TOOLS(
	ID_TOOL int primary key identity(1,1),
	ToolName varchar(30),
	ToolType varchar(30),
	HowMuchTool int
);
GO

CREATE TABLE LivePointsForWorkers(
	ID_LivePointsForWorkers int primary key identity(1,1),
	LivePointLocation varchar(30),
	HowMuchComfrotable int,
	FoodAtLeast varchar(30)
);
GO

CREATE TABLE BuyMoments(
	ID_BuyMomnets int primary key identity(1,1),
	Food_ID int not null foreign key references FOOD(ID_FOOD),
	Tools_ID int not null foreign key references TOOLS(ID_TOOL),
	LivePointsForWorkers_ID int not null foreign key references LivePointsForWorkers(ID_LivePointsForWorkers),
	Animals_ID int not null foreign key references Animals(ID_Animals)
);
GO

CREATE TABLE CLIENTS(
	ID_CLIENTS int primary key identity(1,1),
	ClientName varchar(30),
	ClientSureName varchar(30),
	ClientFather varchar(30),
	ClientMail varchar(30),
	ClientBuyNumber int
);
GO

Create Table Points(
	ID_Points int primary key identity(1,1),
	WLocation varchar(30),
	Clients_ID int not null foreign key references CLIENTS(ID_CLIENTS)
);
GO

Create Table Orders(
	ID_Orders int primary key identity(1,1),
	OrderData varchar(30),
	HowManyAnimals int,
	TypeOfAnimal varchar(30),
	SterilizationOrCastrationNeed varchar(30),
	Client_ID int not null foreign key references CLIENTS(ID_CLIENTS),
	Points_ID int not null foreign key references Points(ID_Points),
);
GO

CREATE TABLE Workers(
	ID_Workers int primary key identity(1,1),
	WorkName varchar(30),
	WorkSureName varchar(30),
	WorkMiddleName varchar(30),
	WorkMail varchar(100) NOT NULL,
	WorkLivePoint_ID int not null foreign key references LivePointsForWorkers(ID_LivePointsForWorkers),
	Points_ID int not null foreign key references Points(ID_Points)
);
GO

INSERT INTO Animals(WType, HowMuch)
VALUES
('Cats', 52),
('Dogs', 49),
('Rats', 82),
('Frogs', 23),
('Birds', 34);
GO

INSERT INTO CATS(CatName, CatAge, CatColor, CatType, Typey_ID)
VALUES
('Alfred', 2, 'BrownBlack', 'Common', 1),
('Bellami', 4, 'WhiteYellowBlack', 'Korat', 1),
('Angry', 1, 'WhiteBlack', 'Nebelung', 1),
('Wrom', 3, 'Black', 'Common', 1),
('Liney', 2, 'White', 'Common', 1);
GO

INSERT INTO DOGS(DogName, DogAge, DogColor, DogType, Typey_ID)
VALUES
('Rick', 4, 'BrownWhite', 'Common', 2),
('Will', 6, 'BrownBlack', 'bloodhound', 2),
('Kill', 7, 'GraayBlack', 'wolfhound', 2),
('Saw', 4, 'Black', 'Common', 2),
('Way', 8, 'White', 'dachshund', 2);
GO

INSERT INTO RATS(RatName, RatAge, RatColor, RatType, Typey_ID)
VALUES
('Ratot', 1, 'Gray', 'Common', 3),
('Vink', 1, 'Black', 'Common', 3),
('Sobery', 1, 'Gray', 'Common', 3),
('Mombastic', 1, 'Black', 'Common', 3),
('Bombastic', 1, 'Black', 'Common', 3);
GO

INSERT INTO FROGS(FrogName, FrogAge, FrogColor, FrogType, Typey_ID)
VALUES
('Wobbly', 2, 'Green', 'Common', 4),
('Jiggly', 4, 'Purple', 'Common', 4),
('Amp', 1, 'White', 'Common', 4),
('Swag', 3, 'Golden', 'Uncommon', 4),
('Gro', 2, 'Black', 'Common', 4);
GO

INSERT INTO BIRDS(BirdName, BirdAge, BirdColor, BirdType, Typey_ID)
VALUES
('Chik', 4, 'Blue', 'Pigeon', 5),
('Chirik', 3, 'Purple', 'Pigeon', 5),
('Damn', 2, 'White', 'Pigeon', 5),
('Ohai', 1, 'Golden', 'Pigeon', 5),
('Yong', 3, 'Black', 'Pigeon', 5);
GO

INSERT INTO TOOLS(ToolName, ToolType, HowMuchTool)
VALUES
('Amputator', 'Scissors', 4),
('Pliers', 'Pliers', 3),
('Dispensers', 'Givver', 17),
('DisinfectantMats', 'Mats', 10),
('TestTubes', 'Bottle', 5);
GO

INSERT INTO CLIENTS(ClientName, ClientSureName, ClientFather, ClientMail, ClientBuyNumber)  
VALUES
('Big', 'Papa', 'Pickle', 'garbage555@gmail.com', 253723),  
('Kim', 'Jong', 'Un', 'clownboot@gmail.com', 413413413),  
('Dekma', 'Alpha', 'Wolf', 'runningwscissors3312@gmail.com', 1488305),  
('John', 'Ridiculous', 'Doe', 'ateurwiener@gmail,com', 83209621),  
('Dave', 'Adolf', 'Strider', 'blindcavesalamander@gmail.com', 78928524);  
GO

INSERT INTO Points(WLocation, Clients_ID)
VALUES
('Moscow', 3),
('Piter', 4),
('Iraq', 2),
('America', 1),
('Canada', 5);
GO

INSERT INTO FOOD(FoodName, FoodType, HowMuch)
VALUES
('Viskas', 'CatFood', 37),
('DryFood', 'AllFood', 25),
('Burger', 'WorkerFood', 17),
('Seeds', 'BirdFood', 87),
('Potato', 'AllFood', 37);
GO

INSERT INTO LivePointsForWorkers(LivePointLocation, HowMuchComfrotable, FoodAtLeast)
VALUES
('Moscow', 10, 'Yes'),
('Piter', 9, 'Yes'),
('Iraq', 2, 'No'),
('America', 8, 'Yes'),
('Canada', 10, 'Yes');
GO

INSERT INTO BuyMoments(Food_ID, Tools_ID, LivePointsForWorkers_ID, Animals_ID)
VAlUES
(1, 1, 1, 1),
(2, 2, 2, 2),
(3, 3, 3, 3),
(4, 4, 4, 4),
(5, 5, 5, 5);
GO

INSERT INTO Orders(OrderData, HowManyAnimals, TypeOfAnimal, SterilizationOrCastrationNeed, Client_ID, Points_ID)
VALUES
('31.05.2024', 5, 'Rat', 'Yes', 3, 2),
('1.06.2024', 1, 'Dog', 'No', 1, 3),
('2.06.2024', 8, 'Cat', 'Yes', 4, 5),
('3.06.2024', 7, 'Bird', 'No', 5, 1),
('4.06.2024', 4, 'Frog', 'Yes', 2, 4);
GO

INSERT INTO Workers(WorkName, WorkSureName, WorkMiddleName, WorkMail, WorkLivePoint_ID, Points_ID)
VALUES
('Jimmy', 'Neitron', 'Bobovich', 'broitsn@gmail.com', 3, 3),
('Game', 'Net', 'WroomWroomovich', 'wroomwroom@gmail.com', 2, 2),
('Watson', 'Wassup', 'Kisserovich', 'boykisser@gmail.com', 1, 1),
('Mutilated', 'Face', 'Dekmivovich', 'dekma@gmail.com', 5, 5),
('Zeig', 'Dich', 'Rammsteionovich', 'rammstein@gmail.com', 4, 4);
GO