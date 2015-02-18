IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_Modificar')
	BEGIN
		DROP  Procedure  Horario_Modificar
	END
GO

CREATE Procedure Horario_Modificar
	@Id int,
	@TipoHorario int,
	@IdCurso int,
	@IdNivel int,
	@IdAula int,
	@IdDocente int,
    @HoraInicio datetime,
    @HoraFin datetime,
    @Dias varchar(128),
    @Activo bit
AS
	UPDATE Horario SET
		TipoHorario = @TipoHorario,
		IdCurso = @IdCurso, 
		IdNivel = @IdNivel,
		IdAula = @IdAula,
		IdDocente = @IdDocente, 
		HoraInicio = @HoraInicio,
		HoraFin = @HoraFin, 
		Dias = @Dias,
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Horario_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
 