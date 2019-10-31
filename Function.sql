USE EnglishCenter;
GO
--1.Tìm giáo viên của lớp học
IF OBJECT_ID('fnTimGiaoVien') IS NOT NULL
	DROP FUNCTION fnTimGiaoVien;
GO

CREATE FUNCTION fnTimGiaoVien
	(@TenLopHoc nvarchar(50))
	RETURNS nvarchar(50)
BEGIN
	RETURN(SELECT NhanVien.HoTen_NV
		FROM LopHoc JOIN NhanVien ON LopHoc.ID_GV=NhanVien.ID_NV
		WHERE LopHoc.Ten_LH LIKE @TenLopHoc);
END;
GO

USE EnglishCenter;
PRINT N'Tên giáo viên: '+ dbo.fnTimGiaoVien(N'Khoa TOEIC co ban');
GO

--2.Tìm lớp học có thời gian khai giảng bắt đầu từ ngày ... đến ngày...
USE EnglishCenter;
GO

IF OBJECT_ID('fnTimLopHocTrongKhoang') IS NOT NULL
	DROP FUNCTION fnTimLopHocTrongKhoang;
GO

CREATE FUNCTION fnTimLopHocTrongKhoang
	(@DateMin date = null,
	@DateMax date = null)
	RETURNS TABLE 
RETURN (SELECT LopHoc.Ten_LH, NhanVien.HoTen_NV , LopHoc.ThoiGianBatDau_LH
	FROM LopHoc JOIN NhanVien ON LopHoc.ID_GV=NhanVien.ID_NV
	WHERE LopHoc.ThoiGianBatDau_LH>=@DateMin AND LopHoc.ThoiGianBatDau_LH<=@DateMax);
GO

USE EnglishCenter;
SELECT * FROM dbo.fnTimLopHocTrongKhoang('2019-06-24','2019-07-10') ORDER BY ThoiGianBatDau_LH;
GO

--3.Tìm tất cả nhân viên đã phụ trách các phiếu thu của một học sinh
USE EnglishCenter;
GO

IF OBJECT_ID('fnTimNhanVien') IS NOT NULL
	DROP FUNCTION fnTimNhanVien;
GO

CREATE FUNCTION fnTimNhanVien
	(@TenHocVien nvarchar(50))
	RETURNS TABLE
RETURN
	(SELECT NhanVien.HoTen_NV, PhieuThu.NgayThanhToan
	FROM PhieuThu JOIN NhanVien ON PhieuThu.ID_NV=NhanVien.ID_NV
	WHERE PhieuThu.ID_HV=(
	SELECT HocVien.ID_HV
	FROM HocVien
	WHERE HocVien.HoTen_HV LIKE @TenHocVien));
GO

USE EnglishCenter
SELECT * FROM dbo.fnTimNhanVien('Bui Tram Anh') ORDER BY NgayThanhToan;
GO

--4. Tìm các lớp học có chương trình khuyến mãi
USE EnglishCenter;
GO 

IF OBJECT_ID('fnLopHoc_KM') IS NOT NULL
	DROP FUNCTION fnTimLopHoc_KM;
GO

CREATE FUNCTION fnTimLopHoc_KM()
	RETURNS TABLE 
AS
	RETURN(SELECT HocVien.HoTen_HV, LopHoc.Ten_LH,Ten_CTKM
		FROM HocVien JOIN LopHoc_HocVien ON LopHoc_HocVien.ID_HV=HocVien.ID_HV
		JOIN LopHoc ON LopHoc.ID_LH=LopHoc_HocVien.ID_LH
		JOIN ChuongTrinhKhuyenMai ON LopHoc.ID_KH=ChuongTrinhKhuyenMai.ID_KH);
GO

USE EnglishCenter;
SELECT * FROM dbo.fnTimLopHoc_KM() ORDER BY Ten_LH, Ten_CTKM;




