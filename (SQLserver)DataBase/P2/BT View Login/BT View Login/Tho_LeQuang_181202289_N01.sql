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
select S.MaSach, S.TenSach, S.MaNXB, NXB.TenNXB, TNB.TNhap, TNB.TBan, S.SoLuong
from tSach S, tNhaXuatBan NXB , tongNhapBan() TNB
where S.MaNXB = 'NXB05' and  NXB.MaNXB = S.MaNXB and TNB.MS = S.MaSach


/*2.	Tạo view KhachVip đưa ra khách hàng gồm thông tin MaKH, 
		TenKH, địa chỉ, điện thoại cho những khách hàng đã mua hàng 
		với tổng tất cả các trị giá hóa đơn trong năm hiện tại lớn hơn 30.000.000*/


