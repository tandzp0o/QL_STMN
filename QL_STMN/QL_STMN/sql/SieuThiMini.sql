USE MASTER
GO
alter database SieuThiMini set single_user with rollback immediate

DROP DATABASE SieuThiMini
GO

CREATE DATABASE SieuThiMini 
GO
USE SieuThiMini
GO	

--	Bảng tài khoản																	
CREATE TABLE TaiKhoan
(
	TaiKhoan VARCHAR(25) PRIMARY KEY,
	MatKhau VARCHAR(25),
	MaNV  VARCHAR(10)  UNIQUE
)
GO	

--Bảng Chức vụ
CREATE TABLE ChucVu
(
	MaCV VARCHAR(10) PRIMARY KEY,
	TenCV NVARCHAR(200)
)
GO	

--Bảng Nhân viên
CREATE TABLE NhanVien
(
	MaNV VARCHAR(10)  PRIMARY KEY,
	TenNV NVARCHAR(50),
	GioiTinh NVARCHAR(10),
	NamSinh DATE,
	SDT_NV VARCHAR(12),
	DiaChi_NV NVARCHAR(200),
	MaCV VARCHAR(10)
)
GO

--Bảng Khách hàng
CREATE TABLE KhachHang
(
	MaKH VARCHAR(10) PRIMARY KEY,
	TenKH NVARCHAR(50),
	SDT_KH VARCHAR(12),
	DiaChi_KH NVARCHAR(200)
)
GO

--Bảng nhà cung cấp
CREATE TABLE NhaCungCap
(
	MaNCC VARCHAR(10) PRIMARY KEY,
	TenNCC NVARCHAR(50),
	DiaChi_NCC NVARCHAR(200)
)
GO

--Bảng loại hàng hoá
CREATE TABLE LoaiHangHoa
(
	MaLoaiHH VARCHAR(10) PRIMARY KEY,
	TenLoaiHH NVARCHAR(200)
)
GO

--Bảng hàng hoá
CREATE TABLE HangHoa
(
	MaHH VARCHAR(10) PRIMARY KEY,
	TenHH NVARCHAR(200),
	DVT NVARCHAR(20),
	GiaNhap FLOAT,
	GiaBan FLOAT,
	SoLuong FLOAT,
	MaloaiHH VARCHAR(10),
	MaNCC VARCHAR(10)
)
GO

--Bảng Phiếu giảm giá
CREATE TABLE PhieuGiamGia
(
	MaPGG VARCHAR(10) PRIMARY KEY,
	TenPGG NVARCHAR(50),
	NgayBD DATE,
	NgayKT DATE,
	GiaTriGG FLOAT,
	GhiChu NVARCHAR(200)
)
GO

--Bảng phiếu nhập hàng
CREATE TABLE PhieuNhapHang
(
	MaPhieuNhap VARCHAR(10) PRIMARY KEY,
	NgayNhap DATE,
	TienNhapHang FLOAT,
	GhiChu NVARCHAR(200),
	MaNV VARCHAR(10)
)
GO

--Bảng chi tiết nhập hàng
CREATE TABLE ChiTietNhapHang
(
	MaPhieuNhap VARCHAR(10),
	MaHH VARCHAR(10),
	GiaNhap FLOAT,
	SoLuong FLOAT,
	ThanhTien FLOAT,
	PRIMARY KEY(MaPhieuNhap,MaHH)
)
GO

--Bảng phiếu bán hàng
CREATE TABLE PhieuBanHang
(
	MaBanHang VARCHAR(10) PRIMARY KEY,
	MaNV VARCHAR(10),
	MaPGG VARCHAR(10),
	MaKH VARCHAR(10),
	NgayBH DATETIME,
	GhiChu NVARCHAR(200),
	TongTien FLOAT
) 
GO

--Bảng chi tiết bán hàng
CREATE TABLE ChiTietBanHang
(
	MaBanHang VARCHAR(10),
	MaHH VARCHAR(10),
	GiaBan FLOAT,
	SoLuong FLOAT,
	ThanhTien FLOAT,
	PRIMARY KEY(MaBanHang,MaHH)
)
GO

-- Ràng buộc khoá ngoại 
--Bảng Nhân viên
ALTER TABLE dbo.NhanVien
ADD CONSTRAINT Fk_NhanVien_ChucVu FOREIGN KEY(MaCV) REFERENCES dbo.ChucVu(MaCV)
GO

--Bảng tài khoản
ALTER TABLE dbo.TaiKhoan
ADD CONSTRAINT Fk_TaiKhoan_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV)
GO

--Bảng Hàng hoá
ALTER TABLE dbo.HangHoa
ADD CONSTRAINT Fk_HangHoa_LoaiHangHoa FOREIGN KEY(MaloaiHH) REFERENCES dbo.LoaiHangHoa(MaLoaiHH)
GO
ALTER TABLE dbo.HangHoa
ADD CONSTRAINT Fk_HangHoa_NhaCungCap FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC)
GO

--Bảng phiếu bán hàng
ALTER TABLE dbo.PhieuBanHang
ADD CONSTRAINT Fk_PhieuBanHang_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV)
GO
ALTER TABLE dbo.PhieuBanHang
ADD CONSTRAINT Fk_PhieuBanHang_KhachHang FOREIGN KEY(MaKH) REFERENCES dbo.KhachHang(MaKH)
GO
ALTER TABLE dbo.PhieuBanHang
ADD CONSTRAINT Fk_PhieuBanHang_PhieuGiamGia FOREIGN KEY(MaPGG)REFERENCES dbo.PhieuGiamGia(MaPGG)
GO

--Bảng Chi tiết bán hàng
ALTER TABLE dbo.ChiTietBanHang
ADD CONSTRAINT Fk_ChiTietBanHang_BanHang FOREIGN KEY (MaBanHang) REFERENCES dbo.PhieuBanHang(MaBanHang)
GO
ALTER TABLE dbo.ChiTietBanHang
ADD CONSTRAINT Fk_PhieuBanHang_HangHoa FOREIGN KEY(MaHH) REFERENCES dbo.HangHoa(MaHH)
GO

--Bảng Phiếu nhập hàng
ALTER TABLE dbo.PhieuNhapHang
ADD CONSTRAINT Fk_PhieuNhapHang_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV)
GO

--Bảng Chi tiết nhập hàng
ALTER TABLE dbo.ChiTietNhapHang
ADD CONSTRAINT Fk_ChiTietNhapHang_PhieuNhapHang FOREIGN KEY(MaPhieuNhap) REFERENCES dbo.PhieuNhapHang(MaPhieuNhap)
GO
ALTER TABLE dbo.ChiTietNhapHang
ADD CONSTRAINT Fk_ChitietNhapHang_HangHoa FOREIGN KEY(MaHH) REFERENCES dbo.HangHoa(MaHH)
GO

----Một số ràng buộc khác
--Trigger kiểm tra ngày bắt đầu và ngày kết thúc của một mã giảm giá
CREATE TRIGGER Trg_CheckNgayBDNgayKT
ON PhieuGiamGia
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @MaPGG VARCHAR(10);
    DECLARE @NgayBD DATE;
    DECLARE @NgayKT DATE;

    SELECT @MaPGG = MaPGG, @NgayBD = NgayBD, @NgayKT = NgayKT
    FROM inserted;

    IF @NgayBD > @NgayKT
    BEGIN
        PRINT('NgayBD phai nho hon NgayKT.')
        ROLLBACK TRANSACTION
    END
END
GO

--Trigger cập nhật giá nhập vào table ChiTietPhieuNhap từ table HangHoa
CREATE TRIGGER Trg_CapNhatGiaNhap
ON ChiTietNhapHang
FOR INSERT, UPDATE
AS 
BEGIN
    UPDATE ctn
    SET ctn.GiaNhap = hh.GiaNhap
    FROM ChiTietNhapHang AS ctn
    INNER JOIN inserted AS i ON ctn.MaPhieuNhap = i.MaPhieuNhap
    INNER JOIN HangHoa AS hh ON ctn.MaHH = hh.MaHH;
END;
GO

--
-- Tạo trigger sau khi thêm dữ liệu vào ChiTietNhapHang
CREATE TRIGGER UpdateThanhTien_NhapHang
ON ChiTietNhapHang
AFTER INSERT
AS
BEGIN
    -- Cập nhật cột ThanhTien dựa trên dữ liệu từ bảng HangHoa
    UPDATE ChiTietNhapHang
    SET ThanhTien = i.GiaNhap * i.SoLuong
    FROM ChiTietNhapHang AS c
    JOIN inserted AS i ON c.MaPhieuNhap = i.MaPhieuNhap AND c.MaHH = i.MaHH
END;
GO

--Cập nhật tổng tiền của bảng phiếu bán hàng
CREATE TRIGGER UpdateTongTien_BanHang
ON ChiTietBanHang
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	Declare @gt varchar(10);
	Select @gt = MaPGG
	From PhieuBanHang
	IF @gt != 'NULL'
	BEGIN
		UPDATE PhieuBanHang
		SET TongTien = (
							SELECT SUM(ThanhTien)
							FROM ChiTietBanHang
							WHERE ChiTietBanHang.MaBanHang = PhieuBanHang.MaBanHang
						)
						- 
						(
							SELECT SUM(ThanhTien)
							FROM ChiTietBanHang
							WHERE ChiTietBanHang.MaBanHang = PhieuBanHang.MaBanHang
						)
						*
						(
							SELECT GiaTriGG 
							FROM PhieuGiamGia 
							WHERE PhieuGiamGia.MaPGG = PhieuBanHang.MaPGG
						) 
						/ 100 
		WHERE EXISTS (
			SELECT 1
			FROM inserted
			WHERE inserted.MaBanHang = PhieuBanHang.MaBanHang
		);
		END
	ELSE
	BEGIN
		UPDATE PhieuBanHang
		SET TongTien = (
							SELECT SUM(ThanhTien)
							FROM ChiTietBanHang
							WHERE ChiTietBanHang.MaBanHang = PhieuBanHang.MaBanHang
						)
		WHERE EXISTS (
			SELECT 1
			FROM inserted
			WHERE inserted.MaBanHang = PhieuBanHang.MaBanHang
		);
	END

    --WHERE EXISTS (
    --    SELECT 1
    --    FROM inserted
    --    WHERE inserted.MaBanHang = PhieuBanHang.MaBanHang
    --);
END; 
GO

--Cập nhật tổng tiền của bảng phiếu nhập hàng
CREATE TRIGGER	UpdateTongTien_NhapHang
ON ChiTietNhapHang
AFTER INSERT, UPDATE, DELETE
AS 
BEGIN
	UPDATE dbo.PhieuNhapHang
	SET TienNhapHang=	(
		SELECT SUM(ThanhTien)
		FROM dbo.ChiTietNhapHang
		WHERE dbo.PhieuNhapHang.MaPhieuNhap=dbo.ChiTietNhapHang.MaPhieuNhap
	)
	WHERE EXISTS (
        SELECT 1
        FROM inserted
        WHERE inserted.MaPhieuNhap = dbo.PhieuNhapHang.MaPhieuNhap
    );
END
GO

-- Tạo Trigger để cập nhật cột ThanhTien_BanHang
CREATE TRIGGER UpdateThanhTien_BanHang
ON ChiTietBanHang
AFTER INSERT, UPDATE
AS
BEGIN
    -- Cập nhật cột ThanhTien bằng cách nhân GiaBan và SoLuong
    UPDATE ChiTietBanHang
    SET ThanhTien = inserted.GiaBan * inserted.SoLuong
    FROM ChiTietBanHang
    INNER JOIN inserted ON ChiTietBanHang.MaBanHang = inserted.MaBanHang AND ChiTietBanHang.MaHH = inserted.MaHH;
END;
GO

--Giảm số lượng tồn trong bảng HangHoa khi hàng hóa đó đc bán đi
Create trigger trg_ChiTietBanHang on dbo.ChiTietBanHang after insert as
Begin 
	Update dbo.HangHoa
	Set SoLuong = dbo.HangHoa.SoLuong - (
		Select SoLuong 
		From inserted
		Where MaHH = dbo.HangHoa.MaHH)
	From dbo.HangHoa
	join inserted on dbo.HangHoa.MaHH = inserted.MaHH
End
go
--Tăng số lượng tồn trong bảng HangHoa khi nhập thêm hàng hóa đó về
Create trigger trg_ChiTietNhapHang on dbo.ChiTietNhapHang after insert as
Begin 
	Update dbo.HangHoa
	Set SoLuong = dbo.HangHoa.SoLuong + (
		Select SoLuong 
		From inserted
		Where MaHH = dbo.HangHoa.MaHH)
	From dbo.HangHoa
	join inserted on dbo.HangHoa.MaHH = inserted.MaHH
End
GO

--Function tính doanh thu theo tháng
CREATE FUNCTION dbo.DoanhThuThang(@Thang INT)
RETURNS FLOAT
AS
BEGIN
    DECLARE @DoanhThu FLOAT;
    SELECT @DoanhThu = SUM(TongTien)
    FROM PhieuBanHang
    WHERE MONTH(NgayBH) = @Thang and YEAR(NgayBH) = YEAR(GETDATE());
    RETURN @DoanhThu;
END;
go

--function trả về doanh thu theo từng tháng
CREATE FUNCTION dbo.DoanhThu()
RETURNS TABLE
AS
RETURN (
    SELECT Thang, dbo.DoanhThuThang(Thang) AS DoanhThu
    FROM (
        VALUES (1), (2), (3), (4), (5), (6),
               (7), (8), (9), (10), (11), (12)
    ) AS Thang(Thang)
);
go

--Function tính chi theo tháng
CREATE FUNCTION dbo.ChiThang(@Thang INT)
RETURNS FLOAT
AS
BEGIN
    DECLARE @Chi FLOAT;
    SELECT @Chi = SUM(TienNhapHang)
    FROM PhieuNhapHang
    WHERE MONTH(NgayNhap) = @Thang and YEAR(NgayNhap) = YEAR(GETDATE());
    RETURN @Chi;
END;
go
--function trả về chi theo từng tháng
CREATE FUNCTION dbo.Chi()
RETURNS TABLE
AS
RETURN (
    SELECT Thang, dbo.ChiThang(Thang) AS Chi
    FROM (
        VALUES (1), (2), (3), (4), (5), (6),
               (7), (8), (9), (10), (11), (12)
    ) AS Thang(Thang)
);
go
--function tính doanh thu theo ngày
CREATE FUNCTION dbo.DoanhThuNgay(@NgayBatDau date, @NgayKetThuc date)
RETURNS TABLE
AS
RETURN (
    select format(convert(date, COALESCE(p.NgayNhap, h.NgayBH)), 'dd-MM-yyyy') as Ngay, ISNULL(isnull(sum(TongTien), 0)-isnull(sum(TienNhapHang), 0), 0) as DoanhThu 
	from PhieuBanHang h full join PhieuNhapHang p 
	on h.NgayBH = p.NgayNhap
	where (NgayBH >= @NgayBatDau and NgayBH <= @NgayKetThuc) or (NgayNhap >= @NgayBatDau and NgayNhap <= @NgayKetThuc)
	group by convert(date, COALESCE(p.NgayNhap, h.NgayBH))
);
go

--function tính doanh thu theo quý
CREATE FUNCTION dbo.DoanhThuQuy(@Quy int)
RETURNS TABLE
AS
RETURN (
    SELECT MONTH(COALESCE(NgayNhap, NgayBH)) as Thang, ISNULL(isnull(sum(TongTien), 0) - isnull(sum(TienNhapHang), 0), 0) AS DoanhThu
	FROM PhieuBanHang full join PhieuNhapHang
	on NgayNhap = NgayBH
	WHERE YEAR(NgayBH) = year(getdate())
	AND Datepart(QUARTER, NgayBH) = @Quy or Datepart(QUARTER, NgayNhap) = @Quy
	group by MONTH(COALESCE(NgayNhap, NgayBH))
);
go
	
--function TinhTongDoanhThuQuy
CREATE FUNCTION dbo.TongDoanhThuQuy(@Quy int)
RETURNS Float
AS
BEGIN
    declare @Tong int = 0
	select @Tong = sum(DoanhThu) from dbo.DoanhThuQuy(@Quy)
	return @Tong;
END
go
--function tính doanh thu theo các quý
CREATE FUNCTION dbo.DoanhThuCacQuy()
RETURNS TABLE
AS
RETURN (
    SELECT Quy, dbo.TongDoanhThuQuy(Quy) AS DoanhThu
    FROM (
        VALUES (1), (2), (3), (4)
    ) AS Quy(Quy)
);
go

------------------------------
------------------------------
GO
ALTER TABLE NhanVien
ADD CONSTRAINT CK_GioiTinh CHECK (GioiTinh IN (N'Nam', N'Nữ'));
GO
-- kt MaHH không được phép null
ALTER TABLE dbo.ChiTietBanHang
ALTER COLUMN MaHH VARCHAR(10) NOT NULL;
GO
--Kiểm tra tài khoản là duy nhất
ALTER TABLE dbo.TaiKhoan
ADD CONSTRAINT UQ_TaiKhoan UNIQUE (TaiKhoan);
GO
-- Ghi chú của phiếu bán mặc dịnh
ALTER TABLE dbo.PhieuBanHang
ADD CONSTRAINT DF_GhiChu DEFAULT ('Chưa có ghi chú') FOR GhiChu;
GO
------------------------------
------------------------------

--Ràng buộc kiểm tra số lượng hàng hóa--Nhập liệu
-- Dữ liệu cho bảng ChucVu
INSERT INTO ChucVu (MaCV, TenCV)
VALUES
    ('CV01', N'Quản lý'),
    ('CV02', N'Nhân viên bán hàng');
GO

-- Dữ liệu cho bảng NhanVien
INSERT INTO NhanVien (MaNV, TenNV, GioiTinh, NamSinh, SDT_NV, DiaChi_NV,MaCV)
VALUES
    ('NV001', N'Nguyễn Văn A', N'Nam', '1990-01-15', '0123456789', N'123 Đường ABC, Quận 1, TP.HCM','CV01'),
    ('NV002', N'Nguyễn Thị B', N'Nữ', '1995-05-20', '0987654321', N'456 Đường XYZ, Quận 2, TP.HCM','CV02'),
    ('NV003', N'Trần Văn C', N'Nam', '1988-11-10', '0369852147', N'789 Đường DEF, Quận 3, TP.HCM','CV02'),
    ('NV004', N'Vũ Thị D', N'Nữ', '1993-07-25', '0912345678', N'321 Đường LMN, Quận 4, TP.HCM','CV02'),
    ('NV005', N'Hoàng Văn E', N'Nam', '1992-03-30', '0765432198', N'654 Đường XYZ, Quận 5, TP.HCM','CV02'),
    ('NV006', N'Lê Tấn', N'Nam', '1992-03-30', '0123456789', N'123 Đường ABC, Quận 1, TP.HCM','CV01');
GO

--Dữ liệu cho bảng TaiKhoan
INSERT INTO TaiKhoan (TaiKhoan, MatKhau, MaNV)
VALUES
    ('tk01', 'pass01', 'NV001'),
    ('tk02', 'pass02', 'NV002'),
    ('tk03', 'pass03', 'NV003'),
    ('tk04', 'pass04', 'NV004'),
    ('tk05', 'pass05', 'NV005');
GO

-- Dữ liệu cho bảng KhachHang
INSERT INTO KhachHang (MaKH, TenKH, SDT_KH, DiaChi_KH)
VALUES
    ('KH001', N'Nguyễn Văn X', '0123456789', N'123 Đường ABC, Quận 1, TP.HCM'),
    ('KH002', N'Nguyễn Thị Y', '0987654321', N'456 Đường XYZ, Quận 2, TP.HCM'),
    ('KH003', N'Trần Văn Z', '0369852147', N'789 Đường DEF, Quận 3, TP.HCM'),
    ('KH004', N'Vũ Thị M', '0912345678', N'321 Đường LMN, Quận 4, TP.HCM'),
    ('KH005', N'Hoàng Văn N', '0765432198', N'654 Đường XYZ, Quận 5, TP.HCM');
GO

-- Dữ liệu cho bảng NhaCungCap
INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi_NCC)
VALUES
    ('NCC001', N'Công ty A', N'123 Đường ABC, Quận 1, TP.HCM'),
    ('NCC002', N'Công ty B', N'456 Đường XYZ, Quận 2, TP.HCM'),
    ('NCC003', N'Công ty C', N'789 Đường DEF, Quận 3, TP.HCM'),
    ('NCC004', N'Công ty D', N'321 Đường LMN, Quận 4, TP.HCM'),
    ('NCC005', N'Công ty E', N'654 Đường XYZ, Quận 5, TP.HCM');
GO

-- Dữ liệu cho bảng LoaiHangHoa
INSERT INTO LoaiHangHoa (MaLoaiHH, TenLoaiHH)
VALUES
    ('LH001', N'Hàng tổng hợp'),
	('LH002', N'Hóa mỹ phẩm'),
	('LH003', N'Thực phẩm khô'),
    ('LH004', N'Kem'),
    ('LH005', N'Sữa & sản phẩm từ sữa'),
	('LH006', N'Bánh kẹo'),
	('LH007', N'Nước giải khát'),
	('LH008', N'Bia - Rượu - Rượu trái cây')
GO

-- Dữ liệu cho bảng HangHoa
INSERT INTO HangHoa (MaHH, TenHH, DVT, GiaNhap, GiaBan, SoLuong, MaloaiHH, MaNCC)
VALUES
    ('HH001', N'Bột giặt Omo hương nước hoa 0.7Kg', N'Túi', 38000, 42000, 50, 'LH001', 'NCC001'),
	('HH002', N'Bột giặt Omo hương nước hoa 3Kg', N'Túi', 140000, 145000, 50, 'LH001', 'NCC001'),
	('HH003', N'Bột giặt Tide chuyên dụng 3.8Kg', N'Túi', 160000, 165000, 50, 'LH001', 'NCC001'),
	('HH004', N'Bột giặt Lix hương chanh 5.5Kg', N'Túi', 158000, 165000, 50, 'LH001', 'NCC001'),
	('HH005', N'Bột giặt Ariel hương Lavender 5Kg', N'Túi', 260000, 275000, 50, 'LH001', 'NCC001'),
	('HH006', N'Nước giặt Omo khử mùi 3.1 lít', N'Túi', 320000, 330000, 50, 'LH001', 'NCC001'),
	('HH007', N'Nước giặt Lix Matic nước hoa 3.6 lít', N'Chai', 150000, 160000, 50, 'LH001', 'NCC001'),
	('HH008', N'Nước giặt Ariel hoa oải hương 3.7 lít', N'Túi', 250000, 270000, 50, 'LH001', 'NCC001'),
	('HH009', N'Nước xả Downy huyền bí 3 lít', N'Túi', 230000, 241000, 50, 'LH001', 'NCC001'),
	('HH010', N'Nước xả Comfort Bella 1.8 lít', N'Túi', 130000, 142000, 50, 'LH001', 'NCC001'),
	('HH011', N'Nước xả Comfort Sophia 3.8 lít', N'Túi', 260000, 271000, 50, 'LH001', 'NCC001'),
	('HH012', N'Nước xả Downy đam mê 3 lít', N'Túi',230000, 241000, 50, 'LH001', 'NCC001'),
	('HH013', N'Nước xả Hygiene trắng 1.3 lít', N'Túi', 105000, 118000, 50, 'LH001', 'NCC001'),
	('HH014', N'Nước xả Hygiene cam 2.2 lít', N'Túi', 188000, 208000, 50, 'LH001', 'NCC001'),
	('HH015', N'Vỉ 4 viên pin Maxell R03 3A', N'Vỉ', 18000, 25000, 50, 'LH001', 'NCC002'),
	('HH016', N'Vỉ 8 viên pin Maxell R03 3A', N'Vỉ', 25000, 35000, 50, 'LH001', 'NCC002'),
	('HH017', N'Vỉ 4 viên pin AAA Panasonic LR03T', N'Vỉ', 55000, 63000, 50, 'LH001', 'NCC002'),
	('HH018', N'Bút bi thiên long  TL-027 xanh', N'Cây', 2500, 5000, 100, 'LH001', 'NCC002'),
	('HH019', N'Bút lông bảng Thiên Long WB-02 đen', N'Cây', 5000, 8000, 100, 'LH001', 'NCC002'),
	('HH020', N'Bút lông bảng Thiên Long WB-03 đỏ', N'Cây', 7000, 11000, 70, 'LH001', 'NCC002'),
	('HH021', N'Bút bi thiên long  TL-095 xanh', N'Cây', 6000, 10000, 100, 'LH001', 'NCC002'),
	('HH022', N'Băng keo trong Thiên Long 47m x 4.8cm', N'Cuộn', 10000, 17000, 40, 'LH001', 'NCC002'),
	('HH023', N'Keo khô điểm 10', N'Chai', 8000, 12000, 50, 'LH001', 'NCC002'),
	('HH024', N'Khẩu trang y tế Famapro 5D 3 lớp', N'Hộp', 12000, 18000, 150, 'LH001', 'NCC002'),
	('HH025', N'Khẩu trang y tế An Phúc KF94-4D', N'Gói', 6000, 10000, 150, 'LH001', 'NCC002'),
	('HH026', N'Khẩu trang y tế than hoạt tính An Phúc 4 lớp', N'Hộp', 32000, 40000, 150, 'LH001', 'NCC002'),
	('HH027', N'Khăn giấy Bless You À La Vie 2 lớp', N'Túi', 20000, 24000, 100, 'LH001', 'NCC002'),
	('HH028', N'Khăn giấy ướt Max Cool Clean', N'Túi', 28000, 40000, 80, 'LH001', 'NCC002'),
	('HH029', N'Tẩy bồn cầu & nhà tắm VIM 880 ml', N'Chai', 28000, 38000, 50, 'LH001', 'NCC001'),
	('HH030', N'Xịt côn trùng Jumbo lavender 600ml', N'Chai', 58000, 69000, 50, 'LH001', 'NCC001'),
	('HH031', N'Nước rửa chén Sunlight chanh 725ml', N'Chai', 15000, 28000, 50, 'LH001', 'NCC001'),
	('HH032', N'Nước rửa chén Surf chanh sả 3.47 lít', N'Chai', 70000, 85000, 50, 'LH001', 'NCC001'),
	('HH033', N'Ô dù che mưa nắng', N'Cây', 29000, 39000, 50, 'LH001', 'NCC002'),
	('HH034', N'Áo mưa cách dơi', N'Cái', 40000, 52000, 50, 'LH001', 'NCC002'),
	('HH035', N'Gói 9 cuộn giấy Pulppy 2 lớp', N'Gói', 70000, 85000, 50, 'LH001', 'NCC002'),
	('HH036', N'Sữa rửa mặt Acnes ngừa mụn 100g', N'Chai', 52000, 68000, 60, 'LH002', 'NCC003'),
	('HH037', N'Nước tẩy trang Simple dịu nhẹ 400ml', N'Chai', 162000, 189000, 60, 'LH002', 'NCC003'),
	('HH038', N'Bông tẩy trang tròn Puri 130 miếng', N'Túi', 18000, 29000, 100, 'LH002', 'NCC003'),
	('HH039', N'Giấy thấm dầu Acnes 100 tờ', N'Túi', 20000,31000, 100, 'LH002', 'NCC003'),
	('HH040', N'Sữa rửa mặt X-Men sáng da 100g', N'Chai', 70000, 82000, 60, 'LH002', 'NCC003'),
	('HH041', N'Nước súc miệng Listerine bạc hà 750ml', N'Chai', 130000, 145000, 60, 'LH002', 'NCC003'),
	('HH042', N'Kem đánh răng Closeup bạc hà', N'Hộp', 35000, 45000, 100, 'LH002', 'NCC003'),
	('HH043', N'Kem đánh răng P/S bảo vệ 123', N'Hộp', 30000, 39000, 100, 'LH002', 'NCC003'),
	('HH044', N'Kem đánh răng Colgate MaxFresh bạc hà 230g', N'Hộp', 39000, 50000, 50, 'LH002', 'NCC003'),
	('HH045', N'Bàn chải P/S bảo vệ 123', N'Cây', 4000, 8000, 100, 'LH002', 'NCC003'),
	('HH046', N'3 bàn chải Puri lông mềm', N'Hộp', 8000, 14000, 60, 'LH002', 'NCC003'),
	('HH047', N'Tăm tre Gấu Trúc 350 cây', N'Hộp', 5000, 7000, 100, 'LH002', 'NCC003'),
	('HH048', N'Tăm chỉ nha khoa Okamura 50 cái', N'Hộp', 15000, 22000, 50, 'LH002', 'NCC003'),
	('HH049', N'Băng hàng ngày Kotex siêu mềm 15cm', N'Gói', 25000, 30000, 60, 'LH002', 'NCC003'),
	('HH050', N'Băng ban ngày Diana Sensi Cool Fresh 23cm', N'Gói', 40000, 45000, 55, 'LH002', 'NCC003'),
	('HH051', N'Băng ban đêm Diana Sensi Cool Fresh 23cm', N'Gói', 40000, 45000, 55, 'LH002', 'NCC003'),
	('HH052', N'Dung dịch vệ sinh Dạ Hương 100ml', N'Chai', 35000, 40000, 55, 'LH002', 'NCC003'),
	('HH053', N'Bao cao su Durex Invisible 52mm', N'Hộp', 80000, 90000, 40, 'LH002', 'NCC003'),
	('HH054', N'Bao cao su Durex Jeans 52.5 mm', N'Hộp', 30000, 40000, 40, 'LH002', 'NCC003'),
	('HH055', N'Bao cao su Durex Kingtex 3s 49mm', N'Hộp', 30000, 40000, 55, 'LH002', 'NCC003'),
	('HH056', N'Dao cạo lưỡi lam Gillette Super Thin Click Er-80', N'Cây', 9000, 14000, 50, 'LH002', 'NCC003'),
	('HH057', N'Dầu gội Romano Classic 180g', N'Chai', 60000, 70000, 60, 'LH002', 'NCC003'),
	('HH058', N'Dầu gội X-Men Wood Sport 180g', N'Chai', 60000, 70000, 60, 'LH002', 'NCC003'),
	('HH059', N'Dầu gội sạch gàu Clear', N'Chai', 160000, 170000, 50, 'LH002', 'NCC003'),
	('HH060', N'Dầu gội Sunsilk 5.8ml x 10 gói', N'Dây', 8000, 12000, 100, 'LH002', 'NCC003'),
	('HH061', N'Dầu xả Pantene Micellar 150ml', N'Chai', 50000, 60000, 55, 'LH002', 'NCC003'),
	('HH062', N'Dầu xả Sunsilk 6.1ml x 10 gói', N'Dây', 8000, 12000, 100, 'LH002', 'NCC003'),
	('HH063', N'Tắm gội 2 in 1 Romano Classic', N'Chai', 55000, 65000, 50, 'LH002', 'NCC003'),
	('HH064', N'Lăn khử mùi Nivea Men Cool Kick 50ml', N'Chai', 70000, 85000, 40, 'LH002', 'NCC003'),
	('HH065', N'Lăn khử mùi Nivea Dry Comfort 50ml', N'Chai', 70000, 82000, 40, 'LH002', 'NCC003'),
	('HH066', N'Dầu đậu nành Happi Soya 1 lít', N'Chai', 50000, 62000, 100, 'LH003', 'NCC004'),
	('HH067', N'Dầu thực vật Cái Lân 1 lít', N'Chai', 32000, 40000, 100, 'LH003', 'NCC004'),
	('HH068', N'Dầu thực vật Cái Lân 2 lít', N'Chai', 64000, 78000, 60, 'LH003', 'NCC004'),
	('HH069', N'Nước mắm Nam Ngư Đệ Nhị 900ml', N'Chai', 18000, 25000, 70, 'LH003', 'NCC004'),
	('HH070', N'Nước mắm Nam Ngư Đệ Nhất 500ml', N'Chai', 28000, 35000, 70, 'LH003', 'NCC004'),
	('HH071', N'Nước tương Maggi thanh dịu 300ml', N'Chai', 10000, 16000, 70, 'LH003', 'NCC004'),
	('HH072', N'Nước tương Maggi đậm đặc 300ml', N'Chai', 12000, 19000, 70, 'LH003', 'NCC004'),
	('HH073', N'Nước tương tỏi ớt Maggi 200ml', N'Chai', 13000, 20000, 70, 'LH003', 'NCC004'),
	('HH074', N'Đường kính trắng Toàn Phát gói 500g', N'Gói', 11000, 16000, 100, 'LH003', 'NCC004'),
	('HH075', N'Bột ngọt hạt lớn Ajinomoto 100g', N'Gói', 5000, 9000, 50, 'LH003', 'NCC004'),
	('HH076', N'Muối sấy i ốt Sosal Group 500g', N'Gói', 3000, 5000, 50, 'LH003', 'NCC004'),
	('HH077', N'Muối ớt Tây Ninh 110g', N'Chai', 9000, 12000, 80, 'LH003', 'NCC004'),
	('HH078', N'Muối tôm Tây Ninh 110g', N'Chai', 9000, 12000, 80, 'LH003', 'NCC004'),
	('HH079', N'Muối tiêu Natas 100g', N'Chai', 10000, 15000, 70, 'LH003', 'NCC004'),
	('HH080', N'Tương ớt Chinsu 250g', N'Chai', 10000, 15000, 80, 'LH003', 'NCC004'),
	('HH081', N'Tương cà Cholimex 270g', N'Chai', 8000, 12000, 80, 'LH003', 'NCC004'),
	('HH082', N'Xốt mayonnaise Ajinomoto 130g', N'Chai', 17000, 21000, 80, 'LH003', 'NCC004'),
	('HH083', N'Tương đen Nam Dương 255g', N'Chai', 9000, 12000, 50, 'LH003', 'NCC004'),
	('HH084', N'Xốt salad mè Golden Farm 250ml', N'Chai', 45000, 50000, 50, 'LH003', 'NCC004'),
	('HH085', N'Chao Bông Mai hũ 170g', N'Chai', 12000, 17000, 50, 'LH003', 'NCC004'),
	('HH086', N'Tương ớt xanh Ông Chà Và 210g', N'Chai', 11000, 16000, 50, 'LH003', 'NCC004'),
	('HH087', N'Dầu hào Maggi đậm đặc 350g', N'Chai', 22000, 27000, 50, 'LH003', 'NCC004'),
	('HH088', N'Bơ thực vật Tường An 200g', N'Hủ', 15000, 20000, 50, 'LH003', 'NCC004'),
	('HH089', N'Sa tế tôm Cholimex 90g', N'Chai', 6000, 10000, 50, 'LH003', 'NCC004'),
	('HH090', N'Ngũ cốc Nestle Nesvita 400g', N'Túi', 50000, 58000, 40, 'LH003', 'NCC004'),
	('HH091', N'Trà gừng Wil 160g', N'Hộp', 42000, 47000, 50, 'LH003', 'NCC004'),
	('HH092', N'Cà phê đen G7 30g', N'Hộp', 22000, 29000, 70, 'LH003', 'NCC004'),
	('HH093', N'Cà phê Highlands Moka 200g', N'Gói', 65000, 85000, 50, 'LH003', 'NCC004'),
	('HH094', N'Cà phê sữa NesCafé 3in1 340g', N'Hộp', 52000, 60000, 60, 'LH003', 'NCC004'),
	('HH095', N'Cà phê MacCoffee Café Phố Gold 3in1 290g', N'Hộp', 48000, 55000, 60, 'LH003', 'NCC004'),
	('HH096', N'Mì Hảo Hảo tôm chua cay gói 75g', N'Gói', 3000, 4500, 300, 'LH003', 'NCC004'),
	('HH097', N'Mì Gấu Đỏ tôm chua cay gói 63g', N'Gói', 2000, 3500, 120, 'LH003', 'NCC004'),
	('HH098', N'Mì khoai tây Omachi xốt bò hầm gói 80g', N'Gói', 7500, 9000, 300, 'LH003', 'NCC004'),
	('HH099', N'Mì khoai tây Cung Đình bò hầm ly 65g', N'Ly', 8000, 9200, 120, 'LH003', 'NCC004'),
	('HH100', N'Mì gà cay Samyang gói 145g', N'Gói', 25000, 34000, 120, 'LH003', 'NCC004'),
	('HH101', N'Mì chay Vifon lẩu thái gói 65g', N'Gói', 2500, 4000, 210, 'LH003', 'NCC004'),
	('HH102', N'Mì chay Vifon rau nấm gói 65g', N'Gói', 2500, 4000, 210, 'LH003', 'NCC004'),
	('HH103', N'Mì 3 Miền tôm hùm gói 65g', N'Gói', 2000, 3500, 300, 'LH003', 'NCC004'),
	('HH104', N'Mì Omachi tôm chua cay Thái ly 111g', N'Ly', 165000, 18000, 190, 'LH003', 'NCC004'),
	('HH105', N'Hủ tiếu sườn heo Nhịp Sống 70g', N'Gói', 7500, 9000, 210, 'LH003', 'NCC004'),
	('HH106', N'Miến Phú Hương thịt bằm 55g', N'Gói', 9500, 11000, 120, 'LH003', 'NCC004'),
	('HH107', N'Bánh đa cua Vifon Hoàng Gia 120g', N'Gói', 22500, 24000, 120, 'LH003', 'NCC004'),
	('HH108', N'Phở bò Đệ Nhất 65g', N'Gói', 7000, 8500, 120, 'LH003', 'NCC004'),
	('HH109', N'Phở bò Cung Đình Hà Nội 68g', N'Gói', 7800, 9500, 120, 'LH003', 'NCC004'),
	('HH110', N'Phở gà Cung Đình Hà Nội 68g', N'Gói', 7800, 9500, 120, 'LH003', 'NCC004'),
	('HH111', N'Cháo thịt bằm Gấu Đỏ 50g', N'Gói', 2500, 4000, 150, 'LH003', 'NCC004'),
	('HH112', N'Cháo gà Gấu Đỏ 50g', N'Gói', 2500, 4000, 150, 'LH003', 'NCC004'),
	('HH113', N'Tokbokki phô mai Ofood 105g', N'Ly', 24500, 26500, 150, 'LH003', 'NCC004'),
	('HH114', N'Tokbokki cay ngọt Ofood 105g', N'Ly', 24500, 26500, 150, 'LH003', 'NCC004'),
	('HH115', N'Tokbokki cay ngọt Yopokki 140g', N'Ly', 35000, 42000, 90, 'LH003', 'NCC004'),
	('HH116', N'Kem Topten Socola Walls cây 60g', N'Cây', 9000, 12000, 50, 'LH004', 'NCC004'),
	('HH117', N'Kem Topten Vanila Walls cây 60g', N'Cây', 9000, 12000, 50, 'LH004', 'NCC004'),
	('HH118', N'Kem chuối Merino truyền thống cây 85g', N'Cây', 9000, 12000, 50, 'LH004', 'NCC004'),
	('HH119', N'Kem cam đào nhân sữa Merino Kool cây 62g', N'Cây', 8000, 11000, 50, 'LH004', 'NCC004'),
	('HH120', N'Sữa chua dẻo phô mai Merino gói 50g', N'Gói', 4500, 6000, 50, 'LH005', 'NCC004'),
	('HH121', N'Kem bánh cá trân châu dừa tắc Celano 70g', N'Gói', 19500, 22000, 50, 'LH004', 'NCC004'),
	('HH122', N'Kem socola vani Merino 465g', N'Hộp', 66500, 75000, 40, 'LH004', 'NCC004'),
	('HH123', N'Kem sầu riêng sữa dừa Merino 465g', N'Hộp', 66500, 75000, 40, 'LH004', 'NCC004'),
	('HH124', N'Kem Milky Chocolate Merino Kool Cutie Bear', N'Cây', 9000, 12000, 50, 'LH004', 'NCC004'),
	('HH125', N'Kem dâu Vinamilk hộp 247.5g', N'Hộp', 47500, 51000, 50, 'LH004', 'NCC004'),
	('HH126', N'Kem đậu xanh Vinamilk hộp 247.5g', N'Hộp', 47500, 51000, 50, 'LH004', 'NCC004'),
	('HH127', N'Kem khoai môn Vinamilk hộp 247.5g', N'Hộp', 47500, 51000, 50, 'LH004', 'NCC004'),
	('HH128', N'Kem sầu riêng Vinamilk hộp 247.5g', N'Hộp', 47500, 51000, 50, 'LH004', 'NCC004'),
	('HH129', N'Kem ốc quế dâu Celano Extra cây 73g', N'Cây', 20500, 24000, 50, 'LH004', 'NCC004'),
	('HH130', N'Kem ốc quế socola Celano Extra cây 73g', N'Cây', 20500, 24000, 50, 'LH004', 'NCC004'),
	('HH131', N'Sữa đặc Ông Thọ đỏ hộp 40g', N'Hộp', 2500, 4500, 30, 'LH005', 'NCC004'),
	('HH132', N'Sữa đặc Ông Thọ đỏ lon 380g', N'Lon', 28000, 31000, 30, 'LH005', 'NCC004'),
	('HH133', N'Sữa đặc Ngôi sao Phương Nam 380g', N'Hộp', 16000, 20000, 30, 'LH005', 'NCC004'),
	('HH134', N'Sữa đặc Ông Thọ đỏ tuýp 165g', N'Tuýp', 17000, 19500, 50, 'LH005', 'NCC004'),
	('HH135', N'Sữa tươi TH true MILK bịch 220ml', N'Bịch', 6200, 8400, 240, 'LH005', 'NCC004'),
	('HH136', N'Lốc 4 hộp sữa tươi Vinamilk có đường 180ml', N'Lốc', 28500, 32500, 240, 'LH005', 'NCC004'),
	('HH137', N'Lốc 4 hộp sữa tươi TH true MILK 180ml', N'Lốc', 32500, 36000, 240, 'LH005', 'NCC004'),
	('HH138', N'Sữa tươi có đường TH true MILK hộp 1 lít', N'Hộp', 33000, 37000, 240, 'LH005', 'NCC004'),
	('HH139', N'Sữa tươi Vinamilk có đường hộp 1 lít', N'Hộp', 32500, 36000, 240, 'LH005', 'NCC004'),
	('HH140', N'Lốc 4 hộp sữa tươi Kun 100% Sữa tươi 180ml', N'Lốc', 30000, 33500, 120, 'LH005', 'NCC004'),
	('HH141', N'Sữa đậu nành ít đường Fami bịch 200ml', N'Bịch', 2600, 4300, 240, 'LH005', 'NCC004'),
	('HH142', N'Sữa đậu nành ít đường Fami Canxi bịch 200ml', N'Bịch', 2600, 4300, 240, 'LH005', 'NCC004'),
	('HH143', N'Sữa đậu đen óc chó hạnh nhân Sahmyook 190ml', N'Hộp', 15500, 18000, 60, 'LH005', 'NCC004'),
	('HH144', N'Sữa 9 loại hạt Vinamilk Super Nut 1 lít', N'Hộp', 56500, 65000, 40, 'LH005', 'NCC004'),
	('HH145', N'Sữa lúa mạch Milo nắp vặn hộp 210ml', N'Hộp', 7800, 10500, 60, 'LH005', 'NCC004'),
	('HH146', N'Lốc 4 hộp sữa lúa mạch Milo 180ml', N'Lốc', 28500, 31500, 240, 'LH005', 'NCC004'),
	('HH147', N'Bánh quy kem vani Oreo 119.6g', N'Gói', 15000, 17500, 40, 'LH006', 'NCC004'),
	('HH148', N'Bánh cracker rau AFC 8 gói', N'Hộp', 27500, 30000, 40, 'LH006', 'NCC004'),
	('HH149', N'Bánh quy sữa Cosy Marie 408g', N'Gói', 41500, 46000, 30, 'LH006', 'NCC004'),
	('HH150', N'Bánh gạo nướng vị tảo biển An gói 111.3g', N'Gói', 20000, 23000, 40, 'LH006', 'NCC004'),
	('HH151', N'Bánh gạo Nhật vị Shouyu mật ong Ichi gói 180g', N'Gói', 35500, 39000, 40, 'LH006', 'NCC004'),
	('HH152', N'Bánh gạo vị ngọt dịu One One gói 230g', N'Gói', 28500, 32000, 40, 'LH006', 'NCC004'),
	('HH153', N'Bánh quế sô cô la Oreo Wafer Roll 3 gói x 18g', N'Hộp', 10000, 13000, 40, 'LH006', 'NCC004'),
	('HH154', N'Bánh quế vị kem socola Cosy gói 117.6g', N'Gói', 12000, 15000, 50, 'LH006', 'NCC004'),
	('HH155', N'Snack tôm cay đặc biệt Oishi 32g', N'Gói', 3500, 5500, 50, 'LH006', 'NCC004'),
	('HH156', N'Snack tôm cay Oishi 32g', N'Gói', 3500, 5500, 50, 'LH006', 'NCC004'),
	('HH157', N'Snack vị tảo biển OStar 32g', N'Gói', 5000, 6500, 50, 'LH006', 'NCC004'),
	('HH158', N'Snack vị tảo biển Lays 54g', N'Gói', 10000, 12000, 50, 'LH006', 'NCC004'),
	('HH159', N'Snack vị tự nhiên Lays 54g', N'Gói', 10000, 12000, 50, 'LH006', 'NCC004'),
	('HH160', N'Snack vị sườn bò BBQ Lays 54g', N'Gói', 10000, 12000, 50, 'LH006', 'NCC004'),
	('HH161', N'Snack cà phê Akiko Oishi 140g', N'Gói', 20000, 23000, 50, 'LH006', 'NCC004'),
	('HH162', N'Snack cà chua Oishi Tomati 32g', N'Gói', 4000, 5500, 50, 'LH006', 'NCC004'),
	('HH163', N'Snack chay vị heo quay Oishi 32g', N'Gói', 4000, 5500, 50, 'LH006', 'NCC004'),
	('HH164', N'Snack phồng mực Oishi 32g', N'Gói', 4000, 5500, 50, 'LH006', 'NCC004'),
	('HH165', N'Snack đậu phộng vị mực cay Pinattsu Oishi gói 85g', N'Gói', 11500, 12000, 50, 'LH006', 'NCC004'),
	('HH166', N'Snack đậu phộng vị hải sản siêu cay Pinattsu Oishi gói 85g', N'Gói', 11500, 12000, 50, 'LH006', 'NCC004'),
	('HH167', N'Kẹo xoài muối ớt Alpenliebe 87g', N'Gói', 10000, 13000, 30, 'LH006', 'NCC004'),
	('HH168', N'Kẹo cà phê KOPIKO 140g', N'Gói', 10000, 13000, 30, 'LH006', 'NCC004'),
	('HH169', N'Kẹo bạc hà Dynamite Big Bang 120g', N'Gói', 10000, 13000, 30, 'LH006', 'NCC004'),
	('HH170', N'Kẹo gum Lotte Xylitol Lime Mint 130.5g', N'Hủ', 54500, 58000, 30, 'LH006', 'NCC004'),
	('HH171', N'Kẹo gum Lotte Xylitol Cool 130.5g', N'Hủ', 54500, 58000, 30, 'LH006', 'NCC004'),
	('HH172', N'Kẹo gum thổi Big Babol 16g', N'Hủ', 4000, 6000, 50, 'LH006', 'NCC004'),
	('HH173', N'Kẹo gum Cool Air bạc hà 58.4g', N'Hủ', 22500, 25500, 50, 'LH006', 'NCC004'),
	('HH174', N'Bánh xốp phủ socola KitKat 35g', N'Gói', 12000, 15500, 50, 'LH006', 'NCC004'),
	('HH175', N'Bánh xốp phủ trà xanh KitKat 35g', N'Gói', 12000, 15500, 50, 'LH006', 'NCC004'),
	('HH176', N'Bánh trứng chà bông Karo Richy 6 gói x 26g', N'Gói', 34500, 39000, 20, 'LH006', 'NCC004'),
	('HH177', N'Bánh mì sandwich lạt Otto', N'Gói', 14000, 16000, 20, 'LH006', 'NCC004'),
	('HH178', N'Bánh mì hoa cúc Otto gói 80g', N'Gói', 19500, 22000, 20, 'LH006', 'NCC004'),
	('HH179', N'Bánh Choco-pie 20 cái', N'Gói', 82000, 88000, 20, 'LH006', 'NCC004'),
	('HH180', N'Bánh bông lan cuộn kem lá dứa Solite', N'Hộp', 48000, 52500, 20, 'LH006', 'NCC004'),
	('HH181', N'Mít sấy Vinamit 100g', N'Gói', 34500, 39500, 50, 'LH006', 'NCC004'),
	('HH182', N'Snack và đậu thập cẩm Fun Mix Tân Tân 200g', N'Hộp', 45000, 49000, 20, 'LH006', 'NCC004'),
	('HH183', N'Kẹo thạch Zai Zai Đức Hạnh gói 160g', N'Gói', 12000, 17000, 20, 'LH006', 'NCC004'),
	('HH184', N'Cơm cháy chà bông vị cay Lucky Star gói 50g', N'Gói', 12000, 17000, 20, 'LH006', 'NCC004'),
	('HH185', N'Khô gà lá chanh C&B hộp 100g', N'Hộp', 55000, 60000, 20, 'LH006', 'NCC004'),
	('HH186', N'Chân gà vị cay Chef Biggy gói 30g', N'Gói', 7500, 10000, 20, 'LH006', 'NCC004'),
	('HH187', N'Nước ngọt Coca Cola lon 320ml', N'Lon', 8000, 10000, 60, 'LH007', 'NCC005'),
	('HH188', N'Nước ngọt Coca Cola Light lon 320ml', N'Lon', 8000, 10000, 60, 'LH007', 'NCC005'),
	('HH189', N'Nước ngọt Pepsi không calo lon 320ml', N'Lon', 8000, 10000, 60,  'LH007', 'NCC005'),
	('HH190', N'Nước ngọt Pepsi không calo vị chanh lon 320ml', N'Lon', 8000, 10000, 60, 'LH007', 'NCC005'),
	('HH191', N'Nước ngọt 7 Up chanh chai 390ml', N'Chai', 6500, 8000, 60, 'LH007', 'NCC005'),
	('HH192', N'Nước tăng lực Sting dâu 330ml', N'Chai', 8000, 10000, 60, 'LH007', 'NCC005'),
	('HH193', N'Nước tăng lực Sting Gold 330ml', N'Chai', 8000, 10000, 60, 'LH007', 'NCC005'),
	('HH194', N'Nước tăng lực Warrior dâu 330ml', N'Chai', 8000, 10000, 60, 'LH007', 'NCC005'),
	('HH195', N'Nước tăng lực Warrior nho 330ml', N'Chai', 8000, 10000, 60, 'LH007', 'NCC005'),
	('HH196', N'Trà xanh chanh tuyết bạc hà C2 Freeze 455ml', N'Chai', 8000, 10000, 60, 'LH007', 'NCC005'),
	('HH197', N'Trà đen dưa lưới bạc hà C2 Freeze 455ml', N'Chai', 8000, 10000, 60, 'LH007', 'NCC005'),
	('HH198', N'Trà đen dâu anh đào C2 455ml', N'Chai', 8000, 10000, 60, 'LH007', 'NCC005'),
	('HH199', N'Hồng trà vải C2 455ml', N'Chai', 8000, 10000, 60, 'LH007', 'NCC005'),
	('HH200', N'Hồng trà đào C2 455ml', N'Chai', 8000, 10000, 60, 'LH007', 'NCC005'),
	('HH201', N'Trà ô long Tea Plus 450ml', N'Chai',  8000, 10000, 60, 'LH007', 'NCC005'),
	('HH202', N'Trà ô long chanh Tea Plus 450ml', N'Chai',  8000, 10000, 60, 'LH007', 'NCC005'),
	('HH203', N'Nước cam có tép Teppy 1 lít', N'Chai', 20000, 22500, 60, 'LH007', 'NCC005'),
	('HH204', N'Nước ép đào Vfresh 1 lít', N'Chai', 39000, 42000, 60, 'LH007', 'NCC005'),
	('HH205', N'Sữa trái cây Nutriboost hương cam 297ml', N'Chai', 9000, 11000, 60, 'LH007', 'NCC005'),
	('HH206', N'Sữa trái cây Nutriboost bánh quy kem 297ml', N'Chai', 9000, 11000, 40, 'LH007', 'NCC005'),
	('HH207', N'Trà sữa Kirin Tea Break 345ml', N'Chai', 9000, 12000, 60, 'LH007', 'NCC005'),
	('HH208', N'Nước tinh khiết Aquafina 355ml', N'Chai', 3000, 4500, 60, 'LH007', 'NCC005'),
	('HH209', N'Nước khoáng La Vie 500ml', N'Chai', 3500, 5000, 60, 'LH007', 'NCC005'),
	('HH210', N'Nước tinh khiết Satori 1.5 lít', N'Chai', 7500, 9500, 60, 'LH007', 'NCC005'),
	('HH211', N'Cà phê sữa Highlands 235ml', N'Lon', 12000, 14000, 20, 'LH007', 'NCC005'),
	('HH212', N'Cà phê sữa Highlands vị cà phê thật 180ml', N'Hộp', 7500, 9000, 40, 'LH007', 'NCC005'),
	('HH213', N'Nước tăng lực Redbull 250ml', N'Lon', 9000, 11000, 60, 'LH007', 'NCC005'),
	('HH214', N'Nước bù khoáng Revive không calo 500ml', N'Chai', 9500, 11500, 60, 'LH007', 'NCC005'),
	('HH215', N'Nước tăng lực Monster 355ml', N'Lon', 28500, 31000, 50, 'LH007', 'NCC005'),
	('HH216', N'Bia Tiger lon 330ml', N'Lon', 10200, 18000, 120, 'LH008', 'NCC005'),
	('HH217', N'Bia Tiger Bạc lon 330ml', N'Lon', 11200, 19000, 120, 'LH008', 'NCC005'),
	('HH218', N'Bia Sài Gòn Lager lon 330ml', N'Lon', 6500, 12500, 120, 'LH008', 'NCC005'),
	('HH219', N'Bia Heineken Sleek 330ml', N'Lon', 12000, 20000, 120, 'LH008', 'NCC005'),
	('HH220', N'Bia 333 lon 330ml', N'Lon', 6500, 12500, 120, 'LH008', 'NCC005'),
	('HH221', N'Strongbow dâu chai 330ml', N'Chai', 11000, 19500, 60, 'LH008', 'NCC005'),
	('HH222', N'Strongbow dâu lon 330ml', N'Lon', 10500, 19000, 60, 'LH008', 'NCC005'),
	('HH223', N'Strongbow táo chai 330ml', N'Chai', 11000, 19500, 60, 'LH008', 'NCC005'),
	('HH224', N'Strongbow táo lon 330ml', N'Lon', 10500, 19000, 60, 'LH008', 'NCC005'),
	('HH225', N'Rượu soju Good Day đào chai 360ml', N'Chai', 45000, 60000, 40, 'LH008', 'NCC005'),
	('HH226', N'Rượu soju Good Day dâu chai 360ml', N'Chai', 45000, 60000, 40, 'LH008', 'NCC005'),
	('HH227', N'Rượu soju Good Day nho chai 360ml', N'Chai', 45000, 60000, 30, 'LH008', 'NCC005'),
	('HH228', N'Rượu soju Good Day việt quất chai 360ml', N'Chai', 45000, 60000, 30, 'LH008', 'NCC005'),
	('HH229', N'Rượu vang trắng Vang Đà Lạt Classic chai 750ml', N'Chai', 84000, 104000, 5, 'LH008', 'NCC005'),
	('HH230', N'Rượu vang đỏ Vang Đà Lạt Classic chai 750ml', N'Chai', 84000, 104000, 5, 'LH008', 'NCC005')
GO

-- Dữ liệu cho bảng PhieuGiamGia
INSERT INTO PhieuGiamGia (MaPGG, TenPGG, NgayBD, NgayKT, GiaTriGG, GhiChu)
VALUES 
    ('PGG001', N'Giảm giá 10%', '2023-01-01', '2023-01-31', 10, N'Giảm giá tháng 1'),
    ('PGG002', N'Giảm giá 20%', '2023-02-01', '2023-02-28', 20, N'Giảm giá tháng 2'),
    ('PGG003', N'Giảm giá 15%', '2023-03-01', '2023-03-31', 15, N'Giảm giá tháng 3'),
    ('PGG004', N'Giảm giá 25%', '2023-04-01', '2023-04-30', 25, N'Giảm giá tháng 4'),
    ('PGG005', N'Giảm giá 30%', '2023-05-01', '2023-05-31', 30, N'Giảm giá tháng 5');
GO

-- Dữ liệu cho bảng PhieuNhapHang
INSERT INTO PhieuNhapHang (MaPhieuNhap, NgayNhap, GhiChu, MaNV)
--TienNhapHang sẽ tự động cập nhật bằng triger
VALUES
    ('PNH001', '2023-01-05', N'Nhập hàng tháng 1', 'NV001'),
    ('PNH002', '2023-02-10', N'Nhập hàng tháng 2', 'NV002'),
    ('PNH003', '2023-03-15', N'Nhập hàng tháng 3', 'NV003'),
    ('PNH004', '2023-04-20', N'Nhập hàng tháng 4', 'NV004'),
    ('PNH005', '2023-05-25', N'Nhập hàng tháng 5', 'NV005');
GO

---- Dữ liệu cho bảng ChiTietNhapHang
INSERT INTO ChiTietNhapHang (MaPhieuNhap, MaHH, SoLuong)--Giá nhập cập nhật tự động bằng trigger
VALUES
    ('PNH001', 'HH001', 10);
GO

---- Dữ liệu cho bảng PhieuBanHang
INSERT INTO PhieuBanHang (MaBanHang, MaNV, MaPGG, MaKH, NgayBH, GhiChu)
--Tổng tiền bán hàng sẽ tự động cập nhật bằng triger
VALUES 
--	('PBH004', 'NV004', 'PGG004', 'KH004', '2023-04-25 14:20:00', N'Bán hàng tháng 4'),
--	('PBH005', 'NV005', NULL, NULL, '2023-05-30 13:00:00', N'Bán hàng tháng 5'),
    ('PBH001', 'NV001', NULL, NULL, '2023-01-10 10:30:00', N'Bán hàng tháng 1' ),
    ('PBH002', 'NV002', NULL,NULL, '2023-02-15 09:45:00', N'Bán hàng tháng 2'),
    ('PBH003', 'NV003', NULL, NULL, '2023-03-20 11:15:00', N'Bán hàng tháng 3'),
    ('PBH004', 'NV004', 'PGG004', 'KH004', '2023-04-25 14:20:00', N'Bán hàng tháng 4'),
    ('PBH005', 'NV005', 'PGG005', 'KH005', '2023-05-30 13:00:00', N'Bán hàng tháng 5');
GO

---- Dữ liệu cho bảng ChiTietBanHang
INSERT INTO ChiTietBanHang (MaBanHang, MaHH, GiaBan, SoLuong)
VALUES 
	--('PBH004', 'HH001', 42000, 4),
	--('PBH004', 'HH002', 145000, 1),
    ('PBH005', 'HH003', 165000, 2),
    ('PBH005', 'HH004', 165000, 1)
GO

--SELECT * FROM dbo.ChiTietBanHang

--SELECT * FROM dbo.ChiTietNhapHang

--SELECT * FROM  dbo.HangHoa

--SELECT * FROM  dbo.KhachHang

--SELECT * FROM  dbo.LoaiHangHoa

--SELECT * FROM  dbo.NhaCungCap

--SELECT * FROM  dbo.NhanVien

--SELECT * FROM  dbo.PhieuBanHang

--SELECT * FROM  dbo.PhieuGiamGia

--SELECT * FROM  dbo.PhieuNhapHang

--SELECT * FROM  dbo.TaiKhoan

--Select TenNV, GiaTriGG, TenKH, NgayBH, TongTien
--From PhieuBanHang left join KhachHang
--On PhieuBanHang.MaKH = KhachHang.MaKH
--left join NhanVien 
--On PhieuBanHang.MaNV = NhanVien.MaNV
--left join PhieuGiamGia 
--On PhieuBanHang.MaPGG = PhieuGiamGia.MaPGG
--Where MaBanHang = 'PBH001'

--select TenHH, ChiTietBanHang.GiaBan, ChiTietBanHang.SoLuong, ThanhTien
--from ChiTietBanHang, HangHoa 
--where HangHoa.MaHH = ChiTietBanHang.MaHH
--and MaBanHang = 'PBH001'

--SELECT hd.MaBanHang as N'Mã hóa đơn', nv.TenNV as N'Nhân viên', pgg.TenPGG as N'Phiếu giảm giá', kh.TenKH as N'Khách hàng', NgayBH as N'Ngày lập', hd.GhiChu as N'Ghi chú', ISNULL(TongTien,0) as N'Tổng tiền'
--FROM PhieuBanHang hd 
--left join NhanVien nv on hd.MaNV = nv.MaNV
--left join KhachHang kh on hd.MaKH = kh.MaKH
--left join PhieuGiamGia pgg on hd.MaPGG = pgg.MaPGG

--WHERE CONVERT(Date,hd.NgayBH,103) = CONVERT(date,'20/03/2023',103)
--AND (CONVERT(Date,hd.NgayBH,103) BETWEEN CONVERT(date,'11/11/2023',103) AND CONVERT(date,'30/11/2023',103))
--AND (hd.TongTien Between 0 AND 99999999)