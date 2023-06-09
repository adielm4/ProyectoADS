CREATE DATABASE [Gestor_Proyectos]
GO
USE [Gestor_Proyectos]
GO
/****** Object:  Table [dbo].[bitacora]    Script Date: 28/04/2023 10:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bitacora](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idCaso] [varchar](60) NOT NULL,
	[descripcion] [varchar](4000) NOT NULL,
 CONSTRAINT [PK_bitacora] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[caso]    Script Date: 28/04/2023 10:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[caso](
	[id] [varchar](60) NOT NULL,
	[idSolicitud] [int] NULL,
	[descripcion] [varchar](4000) NULL,
	[porcentaje_avance] [int] NULL,
	[observaciones] [varchar](4000) NULL,
	[fecha_limite] [datetime] NULL,
	[usuario_creacion] [int] NULL,
	[tester] [int] NULL,
	[programador] [int] NULL,
	[fecha_produccion] [datetime] NULL,
 CONSTRAINT [PK_caso] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[departamento]    Script Date: 28/04/2023 10:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departamento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](60) NOT NULL,
 CONSTRAINT [PK_departamento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estados]    Script Date: 28/04/2023 10:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estados](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK__estados__86989FB27CAFCF88] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol]    Script Date: 28/04/2023 10:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](60) NOT NULL,
 CONSTRAINT [PK_rol] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[solicitud]    Script Date: 28/04/2023 10:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[solicitud](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](4000) NULL,
	[fechaEntrega] [datetime] NOT NULL,
	[idJefeDesarrollo] [int] NOT NULL,
	[estado] [int] NULL,
	[usuarioCreacion] [int] NULL,
	[argumento] [varchar](4000) NULL,
 CONSTRAINT [PK_solicitud] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 28/04/2023 10:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idRol] [int] NULL,
	[idDepartamento] [int] NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[pass] [varchar](30) NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[bitacora] ON 
GO
INSERT [dbo].[bitacora] ([id], [idCaso], [descripcion]) VALUES (1, N'DF30102020851', N'Añadido login')
GO
INSERT [dbo].[bitacora] ([id], [idCaso], [descripcion]) VALUES (2, N'DF30102020851', N'Añadido web service')
GO
INSERT [dbo].[bitacora] ([id], [idCaso], [descripcion]) VALUES (3, N'DF2812023931', N'Actualizacion del proyecto inicio del proyecto de escritorio')
GO
INSERT [dbo].[bitacora] ([id], [idCaso], [descripcion]) VALUES (4, N'DF2812023931', N'Actualizacion numero dos de bitacora')
GO
INSERT [dbo].[bitacora] ([id], [idCaso], [descripcion]) VALUES (5, N'DF2812023931', N'Corrigiendo las observaciones de QA')
GO
SET IDENTITY_INSERT [dbo].[bitacora] OFF
GO
INSERT [dbo].[caso] ([id], [idSolicitud], [descripcion], [porcentaje_avance], [observaciones], [fecha_limite], [usuario_creacion], [tester], [programador], [fecha_produccion]) VALUES (N'DF2812023931', 3, N'Prueba de aceptacion del caso', 100, N'Finalizado', CAST(N'2023-02-04T19:56:06.320' AS DateTime), 3, 4, 5, CAST(N'2023-01-29T19:58:24.000' AS DateTime))
GO
INSERT [dbo].[caso] ([id], [idSolicitud], [descripcion], [porcentaje_avance], [observaciones], [fecha_limite], [usuario_creacion], [tester], [programador], [fecha_produccion]) VALUES (N'DF30102020851', 1, N'Uso de JS', 100, N'Finalizado', CAST(N'2023-02-06T17:25:30.373' AS DateTime), 3, 4, 5, CAST(N'2023-01-29T17:31:27.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[departamento] ON 
GO
INSERT [dbo].[departamento] ([id], [descripcion]) VALUES (1, N'Departamento de finanzas')
GO
INSERT [dbo].[departamento] ([id], [descripcion]) VALUES (2, N'Departamento de ventas')
GO
INSERT [dbo].[departamento] ([id], [descripcion]) VALUES (3, N'Departamento de facturación')
GO
INSERT [dbo].[departamento] ([id], [descripcion]) VALUES (4, N'Departamento de facturación Móvil')
GO
INSERT [dbo].[departamento] ([id], [descripcion]) VALUES (5, N'Departamento de Emergencia')
GO
SET IDENTITY_INSERT [dbo].[departamento] OFF
GO
SET IDENTITY_INSERT [dbo].[estados] ON 
GO
INSERT [dbo].[estados] ([id_estado], [nombre]) VALUES (1, N'En espera de respuesta')
GO
INSERT [dbo].[estados] ([id_estado], [nombre]) VALUES (2, N'Solicituda aceptada')
GO
INSERT [dbo].[estados] ([id_estado], [nombre]) VALUES (3, N'Solicitud rechazada')
GO
INSERT [dbo].[estados] ([id_estado], [nombre]) VALUES (4, N'En desarrollo')
GO
INSERT [dbo].[estados] ([id_estado], [nombre]) VALUES (5, N'Esperando aprobación de área solicitante')
GO
INSERT [dbo].[estados] ([id_estado], [nombre]) VALUES (6, N'Vencido')
GO
INSERT [dbo].[estados] ([id_estado], [nombre]) VALUES (7, N'Devuelto con observaciones')
GO
INSERT [dbo].[estados] ([id_estado], [nombre]) VALUES (8, N'Finalizado')
GO
SET IDENTITY_INSERT [dbo].[estados] OFF
GO
SET IDENTITY_INSERT [dbo].[rol] ON 
GO
INSERT [dbo].[rol] ([id], [descripcion]) VALUES (1, N'Administrador')
GO
INSERT [dbo].[rol] ([id], [descripcion]) VALUES (2, N'Jefe de áreas funcionales')
GO
INSERT [dbo].[rol] ([id], [descripcion]) VALUES (3, N'Jefe de desarrollo')
GO
INSERT [dbo].[rol] ([id], [descripcion]) VALUES (4, N'Empleado de las áreas funcionales')
GO
INSERT [dbo].[rol] ([id], [descripcion]) VALUES (5, N'Programador')
GO
SET IDENTITY_INSERT [dbo].[rol] OFF
GO
SET IDENTITY_INSERT [dbo].[solicitud] ON 
GO
INSERT [dbo].[solicitud] ([id], [descripcion], [fechaEntrega], [idJefeDesarrollo], [estado], [usuarioCreacion], [argumento]) VALUES (1, N'Creación de proyecto enfocado al área de salud', CAST(N'2023-01-27T17:15:49.570' AS DateTime), 3, 6, 2, N'En Desarrollo')
GO
INSERT [dbo].[solicitud] ([id], [descripcion], [fechaEntrega], [idJefeDesarrollo], [estado], [usuarioCreacion], [argumento]) VALUES (2, N'Solicitud de ventas', CAST(N'2023-01-27T17:18:52.643' AS DateTime), 3, 3, 2, N'denegado por falta de indicaciones')
GO
INSERT [dbo].[solicitud] ([id], [descripcion], [fechaEntrega], [idJefeDesarrollo], [estado], [usuarioCreacion], [argumento]) VALUES (3, N'Prueba de
solicitud', CAST(N'2023-01-28T19:34:33.380' AS DateTime), 3, 6, 2, N'En Desarrollo')
GO
INSERT [dbo].[solicitud] ([id], [descripcion], [fechaEntrega], [idJefeDesarrollo], [estado], [usuarioCreacion], [argumento]) VALUES (4, N'Prueba de solicitud
para rechazar
actualizacion', CAST(N'2023-01-29T15:39:11.117' AS DateTime), 3, 3, 2, N'Solicitud rechazada debido a:
razon 1
razon 2
razon 3')
GO
SET IDENTITY_INSERT [dbo].[solicitud] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 
GO
INSERT [dbo].[usuario] ([id], [idRol], [idDepartamento], [nombre], [usuario], [pass]) VALUES (1, 1, 4, N'Daniel De Paz', N'Daniel23', N'1234')
GO
INSERT [dbo].[usuario] ([id], [idRol], [idDepartamento], [nombre], [usuario], [pass]) VALUES (2, 2, 4, N'Jorge Alberto', N'Jorge23', N'1234')
GO
INSERT [dbo].[usuario] ([id], [idRol], [idDepartamento], [nombre], [usuario], [pass]) VALUES (3, 3, 4, N'Jose Cruz', N'Jose23', N'1234')
GO
INSERT [dbo].[usuario] ([id], [idRol], [idDepartamento], [nombre], [usuario], [pass]) VALUES (4, 4, 4, N'Gerson Mendez', N'Gerson23', N'1234')
GO
INSERT [dbo].[usuario] ([id], [idRol], [idDepartamento], [nombre], [usuario], [pass]) VALUES (5, 5, 4, N'Abel Poco', N'Abel23', N'1234')
GO
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
ALTER TABLE [dbo].[bitacora]  WITH CHECK ADD  CONSTRAINT [FK_bitacora_caso] FOREIGN KEY([idCaso])
REFERENCES [dbo].[caso] ([id])
GO
ALTER TABLE [dbo].[bitacora] CHECK CONSTRAINT [FK_bitacora_caso]
GO
ALTER TABLE [dbo].[caso]  WITH CHECK ADD  CONSTRAINT [FK_caso_solicitud] FOREIGN KEY([idSolicitud])
REFERENCES [dbo].[solicitud] ([id])
GO
ALTER TABLE [dbo].[caso] CHECK CONSTRAINT [FK_caso_solicitud]
GO
ALTER TABLE [dbo].[caso]  WITH CHECK ADD  CONSTRAINT [FK_caso_usuario] FOREIGN KEY([usuario_creacion])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[caso] CHECK CONSTRAINT [FK_caso_usuario]
GO
ALTER TABLE [dbo].[caso]  WITH CHECK ADD  CONSTRAINT [FK_caso_usuario1] FOREIGN KEY([tester])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[caso] CHECK CONSTRAINT [FK_caso_usuario1]
GO
ALTER TABLE [dbo].[caso]  WITH CHECK ADD  CONSTRAINT [FK_caso_usuario2] FOREIGN KEY([programador])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[caso] CHECK CONSTRAINT [FK_caso_usuario2]
GO
ALTER TABLE [dbo].[solicitud]  WITH CHECK ADD  CONSTRAINT [FK_solicitud_estados] FOREIGN KEY([estado])
REFERENCES [dbo].[estados] ([id_estado])
GO
ALTER TABLE [dbo].[solicitud] CHECK CONSTRAINT [FK_solicitud_estados]
GO
ALTER TABLE [dbo].[solicitud]  WITH CHECK ADD  CONSTRAINT [FK_solicitud_usuario] FOREIGN KEY([idJefeDesarrollo])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[solicitud] CHECK CONSTRAINT [FK_solicitud_usuario]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_departamento] FOREIGN KEY([idDepartamento])
REFERENCES [dbo].[departamento] ([id])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_departamento]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_rol] FOREIGN KEY([idRol])
REFERENCES [dbo].[rol] ([id])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_rol]
GO
