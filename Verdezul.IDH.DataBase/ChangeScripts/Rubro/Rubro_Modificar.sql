IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'Rubro_Modificar')
	BEGIN
		DROP  Procedure  Rubro_Modificar
	END
GO

CREATE Procedure Rubro_Modificar
	@Id int,
    @Nombre varchar(32),
    @Descripcion varchar(64),
    @Valor decimal(10,2),
    @IVA decimal(10,2),
    @PVP decimal(10,2),
    @TieneIVA bit,
    @Activo bit
AS
	UPDATE Rubro SET
		Nombre = @Nombre, 
		Descripcion = @Descripcion,
		Valor = @Valor, 
		IVA = @IVA, 
		PVP = @PVP, 
		TieneIVA = @TieneIVA,
		Activo = @Activo
	WHERE 	Id = @Id
	
	RETURN 0
GO

--EXEC Rubro_Modificar 18, 'NombreCompleto2', '2', '1714153392', 'Direccion2', '2558745', 'Email@Email2.com', false
--GO
 