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
 