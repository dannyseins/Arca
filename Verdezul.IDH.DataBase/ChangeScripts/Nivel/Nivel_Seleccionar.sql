IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Seleccionar')
	BEGIN
		DROP  Procedure  Nivel_Seleccionar
	END

GO

CREATE Procedure Nivel_Seleccionar
	@Id int
AS
	SELECT * FROM Nivel where (Id = @Id or @Id = 0)
GO

EXEC Nivel_Seleccionar 1
GO 
