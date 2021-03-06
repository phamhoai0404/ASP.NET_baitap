USE [master]
GO
/****** Object:  Database [SinhVienDB]    Script Date: 7/20/2017 8:06:00 PM ******/
CREATE DATABASE [SinhVienDB]  
GO
USE [SinhVienDB]
GO
/****** Object:  Table [dbo].[DangKy]    Script Date: 7/20/2017 8:06:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DangKy](
	[MaSV] [char](15) NOT NULL,
	[MaMon] [char](4) NOT NULL,
	[NgayBatDau] [datetime] NOT NULL,
	[NgayKetThuc] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 7/20/2017 8:06:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMon] [char](4) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[SoTinChi] [int] NULL,
	[SoDangKy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 7/20/2017 8:06:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [char](15) NOT NULL,
	[TenSV] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Anh] [nvarchar](50) NULL,
	[TenDN] [nvarchar](40) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Khoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DangKy] ([MaSV], [MaMon], [NgayBatDau], [NgayKetThuc]) VALUES (N'S01            ', N'M01 ', CAST(N'2016-09-01 00:00:00.000' AS DateTime), CAST(N'2016-12-08 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKy] ([MaSV], [MaMon], [NgayBatDau], [NgayKetThuc]) VALUES (N'S01            ', N'M02 ', CAST(N'2016-10-12 00:00:00.000' AS DateTime), CAST(N'2016-12-28 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKy] ([MaSV], [MaMon], [NgayBatDau], [NgayKetThuc]) VALUES (N'S01            ', N'M03 ', CAST(N'2017-05-03 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[DangKy] ([MaSV], [MaMon], [NgayBatDau], [NgayKetThuc]) VALUES (N'S03            ', N'M03 ', CAST(N'2017-04-09 00:00:00.000' AS DateTime), NULL)

INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'M01 ', N'Cơ sở dữ liệu', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'M02 ', N'Phân tích thiết kế hệ thống', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'M03 ', N'Trí tuệ nhân tạo', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'M04 ', N'Lập trình Windows', 4)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'M05', N'Hệ quản trị SQLserver', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'M06', N'Lập trình Java', 5)

INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [DiaChi], [DienThoai], [Email], [Anh], [TenDN], [MatKhau], [Khoa]) VALUES (N'S01            ', N'Trần Thanh Tùng', N'Đông Anh - Hà Nội', N'0912345678', N'tungtt@gmail.com', N'sv1.jpg', N'tungtt', N'123', 0)
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [DiaChi], [DienThoai], [Email], [Anh], [TenDN], [MatKhau], [Khoa]) VALUES (N'S02            ', N'Nguyễn Thu Hà', N'Hòa Bình - Hòa Bình', N'0913345678', N'hant@gmail.com', N'sv2.jpg', N'hant', N'ha123', 0)
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [DiaChi], [DienThoai], [Email], [Anh], [TenDN], [MatKhau], [Khoa]) VALUES (N'S03            ', N'Lê Ngọc Huyền', N'Sơn Tây - Hà Nội', N'0915678678', N'huyenln@yahoo.com', N'sv3.jpg', N'huyenln', N'abc', 0)
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [DiaChi], [DienThoai], [Email], [Anh], [TenDN], [MatKhau], [Khoa]) VALUES (N'S04            ', N'Hoàng Việt Hà', N'Hà Đông - Hà Nội', N'0915678678', N'huyenln@gmail.com', N'sv4.jpg', N'huyenln', N'abc', 1)
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [DiaChi], [DienThoai], [Email], [Anh], [TenDN], [MatKhau], [Khoa]) VALUES (N'S05            ', N'Lê Việt Hải', N'Quận 1 - TP HCM', N'0985655678', N'hailv@yahoo.com', N'sv5.jpg', N'hailv', N'hai', 1)
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [DiaChi], [DienThoai], [Email], [Anh], [TenDN], [MatKhau], [Khoa]) VALUES (N'S07            ', N'Nguyễn Thị Nhung', N'Thanh Xuân - Hà Nội', N'0987675674', N'nhung@gmail.com', N'sv7.jpg', N'nhungnt', N'123', 1)
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [DiaChi], [DienThoai], [Email], [Anh], [TenDN], [MatKhau], [Khoa]) VALUES (N'S08            ', N'Trần Văn Nam', N'Thái Bình', N'0982345769', N'namtv@gmail.com', N'sv8.jpg', N'namtv', N'123', 0)
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonHoc] ([MaMon])
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
USE [master]
GO
ALTER DATABASE [SinhVienDB] SET  READ_WRITE 
GO
