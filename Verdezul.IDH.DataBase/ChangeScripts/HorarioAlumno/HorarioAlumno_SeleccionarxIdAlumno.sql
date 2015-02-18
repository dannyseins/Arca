IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'HorarioAlumno_SeleccionarxIdAlumno')
	BEGIN
		DROP  Procedure  HorarioAlumno_SeleccionarxIdAlumno
	END

GO

CREATE Procedure HorarioAlumno_SeleccionarxIdAlumno
	@IdAlumno int
AS
	SELECT	HorarioAlumno.*,
			Curso.Nombre as Curso,
			Horario.HoraInicio,
			Horario.HoraFin,
			Horario.Dias,
			Docente.Nombre + ' ' +    Docente.Apellido as Docente,
			Aula.Nombre as Aula,
			(SELECT COUNT(*) FROM DetallePago WHERE IdHorarioAlumno = HorarioAlumno.Id) as NumeroPagos
	FROM	HorarioAlumno
			INNER JOIN Horario ON HorarioAlumno.IdHorario = Horario.Id
			INNER JOIN Curso ON Horario.IdCurso = Curso.Id
			INNER JOIN Docente ON Horario.IdDocente = Docente.Id
			INNER JOIN Aula ON Horario.IdAula = Aula.Id
	WHERE	(IdAlumno = @IdAlumno or @IdAlumno = 0)

GO

EXEC HorarioAlumno_SeleccionarxIdAlumno 18
GO
