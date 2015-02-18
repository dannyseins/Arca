IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pago_SeleccionarConDetallexCierreDeCaja')
	BEGIN
		DROP  Procedure  Pago_SeleccionarConDetallexCierreDeCaja
	END

GO

CREATE Procedure Pago_SeleccionarConDetallexCierreDeCaja
	@IdCierreDeCaja int
AS
	SELECT	DetallePago.Id, 
			DetallePago.IdPago, 
			DetallePago.Cantidad, 
			DetallePago.Valor, 
			DetallePago.IVA, 
			DetallePago.PVP, 
			DetallePago.Descuento, 
			DetallePago.IdMotivoPago, 
			DetallePago.IdRubro, 
			DetallePago.IdConferencia
			,DetallePago.IdHorarioAlumno
			,DetallePago.MesPago
			,DetallePago.TipoAbono
			
			,Rubro.Nombre AS Rubro
			,Conferencia.Nombre AS Conferencia
			,Curso.Nombre AS Curso
			,Nivel.Nombre AS Nivel
			,Area.Nombre AS Area
			,HoraInicio, HoraFin, Dias
			
	FROM	DetallePago
			LEFT OUTER JOIN Rubro ON DetallePago.IdRubro = Rubro.Id
			LEFT OUTER JOIN Conferencia ON DetallePago.IdConferencia = Conferencia.Id
			LEFT OUTER JOIN HorarioAlumno ON DetallePago.IdHorarioAlumno = HorarioAlumno.Id
			LEFT OUTER JOIN Horario ON HorarioAlumno.IdHorario = Horario.Id
			LEFT OUTER JOIN Curso ON Horario.IdCurso = Curso.Id
			LEFT OUTER JOIN Nivel ON Horario.IdNivel = Nivel.Id
			LEFT OUTER JOIN Area ON Nivel.IdArea = Area.Id
	WHERE	IdPago in 
			(	SELECT	Id 
				FROM	Pago 
				WHERE	(IdCierreDeCaja = @IdCierreDeCaja)	 )

	SELECT	Pago.Id, 
			Pago.NumeroDocumento, 
			Alumno.Nombre + ' ' + Alumno.Apellido AS Alumno,
			Pago.Fecha, 
			Pago.Estado, 
			Pago.FormaPago,
			Pago.IdAlumno,
			Pago.IdCierreDeCaja,
			Pago.TipoDocumentoPago,
			Pago.IdSecuencia,
			ISNULL(SUM(DetallePago.PVP), 0) AS Valor,
			Pago.Observacion, 
			'' AS EstadoTexto,
			'' AS FormaPagoTexto,
			'' AS TipoDocumentoPagoTexto
	FROM	Pago INNER JOIN
			Alumno ON Pago.IdAlumno = Alumno.Id LEFT OUTER JOIN
			DetallePago ON Pago.Id = DetallePago.IdPago
	WHERE	(Pago.IdCierreDeCaja = @IdCierreDeCaja)
	GROUP BY	Pago.Id, Pago.IdAlumno, Pago.IdCierreDeCaja, Pago.TipoDocumentoPago,
				Pago.Fecha, Pago.Estado, 
				Pago.Observacion, 
				Pago.NumeroDocumento,
				Alumno.Nombre + ' ' + Alumno.Apellido
				,Pago.FormaPago, Pago.IdSecuencia
	ORDER BY	Pago.Fecha

GO

EXEC Pago_SeleccionarConDetallexCierreDeCaja 13
GO
