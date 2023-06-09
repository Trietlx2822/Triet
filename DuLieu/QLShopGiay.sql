USE [QLShopGiay]
GO
/****** Object:  Table [dbo].[CT_PhieuChuyen]    Script Date: 11/03/2022 13:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuChuyen](
	[SoPhieuChuyen] [nvarchar](10) NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[Dongia] [numeric](18, 0) NULL,
 CONSTRAINT [PK_CT_PhieuChuyen] PRIMARY KEY CLUSTERED 
(
	[SoPhieuChuyen] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CT_PhieuChuyen] ([SoPhieuChuyen], [MaSP], [SoLuong], [Dongia]) VALUES (N'PC01', N'A01', 2, CAST(6200000 AS Numeric(18, 0)))
INSERT [dbo].[CT_PhieuChuyen] ([SoPhieuChuyen], [MaSP], [SoLuong], [Dongia]) VALUES (N'PC02', N'N01', 4, CAST(14000000 AS Numeric(18, 0)))
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/03/2022 13:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[DCNV] [nvarchar](50) NULL,
	[SDTNV] [nvarchar](10) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DCNV], [SDTNV]) VALUES (N'NV01', N'Thái Minh A', N'Thủ Đức', N'02566984')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DCNV], [SDTNV]) VALUES (N'NV02', N'Võ Thị Minh B', N'Thủ Đức', N'03265554')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DCNV], [SDTNV]) VALUES (N'NV03', N'Thái Võ Minh C', N'Hóc Môn', N'03688879')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DCNV], [SDTNV]) VALUES (N'NV04', N'Võ Thái D', N'Hà Nội', N'03546698')
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/03/2022 13:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DCKH] [nvarchar](50) NULL,
	[SDT] [nvarchar](11) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DCKH], [SDT]) VALUES (N'KH01', N'Nguyễn Văn A', N'Long Xuyên', N'0255446')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DCKH], [SDT]) VALUES (N'KH02', N'Nguyễn Minh B', N'Bình Khánh', N'0254888')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DCKH], [SDT]) VALUES (N'KH03', N'Trần Minh C', N'Bình Khánh 1', N'0889554')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DCKH], [SDT]) VALUES (N'KH04', N'Nguyễn Trần Minh D', N'Bình Khánh', N'0366999')
/****** Object:  Table [dbo].[User_ID]    Script Date: 11/03/2022 13:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_ID](
	[TenDN] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Quyen] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[User_ID] ([TenDN], [MatKhau], [Quyen]) VALUES (N'Admin', N'123456', 1)
INSERT [dbo].[User_ID] ([TenDN], [MatKhau], [Quyen]) VALUES (N'KhachHang', N'147258', 2)
INSERT [dbo].[User_ID] ([TenDN], [MatKhau], [Quyen]) VALUES (N'Binhbinh', N'12345685', 2)
INSERT [dbo].[User_ID] ([TenDN], [MatKhau], [Quyen]) VALUES (N'PhungTien', N'147852', 2)
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 11/03/2022 13:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[TGBaoHanh] [nvarchar](50) NULL,
	[NSX] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[Gia] [numeric](18, 0) NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [TGBaoHanh], [NSX], [SoLuong], [Gia]) VALUES (N'A01', N'GIÀY ADIDAS ADIZERO BOSTON 11 NAM - ĐEN TRẮNG', N'6 Tháng', N'ADIDAS', 20, CAST(3100000 AS Numeric(18, 0)))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [TGBaoHanh], [NSX], [SoLuong], [Gia]) VALUES (N'A02', N'GIÀY ADIDAS GALAXY 6 NỮ - TRẮNG XANH', N'12 Tháng', N'ADIDAS', 10, CAST(1600000 AS Numeric(18, 0)))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [TGBaoHanh], [NSX], [SoLuong], [Gia]) VALUES (N'A03', N'GIÀY ADIDAS GLX 5M NAM - TRẮNG', N'24 Tháng', N'ADIDAS', 20, CAST(1490000 AS Numeric(18, 0)))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [TGBaoHanh], [NSX], [SoLuong], [Gia]) VALUES (N'N01', N'GIÀY NIKE AIR ZOOM PEGASUS 39 FLYEASE NAM- XÁM', N'12 Tháng', N'NIKE', 10, CAST(3500000 AS Numeric(18, 0)))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [TGBaoHanh], [NSX], [SoLuong], [Gia]) VALUES (N'N02', N'GIÀY NIKE AIR ZOOM PEGASUS 39 NỮ- XÁM', N'12 Tháng', N'NIKE', 30, CAST(3300000 AS Numeric(18, 0)))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [TGBaoHanh], [NSX], [SoLuong], [Gia]) VALUES (N'P06', N'Pumba', N'12 Tháng', N'Puma', 2, CAST(2000000 AS Numeric(18, 0)))
/****** Object:  Table [dbo].[PHIEUCHUYEN]    Script Date: 11/03/2022 13:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUCHUYEN](
	[SoPhieuChuyen] [nvarchar](10) NOT NULL,
	[TinhTrangChuyen] [nvarchar](50) NULL,
	[NgayChuyen] [datetime] NULL,
	[MaNV] [nvarchar](10) NULL,
	[SoHD] [nvarchar](10) NULL,
 CONSTRAINT [PK_PHIEUCHUYEN] PRIMARY KEY CLUSTERED 
(
	[SoPhieuChuyen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PHIEUCHUYEN] ([SoPhieuChuyen], [TinhTrangChuyen], [NgayChuyen], [MaNV], [SoHD]) VALUES (N'PC01', N'Bình Thường', CAST(0x0000908F00000000 AS DateTime), N'NV01', N'HD001')
INSERT [dbo].[PHIEUCHUYEN] ([SoPhieuChuyen], [TinhTrangChuyen], [NgayChuyen], [MaNV], [SoHD]) VALUES (N'PC02', N'Siêu Tốc', CAST(0x0000908F00000000 AS DateTime), N'NV01', N'HD001')
INSERT [dbo].[PHIEUCHUYEN] ([SoPhieuChuyen], [TinhTrangChuyen], [NgayChuyen], [MaNV], [SoHD]) VALUES (N'PC03', N'Bình Thường', CAST(0x0000921A00000000 AS DateTime), N'NV01', N'HD002')
INSERT [dbo].[PHIEUCHUYEN] ([SoPhieuChuyen], [TinhTrangChuyen], [NgayChuyen], [MaNV], [SoHD]) VALUES (N'PC04', N'Nhanh', CAST(0x00008F2200000000 AS DateTime), N'NV02', N'HD003')
/****** Object:  Table [dbo].[HOADON]    Script Date: 11/03/2022 13:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[SoHD] [nvarchar](10) NOT NULL,
	[NgayLap] [datetime] NULL,
	[NguoiLap] [nvarchar](50) NULL,
	[NgayBatDauBaoHanh] [datetime] NULL,
	[ThoiGianBaoHanh] [nvarchar](50) NULL,
	[MaKH] [nvarchar](10) NULL,
	[MaNV] [nvarchar](10) NULL,
 CONSTRAINT [PK_HOADON_1] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HOADON] ([SoHD], [NgayLap], [NguoiLap], [NgayBatDauBaoHanh], [ThoiGianBaoHanh], [MaKH], [MaNV]) VALUES (N'HD001', CAST(0x0000908F00000000 AS DateTime), N'Thái Minh A', CAST(0x0000908F00000000 AS DateTime), N'12 Tháng', N'KH01', N'NV01')
INSERT [dbo].[HOADON] ([SoHD], [NgayLap], [NguoiLap], [NgayBatDauBaoHanh], [ThoiGianBaoHanh], [MaKH], [MaNV]) VALUES (N'HD002', CAST(0x0000921A00000000 AS DateTime), N'Thái Minh A', CAST(0x0000921A00000000 AS DateTime), N'3 Tháng', N'KH01', N'NV01')
INSERT [dbo].[HOADON] ([SoHD], [NgayLap], [NguoiLap], [NgayBatDauBaoHanh], [ThoiGianBaoHanh], [MaKH], [MaNV]) VALUES (N'HD003', CAST(0x00008F2200000000 AS DateTime), N'Võ Thị Minh B', CAST(0x00008F2200000000 AS DateTime), N'6 Tháng', N'KH02', N'NV03')
INSERT [dbo].[HOADON] ([SoHD], [NgayLap], [NguoiLap], [NgayBatDauBaoHanh], [ThoiGianBaoHanh], [MaKH], [MaNV]) VALUES (N'HD004', CAST(0x0000AD1800000000 AS DateTime), N'Thái Võ Minh C', CAST(0x0000AD1800000000 AS DateTime), N'24 Thánh', N'KH03', N'NV03')
/****** Object:  Table [dbo].[CTBANHANG]    Script Date: 11/03/2022 13:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTBANHANG](
	[MaSP] [nvarchar](10) NOT NULL,
	[SoHD] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CTBANHANG] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[SoHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTBANHANG] ([MaSP], [SoHD], [SoLuong]) VALUES (N'A01', N'HD001', 2)
INSERT [dbo].[CTBANHANG] ([MaSP], [SoHD], [SoLuong]) VALUES (N'A02', N'HD003', 10)
INSERT [dbo].[CTBANHANG] ([MaSP], [SoHD], [SoLuong]) VALUES (N'N01', N'HD002', 4)
/****** Object:  ForeignKey [FK_CTBANHANG_SANPHAM]    Script Date: 11/03/2022 13:31:27 ******/
ALTER TABLE [dbo].[CTBANHANG]  WITH CHECK ADD  CONSTRAINT [FK_CTBANHANG_SANPHAM] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[CTBANHANG] CHECK CONSTRAINT [FK_CTBANHANG_SANPHAM]
GO
/****** Object:  ForeignKey [FK_HOADON_KHACHHANG]    Script Date: 11/03/2022 13:31:27 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_PHIEUCHUYEN_NHANVIEN]    Script Date: 11/03/2022 13:31:27 ******/
ALTER TABLE [dbo].[PHIEUCHUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYEN_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUCHUYEN] CHECK CONSTRAINT [FK_PHIEUCHUYEN_NHANVIEN]
GO
