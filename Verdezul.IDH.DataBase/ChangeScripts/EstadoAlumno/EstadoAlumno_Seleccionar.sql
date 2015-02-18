IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'EstadoAlumno_Seleccionar')
	BEGIN
		DROP  Procedure  EstadoAlumno_Seleccionar
	END

GO

CREATE Procedure EstadoAlumno_Seleccionar
	@Id int
AS
	SELECT * FROM EstadoAlumno where (Id = @Id or @Id = 0)
GO

EXEC EstadoAlumno_Seleccionar 1
GO 
