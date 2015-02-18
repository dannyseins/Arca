IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Curso_SeleccionarxIdAlumno')
	BEGIN
		DROP  Procedure  Curso_SeleccionarxIdAlumno
	END

GO

CREATE Procedure Curso_SeleccionarxIdAlumno
	@IdAlumno int
AS
	--SELECT * FROM Curso
	SELECT	DISTINCT Curso.* 
	FROM	HorarioAlumno 
			LEFT OUTER JOIN Horario ON Horario.Id = HorarioAlumno.IdHorario
			INNER JOIN Curso ON Curso.Id = Horario.IdCurso
	WHERE	HorarioAlumno.Activo = 'True'
			AND (HorarioAlumno.IdAlumno = @IdAlumno)
	
	
	RETURN 0
GO

EXEC Curso_SeleccionarxIdAlumno 18
GO
