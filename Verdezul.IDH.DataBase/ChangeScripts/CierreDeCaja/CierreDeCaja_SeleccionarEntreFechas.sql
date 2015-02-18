IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_SeleccionarEntreFechas')
	BEGIN
		DROP  Procedure  CierreDeCaja_SeleccionarEntreFechas
	END

GO

CREATE Procedure CierreDeCaja_SeleccionarEntreFechas
	@FechaDesde datetime,
	@FechaHasta datetime
AS
	SELECT	Caja.Nombre as Caja,
			Usuario.NickName as Usuario,
			CierreDeCaja.*,
			0 as Valor
	FROM	CierreDeCaja
			INNER JOIN Caja ON Caja.Id = CierreDeCaja.IdCaja
			INNER JOIN Usuario ON Usuario.Id = CierreDeCaja.IdUsuario
	WHERE	FechaCierre BETWEEN @FechaDesde AND @FechaHasta
GO

EXEC CierreDeCaja_SeleccionarEntreFechas '05/15/2009', '05/15/2010'
GO 
