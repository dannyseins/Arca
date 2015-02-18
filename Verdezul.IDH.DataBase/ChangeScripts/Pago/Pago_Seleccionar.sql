IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pago_Seleccionar')
	BEGIN
		DROP  Procedure  Pago_Seleccionar
	END

GO

CREATE Procedure Pago_Seleccionar
	@Id int = 0,
	@IdAlumno int = 0,
	@IdCierreDeCaja int = 0
AS
	SELECT	*
	FROM	Pago 
	WHERE	(Id = @Id or @Id = 0)
	AND		(IdAlumno = @IdAlumno or @IdAlumno = 0)
	AND		(IdCierreDeCaja = @IdCierreDeCaja or @IdCierreDeCaja = 0)
	
GO

EXEC Pago_Seleccionar 0, 18--, 0
GO
