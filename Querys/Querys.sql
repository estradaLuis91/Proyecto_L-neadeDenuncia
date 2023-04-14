USE [Linea_Denuncia]

/********países************/
CREATE TABLE dbo.Countrys(
Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Short_name nvarchar(5) NOT NULL,
Complete_name nvarchar(50) NOT NULL
)
/********INSERTS************/
INSERT INTO  dbo.Countrys VALUES('ARG','ARGENTINA')
INSERT INTO  dbo.Countrys VALUES('EUA','ESTADOS UNIDOS')
INSERT INTO  dbo.Countrys VALUES('MEX','MÉXICO')
INSERT INTO  dbo.States VALUES(1,'Buenos Aires')
INSERT INTO  dbo.States VALUES(2,'California')
INSERT INTO  dbo.States VALUES(3,'Aguscalientes')
INSERT INTO  dbo.States VALUES(3,'Campeche')
INSERT INTO  dbo.States VALUES(3,'Cdmx')

/********estados************/
CREATE TABLE dbo.States(
Country_Id int FOREIGN KEY REFERENCES dbo.Countrys(Id) NOT NULL,
Name nvarchar(80) NOT NULL,
Id int IDENTITY(1,1) NOT NULL PRIMARY KEY
)
/********Denuncia************/

CREATE TABLE dbo.Denuncia(
Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
EO_id int  NOT NULL,
Country_id int  NOT NULL,
State_id int  NOT NULL,
Anonim nvarchar(10) NOT NULL,
Complete_Name nvarchar(200) NULL,
Email nvarchar(200) NULL,
Phone nvarchar(15) NULL,
Folio nvarchar(100) NOT NULL,
Create_Date datetime NOT NULL,
User_Password nvarchar(20) NOT NULL	,
Detalle nvarchar(500) NOT NULL	
)
/********Status de denuncia************/
CREATE TABLE dbo.Status_Denuncia(
Denuncia_Id int FOREIGN KEY REFERENCES dbo.Denuncia(Id) NOT NULL,
Status nvarchar(15) NULL,
Comentarios nvarchar(200) NULL 
)
