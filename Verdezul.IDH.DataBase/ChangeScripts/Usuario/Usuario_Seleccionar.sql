IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Usuario_Seleccionar')
	BEGIN
		DROP  Procedure  Usuario_Seleccionar
	END

GO

CREATE Procedure Usuario_Seleccionar
	@Id int
AS
	SELECT * FROM Usuario where (Id = @Id or @Id = 0)
GO

EXEC Usuario_Seleccionar 1
GO
