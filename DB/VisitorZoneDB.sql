USE [master]
GO
/****** Object:  Database [VisitorZoneDB]    Script Date: 2015-07-28 02:39:53 ******/
CREATE DATABASE [VisitorZoneDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VisitorZoneDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\VisitorZoneDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VisitorZoneDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\VisitorZoneDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VisitorZoneDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VisitorZoneDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VisitorZoneDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [VisitorZoneDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VisitorZoneDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VisitorZoneDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VisitorZoneDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VisitorZoneDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VisitorZoneDB] SET  MULTI_USER 
GO
ALTER DATABASE [VisitorZoneDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VisitorZoneDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VisitorZoneDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [VisitorZoneDB]
GO
/****** Object:  Table [dbo].[tbl_joint_visitor_zone]    Script Date: 2015-07-28 02:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_joint_visitor_zone](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[visitorid] [int] NOT NULL,
	[zoneid] [int] NOT NULL,
 CONSTRAINT [PK_tbl_joint_visitor_zone] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_visitor]    Script Date: 2015-07-28 02:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_visitor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[phone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_visitor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_zone]    Script Date: 2015-07-28 02:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_zone](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[zoneName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_zone] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_joint_visitor_zone] ON 

INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (1, 2, 1)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (2, 2, 2)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (3, 2, 3)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (4, 3, 1)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (5, 3, 4)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (6, 4, 1)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (7, 4, 3)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (8, 4, 4)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (9, 5, 2)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (10, 5, 3)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (11, 5, 4)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (12, 6, 1)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (13, 6, 2)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (14, 6, 3)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (15, 6, 4)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (16, 6, 5)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (17, 7, 1)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (18, 7, 2)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (19, 7, 4)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (20, 8, 1)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (21, 8, 5)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (1020, 1008, 1)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (1021, 1008, 5)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (1022, 1008, 6)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (1023, 1008, 7)
SET IDENTITY_INSERT [dbo].[tbl_joint_visitor_zone] OFF
SET IDENTITY_INSERT [dbo].[tbl_visitor] ON 

INSERT [dbo].[tbl_visitor] ([id], [name], [email], [phone]) VALUES (2, N'Tasfiq', N'tasfiq@gmail.com', N'01867543221')
INSERT [dbo].[tbl_visitor] ([id], [name], [email], [phone]) VALUES (3, N'Ashiq', N'ashiq@gmail.com', N'01911928274')
INSERT [dbo].[tbl_visitor] ([id], [name], [email], [phone]) VALUES (4, N'Himel', N'himel@gmail.com', N'0114325467')
INSERT [dbo].[tbl_visitor] ([id], [name], [email], [phone]) VALUES (5, N'Emon', N'emon@hotmail.com', N'0176234536')
INSERT [dbo].[tbl_visitor] ([id], [name], [email], [phone]) VALUES (6, N'Kyum', N'kyum@yahoo.com', N'0168754323')
INSERT [dbo].[tbl_visitor] ([id], [name], [email], [phone]) VALUES (7, N'Masum', N'maum@yahoo.com', N'01911453243')
INSERT [dbo].[tbl_visitor] ([id], [name], [email], [phone]) VALUES (8, N'Kader', N'kader@gmail.com', N'01654326543')
INSERT [dbo].[tbl_visitor] ([id], [name], [email], [phone]) VALUES (1008, N'sasas', N'wdwd', N'12346')
SET IDENTITY_INSERT [dbo].[tbl_visitor] OFF
SET IDENTITY_INSERT [dbo].[tbl_zone] ON 

INSERT [dbo].[tbl_zone] ([id], [zoneName]) VALUES (1, N'Robin Zone')
INSERT [dbo].[tbl_zone] ([id], [zoneName]) VALUES (2, N'Rpm Zone')
INSERT [dbo].[tbl_zone] ([id], [zoneName]) VALUES (3, N'Sabbir Zone')
INSERT [dbo].[tbl_zone] ([id], [zoneName]) VALUES (4, N'Lash Zone')
INSERT [dbo].[tbl_zone] ([id], [zoneName]) VALUES (5, N'Polash Zone')
INSERT [dbo].[tbl_zone] ([id], [zoneName]) VALUES (6, N'BITM Zone')
INSERT [dbo].[tbl_zone] ([id], [zoneName]) VALUES (7, N'BASIS Zone')
SET IDENTITY_INSERT [dbo].[tbl_zone] OFF
ALTER TABLE [dbo].[tbl_joint_visitor_zone]  WITH CHECK ADD  CONSTRAINT [FK_tbl_joint_visitor_zone_tbl_visitor] FOREIGN KEY([visitorid])
REFERENCES [dbo].[tbl_visitor] ([id])
GO
ALTER TABLE [dbo].[tbl_joint_visitor_zone] CHECK CONSTRAINT [FK_tbl_joint_visitor_zone_tbl_visitor]
GO
ALTER TABLE [dbo].[tbl_joint_visitor_zone]  WITH CHECK ADD  CONSTRAINT [FK_tbl_joint_visitor_zone_tbl_zone] FOREIGN KEY([zoneid])
REFERENCES [dbo].[tbl_zone] ([id])
GO
ALTER TABLE [dbo].[tbl_joint_visitor_zone] CHECK CONSTRAINT [FK_tbl_joint_visitor_zone_tbl_zone]
GO
USE [master]
GO
ALTER DATABASE [VisitorZoneDB] SET  READ_WRITE 
GO
