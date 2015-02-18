IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'EstadoAlumno_Borrar')
	BEGIN
		DROP  Procedure  EstadoAlumno_Borrar
	END
GO

CREATE Procedure EstadoAlumno_Borrar
	@Id int
AS
	DELETE FROM EstadoAlumno
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC EstadoAlumno_Borrar 21
--GO
 