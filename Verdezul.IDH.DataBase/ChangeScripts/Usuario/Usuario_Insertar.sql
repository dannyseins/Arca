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
