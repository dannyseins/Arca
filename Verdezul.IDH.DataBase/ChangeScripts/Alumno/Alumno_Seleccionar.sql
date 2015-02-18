IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_Seleccionar')
	BEGIN
		DROP  Procedure  Alumno_Seleccionar
	END

GO

CREATE Procedure Alumno_Seleccionar
	@Id int
AS
	SELECT * FROM Alumno where (Id = @Id or @Id = 0)
GO

EXEC Alumno_Seleccionar 1
GO
