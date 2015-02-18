IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Docente_Borrar')
	BEGIN
		DROP  Procedure  Docente_Borrar
	END
GO

CREATE Procedure Docente_Borrar
	@Id int
AS
	DELETE FROM Docente
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Docente_Borrar 21
--GO
  