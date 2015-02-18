IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Curso_Borrar')
	BEGIN
		DROP  Procedure  Curso_Borrar
	END
GO

CREATE Procedure Curso_Borrar
	@Id int
AS
	DELETE FROM Curso
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Curso_Borrar 21
--GO
  