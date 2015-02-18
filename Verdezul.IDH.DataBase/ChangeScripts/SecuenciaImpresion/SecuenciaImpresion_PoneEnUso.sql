IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SecuenciaImpresion_PonerEnUso')
	BEGIN
		DROP  Procedure  SecuenciaImpresion_PonerEnUso
	END
GO

CREATE Procedure SecuenciaImpresion_PonerEnUso
	@IdSecuenciaImpresion int,
	@TipoDocumentoPago	int
AS
	UPDATE SecuenciaImpresion SET
		EnUso = 'FALSE'
	WHERE	TipoDocumentoPago = @TipoDocumentoPago
	
	UPDATE SecuenciaImpresion SET
		EnUso = 'TRUE'
	WHERE 	Id = @IdSecuenciaImpresion
	
	RETURN 0
GO

--EXEC SecuenciaImpresion_PonerEnUso 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
