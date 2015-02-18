IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_PedirIdCierreDeCajaxIdCajaIdUsuario')
	BEGIN
		DROP  Procedure  CierreDeCaja_PedirIdCierreDeCajaxIdCajaIdUsuario
	END
GO

CREATE Procedure CierreDeCaja_PedirIdCierreDeCajaxIdCajaIdUsuario
	@IdCierreDeCaja int out,
	@IdCaja	int,
	@IdUsuario int
AS
	-- Verifica que exista el usuario
	IF NOT EXISTS(SELECT Id FROM Usuario WHERE Id = @IdUsuario)
		RETURN 0
	
	-- Verifica que exista la caja	
	IF NOT EXISTS(SELECT Id FROM Caja WHERE Id = @IdCaja)
		RETURN 0
	
	-- Verifica si la caja este cerrada
	IF NOT EXISTS(SELECT Id FROM CierreDeCaja WHERE	FechaCierre is null AND IdCaja = @IdCaja)
		SET @IdCierreDeCaja = 0
	ELSE
	BEGIN
		SELECT	@IdCierreDeCaja = Id
		FROM	CierreDeCaja
		WHERE	FechaCierre is null
		AND		IdCaja = @IdCaja
		AND		IdUsuario = @IdUsuario
		
		IF @IdCierreDeCaja is null
			SET @IdCierreDeCaja = -1
	END
	RETURN 0
GO

DECLARE @Id INT
EXEC CierreDeCaja_PedirIdCierreDeCajaxIdCajaIdUsuario @Id out, 3, 3

IF @Id > 0
	PRINT 'La Caja esta siendo usada por el usuario en el Cierre de Caja ' + cast(@Id as varchar)
ELSE IF @Id = 0
	PRINT 'La Caja esta cerrada'
ELSE IF @Id < 0
	PRINT 'La Caja esta siendo usada por otro usuario'
ELSE
	PRINT 'El usuario o la caja no existen'
GO
