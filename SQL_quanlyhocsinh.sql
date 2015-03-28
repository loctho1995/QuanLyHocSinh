alter table hocsinh add TONGIAO varchar(30)
alter table hocsinh add HOTENCHAC varchar(30)
alter table hocsinh add HOTENME varchar(30)
alter table hocsinh add NGHENGHIEPME varchar(30)
alter table hocsinh add NGHENGHIEPCHA varchar(30)

alter table lop add MATRGLOP int foreign key references hocsinh(MAHS)
ALTER TABLE LOP ADD MAGVCN CHAR (5) FOREIGN KEY REFERENCES GIAOVIEN(MAGV)
ALTER TABLE PHANLOP ADD FOREIGN KEY (MAHS) REFERENCES HOCSINH(MAHS)
alter table monhoc add  MAGV CHAR(5) FOREIGN KEY REFERENCES GIAOVIEN(MAGV)
DELETE FROM HOCSINH
DELETE FROM PHANLOP
create table GIAOVIEN(
	MAGV CHAR(5) PRIMARY KEY,
	HOTEN NVARCHAR(20),
	GIOITINH CHAR (3),
	SODT VARCHAR(11)
)
alter table giaovien alter column GIOITINH nvarchar(3)
DROP TABLE GIAOVIEN
--phân quyền, đăng nhập
CREATE TABLE USERS(
	ID CHAR(5) PRIMARY KEY,
	PASSWORD VARCHAR(30),
	EMAIL VARCHAR(40)
	FOREIGN KEY (ID) REFERENCES GIAOVIEN(MAGV)
)

--thêm table qui định
CREATE TABLE QUIDINH(
	TUOITOITHIEU INT,
	TUOITOIDA INT,
	SISOTOITHIEU INT,
	SISOTOIDA INT,
	DIEMTOITHIEU FLOAT,
	DIEMTOIDA FLOAT
)

--các ràng buộc trong các bảng
--ràng buộc về tuổi
CREATE TRIGGER T_TUOI ON HOCSINH
FOR UPDATE, INSERT
AS
	DECLARE @tuoitoithieu int,
			@tuoitoida int,
			@ngaysinh smalldatetime,
			@tuoi int
	SELECT @tuoitoida = TUOITOIDA, @tuoitoithieu = TUOITOITHIEU FROM QUIDINH
	SELECT @ngaysinh = NGAYSINH FROM inserted
	IF((MONTH(GETDATE())>MONTH(@ngaysinh))OR(MONTH(GETDATE())=MONTH(@ngaysinh) AND DAY(GETDATE())>=DAY(@ngaysinh)))
	BEGIN
		SET @tuoi = YEAR(GETDATE()) - YEAR(@ngaysinh)
	END
	ELSE SET @tuoi = YEAR(GETDATE()) - YEAR(@ngaysinh) -1
	IF(@tuoi<@tuoitoithieu OR @tuoi > @tuoitoida)
	BEGIN
		RAISERROR('Tuổi không hợp lệ', 16,1);
		ROLLBACK TRANSACTION 
	END
DROP TRIGGER T_TUOI

--ràng buộc về sĩ số của lớp
CREATE TRIGGER T_SISOLOP ON PHANLOP
FOR INSERT, UPDATE
AS
	DECLARE @sisotoithieu int,
			@sisotoida int,
			@sisohientai int,
			@malop char(5)
	SELECT @malop = MALOP FROM inserted
	SELECT @sisotoithieu = SISOTOITHIEU ,@sisotoida = SISOTOIDA FROM QUIDINH
	SELECT @sisohientai = COUNT(MAHS) FROM PHANLOP WHERE MALOP = @malop
									  GROUP BY MALOP
	IF(@sisohientai>@sisotoida OR @sisohientai <@sisotoithieu)
	BEGIN
		RAISERROR('Lớp đầy!',16,2);
		ROLLBACK TRANSACTION
	END
--lấy thông tin học sinh theo khối
CREATE PROC sp_ThongtinHocSinhtheoKhoi(@makhoi char(2), @magvcn char(5), @phanquyen int) 
AS
	BEGIN
		IF(@phanquyen = 1) BEGIN
			SELECT HS.MAHS, HS.HOTEN, HS.NGAYSINH, HS.GIOITINH, HS.DIACHI, HS.TONGIAO, HS.EMAIL, HS.HOTENCHAC,HS.NGHENGHIEPCHA, HS.HOTENME,HS.NGHENGHIEPME, PL.MAKHOILOP, PL.MALOP
			FROM HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS
			WHERE PL.MAKHOILOP = @makhoi
		END
		ELSE BEGIN
			SELECT HS.MAHS, HS.HOTEN, HS.NGAYSINH, HS.GIOITINH, HS.DIACHI, HS.TONGIAO, HS.EMAIL, HS.HOTENCHAC,HS.NGHENGHIEPCHA, HS.HOTENME,HS.NGHENGHIEPME, PL.MAKHOILOP, PL.MALOP
			FROM HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS
			WHERE PL.MAKHOILOP = @makhoi AND EXISTS(SELECT * FROM LOP WHERE MAGVCN = @magvcn AND PL.MALOP = MALOP)
		END
	END

DROP PROC sp_ThongtinHocSinhtheoKhoi
EXEC sp_ThongtinHocSinhtheoKhoi 10, 'GV001',0


--lấy thông tin học sinh theo lớp
CREATE PROC sp_ThongtinHocSinhtheoLop(@malop char(5),@magvcn char(5), @phanquyen int)
AS
	BEGIN
		IF(@phanquyen = 1) BEGIN
			SELECT HS.MAHS, HS.HOTEN, HS.NGAYSINH, HS.GIOITINH, HS.DIACHI, HS.TONGIAO, HS.EMAIL, HS.HOTENCHAC,HS.NGHENGHIEPCHA, HS.HOTENME,HS.NGHENGHIEPME, PL.MAKHOILOP, PL.MALOP
			FROM HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS
			WHERE PL.MALOP = @malop
		END
		ELSE BEGIN
			SELECT HS.MAHS, HS.HOTEN, HS.NGAYSINH, HS.GIOITINH, HS.DIACHI, HS.TONGIAO, HS.EMAIL, HS.HOTENCHAC,HS.NGHENGHIEPCHA, HS.HOTENME,HS.NGHENGHIEPME, PL.MAKHOILOP, PL.MALOP
			FROM HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS
			WHERE PL.MALOP = @malop AND EXISTS(SELECT * FROM LOP WHERE MAGVCN = @magvcn AND PL.MALOP = MALOP)
		END
	END

DROP PROC sp_ThongtinHocSinhtheoLop
EXEC sp_ThongtinHocSinhtheoLop '11A1'

--xoá một học sinh
CREATE PROC sp_XoathongtinHocSinh(@mahs int)
AS
	BEGIN
		IF(NOT EXISTS (SELECT * FROM HOCSINH WHERE MAHS = @mahs))
			PRINT N'Học sinh không tồn tại'
		ELSE
			BEGIN TRAN
				SET TRAN ISOLATION LEVEL READ COMMITTED
				DELETE FROM PHANLOP WHERE MAHS = @mahs
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
				DELETE FROM DIEM WHERE MAHS = @mahs
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
				DELETE FROM HOCSINH WHERE MAHS = @mahs
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
			COMMIT
	END

DROP PROC sp_XoathongtinHocSinh
--sửa thông tin học sinh
CREATE PROC sp_SuaThongtinHocSinh(
	@mahs int, 
	@hoten nvarchar(50), 
	@gioitinh char(3), 
	@ngaysinh smalldatetime, 
	@diachi nvarchar(200),
	@email varchar(30),
	@tongiao varchar(30),
	@hotencha varchar(30),
	@nghenghiepcha varchar(30),
	@hotenme varchar(30),
	@nghenghiepme varchar(30),
	@malop char(5)
	) 
AS 
	BEGIN
		IF(NOT EXISTS (SELECT * FROM HOCSINH WHERE MAHS = @mahs))
			PRINT N'Học sinh không tồn tại'
		ELSE
		BEGIN TRAN
			SET TRAN ISOLATION LEVEL READ COMMITTED
			UPDATE HOCSINH
			SET HOTEN = @hoten, GIOITINH = @gioitinh, NGAYSINH = @ngaysinh, DIACHI = @diachi, EMAIL = @email, TONGIAO = @tongiao, HOTENCHAC = @hotencha,
				HOTENME = @hotenme, NGHENGHIEPME = @nghenghiepme, NGHENGHIEPCHA = @nghenghiepcha
			WHERE MAHS = @mahs
			IF(@@ERROR<>0)
				ROLLBACK TRANSACTION
			UPDATE PHANLOP
			SET MALOP = @malop
			WHERE MAHS = @mahs	
				IF(@@ERROR<>0)
				ROLLBACK TRANSACTION
		COMMIT
	END

drop proc sp_SuaThongtinHocSinh

--thêm học sinh
CREATE PROC sp_ThemHocSinh(
	@mahs int, 
	@hoten nvarchar(50), 
	@gioitinh char(3), 
	@ngaysinh smalldatetime, 
	@diachi nvarchar(200),
	@email varchar(30),
	@tongiao varchar(30),
	@hotencha varchar(30),
	@nghenghiepcha varchar(30),
	@hotenme varchar(30),
	@nghenghiepme varchar(30),
	@malop char(5),
	@manamhoc int,
	@makhoilop char(2)
	)
AS
	BEGIN
		IF(EXISTS (SELECT * FROM HOCSINH WHERE MAHS = @mahs))
			RETURN 1
		ELSE

		BEGIN TRAN
			SET TRAN ISOLATION LEVEL READ COMMITTED
			INSERT INTO HOCSINH VALUES(@mahs,@hoten,@gioitinh,@ngaysinh,@diachi,@email,@tongiao,@hotencha,@hotenme,@nghenghiepme,@nghenghiepcha)
			IF(@@ERROR<>0)
				ROLLBACK TRANSACTION
			INSERT INTO PHANLOP VALUES(@mahs,@malop, @manamhoc, @makhoilop)	
			IF(@@ERROR<>0)
				ROLLBACK TRANSACTION
		COMMIT
	END

drop proc sp_ThemHocSinh
EXEC sp_ThemHocSinh 50,'','','1/1/1995','b','b','b','b','b','b','b','10A1',2014,'10'
--lấy mã lớp
select * from PHANLOP
SELECT * FROM HOCSINH
DELETE FROM PHANLOP WHERE MAHS = 50
DELETE FROM HOCSINH WHERE MAHS = 50

--tìm kiếm thông tin học sinh
CREATE PROC sp_TiemKiemHocSinh(@hoten nvarchar(50))
AS
	BEGIN
		SELECT HS.MAHS, HS.HOTEN, HS.NGAYSINH, HS.GIOITINH, HS.DIACHI, HS.TONGIAO, HS.EMAIL, HS.HOTENCHAC,HS.NGHENGHIEPCHA, HS.HOTENME,HS.NGHENGHIEPME, PL.MAKHOILOP, PL.MALOP
	    FROM HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS
		WHERE HS.HOTEN LIKE '%'+@hoten+'%'
	END

--phân quyền, đăng nhập
CREATE PROC sp_DangNhap(@username char(5), @password varchar(30),@check int output, @name nvarchar(20) output,@malop char(5) output)
AS
	SET @check =0
	BEGIN
		IF(EXISTS (SELECT * FROM USERS WHERE ID = @username AND PASSWORD = @password)) BEGIN TRAN
			SET @check = 2
			SELECT @name = HOTEN FROM GIAOVIEN WHERE MAGV = @username
			SAVE TRAN B
			SELECT @malop = MALOP FROM LOP WHERE MAGVCN = @username
			IF(@@ERROR<>0 OR @@ROWCOUNT = 0) BEGIN
				ROLLBACK TRAN B
			END
			ELSE SET @check = 1
		COMMIT
	END
drop proc sp_DangNhap

--database quản lý điểm
--
CREATE PROC sp_LayDiemLop(@magv char(5))
AS
	BEGIN
	END