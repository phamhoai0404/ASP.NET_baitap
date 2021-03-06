USE [master]
GO
/****** Object:  Database [WineStore2]    Script Date: 15/07/2021 8:37:32 pm ******/
CREATE DATABASE [WineStore2]
GO
USE [WineStore2]
GO
/****** Object:  Table [dbo].[Catalogy]    Script Date: 15/07/2021 8:37:32 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catalogy](
	[CatalogyID] [nchar](10) NOT NULL,
	[CatalogyName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
 CONSTRAINT [PK_Catalogies] PRIMARY KEY CLUSTERED 
(
	[CatalogyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nguoidung]    Script Date: 15/07/2021 8:37:32 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nguoidung](
	[manguoidung] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](30) NOT NULL,
	[matkhau] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[khoa] [bit] NOT NULL CONSTRAINT [DF_nguoidung_khoa]  DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[manguoidung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 15/07/2021 8:37:32 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Price] [numeric](8, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[CatalogyID] [nchar](10) NOT NULL,
	[Image] [text] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Catalogy] ([CatalogyID], [CatalogyName], [Description]) VALUES (N'001       ', N'Red Wines', N'this is red wine')
INSERT [dbo].[Catalogy] ([CatalogyID], [CatalogyName], [Description]) VALUES (N'002       ', N'White Wines', N'this is white wine')
INSERT [dbo].[Catalogy] ([CatalogyID], [CatalogyName], [Description]) VALUES (N'003       ', N'Sparkling Wines', N'this is sparkling Wine')
INSERT [dbo].[Catalogy] ([CatalogyID], [CatalogyName], [Description]) VALUES (N'004       ', N'Dessert Wines', N'this is Dessert Wine')
INSERT [dbo].[Catalogy] ([CatalogyID], [CatalogyName], [Description]) VALUES (N'005       ', N'Fortified Wines', N'this is Fortified Wines')
INSERT [dbo].[Catalogy] ([CatalogyID], [CatalogyName], [Description]) VALUES (N'006       ', N'Beer', N'this is Beer')
INSERT [dbo].[Catalogy] ([CatalogyID], [CatalogyName], [Description]) VALUES (N'007       ', N'Spirits & liqueurs', N'this is Spirits & liqueurs')
INSERT [dbo].[Catalogy] ([CatalogyID], [CatalogyName], [Description]) VALUES (N'008       ', N'Accessories', N'this is Accessories')
INSERT [dbo].[Catalogy] ([CatalogyID], [CatalogyName], [Description]) VALUES (N'009       ', N'Wine Packs', N'this is Wine Packs')
INSERT [dbo].[Catalogy] ([CatalogyID], [CatalogyName], [Description]) VALUES (N'010       ', N'Wine Plans', N'this is Wine plans')
INSERT [dbo].[Catalogy] ([CatalogyID], [CatalogyName], [Description]) VALUES (N'011       ', N'Wine Gifts', N'this is Wine Gifts')
SET IDENTITY_INSERT [dbo].[nguoidung] ON 

INSERT [dbo].[nguoidung] ([manguoidung], [hoten], [matkhau], [email], [khoa]) VALUES (1, N'Nguyễn Văn Nam', N'123123', N'nam@gmail.com', 0)
INSERT [dbo].[nguoidung] ([manguoidung], [hoten], [matkhau], [email], [khoa]) VALUES (2, N'Bùi Thị Lan', N'123456', N'lan@yahoo.com', 1)
INSERT [dbo].[nguoidung] ([manguoidung], [hoten], [matkhau], [email], [khoa]) VALUES (3, N'Nguyễn Thị Hoa', N'123', N'abc@gmail.com', 0)
SET IDENTITY_INSERT [dbo].[nguoidung] OFF
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (300, N'ATA RANGI CRAIGHALL CHARDONNAY', CAST(59.95 AS Numeric(8, 2)), 300, N'001       ', N'Chardonnay1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (301, N'BROOKLAND VALLEY VERSE 1 CHARDONNAY', CAST(17.95 AS Numeric(8, 2)), 350, N'001       ', N'Chardonnay2.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (302, N'CAPE JAFFA BROCKS REEF CHARDONNAY', CAST(18.00 AS Numeric(8, 2)), 400, N'001       ', N'Chardonnay3.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (303, N'CLAIRAULT CHARDONNAY', CAST(23.99 AS Numeric(8, 2)), 300, N'001       ', N'Chardonnay4.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (304, N'CLEANSKIN CHARDONNAY', CAST(9.95 AS Numeric(8, 2)), 300, N'001       ', N'Chardonnay5.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (305, N'DE BORTOLI WILLOWGLEN CHARDONNAY', CAST(14.95 AS Numeric(8, 2)), 400, N'001       ', N'Chardonnay6.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (306, N'FLINDERS BAY CHARDONNAY', CAST(16.95 AS Numeric(8, 2)), 350, N'001       ', N'Chardonnay7.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (307, N'GRACEBROOK CHARDONNAY', CAST(16.95 AS Numeric(8, 2)), 400, N'001       ', N'Chardonnay8.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (308, N'GRANITE HILLS CHARDONNAY', CAST(21.95 AS Numeric(8, 2)), 300, N'001       ', N'Chardonnay9.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (309, N'GRANT BURGE SUMMERS CHARDONNAY', CAST(30.00 AS Numeric(8, 2)), 300, N'001       ', N'Chardonnay10.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (310, N'KISSING BRIDGE CHARDONNAY', CAST(14.95 AS Numeric(8, 2)), 300, N'001       ', N'Chardonnay11.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (311, N'LONG FLAT DEST YARRA VALLEY CHARDONNAY', CAST(16.95 AS Numeric(8, 2)), 400, N'001       ', N'Chardonnay12.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (312, N'Lyrup Crossing Chardonnay', CAST(14.95 AS Numeric(8, 2)), 300, N'001       ', N'Chardonnay13.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (313, N'MILLSTONE CHARDONNAY', CAST(17.95 AS Numeric(8, 2)), 300, N'001       ', N'Chardonnay14.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (314, N'PHI LUSATIA PARK CHARDONNAY', CAST(49.95 AS Numeric(8, 2)), 300, N'001       ', N'Chardonnay15.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (315, N'PIGS IN THE SKY RESERVE CHARDONNAY', CAST(12.99 AS Numeric(8, 2)), 400, N'001       ', N'Chardonnay16.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (316, N'REDBANK LONG PADDOCK CHARDONNAY', CAST(13.95 AS Numeric(8, 2)), 400, N'001       ', N'Chardonnay17.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (317, N'SCOTCHMANS HILL SWAN BAY CHARDONNAY', CAST(22.95 AS Numeric(8, 2)), 400, N'001       ', N'Chardonnay18.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (318, N'STEPXSTEP CHARDONNAY', CAST(12.00 AS Numeric(8, 2)), 400, N'001       ', N'Chardonnay19.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (319, N'Taylors 80 Acres Chardonnay', CAST(16.95 AS Numeric(8, 2)), 500, N'001       ', N'Chardonnay20.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (320, N'20% OFF CHURCHVIEW U/W CHARDONNAY 6PK', CAST(114.00 AS Numeric(8, 2)), 500, N'002       ', N'Unwooded-Chardonnay1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (321, N'WINE - CHURCHVIEW UNWOODED CHARDONNAY', CAST(18.95 AS Numeric(8, 2)), 400, N'002       ', N'Unwooded-Chardonnay2.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (322, N'AMBERLEY SEMILLON SAUVIGNON BLANC', CAST(16.95 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (323, N'BARWICK ESTATE CRUSH SEM SAUV BLANC', CAST(12.95 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc2.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (324, N'BOWMAN CROSSING SEM SAUV BLANC', CAST(11.99 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc3.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (325, N'CAPE JAFFA BROCKS REEF SEM SAUV BLANC', CAST(12.95 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc4.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (326, N'CATCHING THIEVES SEM SAUV BLANC', CAST(16.95 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc5.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (327, N'CLAIRAULT SEM SAUV BLANC', CAST(22.99 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc6.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (328, N'CUTTAWAY HILL SEM SAUV BLANC', CAST(22.95 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc7.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (329, N'DE BORTOLI SACRED HILL SEM SAUV BLANC', CAST(8.95 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc8.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (330, N'DE BORTOLI WILLOWGLEN SEM SAUV BLANC', CAST(14.99 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc9.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (331, N'DE BORTOLI WINDY PEAK SAUV BLANC SEM', CAST(16.95 AS Numeric(8, 2)), 500, N'003       ', N'Semillon-Sauvignon-Blanc10.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (332, N'FERNGROVE SYMBOLS SAUV BLANC/SEM', CAST(12.95 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc11.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (333, N'FIDDLERS CREEK SEMILLON SAUV BLANC', CAST(16.99 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc12.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (334, N'FONTYS POOL SEMILLON SAUVIGNON BLANC', CAST(21.95 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc13.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (335, N'HOUGHTON STRIPE SEM SAUV BLANC', CAST(12.95 AS Numeric(8, 2)), 500, N'003       ', N'Semillon-Sauvignon-Blanc14.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (336, N'HUNGERFORD HILL FISHCAGE SEM SAUV', CAST(15.95 AS Numeric(8, 2)), 500, N'003       ', N'Semillon-Sauvignon-Blanc15.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (337, N'KISSING BRIDGE SEM SAUV BLANC', CAST(15.99 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc16.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (338, N'THE PUPPETEER SEM SAUV BLANC', CAST(13.95 AS Numeric(8, 2)), 500, N'003       ', N'Semillon-Sauvignon-Blanc17.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (339, N'TYRRELLS MOORES CREEK SEM SAUV BLANC', CAST(15.95 AS Numeric(8, 2)), 400, N'003       ', N'Semillon-Sauvignon-Blanc18.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (340, N'WINE - BULLER BEVERFORD SEM SAUV BLANC', CAST(14.95 AS Numeric(8, 2)), 500, N'003       ', N'Semillon-Sauvignon-Blanc19.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (341, N'WINE - GRANT BURGE BENCHMARK SEM SAUV', CAST(21.95 AS Numeric(8, 2)), 500, N'003       ', N'Semillon-Sauvignon-Blanc20.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (342, N'CLEANSKIN HUNTER VERDELHO', CAST(9.95 AS Numeric(8, 2)), 500, N'004       ', N'Verdelho/Verdelho1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (343, N'MILLSTONE HUNTER VERDELHO', CAST(17.95 AS Numeric(8, 2)), 500, N'004       ', N'Verdelho2.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (344, N'WINDOWRIE THE MILL VERDELHO', CAST(14.99 AS Numeric(8, 2)), 500, N'004       ', N'Verdelho3.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (345, N'BLACKETS GEWURTZTRAMINER', CAST(28.95 AS Numeric(8, 2)), 500, N'005       ', N'Gewurztraminer1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (346, N'LAWSON DRY HILLS GEWURTZTRAMINER', CAST(23.95 AS Numeric(8, 2)), 500, N'005       ', N'Gewurztraminer1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (347, N'GENRE PINOT GRIGIO', CAST(11.95 AS Numeric(8, 2)), 500, N'006       ', N'Pinot-Grigio-and-Pinot-Gris1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (348, N'KUMEU RIVER PINOT GRIS', CAST(35.95 AS Numeric(8, 2)), 500, N'006       ', N'Pinot-Grigio-and-Pinot-Gris2.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (349, N'TYRRELLS OLD WINERY PINOT GRIGIO', CAST(14.95 AS Numeric(8, 2)), 500, N'006       ', N'Pinot-Grigio-and-Pinot-Gris3.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (350, N'WINE - LONG FLAT PINOT GRIGIO', CAST(10.95 AS Numeric(8, 2)), 500, N'006       ', N'Pinot-Grigio-and-Pinot-Gris4.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (351, N'WINE - SILVERLEAF CHENIN BLANC', CAST(13.95 AS Numeric(8, 2)), 500, N'007       ', N'Chenin-Blanc.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (352, N'BROWN BROS MOSCATO', CAST(16.95 AS Numeric(8, 2)), 500, N'008       ', N'Sweet-White1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (353, N'WINE - GENRE MOSCATO', CAST(11.95 AS Numeric(8, 2)), 500, N'008       ', N'Sweet-White2.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (354, N'WINE BEVERS MOSCATO', CAST(14.95 AS Numeric(8, 2)), 500, N'008       ', N'Sweet-White3.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (355, N'Wine-Kissing Bridge Moscato', CAST(14.99 AS Numeric(8, 2)), 500, N'008       ', N'Sweet-White4.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (356, N'ZILZIE ESTATE S23 MOSCATO', CAST(12.95 AS Numeric(8, 2)), 500, N'008       ', N'Sweet-White5.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (357, N'DE BORTOLI MONTAGE CHARDONNAY SEMILLION', CAST(11.95 AS Numeric(8, 2)), 500, N'009       ', N'Semillon-Chardonnay1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (358, N'DE BORTOLI SACRED HILL SEM CHARD', CAST(9.95 AS Numeric(8, 2)), 500, N'009       ', N'Semillon-Chardonnay2.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (359, N'DE BORTOLI WILLOWGLEN SEM CHARDONNAY', CAST(14.99 AS Numeric(8, 2)), 500, N'009       ', N'Semillon-Chardonnay3.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (360, N'LYRUP CROSSING SEM CHARDONNAY', CAST(13.95 AS Numeric(8, 2)), 500, N'009       ', N'Semillon-Chardonnay4.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (361, N'RIVEREDGE SEM CHARDONNAY', CAST(12.99 AS Numeric(8, 2)), 500, N'009       ', N'Semillon-Chardonnay5.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (362, N'BETHANY BAROSSA SEMILLON', CAST(20.95 AS Numeric(8, 2)), 500, N'010       ', N'Semillon1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (363, N'TYRRELLS VAT 1 SEMILLON', CAST(44.95 AS Numeric(8, 2)), 500, N'010       ', N'Semillon2.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (364, N'AMADIO RIESLING', CAST(21.00 AS Numeric(8, 2)), 500, N'011       ', N'Riesling1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (365, N'DE BORTOLI WILLOWGLEN RIESLING', CAST(16.95 AS Numeric(8, 2)), 500, N'011       ', N'Riesling2.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (366, N'EYRE CREEK RIESLING', CAST(17.95 AS Numeric(8, 2)), 500, N'011       ', N'Riesling3.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (367, N'SCOTCHMANS HILL RIESLING', CAST(31.00 AS Numeric(8, 2)), 500, N'011       ', N'Riesling4.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (368, N'TAYLORS ST ANDREWS RIESLING', CAST(35.95 AS Numeric(8, 2)), 500, N'011       ', N'Riesling5.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (369, N'TOLLANA BAY F2 MUSEUM RELEASE RIESLING', CAST(36.95 AS Numeric(8, 2)), 500, N'011       ', N'Riesling6.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (370, N'VON KESSELSTATT GRAACHER TROCKEN RIESLING', CAST(21.00 AS Numeric(8, 2)), 500, N'011       ', N'Riesling7.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (371, N'WINE ICELY RD RIESLING', CAST(18.95 AS Numeric(8, 2)), 500, N'011       ', N'Riesling8.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (372, N'16 TO THE DOZEN FLINDERS BAY SAUV BLANC', CAST(271.20 AS Numeric(8, 2)), 150, N'002       ', N'Sauvignon-Blanc1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (373, N'BABICH HEADWATERS ORGANIC SAUV BLANC', CAST(26.95 AS Numeric(8, 2)), 250, N'002       ', N'Sauvignon-Blanc2.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (374, N'CRYSTAL LAKE SAUVIGNON BLANC', CAST(13.00 AS Numeric(8, 2)), 500, N'002       ', N'Sauvignon-Blanc3.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (375, N'CUTTAWAY HILL SAUVIGNON BLANC', CAST(22.95 AS Numeric(8, 2)), 150, N'002       ', N'Sauvignon-Blanc4.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (376, N'DRIFT SAUVIGNON BLANC', CAST(16.95 AS Numeric(8, 2)), 400, N'002       ', N'Sauvignon-Blanc5.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (377, N'Genre Sauvignon Blanc', CAST(13.95 AS Numeric(8, 2)), 500, N'002       ', N'Sauvignon-Blanc6.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (378, N'HOUGHTON WISDOM SAUV BLANC', CAST(29.95 AS Numeric(8, 2)), 500, N'002       ', N'Sauvignon-Blanc7.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (379, N'Mountain Pass Sauvignon Blanc Semillon', CAST(20.00 AS Numeric(8, 2)), 400, N'002       ', N'Sauvignon-Blanc8.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (380, N'OYSTER BAY SAUVIGNON BLANC', CAST(19.95 AS Numeric(8, 2)), 500, N'002       ', N'Sauvignon-Blanc9.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (381, N'RAHITI MARLBOROUGH SAUVIGNON BLANC', CAST(9.95 AS Numeric(8, 2)), 500, N'002       ', N'Sauvignon-Blanc10.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (382, N'SCOTCHMANS HILL SAUVIGNON BLANC', CAST(25.00 AS Numeric(8, 2)), 500, N'002       ', N'Sauvignon-Blanc11.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (383, N'SCOTCHMANS HILL THE HILL SAUVIGNON BLANC', CAST(14.95 AS Numeric(8, 2)), 500, N'002       ', N'Sauvignon-Blanc12.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (384, N'Sea Opal Sauvignon Blanc', CAST(15.95 AS Numeric(8, 2)), 500, N'002       ', N'Sauvignon-Blanc13.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (385, N'SIMON WHITLAM SAUVIGNON BLANC', CAST(16.95 AS Numeric(8, 2)), 500, N'002       ', N'Sauvignon-Blanc14.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (386, N'TE ORA MARLBOROUGH SAUVIGNON BLANC', CAST(16.95 AS Numeric(8, 2)), 300, N'002       ', N'Sauvignon-Blanc15.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (387, N'WINE - CHARLOTTE SOUNDS SAUVIGNON BLANC', CAST(18.95 AS Numeric(8, 2)), 500, N'002       ', N'Sauvignon-Blanc16.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (388, N'WINE - FLINDERS BAY SAUVIGNON BLANC', CAST(16.95 AS Numeric(8, 2)), 500, N'002       ', N'Sauvignon-Blanc17.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (389, N'WINE - HIPPIE SAUVIGNON BLANC', CAST(13.95 AS Numeric(8, 2)), 450, N'002       ', N'Sauvignon-Blanc18.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (390, N'WINE - MCKENZIE & GRACE SAUVIGNON BLANC', CAST(14.95 AS Numeric(8, 2)), 450, N'002       ', N'Sauvignon-Blanc19.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (391, N'WINE - NINE ZEROS SAUVIGNON BLANC', CAST(9.95 AS Numeric(8, 2)), 350, N'002       ', N'Sauvignon-Blanc20.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (392, N'Baldivis Classic Dry White Magnum', CAST(30.00 AS Numeric(8, 2)), 450, N'007       ', N'White-Blend-Other-Whites1.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (393, N'BANROCK STATION FIANO', CAST(14.95 AS Numeric(8, 2)), 450, N'007       ', N'White-Blend-Other-Whites2.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (394, N'BANROCK STATION FIANO', CAST(14.95 AS Numeric(8, 2)), 450, N'007       ', N'White-Blend-Other-Whites3.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (395, N'BRINDABELLA HILLS VIOGNIER CHARDONNAY', CAST(27.95 AS Numeric(8, 2)), 450, N'007       ', N'White-Blend-Other-Whites4.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (396, N'BROWN BROTHERS CROUCHEN & RIESLING', CAST(14.95 AS Numeric(8, 2)), 450, N'007       ', N'White-Blend-Other-Whites5.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (397, N'CHAIN OF FIRE CHARDONNAY VIOGNIER', CAST(14.95 AS Numeric(8, 2)), 450, N'007       ', N'White-Blend-Other-Whites6.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (398, N'DE BORTOLI WINDY PEAK CLASSIC DRY WHITE', CAST(15.95 AS Numeric(8, 2)), 450, N'007       ', N'White-Blend-Other-Whites7.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (399, N'HOUGHTON MUSEUM RELEASE WHITE CLASSIC', CAST(34.00 AS Numeric(8, 2)), 450, N'007       ', N'White-Blend-Other-Whites8.jpg')
GO
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (400, N'KNAPPSTEIN SHILLING CLASSIC WHITE', CAST(12.00 AS Numeric(8, 2)), 450, N'007       ', N'White-Blend-Other-Whites9.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (401, N'NIGL FREIHEIT GRUNER VELTLINER', CAST(37.95 AS Numeric(8, 2)), 450, N'007       ', N'White-Blend-Other-Whites10.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (402, N'TYRRELLS GLENBAWN CLASSIC DRY WHITE', CAST(16.95 AS Numeric(8, 2)), 450, N'007       ', N'White-Blend-Other-Whites11.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (403, N'WINE - BROWN BROTHERS EVERTON WHITE', CAST(14.95 AS Numeric(8, 2)), 450, N'007       ', N'White-Blend-Other-Whites12.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [CatalogyID], [Image]) VALUES (404, N'STONEHAVEN HIDDEN SEA VIOGNIER', CAST(21.95 AS Numeric(8, 2)), 450, N'005       ', N'Viognier.jpg')
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Products_Catalogy] FOREIGN KEY([CatalogyID])
REFERENCES [dbo].[Catalogy] ([CatalogyID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Products_Catalogy]
GO
USE [master]
GO
ALTER DATABASE [WineStore2] SET  READ_WRITE 
GO
