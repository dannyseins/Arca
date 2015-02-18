CREATE TABLE [dbo].[Area] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Nombre] VARCHAR (16) NOT NULL,
    CONSTRAINT [PK_Area] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[Nivel] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [IdArea] INT          NOT NULL,
    [Nombre] VARCHAR (32) NOT NULL,
    CONSTRAINT [PK_Nivel] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Nivel_Area] FOREIGN KEY ([IdArea]) REFERENCES [dbo].[Area] ([Id])
);
GO

CREATE TABLE [dbo].[Aula] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Nombre] VARCHAR (32) NOT NULL,
    [Activo] BIT          NOT NULL,
    CONSTRAINT [PK_Aula] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[Caja] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Nombre]      VARCHAR (16) NOT NULL,
    [Observacion] VARCHAR (32) NOT NULL,
    [IP]          VARCHAR (16) NOT NULL,
    CONSTRAINT [PK_Caja] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[Conferencia] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Nombre]     VARCHAR (32) NOT NULL,
    [Fecha]      DATETIME     NOT NULL,
    [Instructor] VARCHAR (32) NOT NULL,
    [Activo]     BIT          NOT NULL,
    CONSTRAINT [PK_Conferencia] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[Curso] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Nombre] VARCHAR (64) NOT NULL,
    [Activo] BIT          NOT NULL,
    CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[Docente] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Nombre]   VARCHAR (32) NOT NULL,
    [Apellido] VARCHAR (32) NOT NULL,
    [Activo]   BIT          NOT NULL,
    CONSTRAINT [PK_Docente] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[EstadoAlumno] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Nombre] VARCHAR (32) NULL,
    CONSTRAINT [PK_EstadoAlumno] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[Parametro] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]        VARCHAR (32)  NOT NULL,
    [Valor]         VARCHAR (32)  NOT NULL,
    [Descripcion]   TEXT          NULL,
    [Tipo]          VARCHAR (128) NOT NULL,
    [Funcionalidad] VARCHAR (64)  NOT NULL,
    CONSTRAINT [PK_Parametro] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[SecuenciaImpresion] (
    [Id]                INT         IDENTITY (1, 1) NOT NULL,
    [Fecha]             DATETIME    NOT NULL,
    [ValorUsado]        INT         NOT NULL,
    [ValorInicio]       INT         NOT NULL,
    [ValorFin]          INT         NOT NULL,
    [Prefijo]           VARCHAR (8) NOT NULL,
    [NumCaracteres]     INT         NOT NULL,
    [EnUso]             BIT         NOT NULL,
    [Cerrado]           BIT         NOT NULL,
    [TipoDocumentoPago] INT         NOT NULL,
    CONSTRAINT [PK_SecuenciaImpresion] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[Usuario] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [TipoRol]        INT          NOT NULL,
    [NickName]       VARCHAR (16) NOT NULL,
    [Clave]          VARCHAR (32) NOT NULL,
    [NombreCompleto] VARCHAR (32) NOT NULL,
    [CI]             VARCHAR (16) NULL,
    [Direccion]      VARCHAR (64) NULL,
    [Telefono]       VARCHAR (16) NULL,
    [Email]          VARCHAR (32) NULL,
    [Activo]         BIT          NOT NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE UNIQUE NONCLUSTERED INDEX [IDX_NickName]
    ON [dbo].[Usuario]([NickName] ASC);
GO

CREATE TABLE [dbo].[CierreDeCaja] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [IdUsuario]     INT          NOT NULL,
    [IdCaja]        INT          NOT NULL,
    [FechaApertura] DATETIME     NOT NULL,
    [FechaCierre]   DATETIME     NULL,
    [Observaciones] VARCHAR (64) NULL,
    CONSTRAINT [PK_CierreDeCaja] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CierreDeCaja_Usuario] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[Usuario] ([Id]),
    CONSTRAINT [FK_CierreDeCaja_Caja] FOREIGN KEY ([IdCaja]) REFERENCES [dbo].[Caja] ([Id])
);
GO

CREATE TABLE [dbo].[Alumno] (
    [Id]                   INT          IDENTITY (1, 1) NOT NULL,
    [IdEstadoAlumno]       INT          NOT NULL,
    [Codigo]               VARCHAR (6)  NOT NULL,
    [Nombre]               VARCHAR (32) NOT NULL,
    [Apellido]             VARCHAR (32) NOT NULL,
    [TipoIdentificacion]   INT          NOT NULL,
    [NumeroIdentificacion] VARCHAR (16) NOT NULL,
    [FechaNacimiento]      DATETIME     NOT NULL,
    [Direccion]            VARCHAR (32) NULL,
    [Email]                VARCHAR (32) NULL,
    [TelefonoDomicilio]    VARCHAR (16) NULL,
    [TelefonoOficina]      VARCHAR (16) NULL,
    [TelefonoCelular]      VARCHAR (16) NULL,
    [FechaIngreso]         DATETIME     NULL,
    [MedioConocimiento]    INT          NOT NULL,
    [OtroConocimiento]     VARCHAR (32) NULL,
    [MotivoInscripcion]    INT          NOT NULL,
    [OtroInscripcion]      VARCHAR (32) NULL,
    [MotivoSalida]         INT          NOT NULL,
    [OtroSalida]           VARCHAR (32) NULL,
    [ArchivoFoto]          VARCHAR (32) NULL,
    CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Alumno_EstadoAlumno] FOREIGN KEY ([IdEstadoAlumno]) REFERENCES [dbo].[EstadoAlumno] ([Id])
);
GO

CREATE TABLE [dbo].[Pago] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [IdAlumno]          INT           NOT NULL,
    [IdCierreDeCaja]    INT           NOT NULL,
    [IdSecuencia]       INT           NOT NULL,
    [Fecha]             DATETIME      NOT NULL,
    [TipoDocumentoPago] INT           NOT NULL,
    [Estado]            INT           NOT NULL,
    [FormaPago]         INT           NOT NULL,
    [NumeroDocumento]   VARCHAR (16)  NOT NULL,
    [Observacion]       VARCHAR (128) NULL,
    CONSTRAINT [PK_Pago] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Pago_CierreDeCaja] FOREIGN KEY ([IdCierreDeCaja]) REFERENCES [dbo].[CierreDeCaja] ([Id]),
    CONSTRAINT [FK_Pago_Alumno] FOREIGN KEY ([IdAlumno]) REFERENCES [dbo].[Alumno] ([Id])
);
GO

CREATE TABLE [dbo].[Observacion] (
    [Id]           INT      IDENTITY (1, 1) NOT NULL,
    [IdAlumno]     INT      NOT NULL,
    [IdDocente]    INT      NOT NULL,
    [TextoAbierto] TEXT     NOT NULL,
    [Fecha]        DATETIME NOT NULL,
    CONSTRAINT [PK_Observacion] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Observacion_Alumno] FOREIGN KEY ([IdAlumno]) REFERENCES [dbo].[Alumno] ([Id])
);
GO

CREATE TABLE [dbo].[Rubro] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Nombre]      VARCHAR (32)    NOT NULL,
    [Descripcion] VARCHAR (64)    NOT NULL,
    [Valor]       DECIMAL (10, 3) NOT NULL,
    [IVA]         DECIMAL (10, 3) NOT NULL,
    [PVP]         DECIMAL (10, 3) NOT NULL,
    [TieneIVA]    BIT             NOT NULL,
    [Activo]      BIT             NOT NULL,
    CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[Horario] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [TipoHorario] INT           NOT NULL,
    [IdCurso]     INT           NULL,
    [IdNivel]     INT           NULL,
    [IdAula]      INT           NOT NULL,
    [IdDocente]   INT           NOT NULL,
    [HoraInicio]  DATETIME      NOT NULL,
    [HoraFin]     DATETIME      NOT NULL,
    [Dias]        VARCHAR (128) NOT NULL,
    [Activo]      BIT           NOT NULL,
    CONSTRAINT [PK_Horario] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Horario_Curso] FOREIGN KEY ([IdCurso]) REFERENCES [dbo].[Curso] ([Id]),
    CONSTRAINT [FK_Horario_Docente] FOREIGN KEY ([IdDocente]) REFERENCES [dbo].[Docente] ([Id]),
    CONSTRAINT [FK_Horario_Aula] FOREIGN KEY ([IdAula]) REFERENCES [dbo].[Aula] ([Id]),
    CONSTRAINT [FK_Horario_Nivel] FOREIGN KEY ([IdNivel]) REFERENCES [dbo].[Nivel] ([Id])
);
GO

CREATE TABLE [dbo].[HorarioAlumno] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [IdAlumno]    INT      NOT NULL,
    [IdHorario]   INT      NOT NULL,
    [FechaInicio] DATETIME NOT NULL,
    [FechaFin]    DATETIME NULL,
    [Activo]      BIT      NOT NULL,
    CONSTRAINT [PK_HorarioAlumno] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_HorarioAlumno_Alumno] FOREIGN KEY ([IdAlumno]) REFERENCES [dbo].[Alumno] ([Id]),
    CONSTRAINT [FK_HorarioAlumno_Horario] FOREIGN KEY ([IdHorario]) REFERENCES [dbo].[Horario] ([Id])
);
GO

CREATE TABLE [dbo].[DetallePago] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [IdPago]          INT             NOT NULL,
    [Cantidad]        INT             NOT NULL,
    [Valor]           DECIMAL (10, 3) NOT NULL,
    [IVA]             DECIMAL (10, 3) NOT NULL,
    [PVP]             DECIMAL (10, 3) NOT NULL,
    [Descuento]       INT             NOT NULL,
    [IdMotivoPago]    INT             NOT NULL,
    [IdRubro]         INT             NULL,
    [IdConferencia]   INT             NULL,
    [IdHorarioAlumno] INT             NULL,
    [MesPago]         DATETIME        NULL,
    [TipoAbono]       INT             NOT NULL,
    CONSTRAINT [PK_DetallePago] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DetallePago_Conferencia] FOREIGN KEY ([IdConferencia]) REFERENCES [dbo].[Conferencia] ([Id]),
    CONSTRAINT [FK_DetallePago_Rubro] FOREIGN KEY ([IdRubro]) REFERENCES [dbo].[Rubro] ([Id]),
    CONSTRAINT [FK_DetallePago_Pago] FOREIGN KEY ([IdPago]) REFERENCES [dbo].[Pago] ([Id]),
    CONSTRAINT [FK_DetallePago_HorarioAlumno] FOREIGN KEY ([IdHorarioAlumno]) REFERENCES [dbo].[HorarioAlumno] ([Id])
);
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
GO
