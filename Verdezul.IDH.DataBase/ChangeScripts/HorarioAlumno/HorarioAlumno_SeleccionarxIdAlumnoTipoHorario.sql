IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'HorarioAlumno_SeleccionarxIdAlumnoTipoHorario')
	BEGIN
		DROP  Procedure HorarioAlumno_SeleccionarxIdAlumnoTipoHorario
	END

GO

CREATE Procedure HorarioAlumno_SeleccionarxIdAlumnoTipoHorario
	@IdAlumno int,
	@TipoHorario int,
	@Activo bit
AS
	IF @Activo = 0 SET @Activo = NULL
		
	SELECT	--distinct
			HorarioAlumno.*
--			--, @Activo, isnull(@Activo, '')
			, Curso.Nombre as Curso
			, Area.Nombre + ' ' + Nivel.Nombre as Nivel, IdNivel
			, Horario.HoraInicio, Horario.HoraFin, Horario.Dias
			, Aula.Nombre as Aula, Docente.Nombre + ' ' + Docente.Apellido as Docente
			, (SELECT COUNT(*) FROM DetallePago WHERE IdHorarioAlumno = HorarioAlumno.Id) as NumeroPagos

	FROM	Horario
			INNER JOIN HorarioAlumno ON HorarioAlumno.IdHorario = Horario.Id 
			LEFT OUTER JOIN Curso ON Horario.IdCurso = Curso.Id
			LEFT OUTER JOIN Nivel ON Horario.IdNivel = Nivel.Id
			LEFT OUTER JOIN Area ON Nivel.IdArea = Area.Id
			INNER JOIN Docente ON Horario.IdDocente = Docente.Id
			INNER JOIN Aula ON Horario.IdAula = Aula.Id
	WHERE	HorarioAlumno.IdAlumno = @IdAlumno
	AND		(TipoHorario = @TipoHorario OR @TipoHorario = 0)
	AND		(Horario.Activo = @Activo OR isnull(@Activo, '') = '')
GO

EXEC HorarioAlumno_SeleccionarxIdAlumnoTipoHorario 18, 2, 'True'
GO  
