--Bài tập 1

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

select * from SachGD
/*
	2.	Tạo view KhachVip đưa ra khách hàng gồm thông tin MaKH, 
		TenKH, địa chỉ, điện thoại cho những khách hàng đã mua hàng 
		với tổng tất cả các trị giá hóa đơn trong năm hiện tại lớn hơn 30.000.000
*/
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
select HDB.SoHDB, SUM(CTHDB.SLBan * S.DonGiaBan) as N'Tổng Tiền' from tKhachHang KH, tHoaDonBan HDB, tChiTietHDB CTHDB, tSach S, tNhanVien NV
where NV.TenNV = N'Trần Huy' and S.MaSach = CTHDB.MaSach and HDB.SoHDB = CTHDB.SoHDB and HDB.MaKH = KH.MaKH and HDB.MaNV = NV.MaNV
GROUP BY HDB.SoHDB


/*
	4.	Tạo view đưa thông tin các các sách còn tồn
*/



/*
	5.	Tạo view đưa ra danh sách các sách không bán được trong năm 2014.
*/



/*
	
*/



/*
	
*/