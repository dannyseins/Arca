IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Horario_Insertar')
	BEGIN
		DROP  Procedure  Horario_Insertar
	END
GO

CREATE Procedure Horario_Insertar
	@Id int out,
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
	INSERT INTO Horario
		(TipoHorario, IdCurso, IdNivel, 
		IdAula, IdDocente, HoraInicio, HoraFin, Dias, Activo)
	VALUES
		(@TipoHorario, @IdCurso, @IdNivel, 
		@IdAula, @IdDocente, @HoraInicio, @HoraFin, @Dias, @Activo)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Horario_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
 