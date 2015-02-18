IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pago_Insertar')
	BEGIN
		DROP  Procedure  Pago_Insertar
	END
GO

CREATE Procedure Pago_Insertar
	@Id	int	out,
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
	INSERT INTO Pago
		(IdAlumno, IdCierreDeCaja, IdSecuencia, Fecha, TipoDocumentoPago, Estado, FormaPago, NumeroDocumento, Observacion)
	VALUES
		(@IdAlumno, @IdCierreDeCaja, @IdSecuencia, @Fecha, @TipoDocumentoPago, @Estado, @FormaPago, @NumeroDocumento, @Observacion)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Pago_Insertar @Id out, 18, 1, '2008/01/01', 1, 'False', 2, '2558745', '11'
--SELECT @Id
