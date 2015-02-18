IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Conferencia_Seleccionar')
	BEGIN
		DROP  Procedure  Conferencia_Seleccionar
	END

GO

CREATE Procedure Conferencia_Seleccionar
	@Id int
AS
	SELECT * FROM Conferencia where (Id = @Id or @Id = 0)
GO

EXEC Conferencia_Seleccionar 1
GO 
