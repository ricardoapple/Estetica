Use Estetica;
go

-------------------------------------------------------------------------------------------------------------
--Primero se crea la parte Geografica Pais,Provincia,Poblacion
CREATE TABLE Country
(
IdCountry int,
CountryName varchar(50),
Status bit,

CONSTRAINT PK_Country_IdCountry PRIMARY KEY(IdCountry), --Llave Primaria
)
GO
-------------------------------------------------------------------------------------------------------------
CREATE TABLE Province
(
IdProvince int, --Llave Primaria
IdCountry int, --Llave Foranea
ProvinceName varchar(50),
RegistrationDate datetime,
Statusdate datetime,
Status bit,

CONSTRAINT PK_Province_IdProvince PRIMARY KEY(IdProvince), --Llave Primaria
CONSTRAINT FK_Province_IdCountry FOREIGN KEY (IdCountry) REFERENCES Country(IdCountry)--Crear llave Foranea

)
GO
-------------------------------------------------------------------------------------------------------------
CREATE TABLE Town
(
IdTown int, --Llave Primaria
IdProvince int , --Llave Foranea
TownName varchar(50),
Status bit

CONSTRAINT PK_Town_IdTown PRIMARY KEY(IdTown), --Llave Primaria

CONSTRAINT FK_Town_IdProvince FOREIGN KEY (IdProvince) REFERENCES Province(IdProvince)--Crear llave Foranea
)
GO
-------------------------------------------------------------------------------------------------------------
CREATE TABLE UserRol
(
  IdUserRol int,
  NameRol varchar(60) Unique NOT NULL,

CONSTRAINT PK_Rol_IdUserRol PRIMARY KEY(IdUserRol), --Llave Primaria
)
GO
-------------------------------------------------------------------------------------------------------------
CREATE TABLE Users
(
  IdUsers int NOT NULL,
  IdUserRol int  NOT NULL,
  IdTown int  NOT NULL,
  Email varchar(60) NOT NULL,
  Password varchar(100)  NOT NULL,  
  CreatedAt Datetime,
  UpdatedAt Datetime ,
  UserName varchar(60)  NOT NULL,
  Url varchar(Max)  NOT NULL,
  UserPassword_hash varbinary(Max) ,
  UserPassword_salt varbinary(Max) , 
  TimeStam Datetime,
  Status bit

  CONSTRAINT PK_Users_IdUsers PRIMARY KEY(IdUsers), --Llave Primaria
  CONSTRAINT FK_Users_IdUserRol FOREIGN KEY (IdUserRol) REFERENCES UserRol(IdUserRol),--Crear llave Foranea
  CONSTRAINT FK_Users_IdTown FOREIGN KEY (IdTown) REFERENCES Town(IdTown),--Crear llave Foranea
) 
GO
-------------------------------------------------------------------------------------------------------------