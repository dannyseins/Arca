IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Area_Borrar')
	BEGIN
		DROP  Procedure  Area_Borrar
	END
GO

CREATE Procedure Area_Borrar
	@Id int
AS
	DELETE FROM Area
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Area_Borrar 21
--GO

 