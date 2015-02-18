IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Area_Modificar')
	BEGIN
		DROP  Procedure  Area_Modificar
	END
GO

CREATE Procedure Area_Modificar
	@Id int,
    @Nombre varchar(32)
AS
	UPDATE Area SET
		Nombre = @Nombre
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Area_Modificar 18, 'NombreCompleto2'
--GO

 