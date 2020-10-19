Create database My_IPOS
go
USE My_IPOS
go
CREATE TABLE TraSua
(
  ID_TraSua NVARCHAR(10) NOT NULL,
  TenTraSua NVARCHAR(50) NOT NULL,
  HinhAnh  image,
  DonGiaTraSua INT NOT NULL,
  PRIMARY KEY (ID_TraSua)
);

CREATE TABLE KhachHang
(
  ID_KhachHang NVARCHAR(10) NOT NULL,
  GioiTinh bit NOT NULL,
  NgaySinh DATE NOT NULL,
  TenKhachHang INT NOT NULL,
  LienHe INT NOT NULL,
  PRIMARY KEY (ID_KhachHang)
);

CREATE TABLE HoaDon
(
  ID_HoaDon NVARCHAR(10) NOT NULL,
  ID_Voucher NVARCHAR(10) NOT NULL,
  TongTien FLOAT NOT NULL,
  PRIMARY KEY (ID_HoaDon),
  FOREIGN KEY (ID_Voucher) REFERENCES Voucher(ID_Voucher)
);

CREATE TABLE Topping
(
  ID_Topping NVARCHAR(10) NOT NULL,
  TenTopping NVARCHAR(50) NOT NULL,
  HinhAnh image,
  DonGiaTopping INT NOT NULL,
  PRIMARY KEY (ID_Topping)
);

CREATE TABLE Voucher
(
  ID_Voucher NVARCHAR(10) NOT NULL,
  MaGiamGia NVARCHAR(16) NOT NULL,
  TenVoucher NVARCHAR(50) NOT NULL,
  PhanTram FLOAT NOT NULL,
  SoLuong INT NOT NULL,
  PRIMARY KEY (ID_Voucher)
);

CREATE TABLE mua
(
  SoLuong INT NOT NULL,
  ID_TraSua NVARCHAR(10) NOT NULL,
  ID_HoaDon NVARCHAR(10) NOT NULL,
  PRIMARY KEY (ID_TraSua, ID_HoaDon),
  FOREIGN KEY (ID_TraSua) REFERENCES TraSua(ID_TraSua),
  FOREIGN KEY (ID_HoaDon) REFERENCES HoaDon(ID_HoaDon)
);

CREATE TABLE ChiTietHoaDon
(
  ThoiGianOrder INT NOT NULL,
  GiamGia INT NOT NULL,
  ID_KhachHang NVARCHAR(10) NOT NULL,
  ID_HoaDon NVARCHAR(10) NOT NULL,
  PRIMARY KEY (ID_KhachHang, ID_HoaDon),
  FOREIGN KEY (ID_KhachHang) REFERENCES KhachHang(ID_KhachHang),
  FOREIGN KEY (ID_HoaDon) REFERENCES HoaDon(ID_HoaDon)
);

CREATE TABLE mua_them
(
  SoLuong INT NOT NULL,
  ID_Topping NVARCHAR(10) NOT NULL,
  ID_HoaDon NVARCHAR(10) NOT NULL,
  PRIMARY KEY (ID_Topping, ID_HoaDon),
  FOREIGN KEY (ID_Topping) REFERENCES Topping(ID_Topping),
  FOREIGN KEY (ID_HoaDon) REFERENCES HoaDon(ID_HoaDon)
);


insert into [TraSua]
values	('TX01',N'Trà Xanh (M)',NULL,'22500'),
		('TX02',N'Trà Xanh Xoài (M)',NULL,'32400'),
		('TX03',N'Trà Dâu Tằm Pha Lê Tuyết (M)',NULL,'33000'),
		('TX04',N'Trà Dứa Hồng Hạc (M)',NULL,'33040'),
		('TX05',N'Trà Xanh Kiwi Chanh Leo (M)',NULL,'32000'),
		('TX06',N'Trà Xanh Chanh Leo (M)',NULL,'34050'),
		('TX07',N'Trà Dứa Nhiệt Đới (M)',NULL,'31200'),
		('TX08',N'Hồng Long Pha Lê Tuyết (M)',NULL,'34020'),
		('TX11',N'Trà Xanh (L)',NULL,'29000'),
		('TX12',N'Trà Xanh Xoài (L)',NULL,'42000'),
		('TX13',N'Trà Dâu Tằm Pha Lê Tuyết (L)',NULL,'43200'),
		('TX14',N'Trà Dứa Hồng Hạc (L)',NULL,'44000'),
		('TX15',N'Trà Kiwi Chanh Leo (L)',NULL,'43200'),
		('TX16',N'Trà Xanh Chanh Leo (L)',NULL,'41020'),
		('TX17',N'Trà Dứa Nhiệt Đới (L)',NULL,'43020'),
		('TX18',N'Hồng Long Pha Lê Tuyết (L)',NULL,'45000');
		  
insert into [Voucher]
values	('VC01','NHP28',N'Ngày Hạnh Phúc 28','0.28',10000),
		('VC02','GF50',N'Grab Food','0.5',10000),
		('VC03','NG100',N'Voucher Ngoại Giao','1',1000);
		
		