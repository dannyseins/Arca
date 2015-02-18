-- cursos
declare @idalumno int set @idalumno = 18
declare @mespago datetime set @mespago = '2008-03-16'
declare @tipoHorario int, @idmotivopago int select @tipoHorario = 1, @idmotivopago = 1
declare @idcurso int set @idcurso = 3

select	--detallepago.*, idhorario, idcurso, Cantidad, Valor, IVA, PVP, Descuento, idhorario, mespago, 
		idhorario, TipoAbono, fecha
from	detallepago 
		inner join pago on pago.id = detallepago.idpago
		inner join horario on horario.id = detallepago.idhorario
where	idmotivopago = @idmotivopago
and		mespago = @mespago
and		idcurso = @idcurso
and 	idalumno = @idalumno

select	horarioalumno.*--, horario.* --,idhorario, idcurso, fecha
from	horarioalumno
		inner join horario on horario.id = horarioalumno.idhorario
where	horarioalumno.activo = 'true'
and		tipoHorario = @tipoHorario
and		idcurso = @idcurso
and		idalumno = @idalumno

