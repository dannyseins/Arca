IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_Borrar')
	BEGIN
		DROP  Procedure  Horario_Borrar
	END
GO

CREATE Procedure Horario_Borrar
	@Id int
AS
	DELETE FROM Horario
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Horario_Borrar 21
--GO
 