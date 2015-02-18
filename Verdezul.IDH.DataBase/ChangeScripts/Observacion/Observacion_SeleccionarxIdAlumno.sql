IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Observacion_SeleccionarxIdAlumno')
	BEGIN
		DROP  Procedure  Observacion_SeleccionarxIdAlumno
	END

GO

CREATE Procedure Observacion_SeleccionarxIdAlumno
	@IdAlumno int
AS
	SELECT	Observacion.*, Docente.Nombre + ' ' + Docente.Apellido as Docente
	FROM	Observacion
			INNER JOIN Docente ON Observacion.IdDocente = Docente.Id
	WHERE	(IdAlumno = @IdAlumno)
GO

EXEC Observacion_SeleccionarxIdAlumno 18
GO  
