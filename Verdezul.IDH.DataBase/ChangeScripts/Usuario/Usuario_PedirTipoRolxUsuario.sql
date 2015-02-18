IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Usuario_PedirTipoRolxUsuario')
	BEGIN
		DROP  Procedure  Usuario_PedirTipoRolxUsuario
	END

GO

CREATE Procedure Usuario_PedirTipoRolxUsuario
	@IdUsuario int,
	@TipoRol int out
AS
	SELECT @TipoRol = TipoRol FROM Usuario where (Id = @IdUsuario)
GO

DECLARE @TipoRol int
EXEC Usuario_PedirTipoRolxUsuario 1, @TipoRol out
SELECT @TipoRol
GO
