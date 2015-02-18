IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Observacion_Modificar')
	BEGIN
		DROP  Procedure  Observacion_Modificar
	END
GO

CREATE Procedure Observacion_Modificar
	@Id int out,
    @IdAlumno int,
    @IdDocente int,
    @TextoAbierto text,
    @Fecha datetime
AS
	UPDATE Observacion SET
		IdAlumno = @IdAlumno, 
		IdDocente = @IdDocente, 
		TextoAbierto = @TextoAbierto, 
		Fecha = @Fecha
	WHERE 	Id = @Id

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Observacion_Modificar @Id out, 18, 1, '1714153390', '01/01/2008'
--SELECT @Id
--GO
