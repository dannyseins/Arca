IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'CierreDeCaja_Modificar')
	BEGIN
		DROP  Procedure  CierreDeCaja_Modificar
	END
GO

CREATE Procedure CierreDeCaja_Modificar
	@Id int,
    @IdCaja int,
    @IdUsuario int,
    @FechaApertura datetime,
    @FechaCierre datetime,
    @Observaciones varchar(64)
AS
	UPDATE CierreDeCaja SET
		IdCaja = @IdCaja, 
		IdUsuario = @IdUsuario,
		FechaApertura = @FechaApertura, 
		FechaCierre = @FechaCierre, 
		Observaciones = @Observaciones
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC CierreDeCaja_Modificar 11, 1, 1, '2001/01/01', '2001/01/01', 'ninguna'
--GO
 