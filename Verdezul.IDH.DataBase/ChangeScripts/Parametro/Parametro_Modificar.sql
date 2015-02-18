IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Parametro_Modificar')
	BEGIN
		DROP  Procedure  Parametro_Modificar
	END
GO

CREATE Procedure Parametro_Modificar
	@Id int,
    @Nombre varchar(16),
    @Valor varchar(32),
    @Descripcion varchar(32)
AS
	UPDATE Parametro SET
		Nombre = @Nombre, 
		Valor = @Valor,
		Descripcion = @Descripcion
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Parametro_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
