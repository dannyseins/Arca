IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Observacion_Borrar')
	BEGIN
		DROP  Procedure  Observacion_Borrar
	END
GO

CREATE Procedure Observacion_Borrar
	@Id int
AS
	DELETE FROM Observacion
	WHERE Id = @Id
	
	RETURN 0
GO

EXEC Observacion_Borrar 5
GO
