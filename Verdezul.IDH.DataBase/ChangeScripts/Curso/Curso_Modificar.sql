IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Curso_Modificar')
	BEGIN
		DROP  Procedure  Curso_Modificar
	END
GO

CREATE Procedure Curso_Modificar
	@Id int,
    @Nombre varchar(32),
    @Activo bit
AS
	UPDATE Curso SET
		Nombre = @Nombre,
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Curso_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
