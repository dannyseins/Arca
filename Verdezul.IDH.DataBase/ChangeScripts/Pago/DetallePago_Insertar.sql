IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'DetallePago_Insertar')
	BEGIN
		DROP  Procedure  DetallePago_Insertar
	END
GO

CREATE Procedure DetallePago_Insertar
	@Id					int	out,
	@IdPago				int,
	@Cantidad			int,
	@Valor				decimal(10, 2),
	@IVA				decimal(10, 2),
	@PVP				decimal(10, 2),
	@Descuento			decimal(10, 2),
	@IdMotivoPago		int,
	@IdRubro			int,
	@IdConferencia		int,
	@IdHorarioAlumno	int,
	@MesPago			datetime,
	@TipoAbono			int
AS
	INSERT INTO DetallePago
		(IdPago, Cantidad, Valor, IVA, PVP, Descuento, 
		IdMotivoPago, IdRubro, IdConferencia,
		IdHorarioAlumno, MesPago, TipoAbono)
	VALUES
		(@IdPago, @Cantidad, @Valor, @IVA, @PVP, @Descuento, 
		@IdMotivoPago, @IdRubro, @IdConferencia, 
		@IdHorarioAlumno, @MesPago, @TipoAbono)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC DetallePago_Insertar @Id out, 1, 1, 2, 2, 2, 2
--SELECT @Id
--GO
 