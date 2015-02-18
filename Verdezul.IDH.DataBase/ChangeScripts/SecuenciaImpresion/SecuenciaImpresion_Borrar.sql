IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SecuenciaImpresion_Borrar')
	BEGIN
		DROP  Procedure  SecuenciaImpresion_Borrar
	END
GO

CREATE Procedure SecuenciaImpresion_Borrar
	@Id int
AS
	DELETE FROM SecuenciaImpresion
	WHERE Id = @Id
	
	RETURN 0
GO

--EXEC SecuenciaImpresion_Borrar 21
--GO
  