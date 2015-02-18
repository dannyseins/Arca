IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_Seleccionar')
	BEGIN
		DROP  Procedure  CierreDeCaja_Seleccionar
	END

GO

CREATE Procedure CierreDeCaja_Seleccionar
	@Id int
AS
	SELECT	CierreDeCaja.*,
			Caja.Nombre as Caja,
			Usuario.NickName as Usuario
	FROM	CierreDeCaja 
			INNER JOIN Caja ON Caja.Id = CierreDeCaja.IdCaja
			INNER JOIN Usuario ON Usuario.Id = CierreDeCaja.IdUsuario
	WHERE	(CierreDeCaja.Id = @Id or @Id = 0)
GO

EXEC CierreDeCaja_Seleccionar 13
GO 
