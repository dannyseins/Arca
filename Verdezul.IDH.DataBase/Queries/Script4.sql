update detallepago
set mespago = '2007-01-01' 
where idmotivopago in (1, 2)

update detallepago
set mespago = DATEADD(week, id, mespago) 
where idmotivopago in (1, 2)

update detallepago
set mespago = DATEADD(day, id, mespago) 
where idmotivopago in (1, 2)
  