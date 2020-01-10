use master
go
if DB_id('MediSoft')is not null
	Drop database MediSoft
go
CREATE DATABASE MediSoft
go
USE MediSoft
go
create table Secretaria(
	Id_Secretaria			int identity(1,1)	not null,
	Nombre					varchar(30)			not null,
	Cedula					varchar(10)			not null,
	constraint PK_Sc primary key  (Id_Secretaria)
)
go
create table Doctor(
	Id_Doctor				int identity(1,1)	not null,
	Nombre					varchar(30)			not null,
	Cedula					varchar(10)			not null,
	Especialidad			varchar(30)			not null,
	constraint PK_Doc primary key  (Id_Doctor),
)
go
create table Paciente(
	Id_Paciente				int identity(1,1)	not null,
	Cedula					varchar(10)			not null,
	Nombres					varchar(30)			not null,
	Apellidos				varchar(30)			not null,
	Sexo					varchar(10)			not null,
	FechaNacimiento			date				not null,
	Edad					int					not null,
	constraint PK_Pc primary key  (Id_Paciente)
)
go
create table HistoriaClinica (
   Id_HistoriaClinica       int identity(1,1)    not null,
   Id_Paciente				int					 not null,
   constraint PK_HC primary key  (Id_HistoriaClinica),
   constraint FK_Pc foreign key (Id_Paciente) references Paciente(Id_Paciente)
)
go
create table CitaMedica(
	Id_CitaMedica				int identity(1,1)	not null,
	Id_Secretaria				int					not null,
	Id_Doctor					int					not null,
	Id_HC						int					not null,
	Fecha						date				not null,
	constraint PK_CM primary key (Id_CitaMedica),
	constraint FK_CMDoc foreign key (Id_Doctor) references Doctor(Id_Doctor),
	constraint FK_CMSc foreign key (Id_Secretaria) references Secretaria(Id_Secretaria),
	constraint FK_HCCM foreign key (Id_HC) references HistoriaClinica(Id_HistoriaClinica)
)
go
create table Diagnostico(
	Id_Diagnostico			int identity(1,1)	not null,
	Id_CitaMedica			int					not null,
	constraint PK_Dg primary key  (Id_Diagnostico),
	constraint FK_HC foreign key (Id_CitaMedica) references CitaMedica(Id_CitaMedica)
)
go
create table SignosVitales(
	Id_SignoVital			int identity(1,1)		not null,
	Id_CitaMedica			int						not null,
	Altura					float					not null,
	Peso					float					not null,
	Temperatura				float					not null,
	PresionA				float					not null,
	PresionB				float					not null,
	RitmoCardiaco			float					not null,
	Saturacion				float					not null,
	constraint PK_SV primary key  (Id_SignoVital),
	constraint FK_SVCM foreign key (Id_CitaMedica) references CitaMedica(Id_CitaMedica)
)
go
create table RecetaMedica(
	Id_Receta				int identity(1,1)	not null,
	Id_CitaMedica			int					not null,
	constraint PK_RM primary key  (Id_Receta),
	constraint FK_RMCM foreign key (Id_CitaMedica) references CitaMedica(Id_CitaMedica)
)
go
create table Medicamento(
	Id_Medicamento				int identity(1,1)		not null,
	Id_Receta					int						not null,
	constraint PK_M primary key  (Id_Medicamento),
	constraint FK_MRM foreign key (Id_Receta) references RecetaMedica(Id_Receta)
)
go

insert into Secretaria values ('Karla Robles','1718192021')
go
insert into Doctor values ('Ramiro Yanez','1718857326','Medico General')
go
insert into Paciente values ('1718657525','Pedro Pablo','Paramo Gutierrez','Masculino','1997-2-23',23)
go
insert into HistoriaClinica values (1)
go
insert into CitaMedica values (1,1,1,'2020-1-6')
go
insert into Diagnostico values (1)
go
insert into SignosVitales values (1,155,57.4,37,105,88,96,100)
go
insert into RecetaMedica values (1)
go
insert into Medicamento values (1)
go

GO  
CREATE PROCEDURE [dbo].[AgregarPaciente]
	@Cedula					varchar(10),
	@Nombres				varchar(30),
	@Apellidos				varchar(30),
	@Sexo					varchar(10),
	@FechaNacimiento		date		,
	@Edad					int,
	@mensaje				varchar(100) OUTPUT
AS   
BEGIN
    SET NOCOUNT ON;
	INSERT INTO Paciente VALUES(@Cedula,@Nombres,@Apellidos,@Sexo,@FechaNacimiento,@Edad);
	if @@ERROR = 0
		set @mensaje = 'Hubo error insertando a la persona';
	else
		set @mensaje = @Nombres + @Apellidos + 'Fue insertado exitosamente';
END
GO 

 
select * from Paciente
