IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_Seleccionar')
	BEGIN
		DROP  Procedure  Horario_Seleccionar
	END

GO

CREATE Procedure Horario_Seleccionar
	@Id int
AS
	SELECT * FROM Horario where (Id = @Id or @Id = 0)
GO

EXEC Horario_Seleccionar 0
GO  
