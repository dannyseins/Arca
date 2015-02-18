IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Area_SeleccionarConNiveles')
	BEGIN
		DROP  Procedure  Area_SeleccionarConNiveles
	END

GO

CREATE Procedure Area_SeleccionarConNiveles
	@IdArea int
AS

	SELECT	*
	FROM	Area
	WHERE	(Id = @IdArea OR @IdArea = 0)

	SELECT	*
	FROM	Nivel
	WHERE	(IdArea = @IdArea OR @IdArea = 0)

GO

EXEC Area_SeleccionarConNiveles 0
GO  

--EXEC Area_SeleccionarConNiveles 1
--GO  