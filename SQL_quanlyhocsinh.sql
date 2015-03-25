alter table hocsinh add TONGIAO varchar(30)
alter table hocsinh add HOTENCHAC varchar(30)
alter table hocsinh add HOTENME varchar(30)
alter table hocsinh add NGHENGHIEPME varchar(30)
alter table hocsinh add NGHENGHIEPCHA varchar(30)

alter table lop add MATRGLOP int foreign key references hocsinh(MAHS)
ALTER TABLE LOP ADD MAGVCN CHAR (4) FOREIGN KEY REFERENCES GIAOVIEN(MAGV)
ALTER TABLE PHANLOP ADD FOREIGN KEY (MAHS) REFERENCES HOCSINH(MAHS)
DELETE FROM HOCSINH
DELETE FROM PHANLOP
create table GIAOVIEN(
	MAGV CHAR(4) PRIMARY KEY,
	HOTEN NVARCHAR(20),
	GIOITINH CHAR (3),
	SODT VARCHAR(11)
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
--lấy thông tin học sinh theo khối
CREATE PROC sp_ThongtinHocSinhtheoKhoi(@makhoi char(2)) 
AS
	BEGIN
		SELECT HS.MAHS, HS.HOTEN, HS.NGAYSINH, HS.GIOITINH, HS.DIACHI, HS.TONGIAO, HS.EMAIL, HS.HOTENCHAC,HS.NGHENGHIEPCHA, HS.HOTENME,HS.NGHENGHIEPME, PL.MAKHOILOP, PL.MALOP
	    FROM HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS
		WHERE PL.MAKHOILOP = @makhoi
	END

EXEC sp_ThongtinHocSinhtheoKhoi 11


--lấy thông tin học sinh theo lớp
CREATE PROC sp_ThongtinHocSinhtheoLop(@malop char(5))
AS
	BEGIN
		SELECT HS.MAHS, HS.HOTEN, HS.NGAYSINH, HS.GIOITINH, HS.DIACHI, HS.TONGIAO, HS.EMAIL, HS.HOTENCHAC,HS.NGHENGHIEPCHA, HS.HOTENME,HS.NGHENGHIEPME, PL.MAKHOILOP, PL.MALOP
	    FROM HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS
		WHERE PL.MALOP = @malop
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
			BEGIN
				DELETE FROM PHANLOP WHERE MAHS = @mahs
				DELETE FROM DIEM WHERE MAHS = @mahs
				DELETE FROM HOCSINH WHERE MAHS = @mahs
			END
	END

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
		BEGIN
			UPDATE HOCSINH
			SET HOTEN = @hoten, GIOITINH = @gioitinh, NGAYSINH = @ngaysinh, DIACHI = @diachi, EMAIL = @email, TONGIAO = @tongiao, HOTENCHAC = @hotencha,
				HOTENME = @hotenme, NGHENGHIEPME = @nghenghiepme, NGHENGHIEPCHA = @nghenghiepcha
			WHERE MAHS = @mahs
			UPDATE PHANLOP
			SET MALOP = @malop
			WHERE MAHS = @mahs	

		END
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
