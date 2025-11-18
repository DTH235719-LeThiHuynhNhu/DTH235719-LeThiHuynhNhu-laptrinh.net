CREATE DATABASE QLHS;
GO

USE QLHS;
GO

CREATE TABLE quequan (
    maqq CHAR(10) PRIMARY KEY,
    tenqq NVARCHAR(50) NOT NULL
);

CREATE TABLE hocsinh (
    mahs CHAR(10) PRIMARY KEY,
    holot NVARCHAR(30),
    tenhs NVARCHAR(20),
    phai NVARCHAR(5),
    ngaysinh DATE,
    maqq CHAR(10),
    FOREIGN KEY (maqq) REFERENCES quequan(maqq)
);

INSERT INTO quequan (maqq, tenqq) VALUES
('AG', N'An Giang'),
('CT', N'Cần Thơ'),
('DT', N'Đồng Tháp'),
('TG', N'Tiền Giang'),
('VL', N'Vĩnh Long');

INSERT INTO hocsinh (mahs, holot, tenhs, phai, ngaysinh, maqq) VALUES
('HS001', N'Trần Văn', N'Hùng', N'Nam', '2003-05-22', 'CT'),
('HS002', N'Lê Văn', N'Ba', N'Nam', '2002-03-12', 'AG'),
('HS003', N'Nguyễn Trúc', N'Mai', N'Nữ', '2002-08-15', 'DT');

SELECT * FROM quequan;
SELECT * FROM hocsinh;
