USE [EnglishCenter]
GO
/****** Object:  Table [dbo].[ChuongTrinhKhuyenMai]    Script Date: 10/29/2019 12:35:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuongTrinhKhuyenMai](
	[ID_CTKM] [nvarchar](50) NOT NULL,
	[Ten_CTKM] [nvarchar](50) NOT NULL,
	[ID_KH] [nvarchar](50) NOT NULL,
	[ThoiGianBatDau_CTKM] [date] NOT NULL,
	[ThoiGianKetThuc_CTKM] [date] NOT NULL,
	[MoTa_CTKM] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ChuongTrinhKhuyenMai] PRIMARY KEY CLUSTERED 
(
	[ID_CTKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 10/29/2019 12:35:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[ID_GV] [nvarchar](50) NOT NULL,
	[HoTen_GV] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[SDT_GV] [nvarchar](50) NOT NULL,
	[MoTa_GV] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[ID_GV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocVien]    Script Date: 10/29/2019 12:35:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocVien](
	[ID_HV] [nvarchar](50) NOT NULL,
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
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 10/29/2019 12:35:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaHoc](
	[ID_KH] [nvarchar](50) NOT NULL,
	[SoBuoiHoc] [int] NOT NULL,
	[MoTa] [nvarchar](100) NOT NULL,
	[ID_Level] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KhoaHoc] PRIMARY KEY CLUSTERED 
(
	[ID_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Levels]    Script Date: 10/29/2019 12:35:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Levels](
	[ID_Level] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Level] PRIMARY KEY CLUSTERED 
(
	[ID_Level] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 10/29/2019 12:35:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc](
	[ID_LH] [nvarchar](50) NOT NULL,
	[Ten_LH] [nvarchar](50) NOT NULL,
	[ThoiGianBatDau_LH] [date] NOT NULL,
	[ThoiGianKetThuc_LH] [date] NOT NULL,
	[HocPhi] [money] NOT NULL,
	[ID_GV] [nvarchar](50) NOT NULL,
	[ID_KH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LopHoc] PRIMARY KEY CLUSTERED 
(
	[ID_LH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHoc_HocVien]    Script Date: 10/29/2019 12:35:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc_HocVien](
	[ID_LH_HV] [nvarchar](50) NOT NULL,
	[ID_LH] [nvarchar](50) NOT NULL,
	[ID_HV] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LopHoc_HocVien] PRIMARY KEY CLUSTERED 
(
	[ID_LH_HV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/29/2019 12:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID_NV] [nvarchar](50) NOT NULL,
	[HoTen_NV] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[SDT_NV] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomTaiLieu]    Script Date: 10/29/2019 12:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomTaiLieu](
	[ID_NTL] [nvarchar](50) NOT NULL,
	[Ten_NTL] [nvarchar](50) NOT NULL,
	[ID_KH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhomTaiLieu] PRIMARY KEY CLUSTERED 
(
	[ID_NTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThu]    Script Date: 10/29/2019 12:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThu](
	[ID_PT] [nvarchar](50) NOT NULL,
	[NgayThanhToan] [date] NOT NULL,
	[PhuongThucThanhToan] [nvarchar](50) NOT NULL,
	[ID_HV] [nvarchar](50) NOT NULL,
	[ID_LH] [nvarchar](50) NOT NULL,
	[SoTien] [money] NOT NULL,
	[ID_NV] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhieuThu] PRIMARY KEY CLUSTERED 
(
	[ID_PT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaikhoanGiaoVien]    Script Date: 10/29/2019 12:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaikhoanGiaoVien](
	[ID_GV_TK] [nvarchar](50) NOT NULL,
	[ID_GV] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TaikhoanGiaoVien] PRIMARY KEY CLUSTERED 
(
	[ID_GV_TK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoanHocVien]    Script Date: 10/29/2019 12:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanHocVien](
	[ID_TKHV] [nvarchar](50) NOT NULL,
	[ID_HV] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TaiKhoanHocVien] PRIMARY KEY CLUSTERED 
(
	[ID_TKHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThoiGianLopHoc]    Script Date: 10/29/2019 12:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThoiGianLopHoc](
	[ID_LH] [nvarchar](50) NOT NULL,
	[NgayHoc_LH] [nvarchar](50) NOT NULL,
	[ThoiGianCuaBuoiHoc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ThoiGianLopHoc] PRIMARY KEY CLUSTERED 
(
	[ID_LH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChuongTrinhKhuyenMai]  WITH NOCHECK ADD  CONSTRAINT [fk_CTKM_KH] FOREIGN KEY([ID_KH])
REFERENCES [dbo].[KhoaHoc] ([ID_KH])
GO
ALTER TABLE [dbo].[ChuongTrinhKhuyenMai] CHECK CONSTRAINT [fk_CTKM_KH]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH NOCHECK ADD  CONSTRAINT [fk_GV_NV] FOREIGN KEY([ID_GV])
REFERENCES [dbo].[NhanVien] ([ID_NV])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [fk_GV_NV]
GO
ALTER TABLE [dbo].[KhoaHoc]  WITH NOCHECK ADD  CONSTRAINT [fk_KH_Level] FOREIGN KEY([ID_Level])
REFERENCES [dbo].[Levels] ([ID_Level])
GO
ALTER TABLE [dbo].[KhoaHoc] CHECK CONSTRAINT [fk_KH_Level]
GO
ALTER TABLE [dbo].[LopHoc]  WITH NOCHECK ADD  CONSTRAINT [fk_LH_GV] FOREIGN KEY([ID_GV])
REFERENCES [dbo].[GiaoVien] ([ID_GV])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [fk_LH_GV]
GO
ALTER TABLE [dbo].[LopHoc]  WITH NOCHECK ADD  CONSTRAINT [fk_LH_KH] FOREIGN KEY([ID_KH])
REFERENCES [dbo].[KhoaHoc] ([ID_KH])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [fk_LH_KH]
GO
ALTER TABLE [dbo].[LopHoc_HocVien]  WITH NOCHECK ADD  CONSTRAINT [fk_LHHV_HV] FOREIGN KEY([ID_HV])
REFERENCES [dbo].[HocVien] ([ID_HV])
GO
ALTER TABLE [dbo].[LopHoc_HocVien] CHECK CONSTRAINT [fk_LHHV_HV]
GO
ALTER TABLE [dbo].[LopHoc_HocVien]  WITH NOCHECK ADD  CONSTRAINT [fk_LHHV_LH] FOREIGN KEY([ID_LH])
REFERENCES [dbo].[LopHoc] ([ID_LH])
GO
ALTER TABLE [dbo].[LopHoc_HocVien] CHECK CONSTRAINT [fk_LHHV_LH]
GO
ALTER TABLE [dbo].[NhomTaiLieu]  WITH NOCHECK ADD  CONSTRAINT [fk_NTL_KH] FOREIGN KEY([ID_KH])
REFERENCES [dbo].[KhoaHoc] ([ID_KH])
GO
ALTER TABLE [dbo].[NhomTaiLieu] CHECK CONSTRAINT [fk_NTL_KH]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH NOCHECK ADD  CONSTRAINT [fk_PT_HV] FOREIGN KEY([ID_HV])
REFERENCES [dbo].[HocVien] ([ID_HV])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [fk_PT_HV]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH NOCHECK ADD  CONSTRAINT [fk_PT_LH] FOREIGN KEY([ID_LH])
REFERENCES [dbo].[LopHoc] ([ID_LH])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [fk_PT_LH]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH NOCHECK ADD  CONSTRAINT [fk_PT_NV] FOREIGN KEY([ID_NV])
REFERENCES [dbo].[NhanVien] ([ID_NV])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [fk_PT_NV]
GO
ALTER TABLE [dbo].[TaikhoanGiaoVien]  WITH NOCHECK ADD  CONSTRAINT [fk_TK_GV] FOREIGN KEY([ID_GV])
REFERENCES [dbo].[GiaoVien] ([ID_GV])
GO
ALTER TABLE [dbo].[TaikhoanGiaoVien] CHECK CONSTRAINT [fk_TK_GV]
GO
ALTER TABLE [dbo].[TaiKhoanHocVien]  WITH NOCHECK ADD  CONSTRAINT [fk_TK_HV] FOREIGN KEY([ID_HV])
REFERENCES [dbo].[HocVien] ([ID_HV])
GO
ALTER TABLE [dbo].[TaiKhoanHocVien] CHECK CONSTRAINT [fk_TK_HV]
GO
ALTER TABLE [dbo].[ThoiGianLopHoc]  WITH NOCHECK ADD  CONSTRAINT [fk_TG_LH] FOREIGN KEY([ID_LH])
REFERENCES [dbo].[LopHoc] ([ID_LH])
GO
ALTER TABLE [dbo].[ThoiGianLopHoc] CHECK CONSTRAINT [fk_TG_LH]
GO
