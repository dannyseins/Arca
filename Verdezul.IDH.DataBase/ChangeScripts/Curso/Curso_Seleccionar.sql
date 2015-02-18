IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Curso_Seleccionar')
	BEGIN
		DROP  Procedure  Curso_Seleccionar
	END

GO

CREATE Procedure Curso_Seleccionar
	@Id int
AS
	SELECT * FROM Curso where (Id = @Id or @Id = 0)
GO

EXEC Curso_Seleccionar 1
GO 
