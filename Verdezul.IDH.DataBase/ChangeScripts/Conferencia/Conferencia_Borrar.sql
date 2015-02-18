IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Conferencia_Borrar')
	BEGIN
		DROP  Procedure  Conferencia_Borrar
	END
GO

CREATE Procedure Conferencia_Borrar
	@Id int
AS
	DELETE FROM Conferencia
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Conferencia_Borrar 21
--GO
 