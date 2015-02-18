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
