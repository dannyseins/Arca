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
 