USE [SPEStore]
GO
ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[LineItems] DROP CONSTRAINT [FK_LineItems_Products]
GO
ALTER TABLE [dbo].[LineItems] DROP CONSTRAINT [FK_LineItems_Carts]
GO
DROP TABLE [dbo].[Products]
GO
DROP TABLE [dbo].[LineItems]
GO
DROP TABLE [dbo].[Categories]
GO
DROP TABLE [dbo].[Carts]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carts](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[Confirmed] [bit] NOT NULL CONSTRAINT [DF_Carts_Confirmed]  DEFAULT ((0)),
 CONSTRAINT [PK_Carts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LineItems](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[CartId] [bigint] NOT NULL,
 CONSTRAINT [PK_LineItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Description] [text] NULL,
	[Author] [nvarchar](250) NOT NULL,
	[Image] [nvarchar](250) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Stock] [int] NOT NULL CONSTRAINT [DF_Products_Stock]  DEFAULT ((0)),
	[CategoryId] [bigint] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'PHP')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'C#')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Java')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'iOS')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'Ruby')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (6, N'Python')
SET IDENTITY_INSERT [dbo].[Categories] OFF

SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Description], [Author], [Image], [Price], [Stock], [CategoryId]) VALUES (2, N'Persistence in PHP with the Doctrine Orm', N'Persistence in PHP with the Doctrine ORM is a concise, fast, and focused guide to build a blog engine with advanced features such as native queries and lifecycle callbacks.', N'Kevin Dunglas', N'4104OS_Mini.jpg', CAST(17.00 AS Decimal(18, 2)), 12, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Author], [Image], [Price], [Stock], [CategoryId]) VALUES (3, N'Doctrine ORM for PHP ', N'The Guide to Doctrine for PHP is the ultimate users manual for you whether you are a beginner or an advanced user. The text aims to document and reference all core functionality provided by Doctrine.', N'Jonathan H. Wage', N'410OV1mJOWL.jpg', CAST(35.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Author], [Image], [Price], [Stock], [CategoryId]) VALUES (4, N'Essential SQLAlchemy', N'Essential SQLAlchemy introduces a high-level open-source code library that makes it easier for Python programmers to access relational databases such as Oracle, DB2, MySQL, PostgreSQL, and SQLite. ', N'Rick Copeland', N'sqlalchemy.jpg', CAST(34.99 AS Decimal(18, 2)), 5, 6)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Author], [Image], [Price], [Stock], [CategoryId]) VALUES (5, N'Hibernate Recipes: A Problem-Solution Approach', N'Hibernate Recipes, Second Edition contains a collection of code recipes and templates for learning and building Hibernate solutions for you and your clients, including how to work with the Spring Framework and the JPA. ', N'Joseph Ottinger', N'512VegyoIZL.jpg', CAST(31.20 AS Decimal(18, 2)), 8, 3)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Author], [Image], [Price], [Stock], [CategoryId]) VALUES (6, N'Pro Active Record: Databases with Ruby and Rails', N'In Pro Active Record, authors Kevin Marshall, Chad Pytel, and Jon Yurek walk you through every step, from the basics of installing the ActiveRecord library to working with legacy schema. ', N'Kevin Marshall ', N'51NZ-jS47TL_.jpg', CAST(40.00 AS Decimal(18, 2)), 0, 5)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Author], [Image], [Price], [Stock], [CategoryId]) VALUES (7, N'Nhibernate 3.0 Cookbook ', N'This book contains quick-paced self-explanatory recipes organized in progressive skill levels and functional areas. Each recipe contains step-by-step instructions about everything necessary to execute a particular task. ', N'Jason Dentler', N'41eQDUF82KL.jpg', CAST(36.50 AS Decimal(18, 2)), 10, 2)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Author], [Image], [Price], [Stock], [CategoryId]) VALUES (9, N'NHibernate in Action', N'In the classic style of Manning''s "In Action" series, NHibernate in Action shows .NET developers how to use the NHibernate Object/Relational Mapping tool. This book is a translation from Java to .NET, as well as an expansion, of Manning''s bestselling Hibernate in Action.', N'Pierre Henri Kuaté', N'51-Y8-3WhJL.jpg', CAST(31.50 AS Decimal(18, 2)), 1, 2)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Author], [Image], [Price], [Stock], [CategoryId]) VALUES (10, N'Nhibernate 3 Beginner''s Guide', N'This is a beginner''s guide with comprehensive step-by-step instructions. There are appropriate screenshots throughout the book and plenty of code, which is explained in a well-thought-out format. ', N'Gabriel N. Schenker ', N'516zoFkpAb.jpg', CAST(36.20 AS Decimal(18, 2)), 15, 2)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Author], [Image], [Price], [Stock], [CategoryId]) VALUES (11, N'Core Data: Data Storage and Management for iOS and OS X', N'Core Data is intricate, powerful, and necessary, and this book is your guide to harnessing its power. Core Data is Apple''s recommended way to persist data: it''s easy to use, built-in, and can integrate with iCloud. Learn fundamental Core Data principles such as thread and memory management. ', N'Marcus S. Zarra ', N'419PNz5w82L.jpg', CAST(30.15 AS Decimal(18, 2)), 8, 4)
SET IDENTITY_INSERT [dbo].[Products] OFF
ALTER TABLE [dbo].[LineItems]  WITH CHECK ADD  CONSTRAINT [FK_LineItems_Carts] FOREIGN KEY([CartId])
REFERENCES [dbo].[Carts] ([Id])
GO
ALTER TABLE [dbo].[LineItems] CHECK CONSTRAINT [FK_LineItems_Carts]
GO
ALTER TABLE [dbo].[LineItems]  WITH CHECK ADD  CONSTRAINT [FK_LineItems_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[LineItems] CHECK CONSTRAINT [FK_LineItems_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
