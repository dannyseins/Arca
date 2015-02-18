IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Aula_Seleccionar')
	BEGIN
		DROP  Procedure  Aula_Seleccionar
	END

GO

CREATE Procedure Aula_Seleccionar
	@Id int
AS
	SELECT * FROM Aula where (Id = @Id or @Id = 0)
GO

EXEC Aula_Seleccionar 1
GO 
