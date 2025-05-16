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
	  FOREIGN KEY (id_TuyenDuong) REFERENCES TUYENDUONG(id_TuyenDuong),
);



-- Vé
CREATE TABLE VE (
    id_Ve INT PRIMARY KEY IDENTITY(1,1),
    id_NguoiDung INT NOT NULL,
    id_XeKhach INT NOT NULL,
    ngay_Dat DATETIME DEFAULT GETDATE(), 
    trang_Thai NVARCHAR(20) CHECK (trang_Thai IN (N'Đã đặt', N'Đã hủy')) DEFAULT N'Đã đặt',
    FOREIGN KEY (id_NguoiDung) REFERENCES NGUOIDUNG(id_NguoiDung),
    FOREIGN KEY (id_XeKhach) REFERENCES XEKHACH(id_XeKhach)
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
INSERT INTO XEKHACH (bien_So, ten_XeKhach, gio_Di, gio_Den, id_TuyenDuong) VALUES
('29B-12345', N'Xe Hoàng Long', '2025-05-02 07:00:00', '2025-05-02 09:30:00', 1),
('51H-67890', N'Xe Mai Linh', '2025-05-02 08:00:00', '2025-05-02 15:00:00', 2),
('43A-11223', N'Xe Phương Trang', '2025-05-02 06:30:00', '2025-05-02 08:00:00', 3),
('16B-44556', N'Xe Thống Nhất', '2025-05-02 09:00:00', '2025-05-02 11:30:00', 4),
('29C-78901', N'Xe Kim Chi', '2025-05-02 05:00:00', '2025-05-02 12:00:00', 5);
go
-- Thêm dữ liệu vào bảng VE
INSERT INTO VE (id_NguoiDung, id_XeKhach, ngay_Dat, trang_Thai) VALUES
(1, 1, '2025-05-01 10:00:00', N'Đã đặt'),
(2, 2, '2025-05-01 11:30:00', N'Đã đặt'),
(3, 3, '2025-05-01 12:00:00', N'Đã hủy'),
(4, 4, '2025-05-01 13:15:00', N'Đã đặt'),
(5, 5, '2025-05-01 14:00:00', N'Đã đặt'),
(1, 3, '2025-05-01 15:00:00', N'Đã đặt'),
(2, 4, '2025-05-01 16:00:00', N'Đã hủy');

select * from VE