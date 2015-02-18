IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Parametro_Seleccionar')
	BEGIN
		DROP  Procedure  Parametro_Seleccionar
	END

GO

CREATE Procedure Parametro_Seleccionar
	@Id int
AS
	SELECT * FROM Parametro where (Id = @Id or @Id = 0)
GO

EXEC Parametro_Seleccionar 0
GO
