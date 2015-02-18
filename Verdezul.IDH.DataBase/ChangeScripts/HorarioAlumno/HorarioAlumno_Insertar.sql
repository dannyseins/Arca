IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'HorarioAlumno_Insertar')
	BEGIN
		DROP  Procedure  HorarioAlumno_Insertar
	END
GO

CREATE Procedure HorarioAlumno_Insertar
	@Id int out,
	@IdAlumno int,
	@IdHorario int,
	@FechaInicio datetime,
	@FechaFin datetime = null,
    @Activo bit
AS
	INSERT INTO HorarioAlumno
		(IdAlumno, IdHorario, FechaInicio, FechaFin, Activo)
	VALUES
		(@IdAlumno, @IdHorario, @FechaInicio, @FechaFin, @Activo)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC HorarioAlumno_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
