--------------------------------------------Bài tập 1------------------------------------------------------------------------

/*1.	Tạo view SachGD đưa ra danh sách các sách với các thông tin 
		MaSach,TenSach, tên thể loại, tổng số lượng nhập, tổng số lượng bán, 
		số lượng tồn do Nhà xuất bản Giáo Dục xuất bản.
*/
USE [BT1]
Go
create function tongBan()
returns	TABLE 
as 
	return(
		select HDB.MaSach, SUM(HDB.SLBan) as TBan from tChiTietHDB HDB, tNhaXuatBan NXB
		where NXB.MaNXB = 'NXB05'
		GROUP BY HDB.MaSach
		)
GO
create function tongNhap()
returns	TABLE 
as 
	return(
		select HDN.MaSach, SUM(HDN.SLNhap) as TNhap from tChiTietHDN HDN, tNhaXuatBan NXB
		where NXB.MaNXB = 'NXB05'
		GROUP BY HDN.MaSach
		)
GO
create function tongNhapBan()
returns	TABLE 
as 
	return(
		select TB.MaSach MS, TN.TNhap, TB.TBan from tongBan() TB left  join tongNhap() TN on TB.MaSach = TN.MaSach
		where TB.MaSach IS NOT NULL 
		)
GO

create view SachGD
as
select S.MaSach, S.TenSach, S.MaNXB, NXB.TenNXB, ISNULL(TNB.TNhap,0) as Nhap, ISNULL(TNB.TBan,0) as Ban, S.SoLuong
from tSach S, tNhaXuatBan NXB , tongNhapBan() TNB
where S.MaNXB = 'NXB05' and  NXB.MaNXB = S.MaNXB and TNB.MS = S.MaSach
Go
select * from SachGD
/*
	2.	Tạo view KhachVip đưa ra khách hàng gồm thông tin MaKH, 
		TenKH, địa chỉ, điện thoại cho những khách hàng đã mua hàng 
		với tổng tất cả các trị giá hóa đơn trong năm hiện tại lớn hơn 30.000.000
*/
Go
create view KhachVip
as
select KH.MaKH, KH.TenKH, KH.DiaChi, KH.DienThoai from tKhachHang KH, tHoaDonBan HDB, tChiTietHDB CTHDB, tSach S
where YEAR(NgayBan) = YEAR(GETDATE()) and S.MaSach = CTHDB.MaSach and HDB.SoHDB = CTHDB.SoHDB
	and HDB.MaKH = KH.MaKH
GROUP BY KH.MaKH, KH.TenKH, KH.DiaChi, KH.DienThoai
Having (SUM(CTHDB.SLBan * S.DonGiaBan) > 30000000)


/*
	3.	Tạo view đưa ra số hóa đơn, trị giá các hóa đơn và tổng toàn bộ trị giá 
		của các hoa đơn do nhân viên có tên “Trần Huy” lập trong tháng hiện tại
*/
Go
create view HDTranHuy
as
select HDB.SoHDB, SUM(CTHDB.SLBan * S.DonGiaBan) as N'Tổng Tiền' from tKhachHang KH, tHoaDonBan HDB, tChiTietHDB CTHDB, tSach S, tNhanVien NV
where NV.TenNV = N'Trần Huy' and S.MaSach = CTHDB.MaSach and HDB.SoHDB = CTHDB.SoHDB and HDB.MaKH = KH.MaKH and HDB.MaNV = NV.MaNV
GROUP BY HDB.SoHDB


/*
	4.	Tạo view đưa thông tin các các sách còn tồn
*/
Go
create view SachTon
as
select * from tSach S
where S.SoLuong > 0


/*
	5.	Tạo view đưa ra danh sách các sách không bán được trong năm 2014.
*/
Go
Create view KhongBan2014
as
select * from tSach S
where S.MaSach not in (select S.MaSach as MaSach from tHoaDonBan HDB, tChiTietHDB CTHDB, tSach S
		where HDB.SoHDB = CTHDB.SoHDB and CTHDB.MaSach = S.MaSach and YEAR(HDB.NgayBan) = 2014) 

--select * from KhongBan2014



/*
	6.	Tạo view đưa ra danh sách các sách của NXB Giáo Dục không bán được trong năm 2014.
*/
Go
Create view KhongBan2014_NXB05
as
select S.MaSach, S.TenSach from tSach S,tNhaXuatBan NXB
where S.MaSach not in (select S.MaSach as MaSach from tHoaDonBan HDB, tChiTietHDB CTHDB, tSach S
		where HDB.SoHDB = CTHDB.SoHDB and CTHDB.MaSach = S.MaSach and YEAR(HDB.NgayBan) = 2014) 
		and NXB.MaNXB = S.MaNXB and S.MaNXB = 'NXB05'

--		select * from tSach S, tNhaXuatBan NXB where S.MaNXB = NXB.MaNXB and NXB.MaNXB = 'NXB05'


/*
	7.	Tạo view đưa ra các thông tin về sách và số lượng từng sách được bán ra trong năm 2014.
*/
Go
Create view ban2014
as
select S.MaSach as N'Mã Sách', S.TenSach, S.DonGiaBan, S.DonGiaNhap,
		SUM(CTHDB.SLBan) as N'Số Lượng Bán'
from tHoaDonBan HDB, tChiTietHDB CTHDB, tSach S
		where HDB.SoHDB = CTHDB.SoHDB and CTHDB.MaSach = S.MaSach and YEAR(HDB.NgayBan) = 2014
		Group By S.MaSach, S.TenSach, S.DonGiaBan, S.DonGiaNhap



/*
	8.	Tạo view đưa ra họ tên khách hàng đã mua hóa đơn có trị giá cao nhất trong năm 2014.
*/
Go
Create view HDCaoNhat
as
select Top(1) KH.MaKH, KH.TenKH, (CTHDB.SLBan*S.DonGiaBan) as N'Giá Trị HĐ', HDB.NgayBan
from tChiTietHDB CTHDB, tHoaDonBan HDB, tKhachHang KH, tSach S
	where CTHDB.SoHDB = HDB.SoHDB and KH.MaKH = HDB.MaKH and S.MaSach = CTHDB.MaSach and YEAR(HDB.NgayBan) = 2014
	Group by KH.MaKH, KH.TenKH,(CTHDB.SLBan*S.DonGiaBan) ,HDB.NgayBan
	ORDER BY (CTHDB.SLBan*S.DonGiaBan) DESC
/*
	9.	Tạo view đưa ra danh sách 3 nhân viên (MaNV, TenNV) có doanh số cao nhất của năm hiện tại.
*/
Go
Create View Top3DoanhThu
as
select Top(3) NV.MaNV, NV.TenNV, SUM(S.DonGiaBan* CTHDB.SLBan) as N'Tổng Tiền' from tNhanVien NV, tHoaDonBan HDB, tChiTietHDB CTHDB, tSach S
where NV.MaNV = HDB.MaNV and CTHDB.SoHDB = HDB.SoHDB and  S.MaSach = CTHDB.MaSach
Group by  NV.MaNV, NV.TenNV 



/*
	10.	Tạo view đưa ra danh sách sách và số lượng nhập của mỗi nhà xuất bản trong năm hiện tại
*/
Go
Create view soluongtonNhapNow
as
select S.MaSach, S.SoLuong, iif(SUM(HDN.SLNhap)>0,SUM(HDN.SLNhap),0) as SoLuongNhap, NXB.MaNXB 
from tSach S left join tHoaDonNhap N on YEAR(GETDATE()) = YEAR(N.NgayNhap)
			left join tChiTietHDN HDN on HDN.MaSach = S.MaSach and YEAR(GETDATE()) = YEAR(N.NgayNhap)
			left join tNhaXuatBan NXB on S.MaNXB = NXB.MaNXB 
Group By S.MaSach, S.SoLuong, NXB.MaNXB 



--------------------------------------------Bài tập 2------------------------------------------------------------------------

/*
	
*/
Go



/*
	
*/
Go




/*
	
*/
Go




/*
	
*/
Go



/*
	
*/
Go



/*
	
*/
Go



/*
	
*/
Go
