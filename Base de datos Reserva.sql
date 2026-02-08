USE [master]
GO
/****** Object:  Database [Reserva]    ******/
CREATE DATABASE [Reserva]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Reserva', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER\MSSQL\DATA\Reserva.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Reserva_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER\MSSQL\DATA\Reserva_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Reserva] SET COMPATIBILITY_LEVEL = 170
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Reserva].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Reserva] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Reserva] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Reserva] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Reserva] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Reserva] SET ARITHABORT OFF 
GO
ALTER DATABASE [Reserva] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Reserva] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Reserva] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Reserva] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Reserva] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Reserva] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Reserva] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Reserva] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Reserva] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Reserva] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Reserva] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Reserva] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Reserva] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Reserva] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Reserva] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Reserva] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Reserva] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Reserva] SET RECOVERY FULL 
GO
ALTER DATABASE [Reserva] SET  MULTI_USER 
GO
ALTER DATABASE [Reserva] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Reserva] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Reserva] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Reserva] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Reserva] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Reserva] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Reserva] SET OPTIMIZED_LOCKING = OFF 
GO
ALTER DATABASE [Reserva] SET QUERY_STORE = ON
GO
ALTER DATABASE [Reserva] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Reserva]
GO
/****** Object:  Table [dbo].[Autor]    Script Date: 6/2/2026 20:01:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autor](
	[Nombre_Sistema] [nvarchar](100) NOT NULL,
	[Duenio] [nvarchar](100) NOT NULL,
	[Descripcion] [nvarchar](1000) NOT NULL,
	[Correo] [nvarchar](100) NOT NULL,
	[Telefono] [nvarchar](20) NOT NULL,
	[Ruta_Foto] [nvarchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitacion]    Script Date: 6/2/2026 20:01:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitacion](
	[Id_Habitacion] [int] NOT NULL,
	[Num_Habitacion] [varchar](10) NOT NULL,
	[Num_Piso] [int] NOT NULL,
	[Tipo_Habitacion] [varchar](50) NOT NULL,
	[Cant_Camas] [int] NOT NULL,
	[Cant_Baños] [int] NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[Estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Habitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Huesped]    Script Date: 6/2/2026 20:01:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Huesped](
	[Id_Huesped] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](15) NOT NULL,
	[Nombres] [varchar](100) NOT NULL,
	[Nacionalidad] [varchar](50) NULL,
	[Correo] [varchar](100) NULL,
	[Telefono] [varchar](20) NULL,
	[Estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Huesped] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 6/2/2026 20:01:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[Id_Reserva] [int] IDENTITY(1,1) NOT NULL,
	[Id_Huesped] [int] NOT NULL,
	[Id_Habitacion] [int] NULL,
	[Id_Servicio] [int] NULL,
	[Fecha_Llegada] [date] NOT NULL,
	[Fecha_Salida] [date] NOT NULL,
	[Fecha_De_Reserva] [datetime] NOT NULL,
	[Cantidad_Adulto] [int] NOT NULL,
	[Cantidad_Ninios] [int] NOT NULL,
	[Sub_Total] [decimal](10, 2) NOT NULL,
	[Iva] [decimal](10, 2) NOT NULL,
	[Total] [decimal](10, 2) NOT NULL,
	[Estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 6/2/2026 20:01:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[Id_Servicio] [int] NOT NULL,
	[Nombre_Servicio] [varchar](50) NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[Estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Autor] ([Nombre_Sistema], [Duenio], [Descripcion], [Correo], [Telefono], [Ruta_Foto]) VALUES (N'Sistema de Gestion Hotelera', N'Joseph Johan Bone Castillo', N'Sistema de gestion hotelera diseñado para administrar reservas, registrar datos de huespedes, asignar habitaciones y calcular costos de estadia y servicios adicionales de forma automatica', N'joseph.bone@gmail.com', N'+593 99 321 0217', N'C:\Users\bonec\Documents\proyecto c#\6-Noviembre-2025-Bone Castillo Joseph Johan\Visual_\Resources\Gemini_Generated_Image_85ab1a85ab1a85ab.png')
GO
INSERT [dbo].[Habitacion] ([Id_Habitacion], [Num_Habitacion], [Num_Piso], [Tipo_Habitacion], [Cant_Camas], [Cant_Baños], [Precio], [Estado]) VALUES (1, N'101', 1, N'Matrimonial', 1, 1, CAST(50.00 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Habitacion] ([Id_Habitacion], [Num_Habitacion], [Num_Piso], [Tipo_Habitacion], [Cant_Camas], [Cant_Baños], [Precio], [Estado]) VALUES (2, N'102', 1, N'Simple', 1, 1, CAST(35.00 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Habitacion] ([Id_Habitacion], [Num_Habitacion], [Num_Piso], [Tipo_Habitacion], [Cant_Camas], [Cant_Baños], [Precio], [Estado]) VALUES (3, N'201', 2, N'Doble', 2, 1, CAST(65.00 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Habitacion] ([Id_Habitacion], [Num_Habitacion], [Num_Piso], [Tipo_Habitacion], [Cant_Camas], [Cant_Baños], [Precio], [Estado]) VALUES (4, N'202', 2, N'Suite', 2, 2, CAST(100.00 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Habitacion] ([Id_Habitacion], [Num_Habitacion], [Num_Piso], [Tipo_Habitacion], [Cant_Camas], [Cant_Baños], [Precio], [Estado]) VALUES (5, N'301', 3, N'Familiar', 3, 2, CAST(120.00 AS Decimal(10, 2)), N'A')
GO
SET IDENTITY_INSERT [dbo].[Huesped] ON 

INSERT [dbo].[Huesped] ([Id_Huesped], [Cedula], [Nombres], [Nacionalidad], [Correo], [Telefono], [Estado]) VALUES (1022, N'0918273645', N'Carlos Mendez', N'Ecuador', N'cmendez@gmail.com', N'0991234567', N'I')
INSERT [dbo].[Huesped] ([Id_Huesped], [Cedula], [Nombres], [Nacionalidad], [Correo], [Telefono], [Estado]) VALUES (1023, N'1726354859', N'Ana Lopez', N'Colombia', N'anitalopez@gmail.com', N'0987654321', N'A')
INSERT [dbo].[Huesped] ([Id_Huesped], [Cedula], [Nombres], [Nacionalidad], [Correo], [Telefono], [Estado]) VALUES (1025, N'1102938475', N'Jorge Ruiz', N'Peru', N'jruizdev@gmail.com', N'0958473625', N'I')
INSERT [dbo].[Huesped] ([Id_Huesped], [Cedula], [Nombres], [Nacionalidad], [Correo], [Telefono], [Estado]) VALUES (1028, N'0701239876', N'María Velez', N'Ecuador', N'mvelez99@gmail.com', N'0961239874', N'A')
INSERT [dbo].[Huesped] ([Id_Huesped], [Cedula], [Nombres], [Nacionalidad], [Correo], [Telefono], [Estado]) VALUES (1029, N'1309485761', N'Roberto Gomez', N'Mexico', N'rogomez@gmail.com', N'0975847362', N'I')
INSERT [dbo].[Huesped] ([Id_Huesped], [Cedula], [Nombres], [Nacionalidad], [Correo], [Telefono], [Estado]) VALUES (1030, N'0928374651', N'Lucía Fernandez', N'España', N'lufer@gmail.com', N'0981122334', N'A')
INSERT [dbo].[Huesped] ([Id_Huesped], [Cedula], [Nombres], [Nacionalidad], [Correo], [Telefono], [Estado]) VALUES (1031, N'1203948576', N'Pedro Castillo', N'Ecuador', N'pcastillo@gmail.com', N'0998877665', N'I')
INSERT [dbo].[Huesped] ([Id_Huesped], [Cedula], [Nombres], [Nacionalidad], [Correo], [Telefono], [Estado]) VALUES (1032, N'0958473621', N'Sofía Torres', N'Argentina', N'sofi.t@gmail.com', N'0939485762', N'A')
INSERT [dbo].[Huesped] ([Id_Huesped], [Cedula], [Nombres], [Nacionalidad], [Correo], [Telefono], [Estado]) VALUES (1033, N'1718293045', N'Miguel Angel', N'Chile', N'mangel88@gmail.com', N'0987123456', N'A')
INSERT [dbo].[Huesped] ([Id_Huesped], [Cedula], [Nombres], [Nacionalidad], [Correo], [Telefono], [Estado]) VALUES (1034, N'0912345678', N'Elena Vasquez', N'Ecuador', N'elenav@gmail.com', N'0995647382', N'I')
SET IDENTITY_INSERT [dbo].[Huesped] OFF
GO
SET IDENTITY_INSERT [dbo].[Reserva] ON 

INSERT [dbo].[Reserva] ([Id_Reserva], [Id_Huesped], [Id_Habitacion], [Id_Servicio], [Fecha_Llegada], [Fecha_Salida], [Fecha_De_Reserva], [Cantidad_Adulto], [Cantidad_Ninios], [Sub_Total], [Iva], [Total], [Estado]) VALUES (1020, 1022, 2, 5, CAST(N'2026-02-10' AS Date), CAST(N'2026-02-12' AS Date), CAST(N'2026-02-06T18:54:05.010' AS DateTime), 1, 2, CAST(105.00 AS Decimal(10, 2)), CAST(12.60 AS Decimal(10, 2)), CAST(117.60 AS Decimal(10, 2)), N'I')
INSERT [dbo].[Reserva] ([Id_Reserva], [Id_Huesped], [Id_Habitacion], [Id_Servicio], [Fecha_Llegada], [Fecha_Salida], [Fecha_De_Reserva], [Cantidad_Adulto], [Cantidad_Ninios], [Sub_Total], [Iva], [Total], [Estado]) VALUES (1021, 1023, 1, 1, CAST(N'2026-02-11' AS Date), CAST(N'2026-02-14' AS Date), CAST(N'2026-02-06T18:57:40.733' AS DateTime), 2, 0, CAST(200.00 AS Decimal(10, 2)), CAST(24.00 AS Decimal(10, 2)), CAST(224.00 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Reserva] ([Id_Reserva], [Id_Huesped], [Id_Habitacion], [Id_Servicio], [Fecha_Llegada], [Fecha_Salida], [Fecha_De_Reserva], [Cantidad_Adulto], [Cantidad_Ninios], [Sub_Total], [Iva], [Total], [Estado]) VALUES (1022, 1025, 3, 3, CAST(N'2026-02-12' AS Date), CAST(N'2026-02-15' AS Date), CAST(N'2026-02-06T19:04:50.347' AS DateTime), 2, 1, CAST(210.00 AS Decimal(10, 2)), CAST(25.20 AS Decimal(10, 2)), CAST(235.20 AS Decimal(10, 2)), N'I')
INSERT [dbo].[Reserva] ([Id_Reserva], [Id_Huesped], [Id_Habitacion], [Id_Servicio], [Fecha_Llegada], [Fecha_Salida], [Fecha_De_Reserva], [Cantidad_Adulto], [Cantidad_Ninios], [Sub_Total], [Iva], [Total], [Estado]) VALUES (1023, 1028, 5, 4, CAST(N'2026-02-14' AS Date), CAST(N'2026-02-20' AS Date), CAST(N'2026-02-06T19:08:35.510' AS DateTime), 3, 2, CAST(727.00 AS Decimal(10, 2)), CAST(87.24 AS Decimal(10, 2)), CAST(814.24 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Reserva] ([Id_Reserva], [Id_Huesped], [Id_Habitacion], [Id_Servicio], [Fecha_Llegada], [Fecha_Salida], [Fecha_De_Reserva], [Cantidad_Adulto], [Cantidad_Ninios], [Sub_Total], [Iva], [Total], [Estado]) VALUES (1024, 1029, 4, 2, CAST(N'2026-02-15' AS Date), CAST(N'2026-02-16' AS Date), CAST(N'2026-02-06T19:11:24.957' AS DateTime), 2, 0, CAST(105.00 AS Decimal(10, 2)), CAST(12.60 AS Decimal(10, 2)), CAST(117.60 AS Decimal(10, 2)), N'I')
INSERT [dbo].[Reserva] ([Id_Reserva], [Id_Huesped], [Id_Habitacion], [Id_Servicio], [Fecha_Llegada], [Fecha_Salida], [Fecha_De_Reserva], [Cantidad_Adulto], [Cantidad_Ninios], [Sub_Total], [Iva], [Total], [Estado]) VALUES (1025, 1030, 2, 3, CAST(N'2026-02-15' AS Date), CAST(N'2026-02-18' AS Date), CAST(N'2026-02-06T19:14:54.780' AS DateTime), 1, 0, CAST(120.00 AS Decimal(10, 2)), CAST(14.40 AS Decimal(10, 2)), CAST(134.40 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Reserva] ([Id_Reserva], [Id_Huesped], [Id_Habitacion], [Id_Servicio], [Fecha_Llegada], [Fecha_Salida], [Fecha_De_Reserva], [Cantidad_Adulto], [Cantidad_Ninios], [Sub_Total], [Iva], [Total], [Estado]) VALUES (1026, 1031, 3, 1, CAST(N'2026-02-16' AS Date), CAST(N'2026-02-17' AS Date), CAST(N'2026-02-06T19:18:12.723' AS DateTime), 2, 0, CAST(75.00 AS Decimal(10, 2)), CAST(9.00 AS Decimal(10, 2)), CAST(84.00 AS Decimal(10, 2)), N'I')
INSERT [dbo].[Reserva] ([Id_Reserva], [Id_Huesped], [Id_Habitacion], [Id_Servicio], [Fecha_Llegada], [Fecha_Salida], [Fecha_De_Reserva], [Cantidad_Adulto], [Cantidad_Ninios], [Sub_Total], [Iva], [Total], [Estado]) VALUES (1027, 1032, 1, 4, CAST(N'2026-02-18' AS Date), CAST(N'2026-02-22' AS Date), CAST(N'2026-02-06T19:20:55.530' AS DateTime), 2, 1, CAST(207.00 AS Decimal(10, 2)), CAST(24.84 AS Decimal(10, 2)), CAST(231.84 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Reserva] ([Id_Reserva], [Id_Huesped], [Id_Habitacion], [Id_Servicio], [Fecha_Llegada], [Fecha_Salida], [Fecha_De_Reserva], [Cantidad_Adulto], [Cantidad_Ninios], [Sub_Total], [Iva], [Total], [Estado]) VALUES (1028, 1033, 5, 5, CAST(N'2026-02-20' AS Date), CAST(N'2026-02-25' AS Date), CAST(N'2026-02-06T19:24:38.583' AS DateTime), 4, 2, CAST(605.00 AS Decimal(10, 2)), CAST(72.60 AS Decimal(10, 2)), CAST(677.60 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Reserva] ([Id_Reserva], [Id_Huesped], [Id_Habitacion], [Id_Servicio], [Fecha_Llegada], [Fecha_Salida], [Fecha_De_Reserva], [Cantidad_Adulto], [Cantidad_Ninios], [Sub_Total], [Iva], [Total], [Estado]) VALUES (1029, 1034, 2, 3, CAST(N'2026-02-21' AS Date), CAST(N'2026-02-22' AS Date), CAST(N'2026-02-06T19:29:24.570' AS DateTime), 1, 0, CAST(50.00 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), CAST(56.00 AS Decimal(10, 2)), N'I')
SET IDENTITY_INSERT [dbo].[Reserva] OFF
GO
INSERT [dbo].[Servicio] ([Id_Servicio], [Nombre_Servicio], [Precio], [Estado]) VALUES (1, N'Sauna', CAST(10.00 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Servicio] ([Id_Servicio], [Nombre_Servicio], [Precio], [Estado]) VALUES (2, N'Gimnasio', CAST(5.00 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Servicio] ([Id_Servicio], [Nombre_Servicio], [Precio], [Estado]) VALUES (3, N'Transporte', CAST(15.00 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Servicio] ([Id_Servicio], [Nombre_Servicio], [Precio], [Estado]) VALUES (4, N'Piscina', CAST(7.00 AS Decimal(10, 2)), N'A')
INSERT [dbo].[Servicio] ([Id_Servicio], [Nombre_Servicio], [Precio], [Estado]) VALUES (5, N'Lavanderia', CAST(5.00 AS Decimal(10, 2)), N'A')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Habitacion_Estado]    Script Date: 6/2/2026 20:01:24 ******/
CREATE NONCLUSTERED INDEX [IX_Habitacion_Estado] ON [dbo].[Habitacion]
(
	[Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Huesped__B4ADFE38739AD1B1]    Script Date: 6/2/2026 20:01:24 ******/
ALTER TABLE [dbo].[Huesped] ADD  CONSTRAINT [UQ__Huesped__B4ADFE38739AD1B1] UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Reserva_Estado]    Script Date: 6/2/2026 20:01:24 ******/
CREATE NONCLUSTERED INDEX [IX_Reserva_Estado] ON [dbo].[Reserva]
(
	[Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reserva_Fechas]    Script Date: 6/2/2026 20:01:24 ******/
CREATE NONCLUSTERED INDEX [IX_Reserva_Fechas] ON [dbo].[Reserva]
(
	[Fecha_Llegada] ASC,
	[Fecha_Salida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Servicio_Estado]    Script Date: 6/2/2026 20:01:24 ******/
CREATE NONCLUSTERED INDEX [IX_Servicio_Estado] ON [dbo].[Servicio]
(
	[Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Habitacion] ADD  DEFAULT ('A') FOR [Estado]
GO
ALTER TABLE [dbo].[Huesped] ADD  DEFAULT ('A') FOR [Estado]
GO
ALTER TABLE [dbo].[Reserva] ADD  DEFAULT ('A') FOR [Estado]
GO
ALTER TABLE [dbo].[Servicio] ADD  DEFAULT ('A') FOR [Estado]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Habitacion] FOREIGN KEY([Id_Habitacion])
REFERENCES [dbo].[Habitacion] ([Id_Habitacion])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Habitacion]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Huesped] FOREIGN KEY([Id_Huesped])
REFERENCES [dbo].[Huesped] ([Id_Huesped])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Huesped]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Servicio] FOREIGN KEY([Id_Servicio])
REFERENCES [dbo].[Servicio] ([Id_Servicio])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Servicio]
GO
USE [master]
GO
ALTER DATABASE [Reserva] SET  READ_WRITE 
GO
