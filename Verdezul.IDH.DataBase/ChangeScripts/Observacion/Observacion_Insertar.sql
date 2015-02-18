IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Observacion_Insertar')
	BEGIN
		DROP  Procedure  Observacion_Insertar
	END
GO

CREATE Procedure Observacion_Insertar
	@Id int out,
    @IdAlumno int,
    @IdDocente int,
    @TextoAbierto text,
    @Fecha datetime
AS
	INSERT INTO Observacion
		(IdAlumno, IdDocente, TextoAbierto, Fecha)
	VALUES
		(@IdAlumno, @IdDocente, @TextoAbierto, @Fecha)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Observacion_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
