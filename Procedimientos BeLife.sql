CREATE PROCEDURE dbo.AgregarCliente


@nombre nvarchar (20),
@apellidos nvarchar (20),
@rut nvarchar (10),
@fechaNacimiento Datetime,
@idSexo tinyint,
@idEcivil tinyint


AS
BEGIN

INSERT INTO BeLife.dbo.Cliente
(RutCliente,Nombres,Apellidos,FechaNacimiento,IdSexo,IdEstadoCivil)

VALUES (@rut,@nombre,@apellidos,@fechaNacimiento,@idSexo,@idEcivil)


END;
go

CREATE PROCEDURE dbo.AgregarContrato

	@numContrato nvarchar(20),
	@fechaCreacion datetime ,
	@fechaTermino datetime  ,
	@titular nvarchar(10)  ,
	@planAsociado nvarchar(10) ,
	@poliza int  ,
	@fechaInicioVig datetime ,
	@fechaTerminoVig datetime,
	@estaVig bit,
	@conDeclaracionDeSalud bit,
	@primaAnual decimal,
	@primaMensual decimal,
	@observaciones nvarchar(50)

AS
BEGIN

INSERT INTO BeLife.dbo.Contrato
(numContrato,fechaCreacion,fechaTermino,planAsociado,poliza,fechaInicioVig,
fechaTerminoVig,estaVig,conDeclaracionDeSalud,primaAnual,primaMensual,observaciones,RutCliente)

VALUES (@numContrato,@fechaCreacion,@fechaTermino,@planAsociado,@poliza,@fechaInicioVig,
@fechaTerminoVig,@estaVig,@conDeclaracionDeSalud,@primaAnual,@primaMensual,@observaciones,@titular)

END;

go

CREATE PROCEDURE dbo.ComboTitularFill
AS
BEGIN

SELECT RutCliente
FROM Cliente
END;

go

CREATE PROCEDURE ListadoClientes
AS
BEGIN

SELECT * FROM Cliente;
END;

go


CREATE PROCEDURE BuscarCliente

@rut nvarchar(10)
AS
BEGIN

select * from Cliente
where RutCliente=@rut;

END;
go

CREATE PROCEDURE ModificarCliente
@rut nvarchar(10),
@nombres nvarchar(20),
@apellidos nvarchar(20),
@fechaNacimiento datetime,
@idSexo tinyint,
@idEstadoCivil tinyint
AS
BEGIN

UPDATE Cliente
 set Nombres = @nombres ,
 Apellidos = @apellidos,
 FechaNacimiento= @fechaNacimiento,
 IdSexo=@idSexo,
 IdEstadoCivil=@idEstadoCivil
where RutCliente =@rut


END;
go

CREATE PROCEDURE EliminarCliente

@rut nvarchar(10)
AS
BEGIN

delete from Cliente where RutCliente=@rut;

END;
go

CREATE PROCEDURE CalcularRecargo
@rut nvarchar(10),
@recargo decimal output
AS
/*DECLARE c1 CURSOR 
FOR SELECT c.RutCliente FROM Contrato c JOIN Cliente cl
ON c.RutCliente = cl.RutCliente WHERE c.RutCliente=@rut
OPEN c1
FETCH NEXT FROM c1;*/
BEGIN

DECLARE @fecha datetime, 
	    @sexo tinyint , 
		@ecivil tinyint,
		@edad int
SELECT @fecha = cl.FechaNacimiento, 
	   @sexo = cl.IdSexo, 
	   @ecivil= cl.IdEstadoCivil 
	   FROM Contrato c JOIN Cliente cl
	   ON c.RutCliente = cl.RutCliente 
	   WHERE c.RutCliente=@rut




	   
SELECT @edad=
    (CONVERT(int,CONVERT(char(8),GETDATE(),112))-CONVERT(char(8),@fecha,112))/10000


	
	SELECT CASE 
	WHEN @edad >=18 and @edad <=25 THEN @recargo+3.6
	WHEN @edad >=26 and @edad <=45 THEN @recargo+2.4
	ELSE @recargo+6
	END

	SELECT CASE
	WHEN @sexo = 1 THEN @recargo+2.4
	ELSE @recargo+1.2
	END

	SELECT CASE
	WHEN @ecivil = 1 THEN @recargo+4.8
	WHEN @ecivil = 2 THEN @recargo+2.4
	ELSE @recargo+3.6
	END

	return @recargo

END;

go

CREATE PROCEDURE ListadoContratos
AS
BEGIN
SELECT * FROM Contrato;
END;
go


CREATE PROCEDURE ListadoContratosFiltroNro
@nroContrato nvarchar(20)
AS
BEGIN
SELECT * FROM Contrato WHERE numContrato=@nroContrato;
END;
go

CREATE PROCEDURE ListadoContratosFiltroRut
@rut nvarchar(10)
AS
BEGIN
SELECT * FROM Contrato c JOIN Cliente cl
ON cl.RutCliente = c.RutCliente WHERE c.RutCliente=@rut;
END;
go

CREATE PROCEDURE ListadoContratosFiltroPoliza
@poliza int
AS
BEGIN
SELECT * FROM Contrato WHERE poliza = @poliza;
END;
go

CREATE PROCEDURE TerminarContrato
@numContrato nvarchar(20)

AS
BEGIN

UPDATE Contrato
	SET estaVig= 0,
		fechaTermino= GETDATE(),
		fechaTerminoVig= GETDATE()
		WHERE numContrato = @numContrato
END;
go


CREATE PROCEDURE BuscarContrato
@numContrato nvarchar(20)

AS
BEGIN
SELECT * FROM Contrato WHERE numContrato=@numContrato

END;
go


CREATE PROCEDURE ModificarContrato
@numContrato nvarchar(20),
@plan nvarchar(10),
@declaracion bit,
@observaciones nvarchar(50)

AS
BEGIN

UPDATE Contrato
	SET planAsociado=@plan,
		conDeclaracionDeSalud=@declaracion,
		observaciones=@observaciones
		WHERE numContrato=@numContrato

END;
go


CREATE PROCEDURE ListadoClientesFiltroSexo
@idSexo tinyint

AS
BEGIN
SELECT * FROM Cliente WHERE idSexo = @idSexo

END;
go

CREATE PROCEDURE ListadoClientesFiltroEstados
@idEstadoCivil tinyint

AS
BEGIN
SELECT * FROM Cliente WHERE IdEstadoCivil = @idEstadoCivil

END;
go



