IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'HorarioAlumno_Borrar')
	BEGIN
		DROP  Procedure  HorarioAlumno_Borrar
	END
GO

CREATE Procedure HorarioAlumno_Borrar
	@Id int
AS
	DELETE FROM HorarioAlumno
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC HorarioAlumno_Borrar 21
--GO
 