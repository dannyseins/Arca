IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_Borrar')
	BEGIN
		DROP  Procedure  Alumno_Borrar
	END
GO

CREATE Procedure Alumno_Borrar
	@Id int
AS
	DELETE FROM Alumno
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC Alumno_Borrar 21
--GO

