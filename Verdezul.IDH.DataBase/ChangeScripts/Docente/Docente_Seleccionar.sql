IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Docente_Seleccionar')
	BEGIN
		DROP  Procedure  Docente_Seleccionar
	END

GO

CREATE Procedure Docente_Seleccionar
	@Id int
AS
	SELECT * FROM Docente where (Id = @Id or @Id = 0)
GO

EXEC Docente_Seleccionar 1
GO 
