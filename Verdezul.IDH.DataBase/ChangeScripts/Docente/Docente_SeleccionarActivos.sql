IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Docente_SeleccionarActivos')
	BEGIN
		DROP  Procedure  Docente_SeleccionarActivos
	END

GO

CREATE Procedure Docente_SeleccionarActivos
AS
	SELECT * 
	FROM Docente
	WHERE Activo = 1
	
	RETURN 0
GO

EXEC Docente_SeleccionarActivos
GO
  