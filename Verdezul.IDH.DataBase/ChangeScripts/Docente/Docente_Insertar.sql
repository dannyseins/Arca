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
  