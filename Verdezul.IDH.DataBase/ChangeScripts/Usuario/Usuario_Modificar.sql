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
