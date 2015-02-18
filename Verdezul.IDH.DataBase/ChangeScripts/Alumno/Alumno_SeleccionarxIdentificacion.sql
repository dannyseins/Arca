IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_SeleccionarxIdentificacion')
	BEGIN
		DROP  Procedure  Alumno_SeleccionarxIdentificacion
	END

GO

CREATE Procedure Alumno_SeleccionarxIdentificacion
	@NumeroIdentificacion varchar(16)
AS
	SELECT * FROM Alumno where (NumeroIdentificacion = @NumeroIdentificacion)
GO

EXEC Alumno_SeleccionarxIdentificacion '1714153392'
GO
