IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_SeleccionarxIdHorario')
	BEGIN
		DROP  Procedure  Alumno_SeleccionarxIdHorario
	END

GO

CREATE Procedure Alumno_SeleccionarxIdHorario
	@IdHorario int
AS
	SELECT	Alumno.* 
	FROM	Alumno
			INNER JOIN HorarioAlumno ON  Alumno.Id = HorarioAlumno.IdAlumno
	WHERE	HorarioAlumno.Activo = 'true'
			AND (IdHorario = @IdHorario)
	ORDER BY  Alumno.Apellido
GO

EXEC Alumno_SeleccionarxIdHorario 1
GO 
