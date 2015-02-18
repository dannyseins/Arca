	UPDATE Alumno 
	SET
		IdEstadoAlumno = 1, 
		Codigo = 'A' + CAST(Id AS VARCHAR), 
		Nombre = 'Nombre' + CAST(Id AS VARCHAR),
		Apellido = 'Apellido' + CAST(Id AS VARCHAR), 
		TipoIdentificacion = 1,
		NumeroIdentificacion = '171717' + CAST(Id AS VARCHAR),
		FechaNacimiento = SUBSTRING(CAST(Id AS VARCHAR) ,1,1) + '/01/1980 00:00:00', 
		Direccion = 'Direccion' + CAST(Id AS VARCHAR),
		Email = 'Usuario@Dominio.' + CAST(Id AS VARCHAR),
		TelefonoDomicilio = '02558453' + CAST(Id AS VARCHAR), 
		TelefonoOficina = '03558453' + CAST(Id AS VARCHAR),  
		TelefonoCelular = '09558453' + CAST(Id AS VARCHAR),  
		FechaIngreso = '01/01/2000',
		MedioConocimiento = 1,
		MotivoInscripcion = 2,
		MotivoSalida = 1
	WHERE Id > 0
	
 