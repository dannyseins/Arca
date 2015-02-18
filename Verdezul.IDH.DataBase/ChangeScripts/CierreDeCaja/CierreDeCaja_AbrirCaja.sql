IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_AbrirCaja')
	BEGIN
		DROP  Procedure  CierreDeCaja_AbrirCaja
	END
GO

CREATE Procedure CierreDeCaja_AbrirCaja
	@IdCierreDeCaja int out,
	@IdCaja	int,
	@IdUsuario int
AS
	DECLARE @FechaApertura datetime
	SET @FechaApertura = GETDATE()
	EXEC CierreDeCaja_Insertar @IdCierreDeCaja out, @IdCaja, @IdUsuario, @FechaApertura, null, null

	RETURN 0
GO

--DECLARE @Id INT
--EXEC CierreDeCaja_AbrirCaja @Id out, 1, 1
--SELECT @Id
--GO
