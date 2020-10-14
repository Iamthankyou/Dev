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
  TongTien FLOAT NOT NULL,
  PRIMARY KEY (ID_HoaDon)
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
  PhanTram INT NOT NULL,
  SoLuong INT NOT NULL,
  ID_KhachHang NVARCHAR(10) NOT NULL,
  PRIMARY KEY (ID_Voucher),
  FOREIGN KEY (ID_KhachHang) REFERENCES KhachHang(ID_KhachHang)
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