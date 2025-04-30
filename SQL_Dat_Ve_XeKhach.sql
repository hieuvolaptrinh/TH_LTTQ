IF EXISTS (  
    SELECT name  
    FROM sys.databases  
    WHERE name = 'dbQuanLyVeKhach'  
)  
BEGIN  
    USE master
    ALTER DATABASE dbQuanLyVeKhach SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE dbQuanLyVeKhach;
END  
GO


-- Tạo database
CREATE DATABASE dbQuanLyVeKhach;
GO
USE dbQuanLyVeKhach;
GO

-- Bảng người dùng
CREATE TABLE NGUOIDUNG (
    id_NguoiDung INT PRIMARY KEY IDENTITY(1,1),
    ten_TaiKhoan VARCHAR(50) UNIQUE NOT NULL,
    ho_Ten NVARCHAR(100) NOT NULL, 
    email VARCHAR(100) UNIQUE NOT NULL,
    so_Dien_Thoai CHAR(10), 
    mat_Khau VARCHAR(255) NOT NULL,
 
);

-- Bảng xe buýt
CREATE TABLE XEBUYT (
    id_XeBuyt INT PRIMARY KEY IDENTITY(1,1),
    bien_So VARCHAR(20) UNIQUE NOT NULL, 
    ten_XeBuyt NVARCHAR(100) NOT NULL
);

-- Bến xe
CREATE TABLE BENXE (
    id_BenXe INT PRIMARY KEY IDENTITY(1,1),
    ten_BenXe NVARCHAR(100) NOT NULL,
    dia_Diem NVARCHAR(255)
);

-- Tuyến đường
CREATE TABLE TUYENDUONG (
    id_TuyenDuong INT PRIMARY KEY IDENTITY(1,1),
    id_Ben_XuatPhat INT NOT NULL,
    id_Ben_Dich INT NOT NULL,
    khoang_Cach_Km DECIMAL(10,2) NOT NULL CHECK (khoang_Cach_Km > 0), 
    FOREIGN KEY (id_Ben_XuatPhat) REFERENCES BENXE(id_BenXe),
    FOREIGN KEY (id_Ben_Dich) REFERENCES BENXE(id_BenXe)
);

-- Chuyến đi
CREATE TABLE CHUYENDI (
    id_ChuyenDi INT PRIMARY KEY IDENTITY(1,1),
    id_TuyenDuong INT NOT NULL,
    id_XeBuyt INT NOT NULL,
    gio_Di DATETIME NOT NULL,
    gio_Den DATETIME NOT NULL,
    FOREIGN KEY (id_TuyenDuong) REFERENCES TUYENDUONG(id_TuyenDuong),
    FOREIGN KEY (id_XeBuyt) REFERENCES XEBUYT(id_XeBuyt),
    CHECK (gio_Den > gio_Di) 
);

-- Loại ghế
CREATE TABLE LOAIGHE (
    id_LoaiGhe INT PRIMARY KEY IDENTITY(1,1),
    ten_LoaiGhe NVARCHAR(50) NOT NULL,
    gia_Ve DECIMAL(10,2) NOT NULL CHECK (gia_Ve >= 0) 
);

-- Ghế
CREATE TABLE GHE (
    id_Ghe INT PRIMARY KEY IDENTITY(1,1),
    id_XeBuyt INT NOT NULL,
    id_LoaiGhe INT NOT NULL,
    so_Ghe VARCHAR(10) NOT NULL,
    FOREIGN KEY (id_XeBuyt) REFERENCES XEBUYT(id_XeBuyt),
    FOREIGN KEY (id_LoaiGhe) REFERENCES LOAIGHE(id_LoaiGhe),
    CONSTRAINT UQ_GHE UNIQUE (id_XeBuyt, so_Ghe) 
);

-- Vé
CREATE TABLE VE (
    id_Ve INT PRIMARY KEY IDENTITY(1,1),
    id_ChuyenDi INT NOT NULL,
    id_NguoiDung INT NOT NULL,
    id_Ghe INT NOT NULL,
    ngay_Dat DATETIME DEFAULT GETDATE(), 
    trang_Thai VARCHAR(20) CHECK (trang_Thai IN ('Đã đặt', 'Đã hủy')) DEFAULT 'Đã đặt',
    FOREIGN KEY (id_ChuyenDi) REFERENCES CHUYENDI(id_ChuyenDi),
    FOREIGN KEY (id_NguoiDung) REFERENCES NGUOIDUNG(id_NguoiDung),
    FOREIGN KEY (id_Ghe) REFERENCES GHE(id_Ghe)
);
go
-- 1. Insert vào bảng NGUOIDUNG
INSERT INTO NGUOIDUNG (ten_TaiKhoan, ho_Ten, email, so_Dien_Thoai, mat_Khau) VALUES
('user001', N'Nguyễn Văn An', 'an.nguyen@example.com', '0901234567', '123456'),
('user002', N'Trần Thị Bình', 'binh.tran@example.com', '0912345678', '123456'),
('user003', N'Lê Văn Cường', 'cuong.le@example.com', '0933456789', '123456');

-- 2. Insert vào bảng XEBUYT
INSERT INTO XEBUYT (bien_So, ten_XeBuyt) VALUES
('51B-12345', N'Xe khách Thaco 45 chỗ'),
('51H-67890', N'Xe giường nằm Hyundai'),
('29A-45678', N'Xe khách Samco 35 chỗ');

-- 3. Insert vào bảng BENXE
INSERT INTO BENXE (ten_BenXe, dia_Diem) VALUES
(N'Bến xe Miền Đông', N'292 Đinh Bộ Lĩnh, Quận Bình Thạnh, TP.HCM'),
(N'Bến xe Giáp Bát', N'Km6 Giải Phóng, Quận Hoàng Mai, Hà Nội'),
(N'Bến xe Mỹ Đình', N'20 Phạm Hùng, Quận Nam Từ Liêm, Hà Nội'),
(N'Bến xe Đà Nẵng', N'201 Tôn Đức Thắng, Quận Liên Chiểu, Đà Nẵng');

-- 4. Insert vào bảng TUYENDUONG
INSERT INTO TUYENDUONG (id_Ben_XuatPhat, id_Ben_Dich, khoang_Cach_Km) VALUES
(1, 4, 850.50),  -- Miền Đông -> Đà Nẵng
(2, 3, 20.00),   -- Giáp Bát -> Mỹ Đình
(4, 1, 850.50),  -- Đà Nẵng -> Miền Đông
(3, 2, 20.00);   -- Mỹ Đình -> Giáp Bát

-- 5. Insert vào bảng CHUYENDI
INSERT INTO CHUYENDI (id_TuyenDuong, id_XeBuyt, gio_Di, gio_Den) VALUES
(1, 1, '2025-05-01 08:00:00', '2025-05-01 22:00:00'), -- Miền Đông -> Đà Nẵng
(2, 2, '2025-05-02 07:30:00', '2025-05-02 08:00:00'), -- Giáp Bát -> Mỹ Đình
(3, 3, '2025-05-03 09:00:00', '2025-05-03 23:00:00'); -- Đà Nẵng -> Miền Đông

-- 6. Insert vào bảng LOAIGHE
INSERT INTO LOAIGHE (ten_LoaiGhe, gia_Ve) VALUES
(N'Ghế ngồi thường', 200000.00),
(N'Ghế ngồi VIP', 300000.00),
(N'Giường nằm', 450000.00);

-- 7. Insert vào bảng GHE
INSERT INTO GHE (id_XeBuyt, id_LoaiGhe, so_Ghe) VALUES
(1, 1, 'A01'), (1, 1, 'A02'), (1, 2, 'B01'), -- Xe 1: 2 ghế thường, 1 ghế VIP
(2, 3, 'G01'), (2, 3, 'G02'),               -- Xe 2: 2 giường nằm
(3, 1, 'C01'), (3, 2, 'C02');               -- Xe 3: 1 ghế thường, 1 ghế VIP

-- 8. Insert vào bảng VE
INSERT INTO VE (id_ChuyenDi, id_NguoiDung, id_Ghe, ngay_Dat, trang_Thai) VALUES
(1, 1, 1, '2025-04-30 10:00:00', 'Đã đặt'),   -- User 1 đặt ghế A01 chuyến Miền Đông -> Đà Nẵng
(2, 2, 4, '2025-04-30 11:00:00', 'Đã đặt'),   -- User 2 đặt giường G01 chuyến Giáp Bát -> Mỹ Đình
(3, 3, 7, '2025-04-30 12:00:00', 'Đã hủy');   -- User 3 đặt ghế C02 chuyến Đà Nẵng -> Miền Đông (hủy)