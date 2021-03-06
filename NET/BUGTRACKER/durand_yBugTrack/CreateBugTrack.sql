USE [BugTrackLike]
GO
/****** Object:  Table [dbo].[T_User]    Script Date: 04/12/2012 23:12:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[firstname] [nvarchar](50) NULL,
	[email] [nvarchar](max) NULL,
	[phone] [nchar](10) NULL,
	[password] [nchar](10) NULL,
 CONSTRAINT [PK_T_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Project]    Script Date: 04/12/2012 23:12:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[version] [float] NULL,
	[startDate] [date] NULL,
 CONSTRAINT [PK_T_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Bug]    Script Date: 04/12/2012 23:12:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Bug](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[idProjet] [int] NOT NULL,
	[Type] [nchar](10) NOT NULL,
	[Description] [text] NOT NULL,
	[Createdate] [date] NOT NULL,
 CONSTRAINT [PK_T_Bug] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Transaction]    Script Date: 04/12/2012 23:12:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Transaction](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBug] [int] NOT NULL,
	[idUser] [int] NOT NULL,
	[statut] [nchar](10) NOT NULL,
 CONSTRAINT [PK_T_Transaction] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Comment]    Script Date: 04/12/2012 23:12:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Comment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idUser] [int] NULL,
	[idBug] [int] NULL,
	[details] [text] NULL,
 CONSTRAINT [PK_T_Comment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_T_Bug_T_Project]    Script Date: 04/12/2012 23:12:32 ******/
ALTER TABLE [dbo].[T_Bug]  WITH CHECK ADD  CONSTRAINT [FK_T_Bug_T_Project] FOREIGN KEY([idProjet])
REFERENCES [dbo].[T_Project] ([Id])
GO
ALTER TABLE [dbo].[T_Bug] CHECK CONSTRAINT [FK_T_Bug_T_Project]
GO
/****** Object:  ForeignKey [FK_T_Comment_T_Bug]    Script Date: 04/12/2012 23:12:32 ******/
ALTER TABLE [dbo].[T_Comment]  WITH CHECK ADD  CONSTRAINT [FK_T_Comment_T_Bug] FOREIGN KEY([idBug])
REFERENCES [dbo].[T_Bug] ([id])
GO
ALTER TABLE [dbo].[T_Comment] CHECK CONSTRAINT [FK_T_Comment_T_Bug]
GO
/****** Object:  ForeignKey [FK_T_Comment_T_User]    Script Date: 04/12/2012 23:12:32 ******/
ALTER TABLE [dbo].[T_Comment]  WITH CHECK ADD  CONSTRAINT [FK_T_Comment_T_User] FOREIGN KEY([idUser])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Comment] CHECK CONSTRAINT [FK_T_Comment_T_User]
GO
/****** Object:  ForeignKey [FK_T_Transaction_T_Bug]    Script Date: 04/12/2012 23:12:32 ******/
ALTER TABLE [dbo].[T_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_T_Transaction_T_Bug] FOREIGN KEY([idBug])
REFERENCES [dbo].[T_Bug] ([id])
GO
ALTER TABLE [dbo].[T_Transaction] CHECK CONSTRAINT [FK_T_Transaction_T_Bug]
GO
/****** Object:  ForeignKey [FK_T_Transaction_T_User]    Script Date: 04/12/2012 23:12:32 ******/
ALTER TABLE [dbo].[T_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_T_Transaction_T_User] FOREIGN KEY([idUser])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Transaction] CHECK CONSTRAINT [FK_T_Transaction_T_User]
GO
