IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_Modificar')
	BEGIN
		DROP  Procedure  Alumno_Modificar
	END
GO

CREATE Procedure Alumno_Modificar
	@Id int,
    @IdEstadoAlumno int,
    @Codigo varchar(6),
    @Nombre varchar(32),
    @Apellido  varchar(32),
    @TipoIdentificacion varchar(1),
    @NumeroIdentificacion varchar(16),
    @FechaNacimiento datetime,
    @Direccion varchar(32),
    @Email varchar(32),
    @TelefonoDomicilio varchar(16),
    @TelefonoOficina varchar(16),
    @TelefonoCelular varchar(16),
    @FechaIngreso datetime,
    @MedioConocimiento int,
    @OtroConocimiento varchar(32),
    @MotivoInscripcion int,
    @OtroInscripcion varchar(32),
    @MotivoSalida int,
    @OtroSalida varchar(32)
AS
	UPDATE Alumno SET
		IdEstadoAlumno = @IdEstadoAlumno, 
		Codigo = @Codigo, 
		Nombre = @Nombre, 
		Apellido = @Apellido, 
		TipoIdentificacion=@TipoIdentificacion,
		NumeroIdentificacion = @NumeroIdentificacion, 
		FechaNacimiento = @FechaNacimiento, 
		Direccion = @Direccion, 
		Email = @Email, 
		TelefonoDomicilio = @TelefonoDomicilio, 
		TelefonoOficina = @TelefonoOficina, 
		TelefonoCelular = @TelefonoCelular, 
		FechaIngreso = @FechaIngreso, 
		MedioConocimiento = @MedioConocimiento,
		OtroConocimiento = @OtroConocimiento,
		MotivoInscripcion = @MotivoInscripcion,
		OtroInscripcion = @OtroInscripcion,
		MotivoSalida = @MotivoSalida,
		OtroSalida = @OtroSalida
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Alumno_Modificar 18, 1, 'c1', 'Cambio1', 'Cambio2', '1', '1714153392', '01/01/2009',
--	'Direccion2', 'Email@Email2.com', '25587451', '25587451', '25587451', '02/03/2005',
--	 3, 'c', 4, 'b', 5, 'a' 
--GO

