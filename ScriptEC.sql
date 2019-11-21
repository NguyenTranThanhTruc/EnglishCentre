USE [EnglishCenter]
GO
/****** Object:  Table [dbo].[ChuongTrinhKhuyenMai]    Script Date: 11/21/2019 10:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuongTrinhKhuyenMai](
	[ID_CTKM] [int] IDENTITY(1,1) NOT NULL,
	[Ten_CTKM] [nvarchar](50) NOT NULL,
	[ID_KH] [int] NOT NULL,
	[ThoiGianBatDau_CTKM] [date] NOT NULL,
	[ThoiGianKetThuc_CTKM] [date] NOT NULL,
	[MoTa_CTKM] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ChuongTrinhKhuyenMai] PRIMARY KEY CLUSTERED 
(
	[ID_CTKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocVien]    Script Date: 11/21/2019 10:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocVien](
	[ID_HV] [int] IDENTITY(1,1) NOT NULL,
	[Ma_HV] [nvarchar](100) NOT NULL,
	[HoTen_HV] [nvarchar](50) NOT NULL,
	[NgaySinh_HV] [date] NOT NULL,
	[DiaChi_HV] [nvarchar](100) NOT NULL,
	[Email_HV] [nvarchar](50) NOT NULL,
	[SDT_HV] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[ID_HV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 11/21/2019 10:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaHoc](
	[ID_KH] [int] IDENTITY(1,1) NOT NULL,
	[Ten_KH] [nvarchar](100) NOT NULL,
	[MoTa] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_KhoaHoc] PRIMARY KEY CLUSTERED 
(
	[ID_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Levels]    Script Date: 11/21/2019 10:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Levels](
	[ID_Level] [int] IDENTITY(1,1) NOT NULL,
	[MoTa] [nvarchar](50) NOT NULL,
	[Ten_Level] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Level] PRIMARY KEY CLUSTERED 
(
	[ID_Level] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 11/21/2019 10:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc](
	[ID_LH] [int] IDENTITY(1,1) NOT NULL,
	[Ma_LH] [nvarchar](100) NOT NULL,
	[Ten_LH] [nvarchar](50) NOT NULL,
	[ThoiGianBatDau_LH] [date] NOT NULL,
	[ThoiGianKetThuc_LH] [date] NOT NULL,
	[HocPhi] [numeric](18, 0) NOT NULL,
	[ID_GV] [int] NOT NULL,
	[ID_KH] [int] NOT NULL,
	[ID_Level] [int] NOT NULL,
	[SoBuoiHoc] [int] NOT NULL,
	[KhungGioHoc] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_LopHoc] PRIMARY KEY CLUSTERED 
(
	[ID_LH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/21/2019 10:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID_NV] [int] IDENTITY(1,1) NOT NULL,
	[Ma_GV] [nvarchar](100) NULL,
	[HoTen_NV] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[SDT_NV] [nvarchar](50) NOT NULL,
	[CMND] [nvarchar](50) NOT NULL,
	[Birthday] [datetime] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomTaiLieu]    Script Date: 11/21/2019 10:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomTaiLieu](
	[ID_NTL] [int] IDENTITY(1,1) NOT NULL,
	[Ma_NTL] [nvarchar](100) NOT NULL,
	[Ten_NTL] [nvarchar](50) NOT NULL,
	[ID_KH] [int] NOT NULL,
 CONSTRAINT [PK_NhomTaiLieu] PRIMARY KEY CLUSTERED 
(
	[ID_NTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 11/21/2019 10:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[ID_PhanQuyen] [int] IDENTITY(1,1) NOT NULL,
	[Ten_PhanQuyen] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[ID_PhanQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThu]    Script Date: 11/21/2019 10:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThu](
	[ID_PT] [int] IDENTITY(1,1) NOT NULL,
	[Ma_PT] [nvarchar](100) NOT NULL,
	[NgayThanhToan] [date] NOT NULL,
	[PhuongThucThanhToan] [nvarchar](50) NOT NULL,
	[ID_HV] [int] NOT NULL,
	[ID_LH] [int] NOT NULL,
	[SoTien] [money] NOT NULL,
	[ID_NV] [int] NOT NULL,
 CONSTRAINT [PK_PhieuThu] PRIMARY KEY CLUSTERED 
(
	[ID_PT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaikhoanGiaoVien]    Script Date: 11/21/2019 10:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaikhoanGiaoVien](
	[ID_GV_TK] [int] IDENTITY(1,1) NOT NULL,
	[ID_GV] [int] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TaikhoanGiaoVien] PRIMARY KEY CLUSTERED 
(
	[ID_GV_TK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoanHocVien]    Script Date: 11/21/2019 10:18:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanHocVien](
	[ID_TKHV] [int] IDENTITY(1,1) NOT NULL,
	[ID_HV] [int] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TaiKhoanHocVien] PRIMARY KEY CLUSTERED 
(
	[ID_TKHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KhoaHoc] ON 

INSERT [dbo].[KhoaHoc] ([ID_KH], [Ten_KH], [MoTa]) VALUES (8, N'Toeic', N'Dạy toeic cho người đi học và đi làm ...')
INSERT [dbo].[KhoaHoc] ([ID_KH], [Ten_KH], [MoTa]) VALUES (10, N'Giao Tiếp', N'Dạy Giao tiếp cho trẻ em và sinh viên')
SET IDENTITY_INSERT [dbo].[KhoaHoc] OFF
SET IDENTITY_INSERT [dbo].[Levels] ON 

INSERT [dbo].[Levels] ([ID_Level], [MoTa], [Ten_Level]) VALUES (6, N'Dành cho những học viên kém khả năng viết và...', N'Học Viết')
INSERT [dbo].[Levels] ([ID_Level], [MoTa], [Ten_Level]) VALUES (7, N'Dạy cho những học viên mất gốc và yếu', N'Cơ Bản')
INSERT [dbo].[Levels] ([ID_Level], [MoTa], [Ten_Level]) VALUES (8, N'Dạy cho những học viên muốn học kiến thức nâng cao', N'Nâng Cao.')
SET IDENTITY_INSERT [dbo].[Levels] OFF
SET IDENTITY_INSERT [dbo].[LopHoc] ON 

INSERT [dbo].[LopHoc] ([ID_LH], [Ma_LH], [Ten_LH], [ThoiGianBatDau_LH], [ThoiGianKetThuc_LH], [HocPhi], [ID_GV], [ID_KH], [ID_Level], [SoBuoiHoc], [KhungGioHoc]) VALUES (4, N'GTCB_01', N'Giao Tiếp Cơ Bản', CAST(N'2019-11-05' AS Date), CAST(N'2020-05-21' AS Date), CAST(6500000 AS Numeric(18, 0)), 1, 10, 7, 42, N'3-5-6 18h đến 19h30')
SET IDENTITY_INSERT [dbo].[LopHoc] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID_NV], [Ma_GV], [HoTen_NV], [ChucVu], [Email], [SDT_NV], [CMND], [Birthday]) VALUES (1, N'NV_01', N'Phạm Thanh Khuê', N'Giáo Viên', N'khuepham1134@gmail.com', N'01258437', N'302569845', CAST(N'1995-02-24T11:39:05.000' AS DateTime))
INSERT [dbo].[NhanVien] ([ID_NV], [Ma_GV], [HoTen_NV], [ChucVu], [Email], [SDT_NV], [CMND], [Birthday]) VALUES (2, N'NV_02', N'Nguyễn Minh Thư', N'Kế Toán ', N'thunguyen1258@gmail.com', N'02356985', N'35698466', CAST(N'1991-05-16T11:39:05.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
ALTER TABLE [dbo].[ChuongTrinhKhuyenMai]  WITH CHECK ADD  CONSTRAINT [fk_CTKM_KH] FOREIGN KEY([ID_KH])
REFERENCES [dbo].[KhoaHoc] ([ID_KH])
GO
ALTER TABLE [dbo].[ChuongTrinhKhuyenMai] CHECK CONSTRAINT [fk_CTKM_KH]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [fk_LH_KH] FOREIGN KEY([ID_KH])
REFERENCES [dbo].[KhoaHoc] ([ID_KH])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [fk_LH_KH]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [fk_LH_LV] FOREIGN KEY([ID_Level])
REFERENCES [dbo].[Levels] ([ID_Level])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [fk_LH_LV]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [fk_LH_NV] FOREIGN KEY([ID_GV])
REFERENCES [dbo].[NhanVien] ([ID_NV])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [fk_LH_NV]
GO
ALTER TABLE [dbo].[NhomTaiLieu]  WITH CHECK ADD  CONSTRAINT [fk_NTL_KH] FOREIGN KEY([ID_KH])
REFERENCES [dbo].[KhoaHoc] ([ID_KH])
GO
ALTER TABLE [dbo].[NhomTaiLieu] CHECK CONSTRAINT [fk_NTL_KH]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD  CONSTRAINT [fk_PT_HV] FOREIGN KEY([ID_HV])
REFERENCES [dbo].[HocVien] ([ID_HV])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [fk_PT_HV]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD  CONSTRAINT [fk_PT_LH] FOREIGN KEY([ID_LH])
REFERENCES [dbo].[LopHoc] ([ID_LH])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [fk_PT_LH]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD  CONSTRAINT [fk_PT_NV] FOREIGN KEY([ID_NV])
REFERENCES [dbo].[NhanVien] ([ID_NV])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [fk_PT_NV]
GO
ALTER TABLE [dbo].[TaikhoanGiaoVien]  WITH CHECK ADD  CONSTRAINT [fk_TKGV_GV] FOREIGN KEY([ID_GV])
REFERENCES [dbo].[NhanVien] ([ID_NV])
GO
ALTER TABLE [dbo].[TaikhoanGiaoVien] CHECK CONSTRAINT [fk_TKGV_GV]
GO
ALTER TABLE [dbo].[TaiKhoanHocVien]  WITH CHECK ADD  CONSTRAINT [fk_TK_HV] FOREIGN KEY([ID_HV])
REFERENCES [dbo].[HocVien] ([ID_HV])
GO
ALTER TABLE [dbo].[TaiKhoanHocVien] CHECK CONSTRAINT [fk_TK_HV]
GO
