USE [QLBanHangSieuThi]
GO
/****** Object:  Table [dbo].[CHITIETNHAP]    Script Date: 10/27/2020 8:35:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETNHAP](
	[MaLoai] [nchar](10) NOT NULL,
	[MaHang] [nchar](10) NOT NULL,
	[SoHDN] [nchar](10) NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[DonGiaN] [bigint] NOT NULL,
	[HSD] [int] NOT NULL,
	[NgaySX] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETXUAT]    Script Date: 10/27/2020 8:35:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETXUAT](
	[MaLoai] [nchar](10) NOT NULL,
	[SoHDX] [nchar](10) NOT NULL,
	[MaHang] [nchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 10/27/2020 8:35:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHang] [nchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[DonVi] [nvarchar](50) NULL,
	[TenNhaSX] [nvarchar](50) NULL,
	[GiaDeNghi] [bigint] NULL,
	[MaLoai] [nchar](10) NULL,
	[SoLuongSP] [int] NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADONNHAP]    Script Date: 10/27/2020 8:35:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONNHAP](
	[SoHDN] [nchar](10) NOT NULL,
	[NgayNhap] [date] NOT NULL,
	[ThanhTienNhap] [bigint] NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[MaNCC] [nchar](10) NULL,
 CONSTRAINT [PK_HOADONNHAP] PRIMARY KEY CLUSTERED 
(
	[SoHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADONXUAT]    Script Date: 10/27/2020 8:35:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONXUAT](
	[SoHDX] [nchar](10) NOT NULL,
	[NgayXuat] [date] NULL,
	[ThanhTienXuat] [bigint] NULL,
	[MaNV] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NULL,
 CONSTRAINT [PK_HOADONXUAT] PRIMARY KEY CLUSTERED 
(
	[SoHDX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 10/27/2020 8:35:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChiKH] [nvarchar](150) NULL,
	[SdtKH] [nchar](15) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIHANG]    Script Date: 10/27/2020 8:35:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHANG](
	[MaLoai] [nchar](10) NOT NULL,
	[DienGiai] [nvarchar](150) NULL,
 CONSTRAINT [PK_LOAIHANG] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 10/27/2020 8:35:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [nchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChiNCC] [nvarchar](150) NULL,
	[SdtNCC] [nchar](15) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/27/2020 8:35:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](10) NOT NULL,
	[HoTenNV] [nvarchar](50) NULL,
	[DiaChiNV] [nvarchar](150) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[GioiTinh] [nchar](10) NULL,
	[SdtNV] [nchar](15) NULL,
	[NgaySinh] [date] NULL,
 CONSTRAINT [PK_NHANHVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLNGUOIDUNG]    Script Date: 10/27/2020 8:35:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLNGUOIDUNG](
	[TenDangNhap] [char](10) NOT NULL,
	[TenNguoiDung] [nvarchar](50) NOT NULL,
	[MatKhau] [char](10) NOT NULL,
	[HinhAnh] [nvarchar](50) NULL,
	[QuyenTruyCap] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QLNGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETNHAP] ([MaLoai], [MaHang], [SoHDN], [SoLuongNhap], [DonGiaN], [HSD], [NgaySX]) VALUES (N'l2        ', N'h03       ', N'n02       ', 10, 111, 12, CAST(N'1921-12-12' AS Date))
INSERT [dbo].[CHITIETNHAP] ([MaLoai], [MaHang], [SoHDN], [SoLuongNhap], [DonGiaN], [HSD], [NgaySX]) VALUES (N'l1        ', N'h01       ', N'n02       ', 20, 222, 13, CAST(N'2015-12-12' AS Date))
INSERT [dbo].[CHITIETNHAP] ([MaLoai], [MaHang], [SoHDN], [SoLuongNhap], [DonGiaN], [HSD], [NgaySX]) VALUES (N'l3        ', N'h06       ', N'n02       ', 50, 110, 10, CAST(N'2018-04-18' AS Date))
GO
INSERT [dbo].[CHITIETXUAT] ([MaLoai], [SoHDX], [MaHang], [SoLuong], [DonGia]) VALUES (N'l1        ', N'x01       ', N'h01       ', 10, 100)
GO
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonVi], [TenNhaSX], [GiaDeNghi], [MaLoai], [SoLuongSP]) VALUES (N'h01       ', N'quần jean xanh', N'cái', NULL, 100, N'l1        ', 10)
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonVi], [TenNhaSX], [GiaDeNghi], [MaLoai], [SoLuongSP]) VALUES (N'h02       ', N'áo thun hình rồng', N'cái', NULL, 200, N'l2        ', 0)
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonVi], [TenNhaSX], [GiaDeNghi], [MaLoai], [SoLuongSP]) VALUES (N'h03       ', N'áo khoác dạ hội', N'cái', N'Versace', 100, N'l3        ', 10)
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonVi], [TenNhaSX], [GiaDeNghi], [MaLoai], [SoLuongSP]) VALUES (N'h04       ', N'giày da lộn gucci', N'đôi', N'Gucci', 120, N'l4        ', 0)
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonVi], [TenNhaSX], [GiaDeNghi], [MaLoai], [SoLuongSP]) VALUES (N'h05       ', N'sneakers aventador', N'đôi', N'lamborghini', 200, N'l5        ', 0)
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonVi], [TenNhaSX], [GiaDeNghi], [MaLoai], [SoLuongSP]) VALUES (N'h06       ', N'áo khoác gió', N'cái', N'the north face', 200, N'l3        ', 0)
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonVi], [TenNhaSX], [GiaDeNghi], [MaLoai], [SoLuongSP]) VALUES (N'h07       ', N'sữa dutch lady', N'hộp', N'dutch man', 12, N'l6        ', 0)
GO
INSERT [dbo].[HOADONNHAP] ([SoHDN], [NgayNhap], [ThanhTienNhap], [MaNV], [MaNCC]) VALUES (N'n02       ', CAST(N'2018-03-21' AS Date), 11111, N'nv01      ', N'ncc02     ')
GO
INSERT [dbo].[HOADONXUAT] ([SoHDX], [NgayXuat], [ThanhTienXuat], [MaNV], [MaKH]) VALUES (N'x01       ', CAST(N'2018-03-20' AS Date), 100000, N'nv01      ', N'kh1       ')
INSERT [dbo].[HOADONXUAT] ([SoHDX], [NgayXuat], [ThanhTienXuat], [MaNV], [MaKH]) VALUES (N'x02       ', NULL, 2000, N'nv01      ', N'kh2       ')
INSERT [dbo].[HOADONXUAT] ([SoHDX], [NgayXuat], [ThanhTienXuat], [MaNV], [MaKH]) VALUES (N'x03       ', NULL, 190892, N'nv03      ', N'kh1       ')
INSERT [dbo].[HOADONXUAT] ([SoHDX], [NgayXuat], [ThanhTienXuat], [MaNV], [MaKH]) VALUES (N'x04       ', NULL, 21234, N'nv04      ', N'kh4       ')
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChiKH], [SdtKH]) VALUES (N'kh1       ', N'hic hic hic', NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChiKH], [SdtKH]) VALUES (N'kh2       ', N'alo alo alo', NULL, N'10101          ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChiKH], [SdtKH]) VALUES (N'kh3       ', N'123123', NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChiKH], [SdtKH]) VALUES (N'kh4       ', N'Fiora', N'top', NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChiKH], [SdtKH]) VALUES (N'kh5       ', N'riven', N'mid', N'22222          ')
GO
INSERT [dbo].[LOAIHANG] ([MaLoai], [DienGiai]) VALUES (N'l1        ', N'quần jean')
INSERT [dbo].[LOAIHANG] ([MaLoai], [DienGiai]) VALUES (N'l2        ', N'áo thun')
INSERT [dbo].[LOAIHANG] ([MaLoai], [DienGiai]) VALUES (N'l3        ', N'áo khoác')
INSERT [dbo].[LOAIHANG] ([MaLoai], [DienGiai]) VALUES (N'l4        ', N'giày da')
INSERT [dbo].[LOAIHANG] ([MaLoai], [DienGiai]) VALUES (N'l5        ', N'giày sneakers')
INSERT [dbo].[LOAIHANG] ([MaLoai], [DienGiai]) VALUES (N'l6        ', N'sữa')
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'ncc01     ', N'Cty TNHH Bình Minh', NULL, NULL)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'ncc02     ', N'Học Viện Kỹ Thuật Quân Sự', NULL, N'09090909       ')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'ncc03     ', N'Văn phòng chính phủ', N'zzzzz', NULL)
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [DiaChiNV], [ChucVu], [GioiTinh], [SdtNV], [NgaySinh]) VALUES (N'nv01      ', N'Vũ Viết Văn', NULL, NULL, N'nam       ', N'090909090      ', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [DiaChiNV], [ChucVu], [GioiTinh], [SdtNV], [NgaySinh]) VALUES (N'nv02      ', N'Hoa Vinh', NULL, NULL, N'nu        ', N'121212121      ', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [DiaChiNV], [ChucVu], [GioiTinh], [SdtNV], [NgaySinh]) VALUES (N'nv03      ', N'Phượng xồ', NULL, NULL, N'nam       ', N'2323232        ', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [DiaChiNV], [ChucVu], [GioiTinh], [SdtNV], [NgaySinh]) VALUES (N'nv04      ', N'Ngọa Hổ', NULL, NULL, N'nu        ', N'1111111        ', NULL)
GO
INSERT [dbo].[QLNGUOIDUNG] ([TenDangNhap], [TenNguoiDung], [MatKhau], [HinhAnh], [QuyenTruyCap]) VALUES (N'cax       ', N'cax', N'1         ', N'', N'nv')
INSERT [dbo].[QLNGUOIDUNG] ([TenDangNhap], [TenNguoiDung], [MatKhau], [HinhAnh], [QuyenTruyCap]) VALUES (N'mizhe     ', N'minh', N'1         ', N'', N'admin')
GO
ALTER TABLE [dbo].[CHITIETNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETNHAP_HANGHOA] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANGHOA] ([MaHang])
GO
ALTER TABLE [dbo].[CHITIETNHAP] CHECK CONSTRAINT [FK_CHITIETNHAP_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETNHAP_HOADONNHAP] FOREIGN KEY([SoHDN])
REFERENCES [dbo].[HOADONNHAP] ([SoHDN])
GO
ALTER TABLE [dbo].[CHITIETNHAP] CHECK CONSTRAINT [FK_CHITIETNHAP_HOADONNHAP]
GO
ALTER TABLE [dbo].[CHITIETNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETNHAP_LOAIHANG] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAIHANG] ([MaLoai])
GO
ALTER TABLE [dbo].[CHITIETNHAP] CHECK CONSTRAINT [FK_CHITIETNHAP_LOAIHANG]
GO
ALTER TABLE [dbo].[CHITIETXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETXUAT_HANGHOA] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANGHOA] ([MaHang])
GO
ALTER TABLE [dbo].[CHITIETXUAT] CHECK CONSTRAINT [FK_CHITIETXUAT_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETXUAT_HOADONXUAT] FOREIGN KEY([SoHDX])
REFERENCES [dbo].[HOADONXUAT] ([SoHDX])
GO
ALTER TABLE [dbo].[CHITIETXUAT] CHECK CONSTRAINT [FK_CHITIETXUAT_HOADONXUAT]
GO
ALTER TABLE [dbo].[CHITIETXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETXUAT_LOAIHANG] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAIHANG] ([MaLoai])
GO
ALTER TABLE [dbo].[CHITIETXUAT] CHECK CONSTRAINT [FK_CHITIETXUAT_LOAIHANG]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_LOAIHANG] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAIHANG] ([MaLoai])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_LOAIHANG]
GO
ALTER TABLE [dbo].[HOADONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_HOADONNHAP_NHACUNGCAP] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[HOADONNHAP] CHECK CONSTRAINT [FK_HOADONNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[HOADONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_HOADONNHAP_NHANHVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADONNHAP] CHECK CONSTRAINT [FK_HOADONNHAP_NHANHVIEN]
GO
ALTER TABLE [dbo].[HOADONXUAT]  WITH CHECK ADD  CONSTRAINT [FK_HOADONXUAT_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADONXUAT] CHECK CONSTRAINT [FK_HOADONXUAT_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADONXUAT]  WITH CHECK ADD  CONSTRAINT [FK_HOADONXUAT_NHANHVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADONXUAT] CHECK CONSTRAINT [FK_HOADONXUAT_NHANHVIEN]
GO
