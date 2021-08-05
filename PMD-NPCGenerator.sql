Create table Ability(
	AbilityId int IDENTITY(1,1) PRIMARY KEY,
	Name Varchar(50) NOT NULL,
	AbilityType int NOT NULL,
	Frequency Varchar(50),
	Effect1 Text NOT NULL,
	Target Varchar(20),
	Keywords Varchar(50),
	Effect2 Text,
);
Create Table Move(
	MoveId int IDENTITY(1,1) PRIMARY KEY,
	MoveName varchar(30),
	Type varchar(10),
	Category varchar(10),
	DamageBase int,
	Frequency varchar(10),
	Accuracy int,
	Range varchar(20),
	Effects Text,
);
Create Table Pokemon(
	PokemonId int IDENTITY(1,1) PRIMARY KEY,
	Species varchar(20) NOT NULL,
	Image varbinary(max),
	Gender varchar(10),
	Type1 varchar(10) NOT NULL,
	Type2 varchar(10),
	HP int,
	Attack int,
	Defense int,
	SPAttack int,
	SPDefense int,
	Speed int,
	Overland int,
	Sky int,
	Swim int,
	Levitate int,
	Burrow int,
	Highjump int,
	Longjump int,
	Power int,
	Size int,
	Weight int,
	Acrobatics varchar(5),
	Athleticts  varchar(5),
	Charm varchar(5),
	Combat varchar(5),
	Command varchar(5),
	GenEd varchar(5),
	MedEd varchar(5),
	OccEd varchar(5),
	PokeEd varchar(5),
	TechEd varchar(5),
	Focus varchar(5),
	Guile varchar(5),
	Intimidate varchar(5),
	Intuition varchar(5),
	Perception varchar(5),
	Stealth varchar(5),
	Survival varchar(5),
);
Create Table LearnableMoves(
	LearnableMoveId int IDENTITY(1,1) PRIMARY KEY,
	PokemonId int FOREIGN KEY REFERENCES Pokemon(PokemonId),
	MoveId int FOREIGN KEY REFERENCES Move(MoveId),
	LearnMethod Text,
	LearnLevel int
);
Select * From Move;
Select * From Ability;
Select * from Pokemon;
Select * from LearnableMoves;
Drop table LearnableMoves;
Drop table Ability;
Drop table Pokemon;
Drop table Move;
