SET QUOTED_IDENTIFIER ON

go


/* Create Empresas database.                                                                  */
use master  

go

create database "BeLife"  

go

use "BeLife"  

go

/* Create new table "Sexo".                    */
create table "Sexo" ( 
	"IdSexo" int not null,
	"Descripcion" nvarchar(10) not null)  

go

alter table "Sexo"
	add constraint "Sexo_PK" primary key ("IdSexo")   


go

/* Create new table "EstadoCivil".             */
create table "EstadoCivil" ( 
	"IdEstadoCivil" int not null,
	"Descripcion" nvarchar(15) not null)  

go

alter table "EstadoCivil"
	add constraint "EstadoCivil_PK" primary key ("IdEstadoCivil")   


go

/* Create new table "Cliente".                 */
create table "Cliente" ( 
	"RutCliente" nvarchar(10) not null,
	"Nombres" nvarchar(20) not null,
	"Apellidos" nvarchar(20) not null,
	"FechaNacimiento" nvarchar(20) not null,
	"IdSexo" int not null, 
	"IdEstadoCivil" int not null,)  

go

alter table "Cliente"
	add constraint "Cliente_PK" primary key ("RutCliente")   


go

/* Add foreign key constraints to table "Cliente".                                           */
alter table "Cliente"
	add constraint "Cliente_Sexo_FK1" foreign key (
		"IdSexo")
	 references "Sexo" (
		"IdSexo") on update no action on delete no action  

go

alter table "Cliente"
	add constraint "Cliente_EstadoCivil_FK1" foreign key (
		"IdEstadoCivil")
	 references "EstadoCivil" (
		"IdEstadoCivil") on update no action on delete no action  

go

CREATE TABLE "Contrato"(
	"numContrato" nvarchar(20) not null,
	"fechaCreacion" datetime not null,
	"fechaTermino" datetime not null,
	"RutCliente" nvarchar(10) not null,
	"planAsociado" nvarchar(10) not null,
	"poliza" int not null,
	"fechaInicioVig" datetime not null,
	"fechaTerminoVig" datetime not null,
	"estaVig" bit not null,
	"conDeclaracionDeSalud" bit not null,
	"primaAnual" decimal not null,
	"primaMensual" decimal not null,
	"observaciones" nvarchar(50) not null
	)
go

ALTER TABLE "Contrato" WITH NOCHECK
	ADD CONSTRAINT "Contrato_PK" primary key ("numContrato"),  
	CONSTRAINT "Contrato_Cliente_FK" foreign key ("RutCliente")
	references "Cliente" ("RutCliente") on update no action on delete no action  
		
go


/* Registros de Sexo */

INSERT INTO [BeLife].[dbo].[Sexo] VALUES (1,'Hombre')
INSERT INTO [BeLife].[dbo].[Sexo] VALUES (2,'Mujer')
go

/* Registros de EstadoCivil */

INSERT INTO [BeLife].[dbo].[EstadoCivil] VALUES (1,'Soltero')
INSERT INTO [BeLife].[dbo].[EstadoCivil] VALUES (2,'Casado')
INSERT INTO [BeLife].[dbo].[EstadoCivil] VALUES (3,'Divorciado')
INSERT INTO [BeLife].[dbo].[EstadoCivil] VALUES (4,'Viudo')
go

