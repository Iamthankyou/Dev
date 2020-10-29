---------------------------------------------------bài 1--------------------------------------------

/*
	1.Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert,
	Update bản ghi để chỉ cho phép nhập giá trị trong khoảng từ 0 đến 10
*/
use BT1_BTN12
GO
create trigger checkDiem on DIEM  for insert ,update
as 
begin
	declare @toan float, @ly float, @hoa float, @van float
	select @toan = TOAN, @ly = LY, @hoa = HOA, @van = VAN from inserted
	if(@toan>10 or @toan<0) rollback
	if(@ly>10 or @ly<0) rollback
	if(@hoa>10 or @hoa<0) rollback
	if(@van>10 or @van<0) rollback
end 

--select * from DIEM
--update DIEM set TOAN = 11 where MAHS = '00001'

/*
	2.Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, 
	Update để tự động cập nhật điểm trung bình của học sinh khi
	thêm mới hay cập nhật bảng điểm Điểm trung bình= ((Toán +Văn)*2+Lý+Hóa)/6
*/
GO
create trigger leverUP on DIEM  for insert ,update
as 
begin
	declare @masv nvarchar(5), @toan float, @ly float, @hoa float, @van float 
	select @masv = MAHS, @toan = TOAN, @ly = LY, @hoa = HOA, @van = VAN from inserted

	update DIEM set DTB = ROUND(((@toan + @van)*2 + @ly + @hoa)/6,2) where @masv = MAHS
end


--select * from DIEM
--update DIEM set TOAN = 10 where MAHS = '00001'
--select * from DIEM



/*
	3.Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert,
	Update để tự động xếp loại học sinh, cách thức xếp loại như sau
	-Nếu Điểm trung bình>=5 là lên lớp, ngược lại là lưu ban
*/
create trigger xeploai on DIEM  for insert ,update
as 
begin
	declare @masv nvarchar(5), @toan float, @ly float, @hoa float, @van float 
	select @masv = MAHS, @toan = TOAN, @ly = LY, @hoa = HOA, @van = VAN from inserted

	if ROUND(((@toan + @van)*2 + @ly + @hoa)/6,2) >= 5
		update DIEM set XepLoai = N'Lên Lớp' where @masv = MAHS
	else update DIEM set XepLoai = N'Lưu Ban' where @masv = MAHS
end

--select * from DIEM
--update DIEM set TOAN = 10 where MAHS = '00001'
--select * from DIEM

/*
	4.Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert,
	Update để tự động xếp loại học sinh, cách thức xếp loại như sau
-Xét điểm thấp nhất (DTN) của các 4 môn
-Nếu DTB>=5 và DTN>=4 là “Lên Lớp”, ngược lại là lưu ban
*/
create trigger xeploai2 on DIEM  for insert ,update
as 
begin
	declare @masv nvarchar(5), @toan float, @ly float, @hoa float, @van float, @dtn float
	select @masv = MAHS, @toan = TOAN, @ly = LY, @hoa = HOA, @van = VAN from inserted
	if(@toan <= @ly and @toan <= @hoa and  @toan <= @van) set @dtn = @toan
	if(@ly <= @toan and @ly <= @hoa and  @ly <= @van) set @dtn = @ly
	if(@hoa <= @toan and @hoa <= @ly and  @hoa <= @van) set @dtn = @hoa
	if(@van <= @toan and @van <= @hoa and  @van <= @ly) set @dtn = @van

	if ROUND(((@toan + @van)*2 + @ly + @hoa)/6,2) >= 5 and @dtn >= 4
		update DIEM set XepLoai = N'Lên Lớp' where @masv = MAHS
	else update DIEM set XepLoai = N'Lưu Ban' where @masv = MAHS
end


--select * from DIEM
--update DIEM set TOAN = 10 where MAHS = '00001'
--update DIEM set TOAN = 3, LY = 10, HOA = 10, VAN = 10 where MAHS = '00001'
--select * from DIEM

/*
	5.Viết một trigger xóa tự động bản ghi về điểm học sinh
	khi xóa dữ liệu học sinh đó trong DSHS
*/
create trigger delHS on DSHS  for delete
as 
begin
	declare @masv nvarchar(5)
	select @masv = MAHS from deleted	
	delete from Diem where @masv = MAHS
end
--select * from DIEM
--select * from DSHS
--delete from DSHS where MAHS = '00007'
--select * from DIEM
--select * from DSHS

/*
	6.Viết nội thủ tục (Stored Procedure) cập nhật phần ghi 
	chú là “Chuyển trường từ ngày 5/9/2016” cho học sinh có 
	mã nhập vào trong bảng danh sách học sinh.
*/




/*
	7.Tạo View báo cáo Kết thúc năm học gồm các thông tin: Mã học sinh,
	Họ và tên, Ngày sinh, Giới tính, Điểm Toán, Lý, Hóa, Văn, Điểm Trung bình, Xếp loại
*/
create function xeploai(@mahs nvarchar(5))
returns nvarchar(10) as
begin 
	declare @toan float, @ly float, @hoa float, @van float, @xl nvarchar(10), @dtb float
	select @toan = TOAN, @ly = LY, @hoa = HOA, @van = VAN from DIEM where MAHS = @mahs
	set @dtb = ROUND(((@toan + @van)*2 + @ly + @hoa)/6,2)
	
	if(@dtb <6.5) set @xl = 'Trung Binh'
	else if(@dtb >=6.5 and @dtb < 8) set @xl = 'Kha'
	else if(@dtb > 8) set @xl = 'Gioi'
	return @xl
end

create view report
as 
	select 
	DS.MAHS, DS.HO +' '+ DS.TEN as HoTen,
	DS.NGAYSINH as NamSinh, iif(DS.NU = 0,'Nam','Nu') as N'Giơi Tính', D.TOAN, D.LY, D.HOA, D.VAN,
	ROUND(((D.TOAN+D.VAN)*2 + D.LY + D.HOA)/6,2) as DTB,
	dbo.xeploai(D.MAHS) as N'Xếp Loại'
	from LOP as L inner join DSHS as DS on L.LOP = DS.LOP
					inner join DIEM as D on D.MAHS = DS.MAHS

select * from report

/*
	8.Tạo trường điểm thấp nhất trong bảng Điểm, tạo thủ tục cập nhật
	điểm thấp nhất cho trường này của tất cả các bản ghi đã có (dùng con trỏ)
*/



/*
	9.Tạo trigger cập nhật điểm thấp nhất mỗi khi insert, update một bản ghi vào bảng điểm.
*/
create trigger diemthapnhat on DIEM  for insert ,update
as 
begin
	declare @masv nvarchar(5), @toan float, @ly float, @hoa float, @van float, @dtn float
	select @masv = MAHS, @toan = TOAN, @ly = LY, @hoa = HOA, @van = VAN from inserted
	if(@toan <= @ly and @toan <= @hoa and  @toan <= @van) set @dtn = @toan
	if(@ly <= @toan and @ly <= @hoa and  @ly <= @van) set @dtn = @ly
	if(@hoa <= @toan and @hoa <= @ly and  @hoa <= @van) set @dtn = @hoa
	if(@van <= @toan and @van <= @hoa and  @van <= @ly) set @dtn = @van
	update DIEM set DiemThapNhat = @dtn where @masv = MAHS
end



/*
	10.Tạo View danh sách HOC SINH XUAT SAC bao gồm các học sinh 
	có DTB>=8.5 và DTN>=8 với các trường: Lop, Mahs, Hoten, 
	Namsinh (năm sinh), Nu, Toan, Ly, Hoa, Van, DTN, DTB (
	không dùng trường thấp nhất đã làm ở câu 7)
*/
create function dtn(@mahs nvarchar(5))
returns float as
begin 
	declare @toan float, @ly float, @hoa float, @van float, @dtn float
	select @toan = TOAN, @ly = LY, @hoa = HOA, @van = VAN from DIEM where MAHS = @mahs
	if(@toan <= @ly and @toan <= @hoa and  @toan <= @van) set @dtn = @toan
	if(@ly <= @toan and @ly <= @hoa and  @ly <= @van) set @dtn = @ly
	if(@hoa <= @toan and @hoa <= @ly and  @hoa <= @van) set @dtn = @hoa
	if(@van <= @toan and @van <= @hoa and  @van <= @ly) set @dtn = @van
	return @dtn
end

create view SX1
as 
	select 
	L.LOP, DS.MAHS, DS.HO +' '+ DS.TEN as HoTen,
	YEAR(DS.NGAYSINH) as NamSinh, DS.NU, D.TOAN, D.LY, D.HOA, D.VAN,
	ROUND(((D.TOAN+D.VAN)*2 + D.LY + D.HOA)/6,2) as DTB,
	dbo.dtn(D.MAHS) as DTN
	from LOP as L inner join DSHS as DS on L.LOP = DS.LOP
						inner join DIEM as D on D.MAHS = DS.MAHS
	where ROUND(((D.TOAN+D.VAN)*2 + D.LY + D.HOA)/6,2) >= 8.5 and
		dbo.dtn(D.MAHS) >=8

select * from SX1

/*
	11.Tạo View danh sách HOC SINH DAT THU KHOA KY THI bao gồm 
	các học sinh xuất sắc có DTB lớn nhất với các trường:
	Lop, Mahs, Hoten, Namsinh, Nu, Toan, Ly, Hoa, Van, DTB
*/
Go
create function dtb()
returns Table 
as
	return (
		select TOP(1) ROUND(((TOAN+VAN)*2 + LY + HOA)/6,2) as DTB from DIEM
		Order by DTB DESC
	)

Go
alter view SX
as 
	select 
	L.LOP, DS.MAHS, DS.HO +' '+ DS.TEN as HoTen,
	DS.NGAYSINH, DS.NU, D.TOAN, D.LY, D.HOA, D.VAN,
	ROUND(((D.TOAN+D.VAN)*2 + D.LY + D.HOA)/6,2) as DTB
	from LOP as L inner join DSHS as DS on L.LOP = DS.LOP
						inner join DIEM as D on D.MAHS = DS.MAHS, dtb()
	where dtb.DTB = ROUND(((D.TOAN+D.VAN)*2 + D.LY + D.HOA)/6,2).

select * from SX






---------------------------------------------------bài 2--------------------------------------------
/*

*/