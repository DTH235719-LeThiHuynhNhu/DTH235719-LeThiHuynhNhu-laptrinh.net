-- Tạo cơ sở dữ liệu QLNV
CREATE DATABASE QLNV;
GO

USE QLNV;
GO

-- ==========================
-- 1. Bảng CHUCVU
-- ==========================
CREATE TABLE chucvu (
    macv NVARCHAR(5) PRIMARY KEY,
    tencv NVARCHAR(50),
    hsphucap FLOAT
);
GO

-- Dữ liệu mẫu cho bảng CHUCVU
INSERT INTO chucvu VALUES ('CV01', N'Trưởng phòng', 2.0);
INSERT INTO chucvu VALUES ('CV02', N'Phó trưởng phòng', 1.5);
INSERT INTO chucvu VALUES ('CV03', N'Nhân viên chuyên trách', 1.2);
INSERT INTO chucvu VALUES ('CV04', N'Lái xe cơ quan', 1.0);
INSERT INTO chucvu VALUES ('CV05', N'Kế toán', 1.3);
GO

-- ==========================
-- 2. Bảng NHANVIEN
-- ==========================
CREATE TABLE nhanvien (
    manv NVARCHAR(5) PRIMARY KEY,
    holot NVARCHAR(50),
    tennv NVARCHAR(10),
    phai NVARCHAR(3),
    ngaysinh SMALLDATETIME,
    macv NVARCHAR(5)
        REFERENCES chucvu(macv)
);
GO

-- Dữ liệu mẫu cho bảng NHANVIEN
INSERT INTO nhanvien VALUES ('NV001', N'Nguyễn Phước', N'Minh Tân', N'Nam', '1975-04-19', 'CV01');
INSERT INTO nhanvien VALUES ('NV004', N'Lý', N'Sang', N'Nam', '1970-12-21', 'CV03');
INSERT INTO nhanvien VALUES ('NV005', N'Nguyễn Thị', N'Thu An', N'Nữ', '1981-08-22', 'CV02');
INSERT INTO nhanvien VALUES ('NV007', N'Nguyễn', N'Thanh Tùng', N'Nam', '1977-07-07', 'CV04');
INSERT INTO nhanvien VALUES ('NV008', N'Trần Văn', N'Sơn', N'Nam', '1978-07-08', 'CV03');
INSERT INTO nhanvien VALUES ('NV009', N'Cao Thị', N'Ngọc Hằng', N'Nữ', '1980-08-18', 'CV05');
INSERT INTO nhanvien VALUES ('NV010', N'Lê Thành', N'Tân', N'Nam', '1984-05-04', 'CV03');
INSERT INTO nhanvien VALUES ('NV011', N'Phan Thị', N'Thủy Tiên', N'Nữ', '1987-10-25', 'CV05');
GO

-- ==========================
-- 3. Bảng QUATRINHLUONG
-- ==========================
CREATE TABLE quatrinhluong (
    manv NVARCHAR(5),
    ngaybd SMALLDATETIME,
    hsluong FLOAT,
    ghichu NVARCHAR(100),
    PRIMARY KEY (manv, ngaybd),
    FOREIGN KEY (manv) REFERENCES nhanvien(manv)
);
GO

-- Dữ liệu mẫu cho bảng QUATRINHLUONG
INSERT INTO quatrinhluong VALUES ('NV001', '2020-01-01', 4.5, N'Lương hiện tại');
INSERT INTO quatrinhluong VALUES ('NV004', '2021-01-01', 3.2, N'Đang thử việc');
INSERT INTO quatrinhluong VALUES ('NV005', '2020-07-01', 3.8, N'Chính thức');
INSERT INTO quatrinhluong VALUES ('NV007', '2019-03-01', 2.9, N'Lái xe');
INSERT INTO quatrinhluong VALUES ('NV008', '2020-05-01', 3.1, N'Tổ nhân sự');
INSERT INTO quatrinhluong VALUES ('NV009', '2020-09-01', 3.4, N'Phòng kế toán');
INSERT INTO quatrinhluong VALUES ('NV010', '2021-02-01', 2.8, N'Nhân viên mới');
INSERT INTO quatrinhluong VALUES ('NV011', '2019-12-01', 3.3, N'Phòng kế toán');
GO

-- Kiểm tra dữ liệu
SELECT * FROM chucvu;
SELECT * FROM nhanvien;
SELECT * FROM quatrinhluong;
GO
