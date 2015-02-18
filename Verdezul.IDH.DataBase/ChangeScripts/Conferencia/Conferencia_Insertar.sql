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
 