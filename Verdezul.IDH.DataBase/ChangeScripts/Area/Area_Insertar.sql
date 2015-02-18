IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Area_Insertar')
	BEGIN
		DROP  Procedure  Area_Insertar
	END
GO

CREATE Procedure Area_Insertar
	@Id int out,
    @Nombre varchar(32)
AS
	INSERT INTO Area
		(Nombre)
	VALUES
		(@Nombre)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Area_Insertar @Id out, 'NombreCompleto1'
--SELECT @Id
--GO

 