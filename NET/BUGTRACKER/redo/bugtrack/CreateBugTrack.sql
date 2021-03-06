USE [BugTrack]
GO
/****** Object:  Table [dbo].[T_Project]    Script Date: 04/02/2009 16:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Project](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[version] [nvarchar](50) NOT NULL,
	[startDate] [datetime] NOT NULL,
 CONSTRAINT [PK_T_Project] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_User]    Script Date: 04/02/2009 16:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_User](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[firstname] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](10) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_T_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Bug]    Script Date: 04/02/2009 16:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Bug](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[idProject] [bigint] NOT NULL,
	[Type] [int] NOT NULL,
	[Description] [text] NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_T_Bug] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 04/02/2009 16:21:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteUser]
	-- Add the parameters for the stored procedure here
	 @id bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM [dbo].[T_User] 
       WHERE id  = @id ;
END
GO
/****** Object:  StoredProcedure [dbo].[CreateUser]    Script Date: 04/02/2009 16:21:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CreateUser]
	-- Add the parameters for the stored procedure here
	 @name nvarchar(50),
   @firstname nvarchar(50),
   @email nvarchar(50),
   @phone nvarchar(10),
   @password nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
INSERT INTO [dbo].[T_User] 
           (
            [name] 
            
           ,[firstname] 
           ,[email] 
           ,[phone] 
           ,[password] )
     VALUES
		(@name ,
		 @firstname ,
		 @email ,
	     @phone ,
	     @password )

select id
 from [dbo].[T_User] 
 where id  = scope_identity()
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateUser]    Script Date: 04/02/2009 16:21:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateUser]
	-- Add the parameters for the stored procedure here
	@id bigint,
	 @name nvarchar(50),
   @firstname nvarchar(50),
   @email nvarchar(50),
   @phone nvarchar(10),
   @password nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	
	UPDATE [dbo].[T_User] 
     
SET

name = @name ,
firstname =		 @firstname ,
email =		 @email ,
phone =	     @phone ,
password =	     @password


WHERE
	id  = @id
	
	end
GO
/****** Object:  Table [dbo].[T_Comment]    Script Date: 04/02/2009 16:21:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Comment](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[idUser] [bigint] NOT NULL,
	[idBug] [bigint] NOT NULL,
	[details] [text] NOT NULL,
 CONSTRAINT [PK_T_Comment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Transaction]    Script Date: 04/02/2009 16:21:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Transaction](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[idBug] [bigint] NOT NULL,
	[idUser] [bigint] NOT NULL,
	[statut] [int] NOT NULL,
 CONSTRAINT [PK_T_Transaction] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_T_Bug_T_Project]    Script Date: 04/02/2009 16:21:21 ******/
ALTER TABLE [dbo].[T_Bug]  WITH CHECK ADD  CONSTRAINT [FK_T_Bug_T_Project] FOREIGN KEY([idProject])
REFERENCES [dbo].[T_Project] ([id])
GO
ALTER TABLE [dbo].[T_Bug] CHECK CONSTRAINT [FK_T_Bug_T_Project]
GO
/****** Object:  ForeignKey [FK_T_Comment_T_Bug]    Script Date: 04/02/2009 16:21:42 ******/
ALTER TABLE [dbo].[T_Comment]  WITH CHECK ADD  CONSTRAINT [FK_T_Comment_T_Bug] FOREIGN KEY([idBug])
REFERENCES [dbo].[T_Bug] ([id])
GO
ALTER TABLE [dbo].[T_Comment] CHECK CONSTRAINT [FK_T_Comment_T_Bug]
GO
/****** Object:  ForeignKey [FK_T_Comment_T_User]    Script Date: 04/02/2009 16:21:42 ******/
ALTER TABLE [dbo].[T_Comment]  WITH CHECK ADD  CONSTRAINT [FK_T_Comment_T_User] FOREIGN KEY([idUser])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Comment] CHECK CONSTRAINT [FK_T_Comment_T_User]
GO
/****** Object:  ForeignKey [FK_T_Transaction_T_Bug]    Script Date: 04/02/2009 16:21:42 ******/
ALTER TABLE [dbo].[T_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_T_Transaction_T_Bug] FOREIGN KEY([idBug])
REFERENCES [dbo].[T_Bug] ([id])
GO
ALTER TABLE [dbo].[T_Transaction] CHECK CONSTRAINT [FK_T_Transaction_T_Bug]
GO
/****** Object:  ForeignKey [FK_T_Transaction_T_User]    Script Date: 04/02/2009 16:21:42 ******/
ALTER TABLE [dbo].[T_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_T_Transaction_T_User] FOREIGN KEY([idUser])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Transaction] CHECK CONSTRAINT [FK_T_Transaction_T_User]
GO
