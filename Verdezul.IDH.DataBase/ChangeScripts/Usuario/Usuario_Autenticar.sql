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
