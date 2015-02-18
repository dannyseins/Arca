IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Rubro_Seleccionar')
	BEGIN
		DROP  Procedure  Rubro_Seleccionar
	END

GO

CREATE Procedure Rubro_Seleccionar
	@Id int
AS
	SELECT * FROM Rubro where (Id = @Id or @Id = 0)
GO

EXEC Rubro_Seleccionar 1
GO
