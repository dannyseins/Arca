IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_Insertar')
	BEGIN
		DROP  Procedure  Alumno_Insertar
	END
GO

CREATE Procedure Alumno_Insertar
	@Id int out,
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
	INSERT INTO Alumno
		(IdEstadoAlumno, Codigo, Nombre, Apellido, TipoIdentificacion, NumeroIdentificacion, 
		FechaNacimiento, Direccion, Email, TelefonoDomicilio, TelefonoOficina, TelefonoCelular,
		FechaIngreso, 
		MedioConocimiento, OtroConocimiento, MotivoInscripcion, OtroInscripcion, MotivoSalida, OtroSalida)
	VALUES
		(@IdEstadoAlumno, @Codigo, @Nombre, @Apellido, @TipoIdentificacion, @NumeroIdentificacion, 
		@FechaNacimiento, @Direccion, @Email, @TelefonoDomicilio, @TelefonoOficina, @TelefonoCelular,
		@FechaIngreso,
		@MedioConocimiento, @OtroConocimiento, @MotivoInscripcion, @OtroInscripcion, @MotivoSalida, @OtroSalida)

	SELECT @Id = scope_identity()
	
	UPDATE Alumno 
	SET Codigo = 'A'+ CAST(@Id AS VARCHAR)
	WHERE Id = @Id
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Alumno_Insertar @Id out, 1, 'c1', 'Cambio1', 'Cambio2', '1', '1714153392', '01/01/2009',
--	'Direccion2', 'Email@Email2.com', '25587451', '25587451', '25587451', '02/03/2005',
--	3, 'sad', 4, 'gf', 5, 'gf'
--SELECT @Id
--GO

