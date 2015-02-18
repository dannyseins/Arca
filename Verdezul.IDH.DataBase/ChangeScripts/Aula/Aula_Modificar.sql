IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Aula_Modificar')
	BEGIN
		DROP  Procedure  Aula_Modificar
	END
GO

CREATE Procedure Aula_Modificar
	@Id int,
    @Nombre varchar(32),
    @Activo bit
AS
	UPDATE Aula SET
		Nombre = @Nombre,
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Aula_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
 