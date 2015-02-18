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
  