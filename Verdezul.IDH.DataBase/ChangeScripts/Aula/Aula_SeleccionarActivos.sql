IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Aula_SeleccionarActivos')
	BEGIN
		DROP  Procedure  Aula_SeleccionarActivos
	END

GO

CREATE Procedure Aula_SeleccionarActivos
AS
	SELECT * 
	FROM Aula
	WHERE Activo = 1
	
	RETURN 0
GO

EXEC Aula_SeleccionarActivos
GO



   