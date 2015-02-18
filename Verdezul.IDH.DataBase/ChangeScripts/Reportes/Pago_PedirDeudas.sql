IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Pago_PedirDeudas')
	BEGIN DROP  Procedure  Pago_PedirDeudas END
GO

CREATE Procedure Pago_PedirDeudas
	@tipoHorarioIdMotivoPago int,
	@IdCurso int,
	@IdArea int,
	@IdNivel int,
	@IdAlumno int,
	@MesDeuda datetime
AS

declare @valorMensualidad decimal(10,3)
select @valorMensualidad = Valor from parametro where nombre = 'ValorMensualidad'

select	HorarioAlumnoIdReal, Area, Nivel, Curso,
		HoraInicio, HoraFin, Dias,
		Nombre + ' ' + Apellido as Alumno,
		SUM(isnull(PVP, 0)) as 'SumaPVP',
		@valorMensualidad as ValorMensualidad,
		(@valorMensualidad - sum(isnull(PVP, 0))) AS 'Diferencia',
		FechaInicio, FechaFin, MesPago
		--IdAlumno, IdCurso, IdArea, IdNivel, IdHorario, IdDetallePago, TipoHorario, IdMotivoPago, IdPago, Activo,
		--TipoAbono, FechaPago, Cantidad, Valor, IVA, Descuento, HorarioAlumnoIdReal, IdHorarioAlumno,
from	vistaDeudas
where	(tipoHorario = @tipoHorarioIdMotivoPago or @tipoHorarioIdMotivoPago = 0)
and		(isnull(IdMotivoPago, @tipoHorarioIdMotivoPago) = @tipoHorarioIdMotivoPago or @tipoHorarioIdMotivoPago = 0)
and		(IdCurso = @IdCurso or @IdCurso = 0)
and		(IdArea = @IdArea or @IdArea = 0)
and		(IdNivel = @IdNivel or @IdNivel = 0)
and		(IdAlumno = @IdAlumno or @IdAlumno = 0)
and		isnull(mesPago, @MesDeuda) = @MesDeuda
and		FechaInicio <= @MesDeuda
and		isnull(FechaFin, @MesDeuda) >= @MesDeuda
group by	HorarioAlumnoIdReal, Area, Nivel, Curso,
			HoraInicio, HoraFin, Dias,
			Nombre + ' ' + Apellido,
			FechaInicio, FechaFin, MesPago

order by 1
GO

--EXEC Pago_PedirDeudas 0, 0, 0, 0, 18, '01-01-2005'
--GO 
