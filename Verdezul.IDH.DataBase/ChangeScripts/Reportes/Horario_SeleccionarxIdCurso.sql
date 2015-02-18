IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_SeleccionarxIdCurso')
	BEGIN
		DROP  Procedure  Horario_SeleccionarxIdCurso
	END

GO

CREATE Procedure Horario_SeleccionarxIdCurso
	@IdCurso int
AS
	SELECT	Horario.*,
			Curso.Nombre as Curso,
			Aula.Nombre as Aula
	FROM	Horario 
			INNER JOIN Curso ON Horario.IdCurso = Curso.Id
			INNER JOIN Aula ON Horario.IdAula = Aula.Id
	WHERE	IdCurso IS NOT NULL
			AND (IdCurso = @IdCurso or @IdCurso = 0)
	ORDER BY Curso.Nombre
GO

EXEC Horario_SeleccionarxIdCurso 0
GO   
