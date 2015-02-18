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
 