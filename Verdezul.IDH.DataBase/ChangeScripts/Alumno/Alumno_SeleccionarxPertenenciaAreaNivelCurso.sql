IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_SeleccionarxPertenenciaAreaNivelCurso')
	BEGIN
		DROP  Procedure Alumno_SeleccionarxPertenenciaAreaNivelCurso
	END

GO

CREATE Procedure Alumno_SeleccionarxPertenenciaAreaNivelCurso
	@TipoPertenencia int, 
	@IdArea int, 
	@IdNivel int, 
	@IdCurso int
AS
	IF (@TipoPertenencia = 2)
	BEGIN
		-- X Nivel
		SELECT	Distinct 
				Alumno.*
		FROM	Alumno 
				LEFT OUTER JOIN HorarioAlumno ON Alumno.Id = HorarioAlumno.IdAlumno
				LEFT OUTER JOIN Horario ON Horario.Id = HorarioAlumno.IdHorario
				LEFT OUTER JOIN Nivel ON Nivel.Id = Horario.IdNivel
				LEFT OUTER JOIN Area ON Area.Id = Nivel.IdArea
		WHERE	Horario.TipoHorario = 2
		AND		(HorarioAlumno.Activo = 'True')
		AND		(Area.Id = @IdArea OR @IdArea = 0)
		AND		(Nivel.Id = @IdNivel OR @IdNivel = 0)
	END
	ELSE IF (@TipoPertenencia = 3)
	BEGIN
		-- X Curso
		SELECT	Distinct
				Alumno.*
		FROM	Alumno 
				LEFT OUTER JOIN HorarioAlumno ON Alumno.Id = HorarioAlumno.IdAlumno
				LEFT OUTER JOIN Horario ON Horario.Id = HorarioAlumno.IdHorario
				LEFT OUTER JOIN Curso ON Curso.Id = Horario.IdCurso
		WHERE	Horario.TipoHorario = 1
		AND		(HorarioAlumno.Activo = 'True')
		AND		(Curso.Id = @IdCurso OR @IdCurso = 0)
	END
	ELSE IF (@TipoPertenencia = 4)
	BEGIN
		-- No son Alumnos
		SELECT	Alumno.*
		FROM	Alumno 
		WHERE	Alumno.Id not in (SELECT IdAlumno FROM HorarioAlumno)
	END
	ELSE 
	BEGIN
		-- Todos
		SELECT	Alumno.*
		FROM	Alumno 
	END	
GO

EXEC Alumno_SeleccionarxPertenenciaAreaNivelCurso 1, 1, 1, 1
GO
