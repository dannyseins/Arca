IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_SeleccionarActivos')
	BEGIN
		DROP  Procedure  Horario_SeleccionarActivos
	END

GO

CREATE Procedure Horario_SeleccionarActivos
AS
	SELECT * 
	FROM Horario
	WHERE Activo = 1
	
	RETURN 0
GO

EXEC Horario_SeleccionarActivos
GO
