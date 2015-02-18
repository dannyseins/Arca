IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_SeleccionarxMesNacimiento')
	BEGIN
		DROP  Procedure  Alumno_SeleccionarxMesNacimiento
	END

GO

CREATE Procedure Alumno_SeleccionarxMesNacimiento
	@MesNacimiento int
AS
	SELECT	*
	FROM	Alumno 
	WHERE	Convert(varchar(2), FechaNacimiento, 101) = @MesNacimiento
	ORDER BY SUBSTRING(Convert(varchar(2), FechaNacimiento, 101), 2, 2)
GO

EXEC Alumno_SeleccionarxMesNacimiento 2
GO 
