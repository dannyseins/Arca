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
 