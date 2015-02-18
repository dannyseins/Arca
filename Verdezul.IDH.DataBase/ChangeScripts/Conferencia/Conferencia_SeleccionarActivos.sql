IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Conferencia_SeleccionarActivos')
	BEGIN
		DROP  Procedure  Conferencia_SeleccionarActivos
	END

GO

CREATE Procedure Conferencia_SeleccionarActivos
AS
	SELECT * 
	FROM Conferencia
	WHERE Activo = 1
	
	RETURN 0
GO

EXEC Conferencia_SeleccionarActivos
GO
 