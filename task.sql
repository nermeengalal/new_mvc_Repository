USE [master]
GO
/****** Object:  Database [TASK]    Script Date: 2019-06-22 10:25:47 PM ******/
CREATE DATABASE [TASK]

GO
USE [TASK]
GO
/****** Object:  StoredProcedure [dbo].[DeviceDetails]    Script Date: 2019-06-22 10:25:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DeviceDetails]
@DevicId int
AS
BEGIN
	select DISTINCT
dev.Device_Name as DeviceName,
Cat.Category_Name as CategoryName,
PropIt.Property_Name as PropertyName,
PropIt.Type as PropertyType,
propValue.Value as PropertyValue,
propOpt.Name as PropertyOptionName
from 
[dbo].[Devices]  dev left join [dbo].[Device_Categories]  Cat on Cat.ID=dev.Category_ID
left join [dbo].[Property_Value]  propValue on propValue.Device_ID=dev.ID
left join [dbo].[Property_Value_Option]  propValueOption on propValueOption.Property_Value_ID=propValue.ID
left join [dbo].[Property_Items]  PropIt on propValue.Property_ID=PropIt.ID
left join [dbo].[Property_Options]  propOpt on propValueOption.Property_Option_ID=propOpt.ID
where
dev.ID=@DevicId
END

GO
/****** Object:  Table [dbo].[Device_Categories]    Script Date: 2019-06-22 10:25:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Device_Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Category_Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Device_Categories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Devices]    Script Date: 2019-06-22 10:25:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devices](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Device_Name] [nvarchar](max) NOT NULL,
	[Category_ID] [int] NOT NULL,
 CONSTRAINT [PK_Devices] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Property_Items]    Script Date: 2019-06-22 10:25:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Property_Items](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Property_Name] [nvarchar](max) NOT NULL,
	[Category_ID] [int] NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_Property_Items] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Property_Options]    Script Date: 2019-06-22 10:25:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Property_Options](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Propert_ID] [int] NULL,
 CONSTRAINT [PK_Property_Options] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Property_Value]    Script Date: 2019-06-22 10:25:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Property_Value](
	[Device_ID] [int] NOT NULL,
	[Property_ID] [int] NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Property_Value_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Property_Value_Option]    Script Date: 2019-06-22 10:25:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Property_Value_Option](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Property_Option_ID] [int] NOT NULL,
	[Property_Value_ID] [int] NOT NULL,
 CONSTRAINT [PK_Property_Value_Option] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Device_Categories] ON 

INSERT [dbo].[Device_Categories] ([ID], [Category_Name]) VALUES (1, N'لابتوب')
INSERT [dbo].[Device_Categories] ([ID], [Category_Name]) VALUES (2, N'cars')
INSERT [dbo].[Device_Categories] ([ID], [Category_Name]) VALUES (3, N'Screen')
SET IDENTITY_INSERT [dbo].[Device_Categories] OFF
SET IDENTITY_INSERT [dbo].[Devices] ON 

INSERT [dbo].[Devices] ([ID], [Device_Name], [Category_ID]) VALUES (1, N'lap', 1)
INSERT [dbo].[Devices] ([ID], [Device_Name], [Category_ID]) VALUES (2, N'sss', 1)
INSERT [dbo].[Devices] ([ID], [Device_Name], [Category_ID]) VALUES (3, N'abdo', 1)
INSERT [dbo].[Devices] ([ID], [Device_Name], [Category_ID]) VALUES (4, N'cheforle', 2)
INSERT [dbo].[Devices] ([ID], [Device_Name], [Category_ID]) VALUES (5, N'LCD', 3)
INSERT [dbo].[Devices] ([ID], [Device_Name], [Category_ID]) VALUES (6, N'lg', 3)
SET IDENTITY_INSERT [dbo].[Devices] OFF
SET IDENTITY_INSERT [dbo].[Property_Items] ON 

INSERT [dbo].[Property_Items] ([ID], [Property_Name], [Category_ID], [Type]) VALUES (1, N'الاصدار', 1, 1)
INSERT [dbo].[Property_Items] ([ID], [Property_Name], [Category_ID], [Type]) VALUES (2, N'الحالة', 1, 2)
INSERT [dbo].[Property_Items] ([ID], [Property_Name], [Category_ID], [Type]) VALUES (3, N'السعر', 1, 1)
INSERT [dbo].[Property_Items] ([ID], [Property_Name], [Category_ID], [Type]) VALUES (4, N'price', 2, 1)
INSERT [dbo].[Property_Items] ([ID], [Property_Name], [Category_ID], [Type]) VALUES (5, N'Model', 3, 1)
INSERT [dbo].[Property_Items] ([ID], [Property_Name], [Category_ID], [Type]) VALUES (6, N'state', 3, 2)
SET IDENTITY_INSERT [dbo].[Property_Items] OFF
SET IDENTITY_INSERT [dbo].[Property_Options] ON 

INSERT [dbo].[Property_Options] ([ID], [Name], [Propert_ID]) VALUES (1, N'جديد', 2)
INSERT [dbo].[Property_Options] ([ID], [Name], [Propert_ID]) VALUES (2, N'مستعمل', 2)
INSERT [dbo].[Property_Options] ([ID], [Name], [Propert_ID]) VALUES (3, N'old', 6)
INSERT [dbo].[Property_Options] ([ID], [Name], [Propert_ID]) VALUES (4, N'new', 6)
SET IDENTITY_INSERT [dbo].[Property_Options] OFF
SET IDENTITY_INSERT [dbo].[Property_Value] ON 

INSERT [dbo].[Property_Value] ([Device_ID], [Property_ID], [Value], [ID]) VALUES (2, 1, N'1', 1)
INSERT [dbo].[Property_Value] ([Device_ID], [Property_ID], [Value], [ID]) VALUES (2, 2, N'', 2)
INSERT [dbo].[Property_Value] ([Device_ID], [Property_ID], [Value], [ID]) VALUES (2, 3, N'12', 3)
INSERT [dbo].[Property_Value] ([Device_ID], [Property_ID], [Value], [ID]) VALUES (3, 2, N'', 4)
INSERT [dbo].[Property_Value] ([Device_ID], [Property_ID], [Value], [ID]) VALUES (3, 1, N'5', 5)
INSERT [dbo].[Property_Value] ([Device_ID], [Property_ID], [Value], [ID]) VALUES (3, 3, N'5465', 6)
INSERT [dbo].[Property_Value] ([Device_ID], [Property_ID], [Value], [ID]) VALUES (4, 4, N'56756', 7)
INSERT [dbo].[Property_Value] ([Device_ID], [Property_ID], [Value], [ID]) VALUES (5, 5, N'EAZ', 8)
INSERT [dbo].[Property_Value] ([Device_ID], [Property_ID], [Value], [ID]) VALUES (6, 6, N'', 9)
INSERT [dbo].[Property_Value] ([Device_ID], [Property_ID], [Value], [ID]) VALUES (6, 5, N'asd', 10)
SET IDENTITY_INSERT [dbo].[Property_Value] OFF
SET IDENTITY_INSERT [dbo].[Property_Value_Option] ON 

INSERT [dbo].[Property_Value_Option] ([ID], [Property_Option_ID], [Property_Value_ID]) VALUES (1, 1, 4)
INSERT [dbo].[Property_Value_Option] ([ID], [Property_Option_ID], [Property_Value_ID]) VALUES (2, 4, 9)
SET IDENTITY_INSERT [dbo].[Property_Value_Option] OFF
/****** Object:  Index [IX_Devices]    Script Date: 2019-06-22 10:25:47 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Devices] ON [dbo].[Devices]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Property_Value]    Script Date: 2019-06-22 10:25:47 PM ******/
CREATE NONCLUSTERED INDEX [IX_Property_Value] ON [dbo].[Property_Value]
(
	[Device_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Devices]  WITH CHECK ADD  CONSTRAINT [FK_Devices_Device_Categories] FOREIGN KEY([Category_ID])
REFERENCES [dbo].[Device_Categories] ([ID])
GO
ALTER TABLE [dbo].[Devices] CHECK CONSTRAINT [FK_Devices_Device_Categories]
GO
ALTER TABLE [dbo].[Property_Items]  WITH CHECK ADD  CONSTRAINT [FK_Property_Items_Device_Categories] FOREIGN KEY([Category_ID])
REFERENCES [dbo].[Device_Categories] ([ID])
GO
ALTER TABLE [dbo].[Property_Items] CHECK CONSTRAINT [FK_Property_Items_Device_Categories]
GO
ALTER TABLE [dbo].[Property_Options]  WITH CHECK ADD  CONSTRAINT [FK_Property_Options_Property_Items] FOREIGN KEY([Propert_ID])
REFERENCES [dbo].[Property_Items] ([ID])
GO
ALTER TABLE [dbo].[Property_Options] CHECK CONSTRAINT [FK_Property_Options_Property_Items]
GO
ALTER TABLE [dbo].[Property_Value]  WITH CHECK ADD  CONSTRAINT [FK_Property_Value_Devices] FOREIGN KEY([Device_ID])
REFERENCES [dbo].[Devices] ([ID])
GO
ALTER TABLE [dbo].[Property_Value] CHECK CONSTRAINT [FK_Property_Value_Devices]
GO
ALTER TABLE [dbo].[Property_Value]  WITH CHECK ADD  CONSTRAINT [FK_Property_Value_Property_Items] FOREIGN KEY([Property_ID])
REFERENCES [dbo].[Property_Items] ([ID])
GO
ALTER TABLE [dbo].[Property_Value] CHECK CONSTRAINT [FK_Property_Value_Property_Items]
GO
ALTER TABLE [dbo].[Property_Value_Option]  WITH CHECK ADD  CONSTRAINT [FK_Property_Value_Option_Property_Options] FOREIGN KEY([Property_Option_ID])
REFERENCES [dbo].[Property_Options] ([ID])
GO
ALTER TABLE [dbo].[Property_Value_Option] CHECK CONSTRAINT [FK_Property_Value_Option_Property_Options]
GO
ALTER TABLE [dbo].[Property_Value_Option]  WITH CHECK ADD  CONSTRAINT [FK_Property_Value_Option_Property_Value] FOREIGN KEY([Property_Value_ID])
REFERENCES [dbo].[Property_Value] ([ID])
GO
ALTER TABLE [dbo].[Property_Value_Option] CHECK CONSTRAINT [FK_Property_Value_Option_Property_Value]
GO
USE [master]
GO
ALTER DATABASE [TASK] SET  READ_WRITE 
GO
