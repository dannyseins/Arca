IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Conferencia_Modificar')
	BEGIN
		DROP  Procedure  Conferencia_Modificar
	END
GO

CREATE Procedure Conferencia_Modificar
	@Id int,
    @Nombre varchar(32),
    @Instructor varchar(32),
    @Fecha datetime,
    @Activo bit
AS
	UPDATE Conferencia SET
		Nombre = @Nombre, 
		Instructor = @Instructor,
		Fecha = @Fecha, 
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Conferencia_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
 