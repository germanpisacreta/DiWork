USE [pruebademo]
GO
/****** Object:  Table [dbo].[Automovil]    Script Date: 10/7/2023 12:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Automovil](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdVehiculo] [bigint] NULL,
	[Tipo] [smallint] NULL,
	[CantidadPuertas] [numeric](1, 0) NULL,
 CONSTRAINT [PK__Automovi__3214EC07BEDEB5FA] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Desperfecto]    Script Date: 10/7/2023 12:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Desperfecto](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[idPresupuesto] [bigint] NULL,
	[Descripcion] [varchar](200) NULL,
	[ManoDeObra] [decimal](18, 6) NULL,
	[Tiempo] [numeric](3, 0) NULL,
 CONSTRAINT [PK__Desperfe__3213E83FDB564742] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DesperfectoRepuesto]    Script Date: 10/7/2023 12:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DesperfectoRepuesto](
	[IdDesperfecto] [bigint] NOT NULL,
	[IdRepuesto] [int] NOT NULL,
 CONSTRAINT [PK_DesperfectoRepuesto] PRIMARY KEY CLUSTERED 
(
	[IdDesperfecto] ASC,
	[IdRepuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Moto]    Script Date: 10/7/2023 12:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Moto](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdVehiculo] [bigint] NULL,
	[Cilindrado] [varchar](50) NULL,
 CONSTRAINT [PK__Moto__3214EC07CF2E7C90] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presupuesto]    Script Date: 10/7/2023 12:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presupuesto](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[Total] [decimal](20, 6) NULL,
	[Recargo] [decimal](18, 6) NULL,
	[Tipo] [int] NULL,
	[IdVehiculo] [bigint] NULL,
 CONSTRAINT [PK__Presupue__3214EC073D3A507A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repuesto]    Script Date: 10/7/2023 12:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repuesto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Precio] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Repuesto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 10/7/2023 12:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](100) NULL,
	[Modelo] [varchar](100) NULL,
	[Patente] [varchar](10) NULL,
 CONSTRAINT [PK__Vehiculo__3214EC07C7FBDEB8] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Automovil]  WITH CHECK ADD  CONSTRAINT [FK__Automovil__IdVeh__412EB0B6] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculo] ([Id])
GO
ALTER TABLE [dbo].[Automovil] CHECK CONSTRAINT [FK__Automovil__IdVeh__412EB0B6]
GO
ALTER TABLE [dbo].[Desperfecto]  WITH CHECK ADD  CONSTRAINT [FK__Desperfec__idPre__3B75D760] FOREIGN KEY([idPresupuesto])
REFERENCES [dbo].[Presupuesto] ([Id])
GO
ALTER TABLE [dbo].[Desperfecto] CHECK CONSTRAINT [FK__Desperfec__idPre__3B75D760]
GO
ALTER TABLE [dbo].[DesperfectoRepuesto]  WITH CHECK ADD  CONSTRAINT [FK_DesperfectoRepuesto_Desperfecto] FOREIGN KEY([IdDesperfecto])
REFERENCES [dbo].[Desperfecto] ([id])
GO
ALTER TABLE [dbo].[DesperfectoRepuesto] CHECK CONSTRAINT [FK_DesperfectoRepuesto_Desperfecto]
GO
ALTER TABLE [dbo].[DesperfectoRepuesto]  WITH CHECK ADD  CONSTRAINT [FK_DesperfectoRepuesto_Repuestos] FOREIGN KEY([IdRepuesto])
REFERENCES [dbo].[Repuesto] ([Id])
GO
ALTER TABLE [dbo].[DesperfectoRepuesto] CHECK CONSTRAINT [FK_DesperfectoRepuesto_Repuestos]
GO
ALTER TABLE [dbo].[Moto]  WITH CHECK ADD  CONSTRAINT [FK__Moto__IdVehiculo__3E52440B] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculo] ([Id])
GO
ALTER TABLE [dbo].[Moto] CHECK CONSTRAINT [FK__Moto__IdVehiculo__3E52440B]
GO
ALTER TABLE [dbo].[Presupuesto]  WITH CHECK ADD  CONSTRAINT [FK__Presupues__IdVeh__38996AB5] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculo] ([Id])
GO
ALTER TABLE [dbo].[Presupuesto] CHECK CONSTRAINT [FK__Presupues__IdVeh__38996AB5]
GO
