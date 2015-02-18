IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_Info_SeleccionarxTipoHorario')
	BEGIN
		DROP  Procedure  Horario_Info_SeleccionarxTipoHorario
	END

GO

CREATE Procedure Horario_Info_SeleccionarxTipoHorario
	@TipoHorario int
AS
	SELECT	Horario.Id, 
			Horario.TipoHorario,
			Horario.IdCurso, 
			Horario.IdNivel,
			Horario.IdAula, 
			Horario.IdDocente, 
			Horario.HoraInicio, 
			Horario.HoraFin, 
			Horario.Dias, 
			Horario.Activo, 
			Curso.Nombre AS Curso, 
			Nivel.Nombre AS Nivel,
			Area.Nombre AS Area,
			Docente.Nombre + ' ' + Docente.Apellido AS Docente, 
			Aula.Nombre AS Aula
	FROM	Horario 
			INNER JOIN Docente ON Horario.IdDocente = Docente.Id 
			INNER JOIN Aula ON Horario.IdAula = Aula.Id 
			LEFT OUTER JOIN Curso ON Horario.IdCurso = Curso.Id
			LEFT OUTER JOIN Nivel ON Horario.IdNivel = Nivel.Id
			LEFT OUTER JOIN Area ON Nivel.IdArea = Area.Id
	WHERE	TipoHorario = @TipoHorario
GO

EXEC Horario_Info_SeleccionarxTipoHorario 2
GO  
