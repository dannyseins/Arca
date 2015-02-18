IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Aula_Borrar')
	BEGIN
		DROP  Procedure  Aula_Borrar
	END
GO

CREATE Procedure Aula_Borrar
	@Id int
AS
	DELETE FROM Aula
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Aula_Borrar 21
--GO
  