IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Alumno_ModificarFoto')
	BEGIN
		DROP  Procedure  Alumno_ModificarFoto
	END
GO

CREATE Procedure Alumno_ModificarFoto
	@IdAlumno int,
    @ArchivoFoto varchar(32)
AS
	UPDATE Alumno SET
		ArchivoFoto = @ArchivoFoto
	WHERE 	Id = @IdAlumno
	
	RETURN 0
GO

--EXEC Alumno_ModificarFoto -1, 'ca.jpg'
--GO
 