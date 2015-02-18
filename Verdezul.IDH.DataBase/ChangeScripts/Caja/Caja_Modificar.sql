IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Caja_Modificar')
	BEGIN
		DROP  Procedure  Caja_Modificar
	END
GO

CREATE Procedure Caja_Modificar
	@Id int,
    @Nombre varchar(16),
    @IP varchar(32),
    @Observacion varchar(32)
AS
	UPDATE Caja SET
		Nombre = @Nombre, 
		IP = @IP,
		Observacion = @Observacion
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Caja_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
