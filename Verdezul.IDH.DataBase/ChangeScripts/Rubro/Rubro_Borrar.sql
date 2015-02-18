IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Rubro_Borrar')
	BEGIN
		DROP  Procedure  Rubro_Borrar
	END
GO

CREATE Procedure Rubro_Borrar
	@Id int
AS
	DELETE FROM Rubro
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Rubro_Borrar 21
--GO
 