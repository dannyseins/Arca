IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SecuenciaImpresion_Modificar')
	BEGIN
		DROP  Procedure  SecuenciaImpresion_Modificar
	END
GO

CREATE Procedure SecuenciaImpresion_Modificar
	@Id int,
	@Fecha	datetime	,
	@ValorUsado	int	,
	@ValorInicio	int	,
	@ValorFin	int	,
	@Prefijo	varchar(8)	,
	@NumCaracteres	int	,
	@EnUso	bit	,
	@Cerrado	bit	,
	@TipoDocumentoPago	int
AS
	UPDATE SecuenciaImpresion SET
		Fecha = @Fecha, 
		ValorUsado = @ValorUsado,
		ValorInicio = @ValorInicio, 
		ValorFin = @ValorFin, 
		Prefijo = @Prefijo, 
		NumCaracteres = @NumCaracteres,
		EnUso = @EnUso,
		Cerrado = @Cerrado,
		TipoDocumentoPago = @TipoDocumentoPago
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC SecuenciaImpresion_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
