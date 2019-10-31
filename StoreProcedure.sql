--Tim chuong trinh khuyen mai cho khoa hoc do
use EnglishCenter;
if OBJECT_ID('spTimCTKM') is not null
	drop proc spTimCTKM;
go

create proc spTimCTKM
@MotaKH nvarchar(50) = null
as 
begin
	select c.Ten_CTKM, c.ThoiGianBatDau_CTKM,c.ThoiGianKetThuc_CTKM, c.MoTa_CTKM
	from ChuongTrinhKhuyenMai c join KhoaHoc 
	on c.ID_KH= KhoaHoc.ID_KH
	where KhoaHoc.MoTa = @MotaKH;
end;
--test proc
declare @MotaKH nvarchar(50);
exec spTimCTKM @MotaKH='Khoa hoc toeic';



--Sap xep thoi gian mo lop theo thu tu giam dan
if OBJECT_ID('spLopHocGanDayNhat') is not null
drop proc spLopHocGanDayNhat;
go
create proc spLopHocGanDayNhat
as
begin
	select * from LopHoc 
	order by ThoiGianBatDau_LH desc
end;
--test proc
execute spLopHocGanDayNhat;



--Tinh so luong hv co trong lop do
if OBJECT_ID('spSoLuongHocVien') is not null
	drop proc spSoLuongHocVien;
go

create proc spSoLuongHocVien
@ID_LH nvarchar(50) = null
as
begin
	select COUNT(ID_HV) from LopHoc_HocVien
	where ID_LH= @ID_LH
end;
--test proc
declare @ID_LH nvarchar(50);
execute spSoLuongHocVien @ID_LH = 'TCB2';


--Tim thoi gian hoc cua lop do
if OBJECT_ID('spTimThoiGianHoc') is not null
	drop proc spTimThoiGianHoc;
go

create proc spTimThoiGianHoc
@ID_LH nvarchar(50)
as 
begin
	select * from ThoiGianLopHoc
	where ID_LH = @ID_LH
end;
--test proc
declare @ID_LH nvarchar(50);
execute spTimThoiGianHoc @ID_LH = 'GT1V08';
