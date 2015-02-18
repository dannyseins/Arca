
SELECT	HorarioAlumno.*
				FROM	HorarioAlumno
						INNER JOIN Horario ON HorarioAlumno.IdHorario = Horario.Id
				WHERE	TipoHorario = 2
						AND HorarioAlumno.IdAlumno = 18
						GO
 