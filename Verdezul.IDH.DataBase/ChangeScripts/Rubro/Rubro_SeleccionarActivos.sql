IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Rubro_SeleccionarActivos')
	BEGIN
		DROP  Procedure  Rubro_SeleccionarActivos
	END

GO

CREATE Procedure Rubro_SeleccionarActivos
AS
	SELECT * 
	FROM Rubro
	WHERE Activo = 1
	
	RETURN 0
GO

EXEC Rubro_SeleccionarActivos
GO
