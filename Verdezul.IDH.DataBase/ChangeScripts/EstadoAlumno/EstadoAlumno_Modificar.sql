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
 