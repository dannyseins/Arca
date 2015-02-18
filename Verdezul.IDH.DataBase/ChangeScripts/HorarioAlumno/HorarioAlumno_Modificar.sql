IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'HorarioAlumno_Modificar')
	BEGIN
		DROP  Procedure  HorarioAlumno_Modificar
	END
GO

CREATE Procedure HorarioAlumno_Modificar
	@Id int,
	@IdAlumno int,
	@IdHorario int,
	@FechaInicio datetime,
	@FechaFin datetime = null,
    @Activo bit
AS
	UPDATE HorarioAlumno SET
		IdAlumno = @IdAlumno,
		IdHorario = @IdHorario, 
		FechaInicio = @FechaInicio,
		FechaFin = @FechaFin,
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC HorarioAlumno_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO

 