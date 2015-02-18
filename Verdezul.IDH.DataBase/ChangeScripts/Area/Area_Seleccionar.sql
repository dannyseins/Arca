IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Area_Seleccionar')
	BEGIN
		DROP  Procedure  Area_Seleccionar
	END

GO

CREATE Procedure Area_Seleccionar
	@Id int
AS
	SELECT * FROM Area where (Id = @Id or @Id = 0)
GO

EXEC Area_Seleccionar 1
GO 
