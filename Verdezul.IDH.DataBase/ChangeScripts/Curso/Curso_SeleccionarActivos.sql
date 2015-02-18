IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Curso_SeleccionarActivos')
	BEGIN
		DROP  Procedure  Curso_SeleccionarActivos
	END

GO

CREATE Procedure Curso_SeleccionarActivos
AS
	SELECT * 
	FROM Curso
	WHERE Activo = 'True'
	
	RETURN 0
GO

EXEC Curso_SeleccionarActivos
GO
