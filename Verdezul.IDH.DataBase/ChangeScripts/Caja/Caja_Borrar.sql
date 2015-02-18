IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Caja_Borrar')
	BEGIN
		DROP  Procedure  Caja_Borrar
	END
GO

CREATE Procedure Caja_Borrar
	@Id int
AS
	DELETE FROM Caja
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Caja_Borrar 21
--GO
