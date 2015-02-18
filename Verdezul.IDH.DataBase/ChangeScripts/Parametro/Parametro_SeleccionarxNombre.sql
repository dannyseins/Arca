IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Parametro_SeleccionarxNombre')
	BEGIN
		DROP  Procedure  Parametro_SeleccionarxNombre
	END

GO

CREATE Procedure Parametro_SeleccionarxNombre
	@Nombre varchar(32),
	@Valor varchar(32) out
AS
	SELECT	@Valor = Valor
	FROM	Parametro 
	WHERE	Nombre = @Nombre
	 
	RETURN 0
GO

DECLARE @Valor varchar(32) 
EXEC Parametro_SeleccionarxNombre 'IVA', @Valor out
SELECT @Valor
GO
