IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Rubro_Insertar')
	BEGIN
		DROP  Procedure  Rubro_Insertar
	END
GO

CREATE Procedure Rubro_Insertar
	@Id int out,
    @Nombre varchar(32),
    @Descripcion varchar(64),
    @Valor decimal(10,3),
    @IVA decimal(10,3),
    @PVP decimal(10,3),
    @TieneIVA bit,
    @Activo bit
AS
	INSERT INTO Rubro
		(Nombre, Descripcion, Valor, IVA, PVP, TieneIVA, Activo)
	VALUES
		(@Nombre, @Descripcion, @Valor, @IVA, @PVP, @TieneIVA, @Activo)

	SELECT @Id = scope_identity()
	
	RETURN 0
GO

--DECLARE @Id INT
--EXEC Rubro_Insertar @Id out, 'NombreCompleto1', '1', '1714153390', 'Direccion1', '2558745', 'Email@Email.COM', true
--SELECT @Id
--GO
 