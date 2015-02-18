IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'HorarioAlumno_CambiarNivel')
	BEGIN
		DROP  Procedure  HorarioAlumno_CambiarNivel
	END
GO

CREATE Procedure HorarioAlumno_CambiarNivel
	--@Id int out,
	@IdAlumno int,
	@IdHorarioAlumno int,
	@FechaInicio datetime,
	@FechaFin datetime = null
AS
	UPDATE HorarioAlumno SET
		Activo = 'False'
	WHERE 	Id in
			(
				SELECT	HorarioAlumno.Id
				FROM	HorarioAlumno
						INNER JOIN Horario ON HorarioAlumno.IdHorario = Horario.Id
				WHERE	TipoHorario = 2
						AND HorarioAlumno.IdAlumno = @IdAlumno
			)	
	
	UPDATE HorarioAlumno SET
		Activo = 'True'
	WHERE 	Id = @IdHorarioAlumno
			
	RETURN 0
GO

--EXEC HorarioAlumno_CambiarNivel 18, 3, '01/01/2005', null
--GO
