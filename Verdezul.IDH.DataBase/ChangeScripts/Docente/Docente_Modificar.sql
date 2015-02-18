IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Docente_Modificar')
	BEGIN
		DROP  Procedure  Docente_Modificar
	END
GO

CREATE Procedure Docente_Modificar
	@Id int,
    @Nombre varchar(32),
    @Apellido varchar(32),
    @Activo bit
AS
	UPDATE Docente SET
		Nombre = @Nombre,
		Apellido = @Apellido,
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Docente_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
 