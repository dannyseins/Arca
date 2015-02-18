IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'HorarioAlumno_PedirHorarioyNivelxAlumno')
	BEGIN
		DROP  Procedure  HorarioAlumno_PedirHorarioyNivelxAlumno
	END

GO

CREATE Procedure HorarioAlumno_PedirHorarioyNivelxAlumno
	@IdAlumno int
AS
	SELECT	HorarioAlumno.*, IdNivel
	FROM	HorarioAlumno
			INNER JOIN Horario ON Horario.Id = HorarioAlumno.IdHorario
	WHERE	HorarioAlumno.Activo = 'True'
			AND TipoHorario = 2
			AND (IdAlumno = @IdAlumno or @IdAlumno = 0)
GO

EXEC HorarioAlumno_PedirHorarioyNivelxAlumno 18
GO 
