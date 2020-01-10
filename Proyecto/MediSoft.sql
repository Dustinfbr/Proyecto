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
   Alergias					varchar(200)		 not null,
   Enfermedades				varchar(300)		 not null,
   constraint PK_HC primary key  (Id_HistoriaClinica),
   constraint FK_Pc foreign key (Id_Paciente) references Paciente(Id_Paciente)
)
go
--Procedimiento Agregar Historia Clinica
go
create proc agregarHC(
@CIPaciente		varchar(10),
@Alergia		varchar(200),
@Enfermedades	varchar(300)
)as
begin
	declare @Paciente int;
	select @Paciente = Id_Paciente from Paciente where Cedula = @CIPaciente;
	insert into HistoriaClinica values (@Paciente,@Alergia,@Enfermedades);
end
go
--Procedimiento Mostrar alergias
create proc MostrarA(
@CI varchar(10),
@Alergia varchar(100) OUTPUT
)
as
begin
	SET NOCOUNT ON;
	declare @Paciente int;
	select @Paciente = Id_Paciente from Paciente where Cedula = @CI; 
	declare @select varchar(100);
    select @select =Alergias from HistoriaClinica where Id_Paciente = @Paciente;
	set @Alergia = @select;
end
go
-- Mostrar Enfermedades
create proc MostrarE(
@CI varchar(10),
@Enfermedades varchar(300) output
)
as
begin
	declare @Paciente int;
	select @Paciente = Id_Paciente from Paciente where Cedula = @CI;
	declare @select varchar(300); 
	select @select=Enfermedades from HistoriaClinica where Id_Paciente = @Paciente;
	set @Enfermedades = @select;
end
go
-- Procedimiento Modificar
create proc modificarHC(
@CIPaciente		varchar(10),
@Alergia		varchar(200),
@Enfermedades	varchar(300)
)as
begin
	declare @Paciente int;
	select @Paciente = Id_Paciente from Paciente where Cedula = @CIPaciente;
	update HistoriaClinica set Alergias=@Alergia,Enfermedades=@Enfermedades where Id_Paciente = @Paciente;
end
--Eliminar HC
go
create proc eliminarHC(
@CIPaciente		varchar(10)
)as
begin
	declare @Paciente int;
	select @Paciente = Id_Paciente from Paciente where Cedula = @CIPaciente;
	delete HistoriaClinica where Id_Paciente = @Paciente;
end
go
CREATE Procedure listarHC
as
begin
 select * from HistoriaClinica;
end
select * from HistoriaClinica;
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
/*create table Medicamento(
	Id_Medicamento				int identity(1,1)		not null,
	Id_Receta					int						not null,
	constraint PK_M primary key  (Id_Medicamento),
	constraint FK_MRM foreign key (Id_Receta) references RecetaMedica(Id_Receta)
)
go*/
create table Medicamento(
	Id_Medicamento				int identity(1,1)		not null,
	Id_Receta					int						not null,
	Nombre						varchar(40)				not null,
	Dosis						varchar(40)				not null,
	constraint PK_M primary key  (Id_Medicamento)
)
go



 CREATE Procedure ingresarMed
(
 @Id_Receta int,
 @Nombre varchar(10),
 @Dosis int
)
as
begin
 insert into Medicamento values (@Id_Receta,@Nombre,@Dosis)
end
GO
CREATE Procedure listarMed
as
begin
 select * from Medicamento
end

GO
CREATE procedure eliminarMed
(
@Id_Receta int,
 @Nombre varchar(10),
 @Dosis int
)
as
delete  from Medicamento
 where @Id_Receta = Id_Receta
 and @Nombre = Nombre
 and @Dosis = Dosis
GO


CREATE procedure actualizarMed
(
@Id_Receta int,
 @Nombre varchar(10),
 @Dosis int
) 
as
update Medicamento 
set @Dosis = Dosis
where @Id_Receta = Id_Receta
GO
insert into Secretaria values ('Karla Robles','1718192021')
go
insert into Doctor values ('Ramiro Yanez','1718857326','Medico General')
go
insert into Paciente values ('1718657525','Pedro Pablo','Paramo Gutierrez','Masculino','1997-2-23',23)
go
insert into HistoriaClinica values (1,'polvo','diabetes')
go
insert into CitaMedica values (1,1,1,'2020-1-6')
go
insert into Diagnostico values (1)
go
insert into SignosVitales values (1,155,57.4,37,105,88,96,100)
go
insert into RecetaMedica values (1)
go
select * from Medicamento;
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
CREATE Procedure listarPacientes
as
begin
 select * from Paciente;
end
 
select * from Paciente
