IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pago_CambiarEstado')
	BEGIN
		DROP  Procedure  Pago_CambiarEstado
	END
GO

CREATE Procedure Pago_CambiarEstado
	@ListaPedidos varchar(max),
	@Estado	int
AS

	DECLARE @SQL varchar(max)
	SET @SQL = '
		UPDATE Pago SET
			Estado = ' + CAST(@Estado AS VARCHAR) + '
		WHERE Id in (' + @ListaPedidos + ')'

	EXEC(@SQL)
	RETURN 0
GO

--EXEC Pago_CambiarEstado '46, 47, 48', 5
--GO
