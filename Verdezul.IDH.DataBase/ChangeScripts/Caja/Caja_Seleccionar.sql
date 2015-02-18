IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Caja_Seleccionar')
	BEGIN
		DROP  Procedure  Caja_Seleccionar
	END

GO

CREATE Procedure Caja_Seleccionar
	@Id int
AS
	SELECT * FROM Caja where (Id = @Id or @Id = 0)
GO

EXEC Caja_Seleccionar 0
GO
