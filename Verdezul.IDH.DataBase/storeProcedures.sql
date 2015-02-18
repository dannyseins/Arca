IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_Borrar')
	BEGIN
		DROP  Procedure  Alumno_Borrar
	END
GO

CREATE Procedure Alumno_Borrar
	@Id int
AS
	DELETE FROM Alumno
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Alumno_Borrar 21
--GO

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

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_ModificarFoto')
	BEGIN
		DROP  Procedure  Alumno_ModificarFoto
	END
GO

CREATE Procedure Alumno_ModificarFoto
	@IdAlumno int,
    @ArchivoFoto varchar(32)
AS
	UPDATE Alumno SET
		ArchivoFoto = @ArchivoFoto
	WHERE 	Id = @IdAlumno
	
	RETURN 0
GO

--EXEC Alumno_ModificarFoto -1, 'ca.jpg'
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_Seleccionar')
	BEGIN
		DROP  Procedure  Alumno_Seleccionar
	END

GO

CREATE Procedure Alumno_Seleccionar
	@Id int
AS
	SELECT * FROM Alumno where (Id = @Id or @Id = 0)
GO

EXEC Alumno_Seleccionar 1
GO
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
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_SeleccionarxPertenenciaAreaNivelCurso')
	BEGIN
		DROP  Procedure Alumno_SeleccionarxPertenenciaAreaNivelCurso
	END

GO

CREATE Procedure Alumno_SeleccionarxPertenenciaAreaNivelCurso
	@TipoPertenencia int, 
	@IdArea int, 
	@IdNivel int, 
	@IdCurso int
AS
	IF (@TipoPertenencia = 2)
	BEGIN
		-- X Nivel
		SELECT	Distinct 
				Alumno.*
		FROM	Alumno 
				LEFT OUTER JOIN HorarioAlumno ON Alumno.Id = HorarioAlumno.IdAlumno
				LEFT OUTER JOIN Horario ON Horario.Id = HorarioAlumno.IdHorario
				LEFT OUTER JOIN Nivel ON Nivel.Id = Horario.IdNivel
				LEFT OUTER JOIN Area ON Area.Id = Nivel.IdArea
		WHERE	Horario.TipoHorario = 2
		AND		(HorarioAlumno.Activo = 'True')
		AND		(Area.Id = @IdArea OR @IdArea = 0)
		AND		(Nivel.Id = @IdNivel OR @IdNivel = 0)
	END
	ELSE IF (@TipoPertenencia = 3)
	BEGIN
		-- X Curso
		SELECT	Distinct
				Alumno.*
		FROM	Alumno 
				LEFT OUTER JOIN HorarioAlumno ON Alumno.Id = HorarioAlumno.IdAlumno
				LEFT OUTER JOIN Horario ON Horario.Id = HorarioAlumno.IdHorario
				LEFT OUTER JOIN Curso ON Curso.Id = Horario.IdCurso
		WHERE	Horario.TipoHorario = 1
		AND		(HorarioAlumno.Activo = 'True')
		AND		(Curso.Id = @IdCurso OR @IdCurso = 0)
	END
	ELSE IF (@TipoPertenencia = 4)
	BEGIN
		-- No son Alumnos
		SELECT	Alumno.*
		FROM	Alumno 
		WHERE	Alumno.Id not in (SELECT IdAlumno FROM HorarioAlumno)
	END
	ELSE 
	BEGIN
		-- Todos
		SELECT	Alumno.*
		FROM	Alumno 
	END	
GO

EXEC Alumno_SeleccionarxPertenenciaAreaNivelCurso 1, 1, 1, 1
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Area_Borrar')
	BEGIN
		DROP  Procedure  Area_Borrar
	END
GO

CREATE Procedure Area_Borrar
	@Id int
AS
	DELETE FROM Area
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Area_Borrar 21
--GO

 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Area_Insertar')
	BEGIN
		DROP  Procedure  Area_Insertar
	END
GO

CREATE Procedure Area_Insertar
	@Id int out,
    @Nombre varchar(32)
AS
	INSERT INTO Area
		(Nombre)
	VALUES
		(@Nombre)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Area_Insertar @Id out, 'NombreCompleto1'
--SELECT @Id
--GO

 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Area_Modificar')
	BEGIN
		DROP  Procedure  Area_Modificar
	END
GO

CREATE Procedure Area_Modificar
	@Id int,
    @Nombre varchar(32)
AS
	UPDATE Area SET
		Nombre = @Nombre
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Area_Modificar 18, 'NombreCompleto2'
--GO

 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Area_Seleccionar')
	BEGIN
		DROP  Procedure  Area_Seleccionar
	END

GO

CREATE Procedure Area_Seleccionar
	@Id int
AS
	SELECT * FROM Area where (Id = @Id or @Id = 0)
GO

EXEC Area_Seleccionar 1
GO 
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Area_SeleccionarConNiveles')
	BEGIN
		DROP  Procedure  Area_SeleccionarConNiveles
	END

GO

CREATE Procedure Area_SeleccionarConNiveles
	@IdArea int
AS

	SELECT	*
	FROM	Area
	WHERE	(Id = @IdArea OR @IdArea = 0)

	SELECT	*
	FROM	Nivel
	WHERE	(IdArea = @IdArea OR @IdArea = 0)

GO

EXEC Area_SeleccionarConNiveles 0
GO  

--EXEC Area_SeleccionarConNiveles 1
--GO  IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Aula_Borrar')
	BEGIN
		DROP  Procedure  Aula_Borrar
	END
GO

CREATE Procedure Aula_Borrar
	@Id int
AS
	DELETE FROM Aula
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Aula_Borrar 21
--GO
  IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Aula_Insertar')
	BEGIN
		DROP  Procedure  Aula_Insertar
	END
GO

CREATE Procedure Aula_Insertar
	@Id int out,
    @Nombre varchar(32),
    @Activo bit
AS
	INSERT INTO Aula
		(Nombre, Activo)
	VALUES
		(@Nombre, @Activo)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Aula_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
  IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Aula_Modificar')
	BEGIN
		DROP  Procedure  Aula_Modificar
	END
GO

CREATE Procedure Aula_Modificar
	@Id int,
    @Nombre varchar(32),
    @Activo bit
AS
	UPDATE Aula SET
		Nombre = @Nombre,
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Aula_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Aula_Seleccionar')
	BEGIN
		DROP  Procedure  Aula_Seleccionar
	END

GO

CREATE Procedure Aula_Seleccionar
	@Id int
AS
	SELECT * FROM Aula where (Id = @Id or @Id = 0)
GO

EXEC Aula_Seleccionar 1
GO 
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Aula_SeleccionarActivos')
	BEGIN
		DROP  Procedure  Aula_SeleccionarActivos
	END

GO

CREATE Procedure Aula_SeleccionarActivos
AS
	SELECT * 
	FROM Aula
	WHERE Activo = 1
	
	RETURN 0
GO

EXEC Aula_SeleccionarActivos
GO



   IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_AbrirCaja')
	BEGIN
		DROP  Procedure  CierreDeCaja_AbrirCaja
	END
GO

CREATE Procedure CierreDeCaja_AbrirCaja
	@IdCierreDeCaja int out,
	@IdCaja	int,
	@IdUsuario int
AS
	DECLARE @FechaApertura datetime
	SET @FechaApertura = GETDATE()
	EXEC CierreDeCaja_Insertar @IdCierreDeCaja out, @IdCaja, @IdUsuario, @FechaApertura, null, null

	RETURN 0
GO

--DECLARE @Id INT
--EXEC CierreDeCaja_AbrirCaja @Id out, 1, 1
--SELECT @Id
--GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_CerrarCaja')
	BEGIN
		DROP  Procedure  CierreDeCaja_CerrarCaja
	END
GO

CREATE Procedure CierreDeCaja_CerrarCaja
	@IdCierreDeCaja int
AS
	DECLARE @FechaCierre datetime
	SET @FechaCierre = GETDATE()
	
	UPDATE CierreDeCaja SET
		FechaCierre = @FechaCierre
	WHERE 	Id = @IdCierreDeCaja
	
	RETURN 0
GO

--EXEC CierreDeCaja_CerrarCaja 11
--GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_Insertar')
	BEGIN
		DROP  Procedure  CierreDeCaja_Insertar
	END
GO

CREATE Procedure CierreDeCaja_Insertar
	@Id int out,
    @IdCaja int,
    @IdUsuario int,
    @FechaApertura datetime,
    @FechaCierre datetime,
    @Observaciones varchar(64)
AS
	INSERT INTO CierreDeCaja
		(IdCaja, IdUsuario, FechaApertura, FechaCierre, Observaciones)
	VALUES
		(@IdCaja, @IdUsuario, @FechaApertura, @FechaCierre, @Observaciones)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC CierreDeCaja_Insertar @Id out, 1, 1, '01/01/2005', '01/01/2005', '2558745'
--SELECT @Id
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_Modificar')
	BEGIN
		DROP  Procedure  CierreDeCaja_Modificar
	END
GO

CREATE Procedure CierreDeCaja_Modificar
	@Id int,
    @IdCaja int,
    @IdUsuario int,
    @FechaApertura datetime,
    @FechaCierre datetime,
    @Observaciones varchar(64)
AS
	UPDATE CierreDeCaja SET
		IdCaja = @IdCaja, 
		IdUsuario = @IdUsuario,
		FechaApertura = @FechaApertura, 
		FechaCierre = @FechaCierre, 
		Observaciones = @Observaciones
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC CierreDeCaja_Modificar 11, 1, 1, '2001/01/01', '2001/01/01', 'ninguna'
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_PedirIdCierreDeCajaxIdCajaIdUsuario')
	BEGIN
		DROP  Procedure  CierreDeCaja_PedirIdCierreDeCajaxIdCajaIdUsuario
	END
GO

CREATE Procedure CierreDeCaja_PedirIdCierreDeCajaxIdCajaIdUsuario
	@IdCierreDeCaja int out,
	@IdCaja	int,
	@IdUsuario int
AS
	-- Verifica que exista el usuario
	IF NOT EXISTS(SELECT Id FROM Usuario WHERE Id = @IdUsuario)
		RETURN 0
	
	-- Verifica que exista la caja	
	IF NOT EXISTS(SELECT Id FROM Caja WHERE Id = @IdCaja)
		RETURN 0
	
	-- Verifica si la caja este cerrada
	IF NOT EXISTS(SELECT Id FROM CierreDeCaja WHERE	FechaCierre is null AND IdCaja = @IdCaja)
		SET @IdCierreDeCaja = 0
	ELSE
	BEGIN
		SELECT	@IdCierreDeCaja = Id
		FROM	CierreDeCaja
		WHERE	FechaCierre is null
		AND		IdCaja = @IdCaja
		AND		IdUsuario = @IdUsuario
		
		IF @IdCierreDeCaja is null
			SET @IdCierreDeCaja = -1
	END
	RETURN 0
GO

DECLARE @Id INT
EXEC CierreDeCaja_PedirIdCierreDeCajaxIdCajaIdUsuario @Id out, 3, 3

IF @Id > 0
	PRINT 'La Caja esta siendo usada por el usuario en el Cierre de Caja ' + cast(@Id as varchar)
ELSE IF @Id = 0
	PRINT 'La Caja esta cerrada'
ELSE IF @Id < 0
	PRINT 'La Caja esta siendo usada por otro usuario'
ELSE
	PRINT 'El usuario o la caja no existen'
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_Seleccionar')
	BEGIN
		DROP  Procedure  CierreDeCaja_Seleccionar
	END

GO

CREATE Procedure CierreDeCaja_Seleccionar
	@Id int
AS
	SELECT	CierreDeCaja.*,
			Caja.Nombre as Caja,
			Usuario.NickName as Usuario
	FROM	CierreDeCaja 
			INNER JOIN Caja ON Caja.Id = CierreDeCaja.IdCaja
			INNER JOIN Usuario ON Usuario.Id = CierreDeCaja.IdUsuario
	WHERE	(CierreDeCaja.Id = @Id or @Id = 0)
GO

EXEC CierreDeCaja_Seleccionar 13
GO 
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_SeleccionarEntreFechas')
	BEGIN
		DROP  Procedure  CierreDeCaja_SeleccionarEntreFechas
	END

GO

CREATE Procedure CierreDeCaja_SeleccionarEntreFechas
	@FechaDesde datetime,
	@FechaHasta datetime
AS
	SELECT	Caja.Nombre as Caja,
			Usuario.NickName as Usuario,
			CierreDeCaja.*,
			0 as Valor
	FROM	CierreDeCaja
			INNER JOIN Caja ON Caja.Id = CierreDeCaja.IdCaja
			INNER JOIN Usuario ON Usuario.Id = CierreDeCaja.IdUsuario
	WHERE	FechaCierre BETWEEN @FechaDesde AND @FechaHasta
GO

EXEC CierreDeCaja_SeleccionarEntreFechas '05/15/2009', '05/15/2010'
GO 
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Conferencia_Borrar')
	BEGIN
		DROP  Procedure  Conferencia_Borrar
	END
GO

CREATE Procedure Conferencia_Borrar
	@Id int
AS
	DELETE FROM Conferencia
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Conferencia_Borrar 21
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Conferencia_Insertar')
	BEGIN
		DROP  Procedure  Conferencia_Insertar
	END
GO

CREATE Procedure Conferencia_Insertar
	@Id int out,
    @Nombre varchar(32),
    @Instructor varchar(32),
    @Fecha datetime,
    @Activo bit
AS
	INSERT INTO Conferencia
		(Nombre, Instructor, Fecha, Activo)
	VALUES
		(@Nombre, @Instructor, @Fecha, @Activo)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Conferencia_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Conferencia_Modificar')
	BEGIN
		DROP  Procedure  Conferencia_Modificar
	END
GO

CREATE Procedure Conferencia_Modificar
	@Id int,
    @Nombre varchar(32),
    @Instructor varchar(32),
    @Fecha datetime,
    @Activo bit
AS
	UPDATE Conferencia SET
		Nombre = @Nombre, 
		Instructor = @Instructor,
		Fecha = @Fecha, 
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Conferencia_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Conferencia_Seleccionar')
	BEGIN
		DROP  Procedure  Conferencia_Seleccionar
	END

GO

CREATE Procedure Conferencia_Seleccionar
	@Id int
AS
	SELECT * FROM Conferencia where (Id = @Id or @Id = 0)
GO

EXEC Conferencia_Seleccionar 1
GO 
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Conferencia_SeleccionarActivos')
	BEGIN
		DROP  Procedure  Conferencia_SeleccionarActivos
	END

GO

CREATE Procedure Conferencia_SeleccionarActivos
AS
	SELECT * 
	FROM Conferencia
	WHERE Activo = 1
	
	RETURN 0
GO

EXEC Conferencia_SeleccionarActivos
GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Curso_Borrar')
	BEGIN
		DROP  Procedure  Curso_Borrar
	END
GO

CREATE Procedure Curso_Borrar
	@Id int
AS
	DELETE FROM Curso
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Curso_Borrar 21
--GO
  IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Curso_Insertar')
	BEGIN
		DROP  Procedure  Curso_Insertar
	END
GO

CREATE Procedure Curso_Insertar
	@Id int out,
    @Nombre varchar(32),
    @Activo bit
AS
	INSERT INTO Curso
		(Nombre, Activo)
	VALUES
		(@Nombre, @Activo)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Curso_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
  IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Curso_Modificar')
	BEGIN
		DROP  Procedure  Curso_Modificar
	END
GO

CREATE Procedure Curso_Modificar
	@Id int,
    @Nombre varchar(32),
    @Activo bit
AS
	UPDATE Curso SET
		Nombre = @Nombre,
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Curso_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Curso_Seleccionar')
	BEGIN
		DROP  Procedure  Curso_Seleccionar
	END

GO

CREATE Procedure Curso_Seleccionar
	@Id int
AS
	SELECT * FROM Curso where (Id = @Id or @Id = 0)
GO

EXEC Curso_Seleccionar 1
GO 
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Curso_SeleccionarActivos')
	BEGIN
		DROP  Procedure  Curso_SeleccionarActivos
	END

GO

CREATE Procedure Curso_SeleccionarActivos
AS
	SELECT * 
	FROM Curso
	WHERE Activo = 'True'
	
	RETURN 0
GO

EXEC Curso_SeleccionarActivos
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Curso_SeleccionarxIdAlumno')
	BEGIN
		DROP  Procedure  Curso_SeleccionarxIdAlumno
	END

GO

CREATE Procedure Curso_SeleccionarxIdAlumno
	@IdAlumno int
AS
	--SELECT * FROM Curso
	SELECT	DISTINCT Curso.* 
	FROM	HorarioAlumno 
			LEFT OUTER JOIN Horario ON Horario.Id = HorarioAlumno.IdHorario
			INNER JOIN Curso ON Curso.Id = Horario.IdCurso
	WHERE	HorarioAlumno.Activo = 'True'
			AND (HorarioAlumno.IdAlumno = @IdAlumno)
	
	
	RETURN 0
GO

EXEC Curso_SeleccionarxIdAlumno 18
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Docente_Borrar')
	BEGIN
		DROP  Procedure  Docente_Borrar
	END
GO

CREATE Procedure Docente_Borrar
	@Id int
AS
	DELETE FROM Docente
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Docente_Borrar 21
--GO
  IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Docente_Insertar')
	BEGIN
		DROP  Procedure  Docente_Insertar
	END
GO

CREATE Procedure Docente_Insertar
	@Id int out,
    @Nombre varchar(32),
    @Apellido varchar(32),
    @Activo bit
AS
	INSERT INTO Docente
		(Nombre, Apellido, Activo)
	VALUES
		(@Nombre, @Apellido, @Activo)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Docente_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
  IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Docente_Modificar')
	BEGIN
		DROP  Procedure  Docente_Modificar
	END
GO

CREATE Procedure Docente_Modificar
	@Id int,
    @Nombre varchar(32),
    @Apellido varchar(32),
    @Activo bit
AS
	UPDATE Docente SET
		Nombre = @Nombre,
		Apellido = @Apellido,
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Docente_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Docente_Seleccionar')
	BEGIN
		DROP  Procedure  Docente_Seleccionar
	END

GO

CREATE Procedure Docente_Seleccionar
	@Id int
AS
	SELECT * FROM Docente where (Id = @Id or @Id = 0)
GO

EXEC Docente_Seleccionar 1
GO 
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Docente_SeleccionarActivos')
	BEGIN
		DROP  Procedure  Docente_SeleccionarActivos
	END

GO

CREATE Procedure Docente_SeleccionarActivos
AS
	SELECT * 
	FROM Docente
	WHERE Activo = 1
	
	RETURN 0
GO

EXEC Docente_SeleccionarActivos
GO
  IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'EstadoAlumno_Borrar')
	BEGIN
		DROP  Procedure  EstadoAlumno_Borrar
	END
GO

CREATE Procedure EstadoAlumno_Borrar
	@Id int
AS
	DELETE FROM EstadoAlumno
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC EstadoAlumno_Borrar 21
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'EstadoAlumno_Insertar')
	BEGIN
		DROP  Procedure  EstadoAlumno_Insertar
	END
GO

CREATE Procedure EstadoAlumno_Insertar
	@Id int out,
    @Nombre varchar(32)
AS
	INSERT INTO EstadoAlumno
		(Nombre)
	VALUES
		(@Nombre)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC EstadoAlumno_Insertar @Id out, 'NombreCompleto1'
--SELECT @Id
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'EstadoAlumno_Modificar')
	BEGIN
		DROP  Procedure  EstadoAlumno_Modificar
	END
GO

CREATE Procedure EstadoAlumno_Modificar
	@Id int,
    @Nombre varchar(32)
AS
	UPDATE EstadoAlumno SET
		Nombre = @Nombre
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC EstadoAlumno_Modificar 18, 'NombreCompleto2'
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'EstadoAlumno_Seleccionar')
	BEGIN
		DROP  Procedure  EstadoAlumno_Seleccionar
	END

GO

CREATE Procedure EstadoAlumno_Seleccionar
	@Id int
AS
	SELECT * FROM EstadoAlumno where (Id = @Id or @Id = 0)
GO

EXEC EstadoAlumno_Seleccionar 1
GO 
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_Borrar')
	BEGIN
		DROP  Procedure  Horario_Borrar
	END
GO

CREATE Procedure Horario_Borrar
	@Id int
AS
	DELETE FROM Horario
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Horario_Borrar 21
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_Info_SeleccionarxTipoHorario')
	BEGIN
		DROP  Procedure  Horario_Info_SeleccionarxTipoHorario
	END

GO

CREATE Procedure Horario_Info_SeleccionarxTipoHorario
	@TipoHorario int
AS
	SELECT	Horario.Id, 
			Horario.TipoHorario,
			Horario.IdCurso, 
			Horario.IdNivel,
			Horario.IdAula, 
			Horario.IdDocente, 
			Horario.HoraInicio, 
			Horario.HoraFin, 
			Horario.Dias, 
			Horario.Activo, 
			Curso.Nombre AS Curso, 
			Nivel.Nombre AS Nivel,
			Area.Nombre AS Area,
			Docente.Nombre + ' ' + Docente.Apellido AS Docente, 
			Aula.Nombre AS Aula
	FROM	Horario 
			INNER JOIN Docente ON Horario.IdDocente = Docente.Id 
			INNER JOIN Aula ON Horario.IdAula = Aula.Id 
			LEFT OUTER JOIN Curso ON Horario.IdCurso = Curso.Id
			LEFT OUTER JOIN Nivel ON Horario.IdNivel = Nivel.Id
			LEFT OUTER JOIN Area ON Nivel.IdArea = Area.Id
	WHERE	TipoHorario = @TipoHorario
GO

EXEC Horario_Info_SeleccionarxTipoHorario 2
GO  
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_Insertar')
	BEGIN
		DROP  Procedure  Horario_Insertar
	END
GO

CREATE Procedure Horario_Insertar
	@Id int out,
	@TipoHorario int,
	@IdCurso int,
	@IdNivel int,
	@IdAula int,
	@IdDocente int,
    @HoraInicio datetime,
    @HoraFin datetime,
    @Dias varchar(128),
    @Activo bit
AS
	INSERT INTO Horario
		(TipoHorario, IdCurso, IdNivel, 
		IdAula, IdDocente, HoraInicio, HoraFin, Dias, Activo)
	VALUES
		(@TipoHorario, @IdCurso, @IdNivel, 
		@IdAula, @IdDocente, @HoraInicio, @HoraFin, @Dias, @Activo)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Horario_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_Modificar')
	BEGIN
		DROP  Procedure  Horario_Modificar
	END
GO

CREATE Procedure Horario_Modificar
	@Id int,
	@TipoHorario int,
	@IdCurso int,
	@IdNivel int,
	@IdAula int,
	@IdDocente int,
    @HoraInicio datetime,
    @HoraFin datetime,
    @Dias varchar(128),
    @Activo bit
AS
	UPDATE Horario SET
		TipoHorario = @TipoHorario,
		IdCurso = @IdCurso, 
		IdNivel = @IdNivel,
		IdAula = @IdAula,
		IdDocente = @IdDocente, 
		HoraInicio = @HoraInicio,
		HoraFin = @HoraFin, 
		Dias = @Dias,
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Horario_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_Seleccionar')
	BEGIN
		DROP  Procedure  Horario_Seleccionar
	END

GO

CREATE Procedure Horario_Seleccionar
	@Id int
AS
	SELECT * FROM Horario where (Id = @Id or @Id = 0)
GO

EXEC Horario_Seleccionar 0
GO  
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_SeleccionarActivos')
	BEGIN
		DROP  Procedure  Horario_SeleccionarActivos
	END

GO

CREATE Procedure Horario_SeleccionarActivos
AS
	SELECT * 
	FROM Horario
	WHERE Activo = 1
	
	RETURN 0
GO

EXEC Horario_SeleccionarActivos
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'HorarioAlumno_Borrar')
	BEGIN
		DROP  Procedure  HorarioAlumno_Borrar
	END
GO

CREATE Procedure HorarioAlumno_Borrar
	@Id int
AS
	DELETE FROM HorarioAlumno
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC HorarioAlumno_Borrar 21
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'HorarioAlumno_CambiarNivel')
	BEGIN
		DROP  Procedure  HorarioAlumno_CambiarNivel
	END
GO

CREATE Procedure HorarioAlumno_CambiarNivel
	--@Id int out,
	@IdAlumno int,
	@IdHorarioAlumno int,
	@FechaInicio datetime,
	@FechaFin datetime = null
AS
	UPDATE HorarioAlumno SET
		Activo = 'False'
	WHERE 	Id in
			(
				SELECT	HorarioAlumno.Id
				FROM	HorarioAlumno
						INNER JOIN Horario ON HorarioAlumno.IdHorario = Horario.Id
				WHERE	TipoHorario = 2
						AND HorarioAlumno.IdAlumno = @IdAlumno
			)	
	
	UPDATE HorarioAlumno SET
		Activo = 'True'
	WHERE 	Id = @IdHorarioAlumno
			
	RETURN 0
GO

--EXEC HorarioAlumno_CambiarNivel 18, 3, '01/01/2005', null
--GO
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

 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'HorarioAlumno_PedirHorarioyNivelxAlumno')
	BEGIN
		DROP  Procedure  HorarioAlumno_PedirHorarioyNivelxAlumno
	END

GO

CREATE Procedure HorarioAlumno_PedirHorarioyNivelxAlumno
	@IdAlumno int
AS
	SELECT	HorarioAlumno.*, IdNivel
	FROM	HorarioAlumno
			INNER JOIN Horario ON Horario.Id = HorarioAlumno.IdHorario
	WHERE	HorarioAlumno.Activo = 'True'
			AND TipoHorario = 2
			AND (IdAlumno = @IdAlumno or @IdAlumno = 0)
GO

EXEC HorarioAlumno_PedirHorarioyNivelxAlumno 18
GO 
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'HorarioAlumno_SeleccionarxIdAlumno')
	BEGIN
		DROP  Procedure  HorarioAlumno_SeleccionarxIdAlumno
	END

GO

CREATE Procedure HorarioAlumno_SeleccionarxIdAlumno
	@IdAlumno int
AS
	SELECT	HorarioAlumno.*,
			Curso.Nombre as Curso,
			Horario.HoraInicio,
			Horario.HoraFin,
			Horario.Dias,
			Docente.Nombre + ' ' +    Docente.Apellido as Docente,
			Aula.Nombre as Aula,
			(SELECT COUNT(*) FROM DetallePago WHERE IdHorarioAlumno = HorarioAlumno.Id) as NumeroPagos
	FROM	HorarioAlumno
			INNER JOIN Horario ON HorarioAlumno.IdHorario = Horario.Id
			INNER JOIN Curso ON Horario.IdCurso = Curso.Id
			INNER JOIN Docente ON Horario.IdDocente = Docente.Id
			INNER JOIN Aula ON Horario.IdAula = Aula.Id
	WHERE	(IdAlumno = @IdAlumno or @IdAlumno = 0)

GO

EXEC HorarioAlumno_SeleccionarxIdAlumno 18
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'HorarioAlumno_SeleccionarxIdAlumnoTipoHorario')
	BEGIN
		DROP  Procedure HorarioAlumno_SeleccionarxIdAlumnoTipoHorario
	END

GO

CREATE Procedure HorarioAlumno_SeleccionarxIdAlumnoTipoHorario
	@IdAlumno int,
	@TipoHorario int,
	@Activo bit
AS
	IF @Activo = 0 SET @Activo = NULL
		
	SELECT	--distinct
			HorarioAlumno.*
--			--, @Activo, isnull(@Activo, '')
			, Curso.Nombre as Curso
			, Area.Nombre + ' ' + Nivel.Nombre as Nivel, IdNivel
			, Horario.HoraInicio, Horario.HoraFin, Horario.Dias
			, Aula.Nombre as Aula, Docente.Nombre + ' ' + Docente.Apellido as Docente
			, (SELECT COUNT(*) FROM DetallePago WHERE IdHorarioAlumno = HorarioAlumno.Id) as NumeroPagos

	FROM	Horario
			INNER JOIN HorarioAlumno ON HorarioAlumno.IdHorario = Horario.Id 
			LEFT OUTER JOIN Curso ON Horario.IdCurso = Curso.Id
			LEFT OUTER JOIN Nivel ON Horario.IdNivel = Nivel.Id
			LEFT OUTER JOIN Area ON Nivel.IdArea = Area.Id
			INNER JOIN Docente ON Horario.IdDocente = Docente.Id
			INNER JOIN Aula ON Horario.IdAula = Aula.Id
	WHERE	HorarioAlumno.IdAlumno = @IdAlumno
	AND		(TipoHorario = @TipoHorario OR @TipoHorario = 0)
	AND		(Horario.Activo = @Activo OR isnull(@Activo, '') = '')
GO

EXEC HorarioAlumno_SeleccionarxIdAlumnoTipoHorario 18, 2, 'True'
GO  
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Borrar')
	BEGIN
		DROP  Procedure  Nivel_Borrar
	END
GO

CREATE Procedure Nivel_Borrar
	@Id int
AS
	DELETE FROM Nivel
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Nivel_Borrar 21
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Insertar')
	BEGIN
		DROP  Procedure  Nivel_Insertar
	END
GO

CREATE Procedure Nivel_Insertar
	@Id int out,
	@IdArea int,
    @Nombre varchar(32)
AS
	INSERT INTO Nivel
		(IdArea, Nombre)
	VALUES
		(@IdArea, @Nombre)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Nivel_Insertar @Id out, 'NombreCompleto1'
--SELECT @Id
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Modificar')
	BEGIN
		DROP  Procedure  Nivel_Modificar
	END
GO

CREATE Procedure Nivel_Modificar
	@Id int,
	@IdArea int,
    @Nombre varchar(32)
AS
	UPDATE Nivel SET
		IdArea = @IdArea,
		Nombre = @Nombre
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Nivel_Modificar 18, 'NombreCompleto2'
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Nivel_Seleccionar')
	BEGIN
		DROP  Procedure  Nivel_Seleccionar
	END

GO

CREATE Procedure Nivel_Seleccionar
	@Id int
AS
	SELECT * FROM Nivel where (Id = @Id or @Id = 0)
GO

EXEC Nivel_Seleccionar 1
GO 
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Observacion_Borrar')
	BEGIN
		DROP  Procedure  Observacion_Borrar
	END
GO

CREATE Procedure Observacion_Borrar
	@Id int
AS
	DELETE FROM Observacion
	WHERE Id = @Id
	
	RETURN 0
GO

EXEC Observacion_Borrar 5
GO
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
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Observacion_Modificar')
	BEGIN
		DROP  Procedure  Observacion_Modificar
	END
GO

CREATE Procedure Observacion_Modificar
	@Id int out,
    @IdAlumno int,
    @IdDocente int,
    @TextoAbierto text,
    @Fecha datetime
AS
	UPDATE Observacion SET
		IdAlumno = @IdAlumno, 
		IdDocente = @IdDocente, 
		TextoAbierto = @TextoAbierto, 
		Fecha = @Fecha
	WHERE 	Id = @Id

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Observacion_Modificar @Id out, 18, 1, '1714153390', '01/01/2008'
--SELECT @Id
--GO
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
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'DetallePago_Insertar')
	BEGIN
		DROP  Procedure  DetallePago_Insertar
	END
GO

CREATE Procedure DetallePago_Insertar
	@Id					int	out,
	@IdPago				int,
	@Cantidad			int,
	@Valor				decimal(10, 2),
	@IVA				decimal(10, 2),
	@PVP				decimal(10, 2),
	@Descuento			decimal(10, 2),
	@IdMotivoPago		int,
	@IdRubro			int,
	@IdConferencia		int,
	@IdHorarioAlumno	int,
	@MesPago			datetime,
	@TipoAbono			int
AS
	INSERT INTO DetallePago
		(IdPago, Cantidad, Valor, IVA, PVP, Descuento, 
		IdMotivoPago, IdRubro, IdConferencia,
		IdHorarioAlumno, MesPago, TipoAbono)
	VALUES
		(@IdPago, @Cantidad, @Valor, @IVA, @PVP, @Descuento, 
		@IdMotivoPago, @IdRubro, @IdConferencia, 
		@IdHorarioAlumno, @MesPago, @TipoAbono)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC DetallePago_Insertar @Id out, 1, 1, 2, 2, 2, 2
--SELECT @Id
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pago_CambiarEstado')
	BEGIN
		DROP  Procedure  Pago_CambiarEstado
	END
GO

CREATE Procedure Pago_CambiarEstado
	@ListaPedidos varchar(max),
	@Estado	int
AS

	DECLARE @SQL varchar(max)
	SET @SQL = '
		UPDATE Pago SET
			Estado = ' + CAST(@Estado AS VARCHAR) + '
		WHERE Id in (' + @ListaPedidos + ')'

	EXEC(@SQL)
	RETURN 0
GO

--EXEC Pago_CambiarEstado '46, 47, 48', 5
--GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pago_Insertar')
	BEGIN
		DROP  Procedure  Pago_Insertar
	END
GO

CREATE Procedure Pago_Insertar
	@Id	int	out,
	@IdAlumno int,
	@IdCierreDeCaja	int,
	@IdSecuencia int,
	@Fecha	datetime,
	@TipoDocumentoPago int,
	@Estado	int,
	@FormaPago int,
	@NumeroDocumento	varchar(16),
	@Observacion	varchar(128)
AS
	INSERT INTO Pago
		(IdAlumno, IdCierreDeCaja, IdSecuencia, Fecha, TipoDocumentoPago, Estado, FormaPago, NumeroDocumento, Observacion)
	VALUES
		(@IdAlumno, @IdCierreDeCaja, @IdSecuencia, @Fecha, @TipoDocumentoPago, @Estado, @FormaPago, @NumeroDocumento, @Observacion)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Pago_Insertar @Id out, 18, 1, '2008/01/01', 1, 'False', 2, '2558745', '11'
--SELECT @Id
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pedido_Modificar')
	BEGIN
		DROP  Procedure  Pedido_Modificar
	END
GO

CREATE Procedure Pedido_Modificar
	@Id	int,
	@IdAlumno int,
	@IdCierreDeCaja	int,
	@IdSecuencia int,
	@Fecha	datetime,
	@TipoDocumentoPago int,
	@Estado	int,
	@FormaPago int,
	@NumeroDocumento	varchar(16),
	@Observacion	varchar(128)
AS
	UPDATE Pedido SET
		IdAlumno = @IdAlumno, 
		IdCierreDeCaja = @IdCierreDeCaja,
		IdSecuencia = @IdSecuencia,
		Fecha = @Fecha, 
		TipoDocumentoPago = @TipoDocumentoPago,
		Estado = @Estado, 
		FormaPago = @FormaPago,
		NumeroDocumento = @NumeroDocumento,
		Observacion = @Observacion
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Pedido_Modificar @Id out, 18, 1, '2008/01/01', 1, 'False', 1, '2558745', '11'
--GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pago_Seleccionar')
	BEGIN
		DROP  Procedure  Pago_Seleccionar
	END

GO

CREATE Procedure Pago_Seleccionar
	@Id int = 0,
	@IdAlumno int = 0,
	@IdCierreDeCaja int = 0
AS
	SELECT	*
	FROM	Pago 
	WHERE	(Id = @Id or @Id = 0)
	AND		(IdAlumno = @IdAlumno or @IdAlumno = 0)
	AND		(IdCierreDeCaja = @IdCierreDeCaja or @IdCierreDeCaja = 0)
	
GO

EXEC Pago_Seleccionar 0, 18--, 0
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pago_SeleccionarConDetallexCierreDeCaja')
	BEGIN
		DROP  Procedure  Pago_SeleccionarConDetallexCierreDeCaja
	END

GO

CREATE Procedure Pago_SeleccionarConDetallexCierreDeCaja
	@IdCierreDeCaja int
AS
	SELECT	DetallePago.Id, 
			DetallePago.IdPago, 
			DetallePago.Cantidad, 
			DetallePago.Valor, 
			DetallePago.IVA, 
			DetallePago.PVP, 
			DetallePago.Descuento, 
			DetallePago.IdMotivoPago, 
			DetallePago.IdRubro, 
			DetallePago.IdConferencia
			,DetallePago.IdHorarioAlumno
			,DetallePago.MesPago
			,DetallePago.TipoAbono
			
			,Rubro.Nombre AS Rubro
			,Conferencia.Nombre AS Conferencia
			,Curso.Nombre AS Curso
			,Nivel.Nombre AS Nivel
			,Area.Nombre AS Area
			,HoraInicio, HoraFin, Dias
			
	FROM	DetallePago
			LEFT OUTER JOIN Rubro ON DetallePago.IdRubro = Rubro.Id
			LEFT OUTER JOIN Conferencia ON DetallePago.IdConferencia = Conferencia.Id
			LEFT OUTER JOIN HorarioAlumno ON DetallePago.IdHorarioAlumno = HorarioAlumno.Id
			LEFT OUTER JOIN Horario ON HorarioAlumno.IdHorario = Horario.Id
			LEFT OUTER JOIN Curso ON Horario.IdCurso = Curso.Id
			LEFT OUTER JOIN Nivel ON Horario.IdNivel = Nivel.Id
			LEFT OUTER JOIN Area ON Nivel.IdArea = Area.Id
	WHERE	IdPago in 
			(	SELECT	Id 
				FROM	Pago 
				WHERE	(IdCierreDeCaja = @IdCierreDeCaja)	 )

	SELECT	Pago.Id, 
			Pago.NumeroDocumento, 
			Alumno.Nombre + ' ' + Alumno.Apellido AS Alumno,
			Pago.Fecha, 
			Pago.Estado, 
			Pago.FormaPago,
			Pago.IdAlumno,
			Pago.IdCierreDeCaja,
			Pago.TipoDocumentoPago,
			Pago.IdSecuencia,
			ISNULL(SUM(DetallePago.PVP), 0) AS Valor,
			Pago.Observacion, 
			'' AS EstadoTexto,
			'' AS FormaPagoTexto,
			'' AS TipoDocumentoPagoTexto
	FROM	Pago INNER JOIN
			Alumno ON Pago.IdAlumno = Alumno.Id LEFT OUTER JOIN
			DetallePago ON Pago.Id = DetallePago.IdPago
	WHERE	(Pago.IdCierreDeCaja = @IdCierreDeCaja)
	GROUP BY	Pago.Id, Pago.IdAlumno, Pago.IdCierreDeCaja, Pago.TipoDocumentoPago,
				Pago.Fecha, Pago.Estado, 
				Pago.Observacion, 
				Pago.NumeroDocumento,
				Alumno.Nombre + ' ' + Alumno.Apellido
				,Pago.FormaPago, Pago.IdSecuencia
	ORDER BY	Pago.Fecha

GO

EXEC Pago_SeleccionarConDetallexCierreDeCaja 13
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pago_SeleccionarxIdConDetalle')
	BEGIN
		DROP  Procedure  Pago_SeleccionarxIdConDetalle
	END

GO

CREATE Procedure Pago_SeleccionarxIdConDetalle
	@IdPago int,
	@NumeroDocumento varchar(16)
AS
	SELECT	DetallePago.Id, 
			DetallePago.IdPago, 
			DetallePago.Cantidad, 
			DetallePago.Valor, 
			DetallePago.IVA, 
			DetallePago.PVP, 
			DetallePago.Descuento, 
			DetallePago.IdMotivoPago, 
			DetallePago.IdRubro, 
			DetallePago.IdConferencia
			,DetallePago.IdHorarioAlumno
			,DetallePago.MesPago
			,DetallePago.TipoAbono
			
			,Rubro.Nombre AS Rubro
			,Conferencia.Nombre AS Conferencia
			,Curso.Nombre AS Curso
			,Nivel.Nombre AS Nivel
			,Area.Nombre AS Area
			,HoraInicio, HoraFin, Dias
			
	FROM	DetallePago
			LEFT OUTER JOIN Rubro ON DetallePago.IdRubro = Rubro.Id
			LEFT OUTER JOIN Conferencia ON DetallePago.IdConferencia = Conferencia.Id
			LEFT OUTER JOIN HorarioAlumno ON DetallePago.IdHorarioAlumno = HorarioAlumno.Id
			LEFT OUTER JOIN Horario ON HorarioAlumno.IdHorario = Horario.Id
			LEFT OUTER JOIN Curso ON Horario.IdCurso = Curso.Id
			LEFT OUTER JOIN Nivel ON Horario.IdNivel = Nivel.Id
			LEFT OUTER JOIN Area ON Nivel.IdArea = Area.Id
	WHERE	IdPago in 
			(	SELECT	Id 
				FROM	Pago 
				WHERE	(NumeroDocumento = @NumeroDocumento or @NumeroDocumento = '')
				AND		(IdPago = @IdPago or @IdPago = 0)
			 )


	SELECT	Pago.Id, 
			Pago.NumeroDocumento, 
			Alumno.Nombre + ' ' + Alumno.Apellido AS Alumno,
			Pago.Fecha, 
			Pago.Estado, 
			Pago.FormaPago,
			Pago.IdAlumno,
			Pago.IdCierreDeCaja,
			Pago.TipoDocumentoPago,
			Pago.IdSecuencia,
			ISNULL(SUM(DetallePago.PVP), 0) AS Valor,
			Pago.Observacion, 
			'' AS EstadoTexto,
			'' AS FormaPagoTexto,
			'' AS TipoDocumentoPagoTexto
	FROM	Pago INNER JOIN
			Alumno ON Pago.IdAlumno = Alumno.Id LEFT OUTER JOIN
			DetallePago ON Pago.Id = DetallePago.IdPago
	WHERE	(Pago.NumeroDocumento = @NumeroDocumento or @NumeroDocumento = '')
	AND		(IdPago = @IdPago or @IdPago = 0)
	GROUP BY	Pago.Id, Pago.IdAlumno, Pago.IdCierreDeCaja, Pago.TipoDocumentoPago,
				Pago.Fecha, Pago.Estado, 
				Pago.Observacion, 
				Pago.NumeroDocumento,
				Alumno.Nombre + ' ' + Alumno.Apellido
				,Pago.FormaPago, Pago.IdSecuencia
	ORDER BY	Pago.Fecha

GO

EXEC Pago_SeleccionarxIdConDetalle 0, 'f1'
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Parametro_Modificar')
	BEGIN
		DROP  Procedure  Parametro_Modificar
	END
GO

CREATE Procedure Parametro_Modificar
	@Id int,
    @Nombre varchar(16),
    @Valor varchar(32),
    @Descripcion varchar(32)
AS
	UPDATE Parametro SET
		Nombre = @Nombre, 
		Valor = @Valor,
		Descripcion = @Descripcion
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Parametro_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Parametro_Seleccionar')
	BEGIN
		DROP  Procedure  Parametro_Seleccionar
	END

GO

CREATE Procedure Parametro_Seleccionar
	@Id int
AS
	SELECT * FROM Parametro where (Id = @Id or @Id = 0)
GO

EXEC Parametro_Seleccionar 0
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Parametro_SeleccionarxNombre')
	BEGIN
		DROP  Procedure  Parametro_SeleccionarxNombre
	END

GO

CREATE Procedure Parametro_SeleccionarxNombre
	@Nombre varchar(32),
	@Valor varchar(32) out
AS
	SELECT	@Valor = Valor
	FROM	Parametro 
	WHERE	Nombre = @Nombre
	 
	RETURN 0
GO

DECLARE @Valor varchar(32) 
EXEC Parametro_SeleccionarxNombre 'IVA', @Valor out
SELECT @Valor
GO
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
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_SeleccionarxIdCurso')
	BEGIN
		DROP  Procedure  Horario_SeleccionarxIdCurso
	END

GO

CREATE Procedure Horario_SeleccionarxIdCurso
	@IdCurso int
AS
	SELECT	Horario.*,
			Curso.Nombre as Curso,
			Aula.Nombre as Aula
	FROM	Horario 
			INNER JOIN Curso ON Horario.IdCurso = Curso.Id
			INNER JOIN Aula ON Horario.IdAula = Aula.Id
	WHERE	IdCurso IS NOT NULL
			AND (IdCurso = @IdCurso or @IdCurso = 0)
	ORDER BY Curso.Nombre
GO

EXEC Horario_SeleccionarxIdCurso 0
GO   
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_SeleccionarxIdNivelArea')
	BEGIN
		DROP  Procedure  Horario_SeleccionarxIdNivelArea
	END

GO

CREATE Procedure Horario_SeleccionarxIdNivelArea
	@IdArea int,
	@IdNivel int
AS
	SELECT	Horario.*,
			Nivel.Nombre as Nivel,
			Area.Nombre as Area,
			Aula.Nombre as Aula
	FROM	Horario 
			INNER JOIN Nivel ON Horario.IdNivel = Nivel.Id
			INNER JOIN Area ON Nivel.IdArea = Area.Id
			INNER JOIN Aula ON Horario.IdAula = Aula.Id
	WHERE	IdNivel IS NOT NULL
			AND (IdNivel = @IdNivel or @IdNivel = 0)
			AND (IdArea = @IdArea or @IdArea = 0)
	ORDER BY Nivel.Nombre
GO

EXEC Horario_SeleccionarxIdNivelArea 0, 0
GO   
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pago_PedirDeudas')
	BEGIN DROP  Procedure  Pago_PedirDeudas END
GO

CREATE Procedure Pago_PedirDeudas
	@tipoHorarioIdMotivoPago int,
	@IdCurso int,
	@IdArea int,
	@IdNivel int,
	@IdAlumno int,
	@MesDeuda datetime
AS

declare @valorMensualidad decimal(10,3)
select @valorMensualidad = Valor from parametro where nombre = 'ValorMensualidad'

select	HorarioAlumnoIdReal, Area, Nivel, Curso,
		HoraInicio, HoraFin, Dias,
		Nombre + ' ' + Apellido as Alumno,
		SUM(isnull(PVP, 0)) as 'SumaPVP',
		@valorMensualidad as ValorMensualidad,
		(@valorMensualidad - sum(isnull(PVP, 0))) AS 'Diferencia',
		FechaInicio, FechaFin, MesPago
		--IdAlumno, IdCurso, IdArea, IdNivel, IdHorario, IdDetallePago, TipoHorario, IdMotivoPago, IdPago, Activo,
		--TipoAbono, FechaPago, Cantidad, Valor, IVA, Descuento, HorarioAlumnoIdReal, IdHorarioAlumno,
from	vistaDeudas
where	(tipoHorario = @tipoHorarioIdMotivoPago or @tipoHorarioIdMotivoPago = 0)
and		(isnull(IdMotivoPago, @tipoHorarioIdMotivoPago) = @tipoHorarioIdMotivoPago or @tipoHorarioIdMotivoPago = 0)
and		(IdCurso = @IdCurso or @IdCurso = 0)
and		(IdArea = @IdArea or @IdArea = 0)
and		(IdNivel = @IdNivel or @IdNivel = 0)
and		(IdAlumno = @IdAlumno or @IdAlumno = 0)
and		isnull(mesPago, @MesDeuda) = @MesDeuda
and		FechaInicio <= @MesDeuda
and		isnull(FechaFin, @MesDeuda) >= @MesDeuda
group by	HorarioAlumnoIdReal, Area, Nivel, Curso,
			HoraInicio, HoraFin, Dias,
			Nombre + ' ' + Apellido,
			FechaInicio, FechaFin, MesPago

order by 1
GO

--EXEC Pago_PedirDeudas 0, 0, 0, 0, 18, '01-01-2005'
--GO 
IF object_id(N'vistaDeudas', 'V') IS NOT NULL
	DROP VIEW dbo.vistaDeudas
GO

CREATE VIEW [dbo].[vistaDeudas]
AS
SELECT	dbo.HorarioAlumno.Id as HorarioAlumnoIdReal,
		dbo.HorarioAlumno.IdAlumno, dbo.HorarioAlumno.IdHorario, dbo.HorarioAlumno.FechaInicio, dbo.HorarioAlumno.FechaFin, 

		dbo.Horario.HoraInicio, dbo.Horario.HoraFin, dbo.Horario.Dias, dbo.HorarioAlumno.Activo, 
		dbo.Horario.TipoHorario, dbo.Horario.IdCurso, dbo.Horario.IdNivel, 

		dbo.DetallePago.IdPago, dbo.DetallePago.Cantidad, dbo.DetallePago.Valor, dbo.DetallePago.IVA, dbo.DetallePago.PVP, 
		dbo.DetallePago.Descuento, dbo.DetallePago.IdMotivoPago, dbo.DetallePago.IdHorarioAlumno, 
		dbo.DetallePago.MesPago, dbo.DetallePago.TipoAbono, dbo.DetallePago.Id AS IdDetallePago, 

		dbo.Alumno.Codigo, dbo.Alumno.Nombre, dbo.Alumno.Apellido, 

		dbo.Nivel.IdArea, dbo.Nivel.Nombre AS Nivel, dbo.Area.Nombre AS Area, dbo.Curso.Nombre AS Curso, 

		dbo.Pago.Fecha AS FechaPago
FROM    dbo.HorarioAlumno 
		LEFT OUTER JOIN dbo.DetallePago ON dbo.DetallePago.IdHorarioAlumno = dbo.HorarioAlumno.Id 
		INNER JOIN dbo.Alumno ON dbo.HorarioAlumno.IdAlumno = dbo.Alumno.Id 
		INNER JOIN dbo.Horario ON dbo.HorarioAlumno.IdHorario = dbo.Horario.Id 
		LEFT OUTER JOIN dbo.Curso ON dbo.Curso.Id = dbo.Horario.IdCurso 
		LEFT OUTER JOIN dbo.Nivel ON dbo.Horario.IdNivel = dbo.Nivel.Id
		LEFT OUTER JOIN dbo.Area ON dbo.Area.Id = dbo.Nivel.IdArea 
		FULL OUTER JOIN dbo.Pago ON dbo.DetallePago.IdPago = dbo.Pago.Id 
WHERE     (ISNULL(dbo.DetallePago.IdMotivoPago, 0) IN (1, 2, 0))
go

select * from vistaDeudas
go
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Rubro_Borrar')
	BEGIN
		DROP  Procedure  Rubro_Borrar
	END
GO

CREATE Procedure Rubro_Borrar
	@Id int
AS
	DELETE FROM Rubro
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Rubro_Borrar 21
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Rubro_Insertar')
	BEGIN
		DROP  Procedure  Rubro_Insertar
	END
GO

CREATE Procedure Rubro_Insertar
	@Id int out,
    @Nombre varchar(32),
    @Descripcion varchar(64),
    @Valor decimal(10,3),
    @IVA decimal(10,3),
    @PVP decimal(10,3),
    @TieneIVA bit,
    @Activo bit
AS
	INSERT INTO Rubro
		(Nombre, Descripcion, Valor, IVA, PVP, TieneIVA, Activo)
	VALUES
		(@Nombre, @Descripcion, @Valor, @IVA, @PVP, @TieneIVA, @Activo)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Rubro_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Rubro_Modificar')
	BEGIN
		DROP  Procedure  Rubro_Modificar
	END
GO

CREATE Procedure Rubro_Modificar
	@Id int,
    @Nombre varchar(32),
    @Descripcion varchar(64),
    @Valor decimal(10,2),
    @IVA decimal(10,2),
    @PVP decimal(10,2),
    @TieneIVA bit,
    @Activo bit
AS
	UPDATE Rubro SET
		Nombre = @Nombre, 
		Descripcion = @Descripcion,
		Valor = @Valor, 
		IVA = @IVA, 
		PVP = @PVP, 
		TieneIVA = @TieneIVA,
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Rubro_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
 IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Rubro_Seleccionar')
	BEGIN
		DROP  Procedure  Rubro_Seleccionar
	END

GO

CREATE Procedure Rubro_Seleccionar
	@Id int
AS
	SELECT * FROM Rubro where (Id = @Id or @Id = 0)
GO

EXEC Rubro_Seleccionar 1
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Rubro_SeleccionarActivos')
	BEGIN
		DROP  Procedure  Rubro_SeleccionarActivos
	END

GO

CREATE Procedure Rubro_SeleccionarActivos
AS
	SELECT * 
	FROM Rubro
	WHERE Activo = 1
	
	RETURN 0
GO

EXEC Rubro_SeleccionarActivos
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SecuenciaImpresion_Borrar')
	BEGIN
		DROP  Procedure  SecuenciaImpresion_Borrar
	END
GO

CREATE Procedure SecuenciaImpresion_Borrar
	@Id int
AS
	DELETE FROM SecuenciaImpresion
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC SecuenciaImpresion_Borrar 21
--GO
  IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SecuenciaImpresion_Insertar')
	BEGIN
		DROP  Procedure  SecuenciaImpresion_Insertar
	END
GO

CREATE Procedure SecuenciaImpresion_Insertar
	@Id int out,
	@Fecha	datetime	,
	@ValorUsado	int	,
	@ValorInicio	int	,
	@ValorFin	int	,
	@Prefijo	varchar(8)	,
	@NumCaracteres	int	,
	@EnUso	bit	,
	@Cerrado	bit	,
	@TipoDocumentoPago	int
AS
	INSERT INTO SecuenciaImpresion
		(Fecha, ValorUsado, ValorInicio, ValorFin, Prefijo, NumCaracteres, EnUso, Cerrado, TipoDocumentoPago)
	VALUES
		(@Fecha, @ValorUsado, @ValorInicio, @ValorFin, @Prefijo, @NumCaracteres, @EnUso, @Cerrado, @TipoDocumentoPago)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC SecuenciaImpresion_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SecuenciaImpresion_Modificar')
	BEGIN
		DROP  Procedure  SecuenciaImpresion_Modificar
	END
GO

CREATE Procedure SecuenciaImpresion_Modificar
	@Id int,
	@Fecha	datetime	,
	@ValorUsado	int	,
	@ValorInicio	int	,
	@ValorFin	int	,
	@Prefijo	varchar(8)	,
	@NumCaracteres	int	,
	@EnUso	bit	,
	@Cerrado	bit	,
	@TipoDocumentoPago	int
AS
	UPDATE SecuenciaImpresion SET
		Fecha = @Fecha, 
		ValorUsado = @ValorUsado,
		ValorInicio = @ValorInicio, 
		ValorFin = @ValorFin, 
		Prefijo = @Prefijo, 
		NumCaracteres = @NumCaracteres,
		EnUso = @EnUso,
		Cerrado = @Cerrado,
		TipoDocumentoPago = @TipoDocumentoPago
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC SecuenciaImpresion_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SecuenciaImpresion_PedirNuevoNumeroSecuencia')
	BEGIN
		DROP  Procedure  SecuenciaImpresion_PedirNuevoNumeroSecuencia
	END

GO

CREATE Procedure SecuenciaImpresion_PedirNuevoNumeroSecuencia
	@TipoDocumentoPago int
AS
	UPDATE	SecuenciaImpresion 
	SET		ValorUsado = ValorUsado + 1
	WHERE	EnUso = 'True'
	AND		TipoDocumentoPago = @TipoDocumentoPago
	
	SELECT	* 
	FROM	SecuenciaImpresion 
	WHERE	EnUso = 'True'
	AND		TipoDocumentoPago = @TipoDocumentoPago
	
	RETURN 0
GO

--EXEC SecuenciaImpresion_PedirNuevoNumeroSecuencia 2
--GO  
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SecuenciaImpresion_PonerEnUso')
	BEGIN
		DROP  Procedure  SecuenciaImpresion_PonerEnUso
	END
GO

CREATE Procedure SecuenciaImpresion_PonerEnUso
	@IdSecuenciaImpresion int,
	@TipoDocumentoPago	int
AS
	UPDATE SecuenciaImpresion SET
		EnUso = 'FALSE'
	WHERE	TipoDocumentoPago = @TipoDocumentoPago
	
	UPDATE SecuenciaImpresion SET
		EnUso = 'TRUE'
	WHERE 	Id = @IdSecuenciaImpresion
	
	RETURN 0
GO

--EXEC SecuenciaImpresion_PonerEnUso 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SecuenciaImpresion_Seleccionar')
	BEGIN
		DROP  Procedure  SecuenciaImpresion_Seleccionar
	END

GO

CREATE Procedure SecuenciaImpresion_Seleccionar
	@Id int
AS
	SELECT * FROM SecuenciaImpresion where (Id = @Id or @Id = 0)
GO

EXEC SecuenciaImpresion_Seleccionar 1
GO 
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Usuario_Autenticar')
	BEGIN
		DROP  Procedure  Usuario_Autenticar
	END

GO

CREATE Procedure Usuario_Autenticar
	@NickName	varchar(16),
	@Clave		varchar(32),
	@IdUsuario	int out
AS
	IF EXISTS(SELECT * FROM Usuario WHERE	NickName = @NickName AND Clave = @Clave)
		SELECT	@IdUsuario = Id
		FROM	Usuario 
		WHERE	NickName = @NickName
		AND		Clave = @Clave
	ELSE
		SET @IdUsuario = 0
	RETURN 0
GO

DECLARE @IdUsuario int
EXEC Usuario_Autenticar 'admin', '21232f297a57a5a743894a0e4a801fc3', @IdUsuario out
SELECT @IdUsuario
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Usuario_Borrar')
	BEGIN
		DROP  Procedure  Usuario_Borrar
	END
GO

CREATE Procedure Usuario_Borrar
	@Id int
AS
	DELETE FROM Usuario
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Usuario_Borrar 21
--GO 
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Usuario_CambiarClave')
	BEGIN
		DROP  Procedure  Usuario_CambiarClave
	END

GO

CREATE Procedure Usuario_CambiarClave
	@IdUsuario int,
	@Clave varchar(32)
AS
	UPDATE	Usuario SET
		Clave = @Clave
	WHERE Id = @IdUsuario
	
	RETURN 0
GO

--EXEC Usuario_CambiarClave 1, '22'
--GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Usuario_Insertar')
	BEGIN
		DROP  Procedure  Usuario_Insertar
	END
GO

CREATE Procedure Usuario_Insertar
	@Id int out,
	@TipoRol int,
	@NickName varchar(16),
	@Clave varchar(32),
    @NombreCompleto varchar(32),
    @CI varchar(16),
    @Direccion varchar(32),
    @Telefono varchar(16),
    @Email varchar(32),
    @Activo bit
AS
	INSERT INTO Usuario
		(TipoRol, NickName, Clave, NombreCompleto, CI, Direccion, Telefono, Email, Activo)
	VALUES
		(@TipoRol, @NickName, @Clave, @NombreCompleto, @CI, @Direccion, @Telefono, @Email, @Activo)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Usuario_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', 'Email@Email.COM', true
--SELECT @Id
--GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Usuario_Modificar')
	BEGIN
		DROP  Procedure  Usuario_Modificar
	END
GO

CREATE Procedure Usuario_Modificar
	@Id int,
	@TipoRol int,
	@NickName varchar(16),
	@Clave varchar(32),
    @NombreCompleto varchar(32),
    @CI varchar(16),
    @Direccion varchar(32),
    @Telefono varchar(16),
    @Email varchar(32),
    @Activo bit
AS
	UPDATE Usuario SET
		TipoRol = @TipoRol,
		NickName = @NickName, 
		Clave = @Clave,
		NombreCompleto = @NombreCompleto, 
		CI = @CI, 
		Direccion = @Direccion, 
		Telefono = @Telefono, 
		Email = @Email,
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Usuario_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Usuario_PedirTipoRolxUsuario')
	BEGIN
		DROP  Procedure  Usuario_PedirTipoRolxUsuario
	END

GO

CREATE Procedure Usuario_PedirTipoRolxUsuario
	@IdUsuario int,
	@TipoRol int out
AS
	SELECT @TipoRol = TipoRol FROM Usuario where (Id = @IdUsuario)
GO

DECLARE @TipoRol int
EXEC Usuario_PedirTipoRolxUsuario 1, @TipoRol out
SELECT @TipoRol
GO
IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Usuario_Seleccionar')
	BEGIN
		DROP  Procedure  Usuario_Seleccionar
	END

GO

CREATE Procedure Usuario_Seleccionar
	@Id int
AS
	SELECT * FROM Usuario where (Id = @Id or @Id = 0)
GO

EXEC Usuario_Seleccionar 1
GO
