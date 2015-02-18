IF object_id(N'vistaDeudas', 'V') IS NOT NULL
	DROP VIEW dbo.vistaDeudas
GO

CREATE VIEW [dbo].[vistaDeudas]
AS
SELECT	dbo.HorarioAlumno.Id as HorarioAlumnoIdReal,
		dbo.HorarioAlumno.IdAlumno, dbo.HorarioAlumno.IdHorario, dbo.HorarioAlumno.FechaInicio, dbo.HorarioAlumno.FechaFin, 

		dbo.Horario.HoraInicio, dbo.Horario.HoraFin, dbo.Horario.Dias, dbo.HorarioAlumno.Activo, 
		dbo.Horario.TipoHorario, dbo.Horario.IdCurso, dbo.Horario.IdNivel, 

		dbo.DetallePago.IdPago, dbo.DetallePago.Cantidad, dbo.DetallePago.Valor, dbo.DetallePago.IVA, dbo.DetallePago.PVP, 
		dbo.DetallePago.Descuento, dbo.DetallePago.IdMotivoPago, dbo.DetallePago.IdHorarioAlumno, 
		dbo.DetallePago.MesPago, dbo.DetallePago.TipoAbono, dbo.DetallePago.Id AS IdDetallePago, 

		dbo.Alumno.Codigo, dbo.Alumno.Nombre, dbo.Alumno.Apellido, 

		dbo.Nivel.IdArea, dbo.Nivel.Nombre AS Nivel, dbo.Area.Nombre AS Area, dbo.Curso.Nombre AS Curso, 

		dbo.Pago.Fecha AS FechaPago
FROM    dbo.HorarioAlumno 
		LEFT OUTER JOIN dbo.DetallePago ON dbo.DetallePago.IdHorarioAlumno = dbo.HorarioAlumno.Id 
		INNER JOIN dbo.Alumno ON dbo.HorarioAlumno.IdAlumno = dbo.Alumno.Id 
		INNER JOIN dbo.Horario ON dbo.HorarioAlumno.IdHorario = dbo.Horario.Id 
		LEFT OUTER JOIN dbo.Curso ON dbo.Curso.Id = dbo.Horario.IdCurso 
		LEFT OUTER JOIN dbo.Nivel ON dbo.Horario.IdNivel = dbo.Nivel.Id
		LEFT OUTER JOIN dbo.Area ON dbo.Area.Id = dbo.Nivel.IdArea 
		FULL OUTER JOIN dbo.Pago ON dbo.DetallePago.IdPago = dbo.Pago.Id 
WHERE     (ISNULL(dbo.DetallePago.IdMotivoPago, 0) IN (1, 2, 0))
go

select * from vistaDeudas
go
