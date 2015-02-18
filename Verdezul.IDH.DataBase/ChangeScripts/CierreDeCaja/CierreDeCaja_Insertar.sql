IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_Insertar')
	BEGIN
		DROP  Procedure  CierreDeCaja_Insertar
	END
GO

CREATE Procedure CierreDeCaja_Insertar
	@Id int out,
    @IdCaja int,
    @IdUsuario int,
    @FechaApertura datetime,
    @FechaCierre datetime,
    @Observaciones varchar(64)
AS
	INSERT INTO CierreDeCaja
		(IdCaja, IdUsuario, FechaApertura, FechaCierre, Observaciones)
	VALUES
		(@IdCaja, @IdUsuario, @FechaApertura, @FechaCierre, @Observaciones)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC CierreDeCaja_Insertar @Id out, 1, 1, '01/01/2005', '01/01/2005', '2558745'
--SELECT @Id
--GO
 