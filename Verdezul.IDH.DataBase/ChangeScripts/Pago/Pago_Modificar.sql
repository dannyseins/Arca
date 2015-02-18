IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pedido_Modificar')
	BEGIN
		DROP  Procedure  Pedido_Modificar
	END
GO

CREATE Procedure Pedido_Modificar
	@Id	int,
	@IdAlumno int,
	@IdCierreDeCaja	int,
	@IdSecuencia int,
	@Fecha	datetime,
	@TipoDocumentoPago int,
	@Estado	int,
	@FormaPago int,
	@NumeroDocumento	varchar(16),
	@Observacion	varchar(128)
AS
	UPDATE Pedido SET
		IdAlumno = @IdAlumno, 
		IdCierreDeCaja = @IdCierreDeCaja,
		IdSecuencia = @IdSecuencia,
		Fecha = @Fecha, 
		TipoDocumentoPago = @TipoDocumentoPago,
		Estado = @Estado, 
		FormaPago = @FormaPago,
		NumeroDocumento = @NumeroDocumento,
		Observacion = @Observacion
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Pedido_Modificar @Id out, 18, 1, '2008/01/01', 1, 'False', 1, '2558745', '11'
--GO
