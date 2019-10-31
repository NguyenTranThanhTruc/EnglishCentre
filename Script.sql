USE [EnglishCenter]
GO
/****** Object:  Table [dbo].[ChuongTrinhKhuyenMai]    Script Date: 11/1/2019 00:22:00 ******/
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
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 11/1/2019 00:22:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[ID_GV] [nvarchar](50) NOT NULL,
	[MoTa_GV] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[ID_GV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocVien]    Script Date: 11/1/2019 00:22:00 ******/
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
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 11/1/2019 00:22:00 ******/
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
/****** Object:  Table [dbo].[Levels]    Script Date: 11/1/2019 00:22:00 ******/
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
/****** Object:  Table [dbo].[LopHoc]    Script Date: 11/1/2019 00:22:00 ******/
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
/****** Object:  Table [dbo].[LopHoc_HocVien]    Script Date: 11/1/2019 00:22:00 ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/1/2019 00:22:00 ******/
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
/****** Object:  Table [dbo].[NhomTaiLieu]    Script Date: 11/1/2019 00:22:00 ******/
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
/****** Object:  Table [dbo].[PhieuThu]    Script Date: 11/1/2019 00:22:00 ******/
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
/****** Object:  Table [dbo].[TaikhoanGiaoVien]    Script Date: 11/1/2019 00:22:00 ******/
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
/****** Object:  Table [dbo].[TaiKhoanHocVien]    Script Date: 11/1/2019 00:22:00 ******/
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
/****** Object:  Table [dbo].[ThoiGianLopHoc]    Script Date: 11/1/2019 00:22:00 ******/
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
INSERT [dbo].[ChuongTrinhKhuyenMai] ([ID_CTKM], [Ten_CTKM], [ID_KH], [ThoiGianBatDau_CTKM], [ThoiGianKetThuc_CTKM], [MoTa_CTKM]) VALUES (N'1', N'Mua tuu truong', N'1', CAST(N'2019-06-15' AS Date), CAST(N'2019-08-15' AS Date), N'Giam 500 000')
INSERT [dbo].[ChuongTrinhKhuyenMai] ([ID_CTKM], [Ten_CTKM], [ID_KH], [ThoiGianBatDau_CTKM], [ThoiGianKetThuc_CTKM], [MoTa_CTKM]) VALUES (N'2', N'Ngay nha giao ', N'2', CAST(N'2019-10-01' AS Date), CAST(N'2019-11-30' AS Date), N'Giam gia 15%')
INSERT [dbo].[ChuongTrinhKhuyenMai] ([ID_CTKM], [Ten_CTKM], [ID_KH], [ThoiGianBatDau_CTKM], [ThoiGianKetThuc_CTKM], [MoTa_CTKM]) VALUES (N'3', N'Mua tuu truong ', N'3', CAST(N'2019-07-01' AS Date), CAST(N'2019-07-10' AS Date), N'Giam gia 10%')
INSERT [dbo].[GiaoVien] ([ID_GV], [MoTa_GV]) VALUES (N'1', N'Bang IELT 8.0')
INSERT [dbo].[GiaoVien] ([ID_GV], [MoTa_GV]) VALUES (N'4', N'Bang IELT 7.5')
INSERT [dbo].[HocVien] ([ID_HV], [HoTen_HV], [NgaySinh_HV], [DiaChi_HV], [Email_HV], [SDT_HV]) VALUES (N'1', N'Nguyen Tuan Hung', CAST(N'1999-04-14' AS Date), N'Tien Giang', N'hhh@gmail.com', N'14041999')
INSERT [dbo].[HocVien] ([ID_HV], [HoTen_HV], [NgaySinh_HV], [DiaChi_HV], [Email_HV], [SDT_HV]) VALUES (N'10', N'Dang Nguyen Tuan Khoi', CAST(N'1999-03-23' AS Date), N'Hai Phong', N'kkk@gmail.com', N'23031999')
INSERT [dbo].[HocVien] ([ID_HV], [HoTen_HV], [NgaySinh_HV], [DiaChi_HV], [Email_HV], [SDT_HV]) VALUES (N'2', N'Nguyen Thanh Nhan', CAST(N'1999-05-29' AS Date), N'Dong Nai', N'nnn@gmail.com', N'29051999')
INSERT [dbo].[HocVien] ([ID_HV], [HoTen_HV], [NgaySinh_HV], [DiaChi_HV], [Email_HV], [SDT_HV]) VALUES (N'3', N'Bui Tram Anh', CAST(N'2012-02-25' AS Date), N'TPHCM', N'', N'25022012')
INSERT [dbo].[HocVien] ([ID_HV], [HoTen_HV], [NgaySinh_HV], [DiaChi_HV], [Email_HV], [SDT_HV]) VALUES (N'4', N'Dang Nguyen Phuc Nhan', CAST(N'2016-03-25' AS Date), N'Hai Phong', N' ', N'25032016')
INSERT [dbo].[HocVien] ([ID_HV], [HoTen_HV], [NgaySinh_HV], [DiaChi_HV], [Email_HV], [SDT_HV]) VALUES (N'5', N'Nguyen Huu Duy', CAST(N'1996-10-02' AS Date), N'TPHCM', N'dđ@gmail.com', N'02101996')
INSERT [dbo].[HocVien] ([ID_HV], [HoTen_HV], [NgaySinh_HV], [DiaChi_HV], [Email_HV], [SDT_HV]) VALUES (N'6', N'La Loc Dinh Bao', CAST(N'1993-01-01' AS Date), N'HPHCM', N'bbb@gmail.com', N'01011993')
INSERT [dbo].[HocVien] ([ID_HV], [HoTen_HV], [NgaySinh_HV], [DiaChi_HV], [Email_HV], [SDT_HV]) VALUES (N'7', N'Dao Son Tung', CAST(N'1995-07-31' AS Date), N'Thai Binh', N'ttt@gmail.com', N'31071995')
INSERT [dbo].[HocVien] ([ID_HV], [HoTen_HV], [NgaySinh_HV], [DiaChi_HV], [Email_HV], [SDT_HV]) VALUES (N'8', N'Phan Xuan Tuan Anh', CAST(N'1999-03-30' AS Date), N'Thanh Hoa', N'aaa@gmail.com', N'30031999')
INSERT [dbo].[HocVien] ([ID_HV], [HoTen_HV], [NgaySinh_HV], [DiaChi_HV], [Email_HV], [SDT_HV]) VALUES (N'9', N'Nguyen Trong Luat', CAST(N'1999-11-01' AS Date), N'Thanh Hoa', N'lll@gmail.com', N'01111999')
INSERT [dbo].[KhoaHoc] ([ID_KH], [SoBuoiHoc], [MoTa], [ID_Level]) VALUES (N'1', 42, N'Khoa hoc toeic', N'1')
INSERT [dbo].[KhoaHoc] ([ID_KH], [SoBuoiHoc], [MoTa], [ID_Level]) VALUES (N'2', 42, N'Khoa hoc toeic', N'2')
INSERT [dbo].[KhoaHoc] ([ID_KH], [SoBuoiHoc], [MoTa], [ID_Level]) VALUES (N'3', 42, N'Khoa hoc giao tiep', N'1')
INSERT [dbo].[KhoaHoc] ([ID_KH], [SoBuoiHoc], [MoTa], [ID_Level]) VALUES (N'4', 42, N'Khoa hoc giao tiep', N'2')
INSERT [dbo].[Levels] ([ID_Level], [MoTa]) VALUES (N'1', N'Co ban')
INSERT [dbo].[Levels] ([ID_Level], [MoTa]) VALUES (N'2', N'Nang cao')
INSERT [dbo].[LopHoc] ([ID_LH], [Ten_LH], [ThoiGianBatDau_LH], [ThoiGianKetThuc_LH], [HocPhi], [ID_GV], [ID_KH]) VALUES (N'GT1V07', N'Khoa giao tiep co ban', CAST(N'2019-06-24' AS Date), CAST(N'2019-11-01' AS Date), 4980000.0000, N'1', N'3')
INSERT [dbo].[LopHoc] ([ID_LH], [Ten_LH], [ThoiGianBatDau_LH], [ThoiGianKetThuc_LH], [HocPhi], [ID_GV], [ID_KH]) VALUES (N'GT1V08', N'Khoa giao tiep nang cao', CAST(N'2019-07-10' AS Date), CAST(N'2019-11-17' AS Date), 4980000.0000, N'4', N'4')
INSERT [dbo].[LopHoc] ([ID_LH], [Ten_LH], [ThoiGianBatDau_LH], [ThoiGianKetThuc_LH], [HocPhi], [ID_GV], [ID_KH]) VALUES (N'TCB1', N'Khoa TOEIC cap toc', CAST(N'2019-07-10' AS Date), CAST(N'2019-09-25' AS Date), 3980000.0000, N'1', N'1')
INSERT [dbo].[LopHoc] ([ID_LH], [Ten_LH], [ThoiGianBatDau_LH], [ThoiGianKetThuc_LH], [HocPhi], [ID_GV], [ID_KH]) VALUES (N'TCB2', N'Khoa TOEIC co ban', CAST(N'2019-07-25' AS Date), CAST(N'2019-10-25' AS Date), 3980000.0000, N'4', N'1')
INSERT [dbo].[LopHoc] ([ID_LH], [Ten_LH], [ThoiGianBatDau_LH], [ThoiGianKetThuc_LH], [HocPhi], [ID_GV], [ID_KH]) VALUES (N'TNC04', N'Khoa TOEIC nang cao', CAST(N'2019-07-03' AS Date), CAST(N'2019-03-08' AS Date), 1200000.0000, N'4', N'2')
INSERT [dbo].[LopHoc_HocVien] ([ID_LH_HV], [ID_LH], [ID_HV]) VALUES (N'1', N'TCB2', N'1')
INSERT [dbo].[LopHoc_HocVien] ([ID_LH_HV], [ID_LH], [ID_HV]) VALUES (N'10', N'GT1V07', N'8')
INSERT [dbo].[LopHoc_HocVien] ([ID_LH_HV], [ID_LH], [ID_HV]) VALUES (N'2', N'GT1V08', N'10')
INSERT [dbo].[LopHoc_HocVien] ([ID_LH_HV], [ID_LH], [ID_HV]) VALUES (N'3', N'TCB2', N'2')
INSERT [dbo].[LopHoc_HocVien] ([ID_LH_HV], [ID_LH], [ID_HV]) VALUES (N'4', N'TCB1', N'7')
INSERT [dbo].[LopHoc_HocVien] ([ID_LH_HV], [ID_LH], [ID_HV]) VALUES (N'5', N'TCB1', N'9')
INSERT [dbo].[LopHoc_HocVien] ([ID_LH_HV], [ID_LH], [ID_HV]) VALUES (N'6', N'TNC04', N'5')
INSERT [dbo].[LopHoc_HocVien] ([ID_LH_HV], [ID_LH], [ID_HV]) VALUES (N'7', N'GT1V07', N'3')
INSERT [dbo].[LopHoc_HocVien] ([ID_LH_HV], [ID_LH], [ID_HV]) VALUES (N'8', N'TNC04', N'6')
INSERT [dbo].[LopHoc_HocVien] ([ID_LH_HV], [ID_LH], [ID_HV]) VALUES (N'9', N'GT1V08', N'4')
INSERT [dbo].[NhanVien] ([ID_NV], [HoTen_NV], [ChucVu], [Email], [SDT_NV]) VALUES (N'1', N'Phan Thi Ngoc Tuyen', N'Giao vien', N'aaa@gmailcom', N'123456')
INSERT [dbo].[NhanVien] ([ID_NV], [HoTen_NV], [ChucVu], [Email], [SDT_NV]) VALUES (N'2', N'Nguyen Ngoc Tu Duyen', N'Lao cong', N'bbb@gmail.com', N'456789')
INSERT [dbo].[NhanVien] ([ID_NV], [HoTen_NV], [ChucVu], [Email], [SDT_NV]) VALUES (N'3', N'Vo Thi Van Anh', N'Ke toan', N'ccc@gmail.com', N'789123')
INSERT [dbo].[NhanVien] ([ID_NV], [HoTen_NV], [ChucVu], [Email], [SDT_NV]) VALUES (N'4', N'Le Thi Kim Ngan', N'Giao vien', N'dd@gmail.com', N'147852')
INSERT [dbo].[NhanVien] ([ID_NV], [HoTen_NV], [ChucVu], [Email], [SDT_NV]) VALUES (N'5', N'Pham Tran Hue Phi', N'Ke toan', N'ee@gmail.com', N'258963')
INSERT [dbo].[NhanVien] ([ID_NV], [HoTen_NV], [ChucVu], [Email], [SDT_NV]) VALUES (N'6', N'Nguyen Ngan Linh', N'Lao cong', N'fff@gmail.com', N'369741')
INSERT [dbo].[NhomTaiLieu] ([ID_NTL], [Ten_NTL], [ID_KH]) VALUES (N'1', N'Tai lieu TOEIC co ban', N'1')
INSERT [dbo].[NhomTaiLieu] ([ID_NTL], [Ten_NTL], [ID_KH]) VALUES (N'2', N'Tai lieu TOEIC nang cao', N'2')
INSERT [dbo].[NhomTaiLieu] ([ID_NTL], [Ten_NTL], [ID_KH]) VALUES (N'3', N'Tai lieu giao tiep co ban', N'3')
INSERT [dbo].[NhomTaiLieu] ([ID_NTL], [Ten_NTL], [ID_KH]) VALUES (N'4', N'Tai lieu giao tiep nang cao', N'4')
INSERT [dbo].[PhieuThu] ([ID_PT], [NgayThanhToan], [PhuongThucThanhToan], [ID_HV], [ID_LH], [SoTien], [ID_NV]) VALUES (N'1', CAST(N'2019-06-20' AS Date), N'Tien mat', N'1', N'TCB2', 3980000.0000, N'3')
INSERT [dbo].[PhieuThu] ([ID_PT], [NgayThanhToan], [PhuongThucThanhToan], [ID_HV], [ID_LH], [SoTien], [ID_NV]) VALUES (N'10', CAST(N'2019-07-07' AS Date), N'Tien mat', N'10', N'GT1V08', 4980000.0000, N'5')
INSERT [dbo].[PhieuThu] ([ID_PT], [NgayThanhToan], [PhuongThucThanhToan], [ID_HV], [ID_LH], [SoTien], [ID_NV]) VALUES (N'11', CAST(N'2019-07-10' AS Date), N'Tien mat', N'3', N'GT1V07', 4980000.0000, N'3')
INSERT [dbo].[PhieuThu] ([ID_PT], [NgayThanhToan], [PhuongThucThanhToan], [ID_HV], [ID_LH], [SoTien], [ID_NV]) VALUES (N'2', CAST(N'2019-07-24' AS Date), N'Tien mat', N'2', N'TCB2', 3980000.0000, N'5')
INSERT [dbo].[PhieuThu] ([ID_PT], [NgayThanhToan], [PhuongThucThanhToan], [ID_HV], [ID_LH], [SoTien], [ID_NV]) VALUES (N'3', CAST(N'2019-07-08' AS Date), N'Tien mat', N'7', N'TCB1', 3980000.0000, N'5')
INSERT [dbo].[PhieuThu] ([ID_PT], [NgayThanhToan], [PhuongThucThanhToan], [ID_HV], [ID_LH], [SoTien], [ID_NV]) VALUES (N'4', CAST(N'2019-07-01' AS Date), N'Tien mat', N'9', N'TCB1', 3980000.0000, N'5')
INSERT [dbo].[PhieuThu] ([ID_PT], [NgayThanhToan], [PhuongThucThanhToan], [ID_HV], [ID_LH], [SoTien], [ID_NV]) VALUES (N'5', CAST(N'2019-07-01' AS Date), N'Tien mat', N'5', N'TNC04', 1200000.0000, N'3')
INSERT [dbo].[PhieuThu] ([ID_PT], [NgayThanhToan], [PhuongThucThanhToan], [ID_HV], [ID_LH], [SoTien], [ID_NV]) VALUES (N'6', CAST(N'2019-07-03' AS Date), N'Tien mat', N'6', N'TNC04', 1200000.0000, N'3')
INSERT [dbo].[PhieuThu] ([ID_PT], [NgayThanhToan], [PhuongThucThanhToan], [ID_HV], [ID_LH], [SoTien], [ID_NV]) VALUES (N'7', CAST(N'2019-06-20' AS Date), N'Tien mat', N'3', N'GT1V07', 4980000.0000, N'5')
INSERT [dbo].[PhieuThu] ([ID_PT], [NgayThanhToan], [PhuongThucThanhToan], [ID_HV], [ID_LH], [SoTien], [ID_NV]) VALUES (N'8', CAST(N'2019-07-09' AS Date), N'Tien mat', N'4', N'GT1V08', 4980000.0000, N'5')
INSERT [dbo].[PhieuThu] ([ID_PT], [NgayThanhToan], [PhuongThucThanhToan], [ID_HV], [ID_LH], [SoTien], [ID_NV]) VALUES (N'9', CAST(N'2019-06-22' AS Date), N'Tien mat', N'8', N'GT1V07', 4980000.0000, N'3')
INSERT [dbo].[TaikhoanGiaoVien] ([ID_GV_TK], [ID_GV], [Username], [PassWord]) VALUES (N'1', N'1', N'Tuyen', N'123456')
INSERT [dbo].[TaikhoanGiaoVien] ([ID_GV_TK], [ID_GV], [Username], [PassWord]) VALUES (N'2', N'4', N'Ngan', N'000000')
INSERT [dbo].[TaiKhoanHocVien] ([ID_TKHV], [ID_HV], [Username], [PassWord]) VALUES (N'1', N'1', N'Hung', N'140499')
INSERT [dbo].[TaiKhoanHocVien] ([ID_TKHV], [ID_HV], [Username], [PassWord]) VALUES (N'2', N'2', N'Nhannghiep', N'290599')
INSERT [dbo].[TaiKhoanHocVien] ([ID_TKHV], [ID_HV], [Username], [PassWord]) VALUES (N'3', N'5', N'Duy', N'081099')
INSERT [dbo].[TaiKhoanHocVien] ([ID_TKHV], [ID_HV], [Username], [PassWord]) VALUES (N'4', N'6', N'Bao', N'081099')
INSERT [dbo].[ThoiGianLopHoc] ([ID_LH], [NgayHoc_LH], [ThoiGianCuaBuoiHoc]) VALUES (N'GT1V07', N'Thu 2, 4, 6', N'19h40 - 21h10')
INSERT [dbo].[ThoiGianLopHoc] ([ID_LH], [NgayHoc_LH], [ThoiGianCuaBuoiHoc]) VALUES (N'GT1V08', N'Thu 3, 5, 7', N'17h45 - 19h15')
INSERT [dbo].[ThoiGianLopHoc] ([ID_LH], [NgayHoc_LH], [ThoiGianCuaBuoiHoc]) VALUES (N'TCB1', N'Thu 2, 3, 4, 5, 6', N'08h30 - 10h30')
INSERT [dbo].[ThoiGianLopHoc] ([ID_LH], [NgayHoc_LH], [ThoiGianCuaBuoiHoc]) VALUES (N'TCB2', N'Thu 3, 5, 7', N'19h40 - 21h10')
INSERT [dbo].[ThoiGianLopHoc] ([ID_LH], [NgayHoc_LH], [ThoiGianCuaBuoiHoc]) VALUES (N'TNC04', N'Thu 2, 4, 6', N'17h45 - 19h15')
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
ALTER TABLE [dbo].[TaikhoanGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_TaikhoanGiaoVien_GiaoVien] FOREIGN KEY([ID_GV])
REFERENCES [dbo].[GiaoVien] ([ID_GV])
GO
ALTER TABLE [dbo].[TaikhoanGiaoVien] CHECK CONSTRAINT [FK_TaikhoanGiaoVien_GiaoVien]
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
