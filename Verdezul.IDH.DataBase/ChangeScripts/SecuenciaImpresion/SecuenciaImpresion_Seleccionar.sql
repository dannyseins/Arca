IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SecuenciaImpresion_Seleccionar')
	BEGIN
		DROP  Procedure  SecuenciaImpresion_Seleccionar
	END

GO

CREATE Procedure SecuenciaImpresion_Seleccionar
	@Id int
AS
	SELECT * FROM SecuenciaImpresion where (Id = @Id or @Id = 0)
GO

EXEC SecuenciaImpresion_Seleccionar 1
GO 
