IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SecuenciaImpresion_Insertar')
	BEGIN
		DROP  Procedure  SecuenciaImpresion_Insertar
	END
GO

CREATE Procedure SecuenciaImpresion_Insertar
	@Id int out,
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
	INSERT INTO SecuenciaImpresion
		(Fecha, ValorUsado, ValorInicio, ValorFin, Prefijo, NumCaracteres, EnUso, Cerrado, TipoDocumentoPago)
	VALUES
		(@Fecha, @ValorUsado, @ValorInicio, @ValorFin, @Prefijo, @NumCaracteres, @EnUso, @Cerrado, @TipoDocumentoPago)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC SecuenciaImpresion_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
