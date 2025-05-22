IF EXISTS (  
    SELECT name  
    FROM sys.databases  
    WHERE name = 'QuanLyVeKhach'  
)  
BEGIN  
    USE master
    ALTER DATABASE QuanLyVeKhach SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyVeKhach;
END  
GO


-- Tạo database
CREATE DATABASE QuanLyVeKhach;
GO
USE QuanLyVeKhach;
GO

-- Bảng người dùng
CREATE TABLE NGUOIDUNG (
    id_NguoiDung INT PRIMARY KEY IDENTITY(1,1),
    ten_TaiKhoan VARCHAR(50) UNIQUE NOT NULL,
    ho_Ten NVARCHAR(100) NOT NULL, 
    so_Dien_Thoai CHAR(10), 
    mat_Khau VARCHAR(255) NOT NULL,
    loai_TaiKhoan VARCHAR(20) NOT NULL 
);
-- Tuyến đường
CREATE TABLE TUYENDUONG (
    id_TuyenDuong INT PRIMARY KEY IDENTITY(1,1),
    khoang_Cach_Km DECIMAL(10,2) NOT NULL CHECK (khoang_Cach_Km > 0), 
    diem_di nvarchar(200),
	diem_den nvarchar(200)
);

-- Bảng xe khach
CREATE TABLE XEKHACH (
    id_XeKhach INT PRIMARY KEY IDENTITY(1,1) ,
    bien_So VARCHAR(20) UNIQUE NOT NULL, 
    ten_XeKhach NVARCHAR(100) NOT NULL,
	gio_Di DATETIME NOT NULL,
    gio_Den DATETIME NOT NULL,
    gia_Ve MONEY,
	id_TuyenDuong INT ,
	  FOREIGN KEY (id_TuyenDuong) REFERENCES TUYENDUONG(id_TuyenDuong)  ON DELETE CASCADE
        ON UPDATE CASCADE
);



-- Vé
CREATE TABLE VE (
    id_Ve INT PRIMARY KEY IDENTITY(1,1),
    id_NguoiDung INT NOT NULL,
    id_XeKhach INT NOT NULL,
    ngay_Dat DATETIME DEFAULT GETDATE(), 
    trang_Thai NVARCHAR(20) CHECK (trang_Thai IN (N'Đã đặt', N'Đã hủy')) DEFAULT N'Đã đặt',
    FOREIGN KEY (id_NguoiDung) REFERENCES NGUOIDUNG(id_NguoiDung),
    FOREIGN KEY (id_XeKhach) REFERENCES XEKHACH(id_XeKhach) ON DELETE CASCADE
        ON UPDATE CASCADE
);
go
GO

-- Thêm dữ liệu vào bảng NGUOIDUNG
INSERT INTO NGUOIDUNG (ten_TaiKhoan, ho_Ten, so_Dien_Thoai, mat_Khau, loai_TaiKhoan) VALUES
('user1', N'Nguyễn Văn An', '0901234567', '1', 'user'),
('user2', N'Trần Thị Bình', '0912345678', '2', 'user'),
('user3', N'Lê Minh Cường', '0923456789', '3', 'user'),
('user4', N'Phạm Thị Dung',  '0934567890', '4', 'user'),
('user5', N'Phạm Thị Hiền',  '0934567891', '5', 'user'),
('admin1', N'Nguyễn Minh Vỹ', '0900000001', '1', 'admin'),
('admin2', N'Nguyễn Nữ Khánh Ngọc', '0900000002', '2', 'admin'),
('admin3', N'Võ Nguyễn Đại Hiếu', '0900000003', '3', 'admin'),
('admin4', N'Nguyễn Hữu Hoàng', '0900000004', '4', 'admin');
GO
go
-- Thêm dữ liệu vào bảng TUYENDUONG
INSERT INTO TUYENDUONG (khoang_Cach_Km, diem_di, diem_den) VALUES
(120.50, N'Hà Nội', N'Hải Phòng'),
(350.75, N'Hà Nội', N'Đà Nẵng'),
(80.25, N'Sài Gòn', N'Vũng Tàu'),
(200.00, N'Đà Nẵng', N'Huế'),
(450.30, N'Hà Nội', N'Nghệ An');
go
-- Thêm dữ liệu vào bảng XEKHACH
INSERT INTO XEKHACH (bien_So, ten_XeKhach, gio_Di, gio_Den,gia_Ve ,id_TuyenDuong) VALUES
('29B-12345', N'Xe Hoàng Long', '2025-05-25 07:00:00', '2025-05-25 09:30:00',120000, 1),
('51H-67890', N'Xe Mai Linh', '2025-05-26 08:00:00', '2025-05-26 15:00:00',115000 ,2),
('43A-11223', N'Xe Phương Trang', '2025-05-27 06:30:00', '2025-05-27 08:00:00', 250000,3),
('16B-44556', N'Xe Thống Nhất', '2025-05-28 09:00:00', '2025-05-28 11:30:00',200000 ,4),
('29C-78901', N'Xe Kim Chi', '2025-05-02 05:00:00', '2025-05-02 12:00:00',175000 ,5);
go
-- Thêm dữ liệu vào bảng VE
INSERT INTO VE (id_NguoiDung, id_XeKhach, ngay_Dat, trang_Thai) VALUES
(1, 1, '2023-01-10 08:00:00', N'Đã đặt'),
(2, 2, '2023-01-15 09:00:00', N'Đã hủy'),
(3, 3, '2023-02-05 07:00:00', N'Đã đặt'),
(4, 4, '2023-02-20 10:00:00', N'Đã đặt'),
(5, 5, '2023-03-01 11:30:00', N'Đã hủy'),
(1, 2, '2023-03-15 12:45:00', N'Đã đặt'),
(2, 3, '2023-04-03 14:00:00', N'Đã đặt'),
(3, 4, '2023-04-18 15:30:00', N'Đã hủy'),
(4, 5, '2023-05-10 09:00:00', N'Đã đặt'),
(5, 1, '2023-06-22 10:15:00', N'Đã đặt'),
(1, 3, '2023-07-05 08:30:00', N'Đã hủy'),
(2, 4, '2023-07-25 09:45:00', N'Đã đặt'),
(3, 5, '2023-08-12 11:00:00', N'Đã đặt'),
(4, 1, '2023-09-01 12:15:00', N'Đã hủy'),
(5, 2, '2023-10-19 13:30:00', N'Đã đặt'),
(1, 3, '2023-11-03 14:45:00', N'Đã đặt'),
(2, 4, '2023-12-27 15:00:00', N'Đã đặt'),

-- Năm 2024
(3, 1, '2024-01-10 08:00:00', N'Đã hủy'),
(4, 2, '2024-02-14 09:00:00', N'Đã đặt'),
(5, 3, '2024-03-08 10:30:00', N'Đã đặt'),
(1, 4, '2024-04-01 11:00:00', N'Đã đặt'),
(2, 5, '2024-05-15 12:15:00', N'Đã hủy'),
(3, 1, '2024-06-20 13:30:00', N'Đã đặt'),
(4, 2, '2024-07-04 14:45:00', N'Đã đặt'),
(5, 3, '2024-08-22 15:00:00', N'Đã đặt'),
(1, 4, '2024-09-10 16:15:00', N'Đã hủy'),
(2, 5, '2024-10-30 08:00:00', N'Đã đặt'),
(3, 1, '2024-11-12 09:15:00', N'Đã đặt'),
(4, 2, '2024-12-05 10:30:00', N'Đã đặt'),

-- Năm 2025
(5, 3, '2025-01-01 11:45:00', N'Đã đặt'),
(1, 4, '2025-01-17 13:00:00', N'Đã hủy'),
(2, 5, '2025-02-08 14:15:00', N'Đã đặt'),
(3, 1, '2025-02-22 15:30:00', N'Đã đặt'),
(4, 2, '2025-03-03 08:45:00', N'Đã hủy'),
(5, 3, '2025-03-19 10:00:00', N'Đã đặt'),
(1, 4, '2025-04-07 11:15:00', N'Đã đặt'),
(2, 5, '2025-04-25 12:30:00', N'Đã đặt'),
(3, 1, '2025-05-10 13:45:00', N'Đã hủy'),
(4, 2, '2025-05-20 15:00:00', N'Đã đặt'),
(5, 3, '2025-06-01 16:15:00', N'Đã đặt'),
(1, 4, '2025-06-15 08:00:00', N'Đã đặt'),
(2, 5, '2025-07-09 09:30:00', N'Đã hủy'),
(3, 1, '2025-07-21 10:45:00', N'Đã đặt'),
(4, 2, '2025-08-14 12:00:00', N'Đã đặt'),
(5, 3, '2025-08-28 13:15:00', N'Đã đặt'),
(1, 4, '2025-09-05 14:30:00', N'Đã hủy'),
(2, 5, '2025-09-25 15:45:00', N'Đã đặt'),
(3, 1, '2025-10-10 08:00:00', N'Đã đặt'),
(4, 2, '2025-10-22 09:15:00', N'Đã đặt'),
(5, 3, '2025-11-03 10:30:00', N'Đã đặt'),
(1, 4, '2025-11-18 11:45:00', N'Đã hủy'),
(2, 5, '2025-12-01 13:00:00', N'Đã đặt'),
(3, 1, '2025-12-24 14:15:00', N'Đã đặt');

select * from VE
select * from TUYENDUONG