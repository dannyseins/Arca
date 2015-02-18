IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_SeleccionarxIdNivelArea')
	BEGIN
		DROP  Procedure  Horario_SeleccionarxIdNivelArea
	END

GO

CREATE Procedure Horario_SeleccionarxIdNivelArea
	@IdArea int,
	@IdNivel int
AS
	SELECT	Horario.*,
			Nivel.Nombre as Nivel,
			Area.Nombre as Area,
			Aula.Nombre as Aula
	FROM	Horario 
			INNER JOIN Nivel ON Horario.IdNivel = Nivel.Id
			INNER JOIN Area ON Nivel.IdArea = Area.Id
			INNER JOIN Aula ON Horario.IdAula = Aula.Id
	WHERE	IdNivel IS NOT NULL
			AND (IdNivel = @IdNivel or @IdNivel = 0)
			AND (IdArea = @IdArea or @IdArea = 0)
	ORDER BY Nivel.Nombre
GO

EXEC Horario_SeleccionarxIdNivelArea 0, 0
GO   
