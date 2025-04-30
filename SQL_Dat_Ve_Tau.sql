USE master;
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'dbQuanLyVeTau')
BEGIN
    ALTER DATABASE dbQuanLyVeTau SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE dbQuanLyVeTau;
END
GO

CREATE DATABASE dbQuanLyVeTau;
GO
USE dbQuanLyVeTau;
GO
-------------------------------
-- TẠO BẢNG --
-------------------------------
-- Bảng người dùng
CREATE TABLE NGUOIDUNG (
    id_NguoiDung INT PRIMARY KEY IDENTITY(1,1),
	ten_TaiKhoan VARCHAR(50) UNIQUE NOT NULL, -- Username do người dùng đặt
    ho_Ten VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    so_Dien_Thoai VARCHAR(15),
    mat_Khau VARCHAR(255) NOT NULL,
	so_Du DECIMAL NULL,
    loai_NguoiDung VARCHAR(20) CHECK (loai_NguoiDung IN ('khach', 'quantri')) DEFAULT 'khach'
);

-- Bảng tàu
CREATE TABLE TAU (
    id_Tau INT PRIMARY KEY IDENTITY(1,1),
    ten_Tau VARCHAR(100) NOT NULL,
);

-- Bảng ga tàu
CREATE TABLE GATAU (
    id_GaTau INT PRIMARY KEY IDENTITY(1,1),
    ten_GaTau VARCHAR(100) NOT NULL,
    dia_Diem VARCHAR(255),
);

-- Bảng tuyến đường
CREATE TABLE TUYENDUONG (
    id_TuyenDuong INT PRIMARY KEY IDENTITY(1,1),
    id_Ga_XuatPhat INT NOT NULL,
    id_Ga_Dich INT NOT NULL,
    khoang_Cach_Km DECIMAL(10,2) NOT NULL
);

-- Bảng nhân viên
CREATE TABLE NHANVIEN (
    id_NhanVien INT PRIMARY KEY IDENTITY(1,1),
    ho_Ten VARCHAR(100) NOT NULL,
    so_Dien_Thoai VARCHAR(15),
    email VARCHAR(100) UNIQUE NOT NULL,
    chuc_Vu VARCHAR(20) CHECK (chuc_vu IN ('ban_ve', 'kiem_ve', 'quan_ly')) NOT NULL
);

-- Bảng chuyến đi
CREATE TABLE CHUYENDI (
    id_ChuyenDi INT PRIMARY KEY IDENTITY(1,1),
    id_TuyenDuong INT,
    gio_Di DATETIME NOT NULL,
    gio_Den DATETIME NOT NULL,
    id_NhanVien INT,
    FOREIGN KEY (id_TuyenDuong) REFERENCES TUYENDUONG(id_TuyenDuong),
    FOREIGN KEY (id_NhanVien) REFERENCES NHANVIEN(id_NhanVien)
);


-- Bảng loại ghế
CREATE TABLE LOAIGHE (
    id_LoaiGhe INT PRIMARY KEY IDENTITY(1,1),
    ten_loaighe VARCHAR(50) NOT NULL,
    gia_Ve DECIMAL(10,2) NOT NULL
);

-- Bảng toa tàu
CREATE TABLE TOATAU (
    id_ToaTau INT PRIMARY KEY IDENTITY(1,1),
    id_Tau INT,
    id_LoaiGhe INT,
    ten_Toa VARCHAR(50) NOT NULL,
    so_Cho_Ngoi INT NOT NULL,
    FOREIGN KEY (id_Tau) REFERENCES Tau(id_Tau),
    FOREIGN KEY (id_LoaiGhe) REFERENCES LOAIGHE(id_LoaiGhe)
);

-- Bảng vé
CREATE TABLE VE (
    id_Ve INT PRIMARY KEY IDENTITY(1,1),
    id_ChuyenDi INT,
    id_NguoiDung INT,
    id_LoaiGhe INT,
    so_Ghe VARCHAR(10) NOT NULL,
    ngay_dat DATETIME DEFAULT CURRENT_TIMESTAMP,
    trang_thai VARCHAR(20) CHECK (trang_thai IN ('Đã đặt', 'Đã hủy')) DEFAULT 'Đã đặt',
    FOREIGN KEY (id_ChuyenDi) REFERENCES CHUYENDI(id_ChuyenDi),
    FOREIGN KEY (id_NguoiDung) REFERENCES NGUOIDUNG(id_NguoiDung),
    FOREIGN KEY (id_LoaiGhe) REFERENCES LOAIGHE(id_LoaiGhe)
);


-- Bảng lịch sử giao dịch
CREATE TABLE LICHSUGIAODICH (
    id_GiaoDich INT PRIMARY KEY IDENTITY(1,1),
    id_NguoiDung INT,
    thoi_Gian DATETIME DEFAULT CURRENT_TIMESTAMP,
    loai_GiaoDich VARCHAR(20) CHECK (loai_GiaoDich IN ('Đặt vé', 'Hủy vé', 'Hoàn tiền', 'Nạp tiền')) NOT NULL,
	so_Tien DECIMAL NOT NULL,
    FOREIGN KEY (id_NguoiDung) REFERENCES NGUOIDUNG(id_NguoiDung)
);

------------------------------
-- RÀNG BUỘC --
------------------------------
ALTER TABLE TUYENDUONG
	ADD CONSTRAINT FK_Ga_XuatPhat FOREIGN KEY (id_Ga_XuatPhat) REFERENCES GATAU(id_GaTau),
		CONSTRAINT FK_Ga_Dich FOREIGN KEY (id_Ga_Dich) REFERENCES GATAU(id_GaTau);

ALTER TABLE TUYENDUONG
	ADD CONSTRAINT CK_GaKhacNhau CHECK (id_Ga_XuatPhat <> id_Ga_Dich);

ALTER TABLE CHUYENDI
	ADD CONSTRAINT CK_GioDenSauGioDi CHECK (gio_Den > gio_Di);

ALTER TABLE TOATAU
	ADD CONSTRAINT CK_SoChoHopLe CHECK (so_Cho_Ngoi > 0);

ALTER TABLE LOAIGHE
	ADD CONSTRAINT CK_GiaVeDuong CHECK (gia_Ve >= 0);

ALTER TABLE TUYENDUONG
	ADD CONSTRAINT CK_KhoangCachDuong CHECK (khoang_Cach_Km >= 0);


-- Thêm dữ liệu bảng NGUOIDUNG
INSERT INTO NGUOIDUNG (ten_TaiKhoan, ho_Ten, email, so_Dien_Thoai, mat_Khau, loai_NguoiDung) VALUES
('nguyenvana', 'Nguyen Van A', 'a@gmail.com', '0912345678', 'matkhau1', 'khach'),
('tranthib', 'Tran Thi B', 'b@gmail.com', '0912345679', 'matkhau2', 'khach'),
('levanc', 'Le Van C', 'c@gmail.com', '0912345680', 'matkhau3', 'khach'),
('phamthid', 'Pham Thi D', 'd@gmail.com', '0912345681', 'matkhau4', 'khach'),
('dovane', 'Do Van E', 'e@gmail.com', '0912345682', 'matkhau5', 'khach'),
('nguyenvanf', 'Nguyen Van F', 'f@gmail.com', '0912345683', 'matkhau6', 'nhanvien'),
('tranthig', 'Tran Thi G', 'g@gmail.com', '0912345684', 'matkhau7', 'nhanvien'),
('levanh', 'Le Van H', 'h@gmail.com', '0912345685', 'matkhau8', 'quantri'),
('phamthii', 'Pham Thi I', 'i@gmail.com', '0912345686', 'matkhau9', 'khach'),
('dovanj', 'Do Van J', 'j@gmail.com', '0912345687', 'matkhau10', 'khach');


--Thêm dữ liệu bảng
INSERT INTO TAU (ten_Tau) VALUES
('SE1'), ('SE2'), ('SE3'), ('SE4'), ('SE5'),
('TN1'), ('TN2'), ('TN3'), ('TN4'), ('TN5');

INSERT INTO GATAU (ten_GaTau, dia_Diem) VALUES
('Ga Ha Noi', 'Ha Noi'),
('Ga Hue', 'Hue'),
('Ga Sai Gon', 'TP.HCM'),
('Ga Da Nang', 'Da Nang'),
('Ga Vinh', 'Nghe An'),
('Ga Nha Trang', 'Khanh Hoa'),
('Ga Dong Hoi', 'Quang Binh'),
('Ga Bien Hoa', 'Dong Nai'),
('Ga Quy Nhon', 'Binh Dinh'),
('Ga Thanh Hoa', 'Thanh Hoa');


INSERT INTO TUYENDUONG (id_Ga_XuatPhat, id_Ga_Dich, khoang_Cach_Km) VALUES
(1, 3, 1726.5),
(1, 4, 764.3),
(3, 2, 1120.4),
(4, 5, 325.0),
(2, 3, 1123.6),
(6, 3, 411.2),
(1, 2, 668.5),
(2, 6, 500.0),
(5, 7, 300.0),
(3, 8, 38.0);


INSERT INTO NHANVIEN (ho_Ten, so_Dien_Thoai, email, chuc_Vu) VALUES
('Nguyen Van NV1', '0911111111', 'nv1@gmail.com', 'ban_ve'),
('Nguyen Van NV2', '0911111112', 'nv2@gmail.com', 'kiem_ve'),
('Nguyen Van NV3', '0911111113', 'nv3@gmail.com', 'quan_ly'),
('Nguyen Van NV4', '0911111114', 'nv4@gmail.com', 'ban_ve'),
('Nguyen Van NV5', '0911111115', 'nv5@gmail.com', 'kiem_ve'),
('Nguyen Van NV6', '0911111116', 'nv6@gmail.com', 'quan_ly'),
('Nguyen Van NV7', '0911111117', 'nv7@gmail.com', 'ban_ve'),
('Nguyen Van NV8', '0911111118', 'nv8@gmail.com', 'kiem_ve'),
('Nguyen Van NV9', '0911111119', 'nv9@gmail.com', 'quan_ly'),
('Nguyen Van NV10', '0911111120', 'nv10@gmail.com', 'ban_ve');


INSERT INTO CHUYENDI (id_TuyenDuong, gio_Di, gio_Den, id_NhanVien) VALUES
(1, '2025-04-18 06:00', '2025-04-18 20:00', 1),
(2, '2025-04-18 07:30', '2025-04-18 15:30', 2),
(3, '2025-04-18 08:00', '2025-04-18 21:00', 3),
(4, '2025-04-19 09:00', '2025-04-19 13:00', 4),
(5, '2025-04-19 10:00', '2025-04-19 22:00', 5),
(6, '2025-04-20 06:30', '2025-04-20 12:00', 6),
(7, '2025-04-20 07:00', '2025-04-20 11:30', 7),
(8, '2025-04-21 08:00', '2025-04-21 13:00', 8),
(9, '2025-04-21 09:00', '2025-04-21 11:00', 9),
(10, '2025-04-22 10:00', '2025-04-22 11:00', 10);


INSERT INTO LOAIGHE (ten_loaighe, gia_Ve) VALUES
('Ghế cứng', 150000),
('Ghế mềm', 200000),
('Nằm điều hòa', 300000),
('Nằm khoang 4', 400000),
('Nằm khoang 6', 350000),
('VIP', 600000),
('Ghế mềm điều hòa', 250000),
('Giường tầng', 450000),
('Ghế du lịch', 180000),
('Luxury', 700000);


INSERT INTO TOATAU (id_Tau, id_LoaiGhe, ten_Toa, so_Cho_Ngoi) VALUES
(1, 1, 'A1', 64),
(1, 2, 'A2', 56),
(1, 3, 'B1', 48),
(2, 4, 'B2', 40),
(2, 5, 'C1', 60),
(2, 6, 'C2', 30),
(3, 7, 'D1', 50),
(3, 8, 'D2', 44),
(4, 9, 'E1', 52),
(4, 10, 'E2', 32);


INSERT INTO VE (id_ChuyenDi, id_NguoiDung, id_LoaiGhe, so_Ghe) VALUES
(1, 1, 1, 'A1-01'),
(1, 2, 2, 'A2-03'),
(2, 3, 3, 'B1-05'),
(3, 4, 4, 'B2-01'),
(4, 5, 5, 'C1-10'),
(5, 6, 6, 'C2-02'),
(6, 7, 7, 'D1-20'),
(7, 8, 8, 'D2-15'),
(8, 9, 9, 'E1-08'),
(9, 10, 10, 'E2-05');


INSERT INTO LICHSUGIAODICH (id_NguoiDung, loai_GiaoDich) VALUES
(1, 'Đặt vé'),
(2, 'Đặt vé'),
(3, 'Hủy vé'),
(4, 'Đặt vé'),
(5, 'Hoàn tiền'),
(6, 'Đặt vé'),
(7, 'Đặt vé'),
(8, 'Hủy vé'),
(9, 'Đặt vé'),
(10, 'Hoàn tiền');


SELECT dbo.Ve.* FROM dbo.Ve
JOIN dbo.NguoiDung ON NguoiDung.id_nguoidung = Ve.id_nguoidung
WHERE NguoiDung.ho_ten = 'Nguyen Van A'