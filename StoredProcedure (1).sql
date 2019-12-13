use EnglishCenter;
go
--2.Thêm level
use EnglishCenter;

IF OBJECT_ID('sp_ThemLevel') IS NOT NULL
DROP proc  sp_ThemLevel;
go

create proc sp_ThemLevel
	@malv nvarchar(100),
	@tenlv nvarchar(50),
	@mota nvarchar(50)
as
begin
	if(exists (select * from Levels
				where (Ma_Level= @malv) or (Ten_Level like @tenlv)and TrangThai like '1'))
				return -1;
	else
		begin tran ;							
			begin try 
				set identity_insert Levels off;
				insert into Levels(Ma_Level,Ten_Level,MoTa,TrangThai)
				values (@malv,@tenlv,@mota, 1);	
				commit tran;
			end try
			begin catch
				rollback tran
			end catch

end
go


--4.Sửa thông tin level
IF OBJECT_ID('sp_SuaLevel') IS NOT NULL
DROP proc  sp_SuaLevel
go
create proc sp_SuaLevel 
	@idlv int ,
	@malv nvarchar(100),
	@mota nvarchar(50),
	@tenlv nvarchar(50)
as
begin
		begin tran ;
			begin try 
				set identity_insert Levels off;
				update Levels set Ma_Level=@malv,Ten_Level=@tenlv,MoTa=@mota
				where LevelsId=@idlv 
				commit tran;
			end try
			begin catch
				rollback tran				
			end catch
end
go
--6.List level
IF OBJECT_ID('fn_LoadLevel') IS NOT NULL
DROP function  fn_LoadLevel
go
create function fn_LoadLevel 
()
returns table
as
return(	select * from Levels
	where Levels.TrangThai like '1')
go
--7.Xóa Level
IF OBJECT_ID('sp_XoaLevel') IS NOT NULL
DROP proc  sp_XoaLevel
go
create proc sp_XoaLevel 
	@idlv int 
as
	update Levels 
	set TrangThai = '0'
	where Levels.LevelsId=@idlv;
go

--8.Thêm Nhân Viên
IF OBJECT_ID('sp_ThemNhanVien') IS NOT NULL
DROP proc  sp_ThemNhanVien
go
create proc sp_ThemNhanVien 
	@manv nvarchar(100),
	@hoten nvarchar(50),
	@chucvu nvarchar(50),
	@email nvarchar(50),
	@sdt nvarchar(50),
	@cmnd nvarchar(50),
	@ngaysinh datetime

as
begin 
	if(exists (select * from NhanVien
				where CMND=@cmnd and Ma_NV=@manv and TrangThai like '1'))
				return -1;
	else
		begin tran ;
			begin try 
				set identity_insert NhanVien off;
				insert into NhanVien(Ma_NV,HoTen_NV,ChucVu,Email,SDT_NV,CMND,Birthday,TrangThai)
				values (@manv,@hoten,@chucvu,@email,@sdt,@cmnd,@ngaysinh, 1);	
				commit tran;
			end try
			begin catch
				rollback tran
			end catch
end
go

select * from NhanVien_audits
--9.Sửa Nhân Viên
IF OBJECT_ID('sp_SuaNhanVien') IS NOT NULL
DROP proc  sp_SuaNhanVien
go
create proc sp_SuaNhanVien 
	@id_nv int ,
	@manv nvarchar(100),
	@hoten nvarchar(50),
	@chucvu nvarchar(50),
	@email nvarchar(50),
	@sdt nvarchar(50),
	@cmnd nvarchar(50),
	@ngaysinh datetime
as
	begin 

		begin tran ;
			begin try 
				set identity_insert NhanVien off;
				update NhanVien set Ma_NV=@manv, HoTen_NV=@hoten,ChucVu=@chucvu,Email=@email,SDT_NV=@sdt,CMND=@cmnd,Birthday=@ngaysinh
				where NhanVienId=@id_nv;
				commit tran;
			end try
			begin catch
				rollback tran
			end catch
end
go

--10.Xóa Nhân Viên
IF OBJECT_ID('sp_XoaNhanVien') IS NOT NULL
DROP proc  sp_XoaNhanVien
go
create proc sp_XoaNhanVien 
	@id_nv int 	
as
		update NhanVien
		set TrangThai = '0'
		where NhanVienId=@id_nv;
go


--11.List Nhân Viên
use EnglishCenter;
go
IF OBJECT_ID('fn_ListNhanVien') IS NOT NULL
DROP function  fn_ListNhanVien
go
create function fn_ListNhanVien 
()
returns table
as
	return (select * from NhanVien
	where TrangThai like '1');
go

--10.Tìm nhân viên theo tên
use EnglishCenter;
go
if OBJECT_ID('sp_TimNhanVienTheoTen') is not null
DROP proc  sp_TimNhanVienTheoTen
go
create proc sp_TimNhanVienTheoTen 
	@ten nvarchar(50),
	@chucvu nvarchar(50) =null
as
	begin 
		if(@chucvu is null)
			select * from NhanVien
			where UPPER(NhanVien.HoTen_NV) like '%'+@ten+'%';
		else
			select * from NhanVien
			where UPPER(NhanVien.HoTen_NV) like '%'+@ten+'%'
			and NhanVien.ChucVu like @chucvu
	end
go

exec dbo.sp_TimNhanVienTheoTen N'', N'Giáo Viên'; 
--12. Thêm Khóa Học
use EnglishCenter;

IF OBJECT_ID('sp_ThemKhoaHoc') IS NOT NULL
DROP proc  sp_ThemKhoaHoc;
go

create proc sp_ThemKhoaHoc
	@makh nvarchar(100),
	@tenkh nvarchar(100),
	@mota nvarchar(100)
as
	begin 
	if(exists (select * from KhoaHoc
				where (Ma_KH=@makh or Ten_KH like @tenkh) and TrangThai like '1'))
				return -1;
	else
		begin tran ;
			begin try 
				set identity_insert KhoaHoc off;
				insert into KhoaHoc(Ma_KH,Ten_KH,MoTa, TrangThai)
				values (@makh,@tenkh,@mota, 1);	
				commit tran;
			end try
			begin catch
				rollback tran
			end catch
end
go

--17.Sửa thông tin khóa học
IF OBJECT_ID('sp_SuaKhoaHoc') IS NOT NULL
DROP proc  sp_SuaKhoaHoc
go
create proc sp_SuaKhoaHoc 
	@id_KH int,
	@makh nvarchar(100),
	@tenkh nvarchar(100),
	@mota nvarchar(100)
as
begin
			begin tran ;
			begin try 
				set identity_insert KhoaHoc off;
				update KhoaHoc set Ma_KH=@makh,Ten_KH=@tenkh,MoTa=@mota
				where KhoaHocId=@id_KH 
				commit tran;
			end try
			begin catch
				rollback tran				
			end catch
end
go


--18.Xóa Khóa Học
use EnglishCenter;
IF OBJECT_ID('sp_XoaKhoaHoc') IS NOT NULL
DROP proc  sp_XoaKhoaHoc
go
create proc sp_XoaKhoaHoc 
	@id_kh int 
as
	update KhoaHoc
	set TrangThai = '0'
	where KhoaHocId=@id_kh
go
--13.List Khoa Học
IF OBJECT_ID('fn_ListKhoaHoc') IS NOT NULL
DROP function  fn_ListKhoaHoc
go
create function fn_ListKhoaHoc 
()
returns table
as
	return(select * from KhoaHoc
	where TrangThai like '1');
go
--20.Thêm Lớp Học
use EnglishCenter;

IF OBJECT_ID('sp_ThemLopHoc') IS NOT NULL
DROP proc  sp_ThemLopHoc;
go

create proc sp_ThemLopHoc
	@malh nvarchar(100),
	@tenlh nvarchar(100),
	@thoigianbatdau smalldatetime,
	@thoigianketthuc smalldatetime,
	@hocphi numeric(18,0),
	@idnv int ,
	@idkh int,
	@idlv int,
	@sobuoihoc int,
	@khunggiohoc nvarchar(max)
as
begin 
	if(exists (select * from LopHoc
				where Ma_LH=@malh and TrangThai like '1'))
				return -1
	else		begin tran ;
			begin try 
				set identity_insert LopHoc off;
				insert into LopHoc(Ma_LH,Ten_LH,ThoiGianBatDau_LH,ThoiGianKetThuc_LH,HocPhi,NhanVienId
				,KhoaHocId,LevelsId,SoBuoiHoc,KhungGioHoc, TrangThai)
				values (@malh,@tenlh, @thoigianbatdau,@thoigianketthuc,@hocphi,@idnv,@idkh,@idlv,@sobuoihoc,@khunggiohoc, 1);	
				commit tran;
			end try
			begin catch
				rollback tran
			end catch

end		
go

--21.Sửa Lớp Học
use EnglishCenter;

IF OBJECT_ID('sp_SuaLopHoc') IS NOT NULL
DROP proc  sp_SuaLopHoc;
go

create proc sp_SuaLopHoc
	@malh nvarchar(100),
	@tenlh nvarchar(100),
	@thoigianbatdau smalldatetime,
	@thoigianketthuc smalldatetime,
	@hocphi numeric(18,0),
	@idnv int ,
	@idkh int,
	@idlv int,
	@sobuoihoc int,
	@khunggiohoc nvarchar(max)
as
begin
		begin tran ;
			begin try 
				update LopHoc
				set Ma_LH= @malh, Ten_LH = @tenlh, ThoiGianBatDau_LH= @thoigianbatdau, ThoiGianKetThuc_LH= @thoigianketthuc, 
				HocPhi = @hocphi, NhanVienId= @idnv, KhoaHocId = @idkh, LevelsId = @idlv, SoBuoiHoc = @sobuoihoc, KhungGioHoc= @khunggiohoc
				where Ma_LH=@malh;
				commit tran;
			end try
			begin catch
				rollback tran
			end catch		

end		
go
--22.Xóa Lớp Học
IF OBJECT_ID('sp_XoaLopHoc') IS NOT NULL
DROP proc  sp_XoaLopHoc
go
create proc sp_XoaLopHoc 
	@idlh int 	
as
		update LopHoc
		set TrangThai = '0'
		where LopHocId=@idlh;
go
--23.List Lớp Học
use EnglishCenter;

IF OBJECT_ID('fn_ListLopHoc') IS NOT NULL
DROP function  fn_ListLopHoc;
go 

create function fn_ListLopHoc
()
returns table
as
	return (select LopHoc.LopHocId,LopHoc.Ma_LH,LopHoc.Ten_LH, NhanVien.HoTen_NV,KhoaHoc.Ten_KH,
Levels.Ten_Level, LopHoc.HocPhi,LopHoc.SoBuoiHoc, LopHoc.KhungGioHoc,
LopHoc.ThoiGianBatDau_LH,LopHoc.ThoiGianKetThuc_LH
  from LopHoc join KhoaHoc on KhoaHoc.KhoaHocId=LopHoc.KhoaHocId
	join NhanVien on NhanVien.NhanVienId=LopHoc.NhanVienId
	join Levels on Levels.LevelsId= LopHoc.LevelsId	
where LopHoc.TrangThai like '1')
go


--24.List Giáo Viên 
use EnglishCenter;

IF OBJECT_ID('view_ListGiaoVien') IS NOT NULL
DROP view  view_ListGiaoVien;
go

create view view_ListGiaoVien

as
select NhanVien.HoTen_NV, NhanVien.Ma_NV, NhanVien.NhanVienId from NhanVien
		where NhanVien.ChucVu like N'Giáo Viên%'
		and NhanVien.TrangThai like '1';
go

select * from  dbo.view_ListGiaoVien;

--25.Lấy Lớp Học Theo Giáo Viên 
use EnglishCenter;
IF OBJECT_ID('fn_TimLopTheoGiaoVien') IS NOT NULL
DROP function  fn_TimLopTheoGiaoVien
go
create function fn_TimLopTheoGiaoVien 
(
	@idgv int
)
returns table
as
return(select LopHoc.LopHocId, LopHoc.Ma_LH,LopHoc.Ten_LH, NhanVien.HoTen_NV,KhoaHoc.Ten_KH,
	Levels.Ten_Level, LopHoc.HocPhi,LopHoc.SoBuoiHoc, LopHoc.KhungGioHoc,
	LopHoc.ThoiGianBatDau_LH,LopHoc.ThoiGianKetThuc_LH
	from LopHoc join KhoaHoc on KhoaHoc.KhoaHocId=LopHoc.KhoaHocId
		join NhanVien on NhanVien.NhanVienId=LopHoc.NhanVienId
		join Levels on Levels.LevelsId= LopHoc.LevelsId	
	where NhanVien.NhanVienId=@idgv and LopHoc.TrangThai like '1'
	)	
go

set statistics io, time on ;
use EnglishCenter;
select * from dbo.fn_TimLopTheoGiaoVien(3) ;



--26 Thêm Học Viên 
use EnglishCenter;

IF OBJECT_ID('sp_ThemHocVien') IS NOT NULL
DROP proc  sp_ThemHocVien;
go

create proc sp_ThemHocVien
	@mahv nvarchar(50),
	@hoten nvarchar(50),
	@diachi nvarchar(100),
	@email nvarchar(50),
	@sdt nvarchar(50)
as
	begin 
	if(exists (select * from HocVien
				where Ma_HV like @mahv and TrangThai like '1'))
				return -1;
	else
		begin tran ;
			begin try 
				set identity_insert HocVien off;
				insert into HocVien(Ma_HV,HoTen_HV,DiaChi_HV,Email_HV,SDT_HV, TrangThai)
				values (@mahv,@hoten,@diachi,@email,@sdt, 1);	
				commit tran;
			end try
			begin catch
				rollback tran
			end catch
end
go

--26 Sửa Học Viên 
use EnglishCenter;

IF OBJECT_ID('sp_SuaHocVien') IS NOT NULL
DROP proc  sp_SuaHocVien;
go

create proc sp_SuaHocVien
	@idhv int ,
	@mahv nvarchar(50),
	@hoten nvarchar(50),
	@diachi nvarchar(100),
	@email nvarchar(50),
	@sdt nvarchar(50)
as
	begin 

	begin tran ;
			begin try 
				update HocVien
				set Ma_HV=@mahv, HoTen_HV=@hoten, DiaChi_HV=@diachi,
				Email_HV=@email,SDT_HV=@sdt
				where HocVienId=@idhv
				commit tran;
			end try
			begin catch
				rollback tran
			end catch		
end
go
--27.Xóa Học Viên 
IF OBJECT_ID('sp_XoaHocVien') IS NOT NULL
DROP proc  sp_XoaHocVien
go
create proc sp_XoaHocVien 
	@id_hv int 	
as
		update HocVien
		set TrangThai = '0'
		where HocVienId=@id_hv;
go
exec dbo.sp_XoaHocVien 1007;
--28.List Học Viên

use EnglishCenter;

IF OBJECT_ID('fn_ListHocVien') IS NOT NULL
DROP function  fn_ListHocVien;
go

create function fn_ListHocVien
(
)
returns table
as
return(select * from HocVien
		where TrangThai like '1')
go
--29. Tìm Học Viên Theo Tên
use EnglishCenter;
go
if OBJECT_ID('sp_TimHocVienTheoTen') is not null
DROP proc  sp_TimHocVienTheoTen
go
create proc sp_TimHocVienTheoTen 
	@ten nvarchar(50)
as
	select * from HocVien
			where UPPER(HocVien.HoTen_HV) like '%'+@ten+'%';
go



--33. list lưu lại lịch sử update của nhân viên
--Tạo bảng lưu những thay đổi trên bảng nhân viên	
use EnglishCenter;
go
create table NhanVien_audits
(
	Change_id int identity primary key,
	Ma_NV nvarchar(100) not null,
	HoTen_NV nvarchar(100) not null,
	ChucVu nvarchar(100) not null,
	Email nvarchar(100) not null,
	SDT_NV nvarchar(100) not null,
	CMND_NV nvarchar(100) not null,
	Birthday datetime null,
	Update_at datetime not null,		  
	Operation char(3) not null,
	check(operation ='INS' or operation = 'DEL')
)
if object_id('tr_NV_update') is not null
	drop trigger tr_NV_update;
go

create trigger tr_NV_update
on NhanVien
after insert, update
as 
begin
	insert NhanVien_audits(Ma_NV, HoTen_NV, ChucVu, Email,SDT_NV,CMND_NV,Birthday,Update_at,Operation)
	select
		 i.Ma_NV,
		 i.HoTen_NV,
		 i.ChucVu,
		 i.Email,
		 i.SDT_NV,
		 i.CMND,
		 i.Birthday,
		 GETDATE(),
		 'INS'
	from inserted i
end
go

select * from NhanVien_audits;


--
if object_id('tr_NV_delete') is not null
	drop trigger tr_NV_delete;
go


  create trigger tr_NV_delete
on NhanVien
after delete
as 
begin
	insert NhanVien_audits(Ma_NV, HoTen_NV, ChucVu, Email,SDT_NV,CMND_NV,Birthday,Update_at,Operation)
	select
		 d.Ma_NV,
		 d.HoTen_NV,
		 d.ChucVu,
		 d.Email,
		 d.SDT_NV,
		 d.CMND,
		 d.Birthday,
		 GETDATE(),
		 'DEL'
	from deleted d
end
go


  --Đặt điều kiện lớp không được > 20 học viên
use EnglishCenter;
go
if OBJECT_ID('tr_soHv') is not null
	drop trigger tr_soHv;
go
create trigger tr_SoHv 
on LopHoc for insert
 as
 declare @soluong int;
 select @soluong = count(*) from PhieuThu p join LopHoc l
 on p.LopHocId = l.LopHocId
 if @soluong > 20
 begin 
	rollback transaction
end 
return 
go
--create a view 
use EnglishCenter;
go
if OBJECT_ID('dsLop') is not null
drop view dsLop;
go
create view dsLop
as 
select Ma_LH, Ten_LH, ThoiGianBatDau_LH, ThoiGianKetThuc_LH, HocPhi, SoBuoiHoc,KhungGioHoc
from LopHoc l join KhoaHoc k on l.KhoaHocId = k.KhoaHocId
go

use EnglishCenter;
go
if OBJECT_ID('dsHocVien') is not null
drop view dsHocVien;
go
create view dsHocVien 

as
select h.Ma_HV, h.HoTen_HV, h.SDT_HV
from  HocVien h join PhieuThu p
on h.HocVienId = p.HocVienId and p.LopHocId = (select LopHocId from LopHoc where Ma_LH='LH_1')
go

--Them phieu thu
use EnglishCenter;

IF OBJECT_ID('sp_ThemPhieuThu') IS NOT NULL
DROP proc  sp_ThemPhieuThu;
go

create proc sp_ThemPhieuThu	
	@idhv int,
	@idlh int,
	@idnv int
as
	begin 
	if(exists (select * from PhieuThu
				where HocVienId=@idhv and LopHocId= @idlh  ))
				return -1;
	else
		begin tran ;
			begin try 
				set identity_insert PhieuThu off;
				insert into PhieuThu(HocVienId,LopHocId,NhanVienId)
				values (@idhv,@idlh,@idnv);	
				commit tran;
			end try
			begin catch
				rollback tran
			end catch
end
go

--Them tai khoan gv
use EnglishCenter;
go
if OBJECT_ID('tr_ThemTaiKhoanGV') is not null
	drop trigger tr_ThemTaiKhoanGV
go

create trigger tr_ThemTaiKhoanGV
on NhanVien 
after insert, update
as
	if(exists(select * from TaikhoanGiaoVien 
	join inserted on TaikhoanGiaoVien.NhanVienId = inserted.NhanVienId
	 ))
		 update TaikhoanGiaoVien 
		 set Username=NhanVien.HoTen_NV, ChucVu= NhanVien.ChucVu,PassWords=NhanVien.SDT_NV, PhanQuyenId= PhanQuyen.PhanQuyenId
		 from NhanVien  join PhanQuyen on PhanQuyen.Ten_PhanQuyen like  NhanVien.ChucVu
		where TaikhoanGiaoVien.NhanVienId = NhanVien.NhanVienId;
	else
			insert into TaikhoanGiaoVien(NhanVienId, Username, ChucVu,PassWords, TrangThai,PhanQuyenId)
		select NhanVienId, HoTen_NV, ChucVu,SDT_NV,TrangThai, PhanQuyen.PhanQuyenId
		from inserted  join PhanQuyen on PhanQuyen.Ten_PhanQuyen like  inserted.ChucVu
		where NhanVienId = inserted.NhanVienId;	
go	
exec dbo.sp_SuaNhanVien  14,N'NV_16',N'Trần Phước Tài',N'Giáo Viên',N'ewiiẻtregr',N'123456',N'754561254',N'1994-09-26 21:32:13.000';
 --Xoa TKNV
use EnglishCenter;
go
if OBJECT_ID('tr_XoaTaiKhoanGV') is not null
	drop trigger tr_XoaTaiKhoanGV
go

create trigger tr_XoaTaiKhoanGV
on NhanVien after update 
as
begin
	update TaikhoanGiaoVien
	set TrangThai = '0' 
	where NhanVienId in (select NhanVien.NhanVienId from NhanVien
	where NhanVien.TrangThai like '0')
		
end
go	
exec dbo.sp_XoaNhanVien 13


--Tai khoan hoc vien
use EnglishCenter;
go
if OBJECT_ID('tr_ThemTaiKhoanHV') is not null
	drop trigger tr_ThemTaiKhoanHV
go

create trigger tr_ThemTaiKhoanHV
on HocVien 
after insert
as
	insert into TaiKhoanHocVien(HocVienId, Username,PassWords, TrangThai, PhanQuyenId)
	select HocVienId, HoTen_HV,SDT_HV,TrangThai,4
	from inserted  
	where HocVienId = inserted.HocVienId
go
	
 --Xoa TKNV
use EnglishCenter;
go
if OBJECT_ID('tr_XoaTaiKhoanHV') is not null
	drop trigger tr_XoaTaiKhoanHV
go

create trigger tr_XoaTaiKhoanHV
on HocVien after update 
as
begin
	update TaiKhoanHocVien
	set TrangThai = '0' 
	where HocVienId in (select HocVien.HocVienId from HocVien
	where HocVien.TrangThai like '0')
end
go
exec dbo.sp_XoaHocVien 1007;
--Dang nhap user 

			
--du lieu nam o cay clusterd, uu tien cho cai quan trong nhat
--con lại nonclustered, 
--neu tim theo khoang -> clustered hieu qua hon
--2 dieu kien -> dieu kien = uu tien trc

alter table TaikhoanGiaoVien
add constraint fk_PQ_GV
foreign key (PhanQuyenId)
references PhanQuyen(PhanQuyenId)
--Kiểm tra tai khoản nhân viên 
use EnglishCenter
go

IF OBJECT_ID('sp_KiemTraTaiKhoanNV') IS NOT NULL
DROP proc  sp_KiemTraTaiKhoanNV;
go
create proc  sp_KiemTraTaiKhoanNV
(	@idpq int output,
	@idnv int output,
	@name nvarchar(100),
	@pass nvarchar(100), 
	@chucvu nvarchar(100)
	)					   
as
begin
	select @idpq = PhanQuyenId, @idnv=NhanVienId from TaikhoanGiaoVien
	where Username like @name
	and PassWords like @pass	
	and ChucVu like @chucvu
end
go


--Kiểm tra tai khoản học viên 
use EnglishCenter
go

IF OBJECT_ID('sp_KiemTraTaiKhoanHV') IS NOT NULL
DROP proc  sp_KiemTraTaiKhoanHV;
go
create proc  sp_KiemTraTaiKhoanHV
(	@idpq int output,
	@idhv int output,
	@name nvarchar(100),
	@pass nvarchar(100)
	)					   
as
begin
	select @idpq = PhanQuyenId, @idhv=HocVienId from TaiKhoanHocVien
	where Username like @name
	and PassWords like @pass	
end
go

declare @id int
declare @innv int
exec  dbo.sp_KiemTraTaiKhoanNV @id output,@innv output,'Admin','123456789', 'Admin';
print @id
print @innv

--Lấy danh sách lớp học theo khoa học
use EnglishCenter;

IF OBJECT_ID('fn_ListLopHocTheoKhoaHoc') IS NOT NULL
DROP function  fn_ListLopHocTheoKhoaHoc;
go 

create function fn_ListLopHocTheoKhoaHoc
(
 @idkh int
)
returns table
as
	return (select LopHoc.LopHocId,LopHoc.Ma_LH,LopHoc.Ten_LH, NhanVien.HoTen_NV,KhoaHoc.Ten_KH,
Levels.Ten_Level, LopHoc.HocPhi,LopHoc.SoBuoiHoc, LopHoc.KhungGioHoc,
LopHoc.ThoiGianBatDau_LH,LopHoc.ThoiGianKetThuc_LH
  from LopHoc join KhoaHoc on KhoaHoc.KhoaHocId=LopHoc.KhoaHocId
	join NhanVien on NhanVien.NhanVienId=LopHoc.NhanVienId
	join Levels on Levels.LevelsId= LopHoc.LevelsId	
where LopHoc.TrangThai like '1' and KhoaHoc.KhoaHocId=@idkh)
go

--Lấy danh sách học viên của lớp học
use EnglishCenter;

IF OBJECT_ID('fn_ListHocVienCuaLopHoc') IS NOT NULL
DROP function  fn_ListHocVienCuaLopHoc;
go
create function fn_ListHocVienCuaLopHoc
(
	@idlh int
)
returns table
as
return (select s.Ma_HV, s.HoTen_HV,s.DiaChi_HV,s.Email_HV,s.SDT_HV from HocVien s
		join PhieuThu p  on s.HocVienId=p.HocVienId
		where p.LopHocId=@idlh and s.TrangThai like '1')
go

--lấy danh sách phiếu thu 

use EnglishCenter;

IF OBJECT_ID('fn_ListPhieuThu') IS NOT NULL
DROP function  fn_ListPhieuThu;
go
create function fn_ListPhieuThu
(
	@idlh int
)
returns table
as
return (select p.PhieuThuId, s.Ma_HV, s.HoTen_HV, NhanVien.HoTen_NV, p.SoTien,p.PhuongThucThanhToan,p.NgayThanhToan,s.HocVienId from HocVien s
		join PhieuThu p  on s.HocVienId=p.HocVienId
		join NhanVien on NhanVien.NhanVienId= p.NhanVienId
		where p.LopHocId=@idlh and s.TrangThai like '1')
go

--cập nhật phiếu thu
use EnglishCenter;

IF OBJECT_ID('sp_CapNhatPhieuThu') IS NOT NULL
DROP proc  sp_CapNhatPhieuThu;
go

create proc sp_CapNhatPhieuThu
	@idpt int ,
	@ngaythanhtoan smalldatetime,
	@phuongthucthanhtoan nvarchar(50),
	@sotien numeric(18,0),
	@idhv int,
	@idlh int,
	@idnv int
as
	begin 

	begin tran ;
			begin try 
				update PhieuThu
				set NgayThanhToan=@ngaythanhtoan,PhuongThucThanhToan=@phuongthucthanhtoan,
				SoTien=@sotien,NhanVienId=@idnv			
				where HocVienId=@idhv and LopHocId=@idlh
				commit tran;
			end try
			begin catch
				rollback tran
			end catch		
end
go
--tìm tên học viên trên phiếu thu
use EnglishCenter;

IF OBJECT_ID('fn_TimTenTrenPhieuThu') IS NOT NULL
DROP function  fn_TimTenTrenPhieuThu;
go
create function fn_TimTenTrenPhieuThu
(
	@idlh int,
	@ten nvarchar(50)
)
returns table
as
return (select p.PhieuThuId, s.Ma_HV, s.HoTen_HV, NhanVien.HoTen_NV, p.SoTien,p.PhuongThucThanhToan,p.NgayThanhToan,s.HocVienId from HocVien s
		join PhieuThu p  on s.HocVienId=p.HocVienId
		join NhanVien on NhanVien.NhanVienId= p.NhanVienId
		where p.LopHocId=@idlh and s.TrangThai like '1' and s.HoTen_HV like '%'+@ten+'%' )
go


--Sắp xếp tên admin
