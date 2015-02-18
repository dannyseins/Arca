USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Borrar')
	BEGIN
		DROP  Procedure  Nivel_Borrar
	END
GO

CREATE Procedure Nivel_Borrar
	@Id int
AS
	DELETE FROM Nivel
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Nivel_Borrar 21
--GO
 USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Insertar')
	BEGIN
		DROP  Procedure  Nivel_Insertar
	END
GO

CREATE Procedure Nivel_Insertar
	@Id int out,
	@IdArea int,
    @Nombre varchar(32)
AS
	INSERT INTO Nivel
		(IdArea, Nombre)
	VALUES
		(@IdArea, @Nombre)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Nivel_Insertar @Id out, 'NombreCompleto1'
--SELECT @Id
--GO
 USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Modificar')
	BEGIN
		DROP  Procedure  Nivel_Modificar
	END
GO

CREATE Procedure Nivel_Modificar
	@Id int,
	@IdArea int,
    @Nombre varchar(32)
AS
	UPDATE Nivel SET
		IdArea = @IdArea,
		Nombre = @Nombre
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Nivel_Modificar 18, 'NombreCompleto2'
--GO
 USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Seleccionar')
	BEGIN
		DROP  Procedure  Nivel_Seleccionar
	END

GO

CREATE Procedure Nivel_Seleccionar
	@Id int
AS
	SELECT * FROM Nivel where (Id = @Id or @Id = 0)
GO

EXEC Nivel_Seleccionar 1
GO USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Borrar')
	BEGIN
		DROP  Procedure  Nivel_Borrar
	END
GO

CREATE Procedure Nivel_Borrar
	@Id int
AS
	DELETE FROM Nivel
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Nivel_Borrar 21
--GO
 USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Insertar')
	BEGIN
		DROP  Procedure  Nivel_Insertar
	END
GO

CREATE Procedure Nivel_Insertar
	@Id int out,
	@IdArea int,
    @Nombre varchar(32)
AS
	INSERT INTO Nivel
		(IdArea, Nombre)
	VALUES
		(@IdArea, @Nombre)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Nivel_Insertar @Id out, 'NombreCompleto1'
--SELECT @Id
--GO
 USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Modificar')
	BEGIN
		DROP  Procedure  Nivel_Modificar
	END
GO

CREATE Procedure Nivel_Modificar
	@Id int,
	@IdArea int,
    @Nombre varchar(32)
AS
	UPDATE Nivel SET
		IdArea = @IdArea,
		Nombre = @Nombre
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Nivel_Modificar 18, 'NombreCompleto2'
--GO
 USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Seleccionar')
	BEGIN
		DROP  Procedure  Nivel_Seleccionar
	END

GO

CREATE Procedure Nivel_Seleccionar
	@Id int
AS
	SELECT * FROM Nivel where (Id = @Id or @Id = 0)
GO

EXEC Nivel_Seleccionar 1
GO USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Borrar')
	BEGIN
		DROP  Procedure  Nivel_Borrar
	END
GO

CREATE Procedure Nivel_Borrar
	@Id int
AS
	DELETE FROM Nivel
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Nivel_Borrar 21
--GO
 USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Insertar')
	BEGIN
		DROP  Procedure  Nivel_Insertar
	END
GO

CREATE Procedure Nivel_Insertar
	@Id int out,
	@IdArea int,
    @Nombre varchar(32)
AS
	INSERT INTO Nivel
		(IdArea, Nombre)
	VALUES
		(@IdArea, @Nombre)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Nivel_Insertar @Id out, 'NombreCompleto1'
--SELECT @Id
--GO
 USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Modificar')
	BEGIN
		DROP  Procedure  Nivel_Modificar
	END
GO

CREATE Procedure Nivel_Modificar
	@Id int,
	@IdArea int,
    @Nombre varchar(32)
AS
	UPDATE Nivel SET
		IdArea = @IdArea,
		Nombre = @Nombre
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Nivel_Modificar 18, 'NombreCompleto2'
--GO
 USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Seleccionar')
	BEGIN
		DROP  Procedure  Nivel_Seleccionar
	END

GO

CREATE Procedure Nivel_Seleccionar
	@Id int
AS
	SELECT * FROM Nivel where (Id = @Id or @Id = 0)
GO

EXEC Nivel_Seleccionar 1
GO USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Borrar')
	BEGIN
		DROP  Procedure  Nivel_Borrar
	END
GO

CREATE Procedure Nivel_Borrar
	@Id int
AS
	DELETE FROM Nivel
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Nivel_Borrar 21
--GO
 USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Insertar')
	BEGIN
		DROP  Procedure  Nivel_Insertar
	END
GO

CREATE Procedure Nivel_Insertar
	@Id int out,
	@IdArea int,
    @Nombre varchar(32)
AS
	INSERT INTO Nivel
		(IdArea, Nombre)
	VALUES
		(@IdArea, @Nombre)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Nivel_Insertar @Id out, 'NombreCompleto1'
--SELECT @Id
--GO
 USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Modificar')
	BEGIN
		DROP  Procedure  Nivel_Modificar
	END
GO

CREATE Procedure Nivel_Modificar
	@Id int,
	@IdArea int,
    @Nombre varchar(32)
AS
	UPDATE Nivel SET
		IdArea = @IdArea,
		Nombre = @Nombre
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Nivel_Modificar 18, 'NombreCompleto2'
--GO
 USE Caja.Datos
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Seleccionar')
	BEGIN
		DROP  Procedure  Nivel_Seleccionar
	END

GO

CREATE Procedure Nivel_Seleccionar
	@Id int
AS
	SELECT * FROM Nivel where (Id = @Id or @Id = 0)
GO

EXEC Nivel_Seleccionar 1
GO 