SELECT	HorarioCurso.Id, 
		HorarioCurso.IdCurso, 
		HorarioCurso.IdAula, 
		HorarioCurso.IdDocente, 
		HorarioCurso.HoraInicio, 
		HorarioCurso.HoraFin, 
		HorarioCurso.Activo, 
		Docente.Nombre + ' ' + Docente.Apellido AS Docente, 
		Curso.Nombre AS Curso, 
		Aula.Nombre AS Aula
FROM	HorarioCurso INNER JOIN
		Docente ON HorarioCurso.IdDocente = Docente.Id INNER JOIN
		Aula ON HorarioCurso.IdAula = Aula.Id INNER JOIN
		Curso ON HorarioCurso.IdCurso = Curso.Id