USE [master]
GO
/****** Object:  Database [quanlylinhkienpc]    Script Date: 01/13/2018 14:04:57 ******/
CREATE DATABASE [quanlylinhkienpc] ON  PRIMARY 
( NAME = N'quanlylinhkienpc', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\quanlylinhkienpc.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'quanlylinhkienpc_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\quanlylinhkienpc_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [quanlylinhkienpc] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlylinhkienpc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlylinhkienpc] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET ANSI_NULLS OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET ANSI_PADDING OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET ARITHABORT OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET AUTO_CLOSE ON
GO
ALTER DATABASE [quanlylinhkienpc] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [quanlylinhkienpc] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [quanlylinhkienpc] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [quanlylinhkienpc] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET  ENABLE_BROKER
GO
ALTER DATABASE [quanlylinhkienpc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [quanlylinhkienpc] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [quanlylinhkienpc] SET  READ_WRITE
GO
ALTER DATABASE [quanlylinhkienpc] SET RECOVERY SIMPLE
GO
ALTER DATABASE [quanlylinhkienpc] SET  MULTI_USER
GO
ALTER DATABASE [quanlylinhkienpc] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [quanlylinhkienpc] SET DB_CHAINING OFF
GO
USE [quanlylinhkienpc]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 01/13/2018 14:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[taikhoan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](30) NOT NULL,
	[password] [varchar](1000) NOT NULL,
	[level] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[taikhoan] ON
INSERT [dbo].[taikhoan] ([id], [username], [password], [level]) VALUES (1, N'admin', N'1', 1)
INSERT [dbo].[taikhoan] ([id], [username], [password], [level]) VALUES (2, N'nhanvien1', N'1', 0)
SET IDENTITY_INSERT [dbo].[taikhoan] OFF
/****** Object:  Table [dbo].[linhkien]    Script Date: 01/13/2018 14:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[linhkien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[malinhkien] [char](10) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[loai] [char](10) NOT NULL,
	[quycach] [nvarchar](100) NULL,
	[noisanxuat] [nvarchar](30) NULL,
	[namsanxuat] [date] NULL,
	[thoigianbh] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[malinhkien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[linhkien] ON
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (1, N'A011      ', N'Mainboard', N'A         ', N' ASUS Z10PE-D8WS', N'Taipei, Taiwan', CAST(0xA3390B00 AS Date), 36)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (2, N'A021      ', N'CPU', N'A         ', N'Intel Core i7 8700K 3.7Ghz Turbo Up to 4.7Ghz ', N'Santa Clara, California, Unite', CAST(0xA53B0B00 AS Date), 36)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (3, N'A031      ', N'Ổ Cứng HDD ', N'A         ', N'Western Purple 4TB/5400 Sata 3 64Mb', N'United States', CAST(0x71390B00 AS Date), 36)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (4, N'A041      ', N'Ổ cứng SSD  ', N'A         ', N'AVEXIR S100 Blue 120GB SATA3 6Gb/s 2.5', N'Hsinchu County, Taiwan', CAST(0x0E3C0B00 AS Date), 36)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (5, N'A051      ', N'Ram', N'A         ', N'Gskill Triden 32GB (4*8GB) DDR4 Bus 3200 Mhz', N'Taipei, Taiwan', CAST(0x313C0B00 AS Date), 36)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (6, N'A061      ', N'Tản nhiệt CPU', N'A         ', N'Corsair Hydro Series H115i 280mm Ext', N'Fremont, California, United St', CAST(0xF13A0B00 AS Date), 24)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (7, N'A071      ', N'VGA', N'A         ', N' GIGABYTE Radeon RX VEGA 64 Watercooling 8G', N'New Taipei City, Taiwan', CAST(0x573C0B00 AS Date), 36)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (8, N'A081      ', N'Case', N'A         ', N' Corsair Obsidian Series® 900D (Window - Super)', N'Fremont, California, United St', CAST(0xE43B0B00 AS Date), 12)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (9, N'A091      ', N'Nguồn', N'A         ', N' FSP Power Supply HYDRO X Series HGX650 - Active PFC - 80 Plus Gold', N'Oslo, Norway', CAST(0xCC3B0B00 AS Date), 36)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (10, N'A101      ', N'Màn hình', N'A         ', N' Asus 28"PB287Q LED 4K', N'Taipei, Taiwan', CAST(0xF33A0B00 AS Date), 36)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (11, N'B011      ', N'Bàn Phím', N'B         ', N' SteelSeries Apex M750 Mechanical Gaming', N'Copenhagen, Denmark', CAST(0x143B0B00 AS Date), 36)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (12, N'B021      ', N'Chuột', N'B         ', N' SteelSeries Rival 300 CS:GO Hyperbeast Editiion', N'Copenhagen, Denmark', CAST(0x173B0B00 AS Date), 36)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (13, N'B031      ', N'Bàn Di', N'B         ', N'SteelSeries QcK+ Limited Gaming(63700)', N'Copenhagen, Denmark', CAST(0x6B3A0B00 AS Date), 36)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (14, N'B041      ', N'Tai nghe', N'B         ', N' Razer Tiamat 2.2 V2 - Analog Gaming Headset', N'San Francisco, California, Uni', CAST(0x463B0B00 AS Date), 36)
INSERT [dbo].[linhkien] ([id], [malinhkien], [ten], [loai], [quycach], [noisanxuat], [namsanxuat], [thoigianbh]) VALUES (15, N'B051      ', N'Ghế', N'B         ', N' DXRACER R Series R288-NRW-W1 ', N'9177 E. Michigan 36', CAST(0x463B0B00 AS Date), 36)
SET IDENTITY_INSERT [dbo].[linhkien] OFF
/****** Object:  Table [dbo].[khachhang]    Script Date: 01/13/2018 14:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[makhachhang] [int] IDENTITY(1,1) NOT NULL,
	[ngaythanhtoan] [datetime] NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](20) NOT NULL,
	[sdt] [nvarchar](12) NOT NULL,
	[tongtien] [float] NOT NULL,
	[hanhdong] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[makhachhang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[khachhang] ON
INSERT [dbo].[khachhang] ([makhachhang], [ngaythanhtoan], [hoten], [diachi], [sdt], [tongtien], [hanhdong]) VALUES (1, CAST(0x0000A86700AC9F68 AS DateTime), N'Nguyễn văn a', N'112/24 phường lĩnh n', N'0971069100', 12954100, N'Bán ra')
INSERT [dbo].[khachhang] ([makhachhang], [ngaythanhtoan], [hoten], [diachi], [sdt], [tongtien], [hanhdong]) VALUES (2, CAST(0x0000A86700ACE810 AS DateTime), N'trần văn b', N'43 đống đa hà nội', N'01692829597', 7983800, N'Nhập vào')
INSERT [dbo].[khachhang] ([makhachhang], [ngaythanhtoan], [hoten], [diachi], [sdt], [tongtien], [hanhdong]) VALUES (3, CAST(0x0000A86700AD30B8 AS DateTime), N'Hoàng công nam', N'gia bình bắc ninh', N'099184727', 7244000, N'Nhập vào')
INSERT [dbo].[khachhang] ([makhachhang], [ngaythanhtoan], [hoten], [diachi], [sdt], [tongtien], [hanhdong]) VALUES (4, CAST(0x0000A86700AD7000 AS DateTime), N'phạm văn a', N'123 phố huế hà nội', N'0987346723', 3311500, N'Bán ra')
SET IDENTITY_INSERT [dbo].[khachhang] OFF
/****** Object:  StoredProcedure [dbo].[inskhachhang]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[inskhachhang](
@ngaythanhtoan datetime,
@hoten nvarchar(50) ,
@diachi nvarchar(20) ,
@sdt nvarchar(12),
@tongtien float ,
@hanhdong nvarchar(30))
as begin
insert into khachhang values(@ngaythanhtoan,@hoten,@diachi,@sdt,@tongtien,@hanhdong)
end
GO
/****** Object:  Table [dbo].[muaban]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[muaban](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[malinhkien] [char](10) NOT NULL,
	[chatluong] [int] NOT NULL,
	[gianhap] [float] NOT NULL,
	[giaxuat] [float] NOT NULL,
	[lai] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[malinhkien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[muaban] ON
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (1, N'A011      ', 1, 1250000, 1499900, 249900)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (2, N'A021      ', 1, 790000, 974900, 184900)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (3, N'A031      ', 1, 272000, 395000, 123000)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (4, N'A041      ', 1, 121000, 189900, 68900)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (5, N'A051      ', 1, 820000, 929900, 109900)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (6, N'A061      ', 1, 242000, 358900, 116900)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (7, N'A071      ', 1, 1832000, 2299900, 467900)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (8, N'A081      ', 1, 632000, 734800, 102800)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (9, N'A091      ', 1, 199900, 239900, 40000)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (10, N'A101      ', 1, 1199900, 1299900, 100000)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (11, N'B011      ', 1, 220000, 323000, 103000)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (12, N'B021      ', 1, 99000, 142000, 43000)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (13, N'B031      ', 1, 42000, 69900, 27900)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (14, N'B041      ', 1, 272000, 333900, 61900)
INSERT [dbo].[muaban] ([id], [malinhkien], [chatluong], [gianhap], [giaxuat], [lai]) VALUES (15, N'B051      ', 1, 699900, 799900, 100000)
SET IDENTITY_INSERT [dbo].[muaban] OFF
/****** Object:  StoredProcedure [dbo].[deletetaikhoan]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletetaikhoan](@id int)
as
begin
delete from taikhoan where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[getidlinhkien]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getidlinhkien](@malinhkien char(10))
as
begin
select id from linhkien where malinhkien=@malinhkien
end
GO
/****** Object:  StoredProcedure [dbo].[delkhachhang]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delkhachhang](@makhachhang int)
as begin
delete from khachhang where makhachhang=@makhachhang
end
GO
/****** Object:  StoredProcedure [dbo].[insertlinhkien]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertlinhkien] ( @malinhkien char(10),
	@ten nvarchar(50) ,	
	@loai char(10) ,
	@quycach nvarchar(100),
	@noisanxuat nvarchar(30),
	@namsanxuat date,
	@thoigianbh int)
as
begin
	insert into linhkien values (@malinhkien,@ten,@loai,@quycach,@noisanxuat,@namsanxuat,@thoigianbh)
end
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hoadon](
	[mahoadon] [int] IDENTITY(1,1) NOT NULL,
	[makhachhang] [int] NOT NULL,
	[malinhkien] [char](10) NOT NULL,
	[gia] [float] NOT NULL,
	[soluong] [int] NOT NULL,
	[thanhtien] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[hoadon] ON
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (1, 1, N'A011      ', 1499900, 1, 1499900)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (2, 1, N'A021      ', 974900, 2, 1949800)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (3, 1, N'A031      ', 395000, 3, 1185000)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (4, 1, N'A051      ', 929900, 4, 3719600)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (5, 1, N'A071      ', 2299900, 2, 4599800)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (6, 2, N'A051      ', 820000, 1, 820000)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (7, 2, N'A091      ', 199900, 2, 399800)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (8, 2, N'A071      ', 1832000, 3, 5496000)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (9, 2, N'B031      ', 42000, 4, 168000)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (10, 2, N'B011      ', 220000, 5, 1100000)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (11, 3, N'A061      ', 242000, 2, 484000)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (12, 3, N'A071      ', 1832000, 3, 5496000)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (13, 3, N'A081      ', 632000, 2, 1264000)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (14, 4, N'B021      ', 142000, 5, 710000)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (15, 4, N'B041      ', 333900, 3, 1001700)
INSERT [dbo].[hoadon] ([mahoadon], [makhachhang], [malinhkien], [gia], [soluong], [thanhtien]) VALUES (16, 4, N'B051      ', 799900, 2, 1599800)
SET IDENTITY_INSERT [dbo].[hoadon] OFF
/****** Object:  Table [dbo].[soluong]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[soluong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[malinhkien] [char](10) NOT NULL,
	[slnhap] [int] NULL,
	[slxuat] [int] NULL,
	[slcon] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[malinhkien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[soluong] ON
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (1, N'A011      ', 15, 1, 14)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (2, N'A021      ', 12, 2, 10)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (3, N'A031      ', 12, 3, 9)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (4, N'A041      ', 22, 0, 22)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (5, N'A051      ', 17, 4, 13)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (6, N'A061      ', 10, 0, 10)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (7, N'A071      ', 12, 2, 10)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (8, N'A081      ', 10, 0, 10)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (9, N'A091      ', 17, 0, 17)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (10, N'A101      ', 18, 0, 18)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (11, N'B011      ', 25, 0, 25)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (12, N'B021      ', 25, 5, 20)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (13, N'B031      ', 26, 0, 26)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (14, N'B041      ', 18, 3, 15)
INSERT [dbo].[soluong] ([id], [malinhkien], [slnhap], [slxuat], [slcon]) VALUES (15, N'B051      ', 25, 2, 23)
SET IDENTITY_INSERT [dbo].[soluong] OFF
/****** Object:  StoredProcedure [dbo].[updatelinhkien]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatelinhkien] (@id int, @malinhkien char(10),
	@ten nvarchar(50) ,	
	@loai char(10) ,
	@quycach nvarchar(100),
	@noisanxuat nvarchar(30),
	@namsanxuat date,
	@thoigianbh int)
as
begin
	update  linhkien set malinhkien=@malinhkien,ten=@ten,loai=@loai,quycach=@quycach,noisanxuat=@noisanxuat,namsanxuat=@namsanxuat,thoigianbh=@thoigianbh
	where id=@id
end
GO
/****** Object:  Table [dbo].[thunhap]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[thunhap](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[malinhkien] [char](10) NOT NULL,
	[tienvon] [float] NULL,
	[tienthu] [float] NULL,
	[tienlai] [float] NULL,
	[hoivon] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[malinhkien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[thunhap] ON
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (1, N'A011      ', 18750000, 1499900, 249900, -17250100)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (2, N'A021      ', 9480000, 1949800, 369800, -7530200)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (3, N'A031      ', 3264000, 1185000, 369000, -2079000)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (4, N'A041      ', 2662000, 0, 0, -2662000)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (5, N'A051      ', 13120000, 3719600, 439600, -9400400)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (6, N'A061      ', 1936000, 0, 0, -1936000)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (7, N'A071      ', 10992000, 4599800, 935800, -6392200)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (8, N'A081      ', 5056000, 0, 0, -5056000)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (9, N'A091      ', 2998500, 0, 0, -2998500)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (10, N'A101      ', 21598200, 0, 0, -21598200)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (11, N'B011      ', 4400000, 0, 0, -4400000)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (12, N'B021      ', 2475000, 710000, 215000, -1765000)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (13, N'B031      ', 924000, 0, 0, -924000)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (14, N'B041      ', 4896000, 1001700, 185700, -3894300)
INSERT [dbo].[thunhap] ([id], [malinhkien], [tienvon], [tienthu], [tienlai], [hoivon]) VALUES (15, N'B051      ', 17497500, 1599800, 200000, -15897700)
SET IDENTITY_INSERT [dbo].[thunhap] OFF
/****** Object:  StoredProcedure [dbo].[inserttaikhoan]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[inserttaikhoan](
@username varchar(30) ,
@password varchar(1000),
@level int)
as
begin
	insert into taikhoan values (@username,@password,@level)
end
GO
/****** Object:  StoredProcedure [dbo].[updatetaikhoan]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatetaikhoan]( 
@id int, 
@username varchar(30) ,
@password varchar(1000),
@level int)
as
begin
		update taikhoan 
		set username=@username,password=@password,level=@level
		where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[dangnhap]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[dangnhap]
(
@username varchar(30) ,
@password varchar(1000)
 )
as
	begin
		 select * from taikhoan where username=@username and password=@password
	end
GO
/****** Object:  StoredProcedure [dbo].[updatethunhap]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[updatethunhap]( @id int,@malinhkien char(10))
as

begin
DECLARE @slnhap int
select @slnhap=slnhap from soluong where malinhkien= @malinhkien
DECLARE @slxuat int
select @slxuat=slxuat from soluong where malinhkien= @malinhkien
DECLARE @gianhap float
select @gianhap=gianhap from muaban where malinhkien= @malinhkien
DECLARE @giaxuat float
select @giaxuat=giaxuat from muaban where malinhkien= @malinhkien
DECLARE @tienvon float
UPDATE thunhap
SET malinhkien=@malinhkien,tienvon = @slnhap*@gianhap, tienthu = @slxuat*@giaxuat,tienlai=@slxuat*(@giaxuat-@gianhap),hoivon=@slxuat*@giaxuat-@slnhap*@gianhap
WHERE id=@id;
 end
GO
/****** Object:  StoredProcedure [dbo].[updatesoluong]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[updatesoluong](@id int, @malinhkien char(10),@slnhap int,@slxuat int)
as
begin
update soluong set slnhap=@slnhap,slxuat=@slxuat
where id=@id
update soluong set slcon=slnhap-slxuat
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[updatemuaban]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[updatemuaban](@id int, @malinhkien char(10),@chatluong int,@gianhap float,@giaxuat float)
as
begin
update  muaban 
set malinhkien=@malinhkien,chatluong=@chatluong,gianhap=@gianhap,giaxuat=@giaxuat,lai=@giaxuat-@gianhap
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[insertsoluong]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[insertsoluong]( @malinhkien char(10),@slnhap int,@slxuat int)
as
begin
insert into soluong values (@malinhkien,@slnhap,@slxuat,@slnhap-@slxuat)
end
GO
/****** Object:  StoredProcedure [dbo].[insertmuaban]    Script Date: 01/13/2018 14:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[insertmuaban]( @malinhkien char(10),@chatluong int,@gianhap float,@giaxuat float)
as
begin
insert into muaban values (@malinhkien,@chatluong,@gianhap,@giaxuat,@giaxuat-@gianhap)
end
GO
/****** Object:  View [dbo].[selectthongke]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create VIEW  [dbo].[selectthongke]
as
select  lk.malinhkien as[Mã Linh Kiện],lk.ten as[Tên Linh Kiện],lk.loai as [Loại],mb.chatluong[Chất Lượng],
lk.thoigianbh as [Bảo Hành],sl.slnhap as [Số Lượng Nhập],sl.slxuat as[Số Lượng Bán],sl.slcon [Còn Lại]
,mb.gianhap as [Giá Nhập], mb.giaxuat as[Giá Bán] ,
tn.tienvon as[Vốn],tn.tienthu as[Thu Lại], tn.tienlai as[Lãi],tn.hoivon as [Hồi Vốn]
from linhkien as lk, soluong as sl, muaban as mb ,thunhap as tn
where lk.malinhkien=sl.malinhkien and mb.malinhkien =lk.malinhkien and tn.malinhkien=lk.malinhkien
GO
/****** Object:  View [dbo].[selectnhaplinhkien]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create VIEW  [dbo].[selectnhaplinhkien]
as
select  lk.id,lk.malinhkien as[Mã Linh Kiện],lk.ten as[Tên Linh Kiện],lk.loai as [Loại],lk.quycach as [Quy Cách],lk.noisanxuat as[Xuất Sứ],
lk.namsanxuat[Năm Sản Xuất],lk.thoigianbh as [Bảo Hành],
mb.chatluong[Chất Lượng],mb.gianhap as [Giá Nhập],mb.giaxuat as[Giá Bán] ,
sl.slnhap as[Đã Nhập],sl.slxuat as[Đã Bán]
from linhkien as lk, soluong as sl, muaban as mb 
where lk.malinhkien=sl.malinhkien and mb.malinhkien =lk.malinhkien
GO
/****** Object:  View [dbo].[selectnhap]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create VIEW  [dbo].[selectnhap]
as
select  lk.malinhkien as[Mã Linh Kiện],lk.ten as[Tên Linh Kiện],lk.loai as [Loại],lk.quycach ,mb.chatluong[Chất Lượng],mb.gianhap as[Giá nhập] ,sl.slcon [Còn Lại]
from linhkien as lk, soluong as sl, muaban as mb 
where lk.malinhkien=sl.malinhkien and mb.malinhkien =lk.malinhkien
GO
/****** Object:  View [dbo].[selectmuaban]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create VIEW  [dbo].[selectmuaban]
as
select  lk.malinhkien as[Mã Linh Kiện],lk.ten as[Tên Linh Kiện],lk.loai as [Loại],lk.quycach as [Quy Cách],lk.noisanxuat as[Xuất Sứ],
lk.thoigianbh as [Bảo Hành],lk.namsanxuat[Năm Sản Xuất],mb.chatluong[Chất Lượng],mb.giaxuat as[Giá Bán] ,sl.slcon [Còn Lại]
from linhkien as lk, soluong as sl, muaban as mb 
where lk.malinhkien=sl.malinhkien and mb.malinhkien =lk.malinhkien
GO
/****** Object:  View [dbo].[selectban]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create VIEW  [dbo].[selectban]
as
select  lk.malinhkien as[Mã Linh Kiện],lk.ten as[Tên Linh Kiện],lk.loai as [Loại],lk.quycach ,mb.chatluong[Chất Lượng],mb.giaxuat as[Giá Bán] ,sl.slcon [Còn Lại]
from linhkien as lk, soluong as sl, muaban as mb 
where lk.malinhkien=sl.malinhkien and mb.malinhkien =lk.malinhkien
GO
/****** Object:  StoredProcedure [dbo].[nhaplinhkien]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhaplinhkien] ( @malinhkien char(10),
	@ten nvarchar(50) ,	
	@loai char(10) ,
	@quycach nvarchar(100),
	@noisanxuat nvarchar(30),
	@namsanxuat date,
	@thoigianbh int,
	@chatluong int ,
	@gianhap float ,
	@giaxuat float ,
	@slnhap int,
	@slxuat int )
as

begin

	insert into linhkien values (@malinhkien,@ten,@loai,@quycach,@noisanxuat,@namsanxuat,@thoigianbh)
	insert into muaban values (@malinhkien,@chatluong,@gianhap,@giaxuat,@giaxuat-@gianhap)
	insert into soluong values (@malinhkien,@slnhap,@slxuat,@slnhap)
end
GO
/****** Object:  StoredProcedure [dbo].[getidthunhap]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getidthunhap](@idlinhkien int)
 as
 begin
	select tn.id from linhkien as lk, thunhap as tn where lk.malinhkien=tn.malinhkien and lk.id=@idlinhkien
 end
GO
/****** Object:  StoredProcedure [dbo].[getidsoluong]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getidsoluong]( @idlinhkien int)
 as
 begin
	select sl.id from linhkien as lk, soluong as sl where lk.malinhkien=sl.malinhkien and lk.id=@idlinhkien
 end
GO
/****** Object:  StoredProcedure [dbo].[getidmuaban]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getidmuaban]( @idlinhkien int)
 as
 begin
	select mb.id from linhkien as lk, muaban as mb where lk.malinhkien=mb.malinhkien and lk.id=@idlinhkien
 end
GO
/****** Object:  StoredProcedure [dbo].[delhoadon]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delhoadon](
@mahoadon int
)
as begin
delete from hoadon where mahoadon=@mahoadon
end
GO
/****** Object:  StoredProcedure [dbo].[deletelinhkien]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--dbo.updatelinhkien 2 , 'a12',N'ten','loai a',N'quycach',N'xuat sư','2010/06/10',6

create proc [dbo].[deletelinhkien] (@malinhkien char(10))
as
begin
	delete from muaban where malinhkien=@malinhkien
	delete from soluong where malinhkien=@malinhkien
	delete from thunhap where malinhkien=@malinhkien
	delete from linhkien where malinhkien=@malinhkien
end
GO
/****** Object:  StoredProcedure [dbo].[inshoadon]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[inshoadon](
@makhachhang int,
@malinhkien char(10) ,
@gia float,
@soluong int ,
@thanhtien float 
)
as begin
insert into hoadon values(@makhachhang,@malinhkien,@gia,@soluong,@thanhtien)
end
GO
/****** Object:  StoredProcedure [dbo].[insertthunhap]    Script Date: 01/13/2018 14:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[insertthunhap]( @malinhkien char(10))
as
begin
DECLARE @slnhap int
select @slnhap=slnhap from soluong where malinhkien= @malinhkien
DECLARE @slxuat int
select @slxuat=slxuat from soluong where malinhkien= @malinhkien
DECLARE @gianhap float
select @gianhap=gianhap from muaban where malinhkien= @malinhkien
DECLARE @giaxuat float
select @giaxuat=giaxuat from muaban where malinhkien= @malinhkien
DECLARE @tienvon float
insert into thunhap values (@malinhkien,@slnhap*@gianhap,@slxuat*@giaxuat,@slxuat*(@giaxuat-@gianhap),@slxuat*@giaxuat-@slnhap*@gianhap)
end
GO
/****** Object:  Default [DF__taikhoan__level__014935CB]    Script Date: 01/13/2018 14:05:00 ******/
ALTER TABLE [dbo].[taikhoan] ADD  DEFAULT ((0)) FOR [level]
GO
/****** Object:  Default [DF__soluong__slnhap__0EA330E9]    Script Date: 01/13/2018 14:05:20 ******/
ALTER TABLE [dbo].[soluong] ADD  DEFAULT ((0)) FOR [slnhap]
GO
/****** Object:  Default [DF__soluong__slxuat__0F975522]    Script Date: 01/13/2018 14:05:20 ******/
ALTER TABLE [dbo].[soluong] ADD  DEFAULT ((0)) FOR [slxuat]
GO
/****** Object:  Default [DF__soluong__slcon__108B795B]    Script Date: 01/13/2018 14:05:20 ******/
ALTER TABLE [dbo].[soluong] ADD  DEFAULT ((0)) FOR [slcon]
GO
/****** Object:  ForeignKey [FK__muaban__malinhki__09DE7BCC]    Script Date: 01/13/2018 14:05:20 ******/
ALTER TABLE [dbo].[muaban]  WITH CHECK ADD FOREIGN KEY([malinhkien])
REFERENCES [dbo].[linhkien] ([malinhkien])
GO
/****** Object:  ForeignKey [FK__hoadon__makhachh__1FCDBCEB]    Script Date: 01/13/2018 14:05:20 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhang] ([makhachhang])
GO
/****** Object:  ForeignKey [FK__hoadon__malinhki__1ED998B2]    Script Date: 01/13/2018 14:05:20 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD FOREIGN KEY([malinhkien])
REFERENCES [dbo].[linhkien] ([malinhkien])
GO
/****** Object:  ForeignKey [FK__soluong__malinhk__117F9D94]    Script Date: 01/13/2018 14:05:20 ******/
ALTER TABLE [dbo].[soluong]  WITH CHECK ADD FOREIGN KEY([malinhkien])
REFERENCES [dbo].[linhkien] ([malinhkien])
GO
/****** Object:  ForeignKey [FK__thunhap__malinhk__164452B1]    Script Date: 01/13/2018 14:05:20 ******/
ALTER TABLE [dbo].[thunhap]  WITH CHECK ADD FOREIGN KEY([malinhkien])
REFERENCES [dbo].[linhkien] ([malinhkien])
GO
