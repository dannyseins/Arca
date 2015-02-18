IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Usuario_Borrar')
	BEGIN
		DROP  Procedure  Usuario_Borrar
	END
GO

CREATE Procedure Usuario_Borrar
	@Id int
AS
	DELETE FROM Usuario
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Usuario_Borrar 21
--GO 
