IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_CerrarCaja')
	BEGIN
		DROP  Procedure  CierreDeCaja_CerrarCaja
	END
GO

CREATE Procedure CierreDeCaja_CerrarCaja
	@IdCierreDeCaja int
AS
	DECLARE @FechaCierre datetime
	SET @FechaCierre = GETDATE()
	
	UPDATE CierreDeCaja SET
		FechaCierre = @FechaCierre
	WHERE 	Id = @IdCierreDeCaja
	
	RETURN 0
GO

--EXEC CierreDeCaja_CerrarCaja 11
--GO
