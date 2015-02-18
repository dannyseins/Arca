IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_SeleccionarxIdentificaionxNombrexApellido')
	BEGIN
		DROP  Procedure  Alumno_SeleccionarxIdentificaionxNombrexApellido
	END

GO

CREATE Procedure Alumno_SeleccionarxIdentificaionxNombrexApellido
	@NumeroIdentificacion varchar(16),
	@Nombre varchar(32),
	@Apellido varchar(32)
AS
	SELECT * FROM Alumno
	WHERE (NumeroIdentificacion = @NumeroIdentificacion or @NumeroIdentificacion = '')
	AND (Nombre LIKE '%'+ @Nombre + '%' or @Nombre = '')
	AND (Apellido LIKE '%' + @Apellido + '%' or @Apellido = '')
GO

EXEC Alumno_SeleccionarxIdentificaionxNombrexApellido '', '', ''
GO
