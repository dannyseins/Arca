IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Caja_Insertar')
	BEGIN
		DROP  Procedure  Caja_Insertar
	END
GO

CREATE Procedure Caja_Insertar
	@Id int out,
    @Nombre varchar(16),
    @IP varchar(32),
    @Observacion varchar(32)
AS
	INSERT INTO Caja
		(Nombre, IP, Observacion)
	VALUES
		(@Nombre, @IP, @Observacion)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Caja_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
