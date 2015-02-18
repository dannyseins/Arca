IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SecuenciaImpresion_PedirNuevoNumeroSecuencia')
	BEGIN
		DROP  Procedure  SecuenciaImpresion_PedirNuevoNumeroSecuencia
	END

GO

CREATE Procedure SecuenciaImpresion_PedirNuevoNumeroSecuencia
	@TipoDocumentoPago int
AS
	UPDATE	SecuenciaImpresion 
	SET		ValorUsado = ValorUsado + 1
	WHERE	EnUso = 'True'
	AND		TipoDocumentoPago = @TipoDocumentoPago
	
	SELECT	* 
	FROM	SecuenciaImpresion 
	WHERE	EnUso = 'True'
	AND		TipoDocumentoPago = @TipoDocumentoPago
	
	RETURN 0
GO

--EXEC SecuenciaImpresion_PedirNuevoNumeroSecuencia 2
--GO  
