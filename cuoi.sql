DROP TABLE IF EXISTS dbo.T_PhieuChi
DROP TABLE IF EXISTS dbo.T_PhieuThu
DROP TABLE IF EXISTS dbo.T_ChiTietMH
DROP TABLE IF EXISTS dbo.T_HoaDonMH
DROP TABLE IF EXISTS dbo.T_ChiTietBH
DROP TABLE IF EXISTS dbo.T_HoaDonBH
DROP TABLE IF EXISTS dbo.T_NhomHang
DROP TABLE IF EXISTS dbo.T_HangHoa
DROP TABLE IF EXISTS dbo.T_KhachHang
DROP TABLE IF EXISTS dbo.T_TaiKhoan
DROP TABLE IF EXISTS dbo.T_NhanVien
DROP TABLE IF EXISTS dbo.T_NhaCungCap

create table T_NhaCungCap (
	MaNCC varchar(10) primary key,
	TenNCC nvarchar(255) not null,
	DiaChiNCC nvarchar(255) not null,
	TP_Tinh nvarchar(30) null,
	DienThoaiNCC varchar(15) null,
	MST varchar(25) null,
	Web varchar(255) null,
)

create table T_NhanVien (
	MaNV varchar(10) primary key,
	HoTen nvarchar(255) not null,
	NgaySinh date null,
	Phai bit null,
	ChucVu nvarchar(30) null,
	DiaChi nvarchar(255) null,
	TP_Tinh nvarchar(30) null,
	DienThoai varchar(15) null,
)

create table T_TaiKhoan (
	MaTK varchar(10) primary key,
	TenTK varchar(50) not null,
	MatKhau varchar (50) not null,
	MaNV varchar(10),
	constraint FK_TaiKhoan_MaNV foreign key (MaNV) references T_NhanVien(MaNV)
)

create table T_KhachHang (
	MaKH varchar(10) primary key,
	TenKH nvarchar(255) not null,
	DiaChiKH nvarchar(255) null,
	TP_Tinh nvarchar(30) null,
	DienThoaiKH varchar(15) null,
	MST varchar(25) null,
)

create table T_NhomHang (
	MaNhom varchar(10) primary key,
	TenNhom nvarchar(255) not null,
)

create table T_HangHoa (
	MaHang varchar(20) primary key,
	MaNhom varchar(10) not null,
	TenHang nvarchar(255) not null,
	MaNCC varchar(10) not null,
	DVT nvarchar(15) not null,
	SLTonDK int not null,
	TGTonDK float not null,
	constraint FK_HangHoa_MaNCC foreign key (MaNCC) references T_NhaCungCap(MaNCC),
	constraint FK_HangHoa_MaHang foreign key (MaNhom) references T_NhomHang(MaNhom)
)

create table T_HoaDonBH (
	MaHDBH varchar(10) primary key,
	NgayLHD datetime not null,
	MaKH varchar(10) not null,
	MaNV varchar(10) not null,
	constraint FK_HoaDonBH_MaKH foreign key (MaKH) references T_KhachHang(MaKH),
	constraint FK_HoaDonBH_MaNV foreign key (MaNV) references T_NhanVien(MaNV),
)

create table T_ChiTietBH (
	MaHDBH varchar(10),
	MaHang varchar(20),
	SLBan int not null,
	DGBan float not null,
	CK float not null,
	CP float not null,
	constraint PK_MaHDBH_MaHang primary key (MaHDBH, MaHang),
	constraint FK_ChiTietBH_MaHDBH foreign key (MaHDBH) references T_HoaDonBH(MaHDBH),
	constraint FK_ChiTietBH_MaHang foreign key (MaHang) references T_HangHoa(MaHang),
)

create table T_HoaDonMH (
	MaHDMH varchar(10) primary key,
	NgayNhap datetime not null,
	MaNV varchar(10) not null,
	MaNCC varchar(10) not null,
	constraint FK_HoaDonMH_MaNV foreign key (MaNV) references T_NhanVien(MaNV),
	constraint FK_HoaDonMH_MaNCC foreign key (MaNCC) references T_NhaCungCap(MaNCC),
)

create table T_ChiTietMH (
	MaHDMH varchar(10),
	MaHang varchar(20),
	SLNhap int not null,
	DGNhap float not null,
	CK float not null,
	CP float not null,
	constraint PK_MaHDMH_MaHang primary key (MaHDMH, MaHang),
	constraint FK_ChiTietMH_MaHDMH foreign key (MaHDMH) references T_HoaDonMH(MaHDMH),
	constraint FK_ChiTietMH_MaHang foreign key (MaHang) references T_HangHoa(MaHang),
)

create table T_PhieuThu (
	MaPTT varchar(10) primary key,
	MaKH varchar(10) not null,
	NgayTT datetime not null,
	Thue float not null,
	SoTienTT float not null,
	MaNV varchar(10) not null,
	constraint FK_PhieuThu_MaKH foreign key (MaKH) references T_KhachHang(MaKH),
	constraint FK_PhieuThu_MaNV foreign key (MaNV) references T_NhanVien(MaNV),
)

create table T_PhieuChi (
	MaPC varchar(10) primary key,
	MaNV varchar(10) not null,
	MaNCC varchar(10) not null,
	NgayChi datetime not null,
	SoTien float not null,
	constraint FK_PhieuChi_MaNV foreign key (MaNV) references T_NhanVien(MaNV),
	constraint FK_PhieuChi_MaNCC foreign key (MaNCC) references T_NhaCungCap(MaNCC),
)

insert into T_NhaCungCap (MaNCC, TenNCC, DiaChiNCC, TP_Tinh, DienThoaiNCC, MST, Web)
values
('0001',N'Công Ty TNHH Thiên Long',N'158 Bàn Cờ-Q3-TPHCM',N'TP.HCM','08 8.358605','',''),
('0002',N'Siêu Thị Máy Tính Nguyễn Hoàng',N'Phường Cư Trinh-Q1-TPHCM',N'TP.HCM','8489.203404','',''),
('0003',N'Công Ty TNHH Tân Bách Khoa',N'171-Quốc Lộ 1-Biên Hòa-ĐN',N'Biên Hòa - Đồng Nai','061 .825880','',''),
('0005',N'Dịch Vụ Tin Học A & T',N'14 Lê Văn Tám-TP Vũng Tàu',N'TP Vũng Tàu','64 .530053','',''),
('0006',N'Công Ty TNHH Thành Nhân',N'174 Bùi Thi Xuân-Q1-TPHCM',N'TP.HCM','8489.250259','',''),
('0007',N'Công Ty TNHH  CTC',N'112 Khu Phước Hải-LT-ĐN',N'Biên Hòa - Đồng Nai','061.859600','',''),
('0008',N'Công Ty TNHH Đông An',N'130 Khu Phước Long-LT-ĐN',N'Biên Hòa - Đồng Nai','061 .845232','','')

insert into T_NhanVien (MaNV, HoTen, NgaySinh, Phai, ChucVu, DiaChi, TP_Tinh, DienThoai)
values
('01',N'PHẠM THÀNH TÀI','1978/03/16',1,N'Trưởng Phòng',N'115 QL15-Phường Quyết Thắng-Biên Hòa',N'Đồng Nai','0918144523'),
('02',N'NGUYỄN THỊ MAI','1990/08/18',0,N'Quản lý',N'Hố Nai 1',N'Biên Hoà - Đồng Nai','061887569'),
('03',N'HUỲNH THÁI SANG','',1,N'Nhân viên',N'Tân Biên',N'Biên Hoà - Đồng Nai','(065)41346'),
('04',N'MAI THỊ BÍCH TUYỀN','',0,N'Nhân viên',N'233/5 - KP8 Tân Biên',N'Biên Hoà - Đồng Nai',''),
('05',N'NGUYỄN THỊ KIM CHI','',0,N'',N'230 Long Tân-NT-ĐN',N'Biên Hoà - Đồng Nai','061518477'),
('06',N'NGUYỄN TẤN TRUNG','',1,N'Nhân Viên',N'1/02 QL51-LT-ĐN',N'Đồng Nai','061545789'),
('07',N'NGUYỄN VÕ THỊ MAI','',0,N'Nhân Viên',N'Ap 1 An Phước-LT-ĐN',N'Đồng Nai','061841235'),
('08',N'VÕ MINH QUÂN','',1,N'Nhân Viên',N'Thôn 3 Long Khánh-Đồng Nai',N'Đồng Nai','061826333')

insert into T_TaiKhoan(MaTK, TenTK, MatKhau, MaNV)
values
('01', 'admin', '123', '01'),
('02', 'maint', 'maint123', '02')

insert into T_KhachHang (MaKH, TenKH, DiaChiKH, TP_Tinh, DienThoaiKH, MST)
values
('00001',N'BÙI MINH KHÔI',N'Phường Hố Nai',N'Bến Lức - Long An','061887685',''),
('00002',N'TRẦN THỊ THIÊN THANH',N'Phường Hố Nai',N'Biên Hoà - Đồng Nai','061887685',''),
('00003',N'NGUYỄN THỊ TUYẾT NHUNG',N'Kp8 Phường Quyết Thắng-TP Biên Hòa',N'Đồng Nai','02648698',''),
('00004',N'ĐẶNG ANH NGỮ',N'Phường Tân Hoà-TP Biên Hòa',N'Biên Hoà - Đồng Nai','061897756',''),
('00005',N'NGUYỄN THỊ THÁI YẾN',N'Phường Hố Nai-TP-Biên Hòa',N'Biên Hoà - Đồng Nai','061897254',''),
('00006',N'NGUYỄN MINH TÂN',N'Long Thành-Đồng Nai',N'Biên Hoà - Đồng Nai','',''),
('00007',N'PHẠM THÀNH NHÂN',N'124 QL1-Biên Hòa',N'Biên Hoà - Đồng Nai','061856477',''),
('00008',N'VÕ THỊ MAI',N'Công Ty VeDan Việt Nam-Khu Công Nghiệp Gò aĐN',N'Đồng Nai','061848777',''),
('00009',N'PHẠM HUỲNH THANH MAI',N'Công Ty TACERA-Khu Công Nghiệp Gò Dầu-LT-ĐN',N'Đồng Nai','061845323',''),
('00010',N'QUỐC TIẾN DŨNG',N'Công Ty HuaLon Việt Nam-Khu Công Nghiệp 2-NT-ĐN',N'Đồng Nai','061845564','')

insert into T_NhomHang(MaNhom, TenNhom)
values
('CAB',N'Cáp'),
('CAR',N'Mực in'),
('CAS',N'Case'),
('CDR',N'Ổ đĩa'),
('CPU',N'Bộ xử lý trung tâm'),
('FDD',N'Ổ đĩa mềm'),
('FM',N'Modem'),
('HDD',N'Ổ cứng'),
('HPH',N'Tai nghe'),
('KB',N'Bàn phím'),
('MB',N'Bộ vi xử lý'),
('MOS',N'Chuột'),
('MOT',N'Màn hình'),
('OTH',N'Dụng cụ'),
('PRT',N'Máy in'),
('RAM',N'Bộ nhớ RAM'),
('SPK',N'Loa'),
('SWT',N'Thiết bị mạng'),
('UPS',N'Thiết bị ổn áp'),
('VGA',N'Card đồ họa'),
('WEC',N'Webcam')

insert into T_HangHoa (MaHang, MaNhom, TenHang, MaNCC, DVT, SLTonDK, TGTonDK)
values
('CAB0001','CAB',N'Power Cable','0008',N'Cái',0,0),
('CAB0004','CAB',N'Print Cable 5m','0003',N'Sợi',0,0),
('CAR00135','CAR',N'Mực In Hp 24A-HP Lajerjest 1150','0002',N'Thùng',0,0),
('CAR0050','CAR',N'Mực In HP 41A-HP Deskjet 840C, 760','0007',N'Lọ',0,0),
('CAS0107','CAS',N'Case Digital2702D','0003',N'Cái',0,0),
('CAS0108','CAS',N'Case Digital2705A','0003',N'Cái',1,18),
('CDR0003','CDR',N'CD 52X Sansung','0008',N'Cái',4,18),
('CDR0006','CDR',N'CD 52X Actima','0008',N'Cái',0,0),
('CPU0012','CPU',N'Celeron 1.2 Ghr','0001',N'Con',0,0),
('CPU0014','CPU',N'Celeron 1.3Ghr','0002',N'Con',0,0),
('FDD0002','FDD',N'FDD 1.44 SoNy','0001',N'Cái',0,0),
('FDD0003','FDD',N'FDD 1.44 Panasonic','0003',N'Cái',0,0),
('HDD0002','HDD',N'Seagate 20Gb ATA133-5400rpm-China','0002',N'Cái',4,51.5),
('HDD0003','HDD',N'Baracuda 30Gb-ATA100-7200rpm-Singapor','0005',N'Cái',5,60),
('HPH0002','HPH',N'headPhone có Micro','0001',N'Cái',0,0),
('HPH0010','HPH',N'Labtec Headphone Elite 840','0002',N'Cái',0,0),
('KB00024','KB',N'Keyboard Vibird','0006',N'Cái',4,5),
('KB00025','KB',N'Keyboard Gigabyte','0003',N'Cái',1,6),
('KH00031','KB',N'Keyboard Logitech','0006',N'Cái',0,0),
('MB00065','MB',N'Via 266E P4VMM2','0005',N'Cái',0,0),
('MB00137','MB',N'SIS 648 & SIS 963 L4S8A2','0006',N'Cái',0,0),
('MOS0005','MOS',N'Mouse Genius','0006',N'Con',6,2.5),
('MOT00130','MOT',N'Monitor 17" ACERAC713','0007',N'Cái',0,0),
('MOT0014','MOT',N'Monitor 15" Proview','0003',N'Cái',2,79),
('OTH0007','OTH',N'Kềm bấm mạng RJ45','0006',N'Cái',0,0),
('OTH0033','OTH',N'Pin Cmos','0008',N'Cái',0,0),
('PRT0004','PRT',N'Printer CanonBJC-2100SP','0002',N'Cái',0,0),
('PRT0023','PRT',N'Priter Canon S200SPX','0002',N'Cái',0,0),
('RAM0006','RAM',N'SDRam 128 Mhr','0001',N'Thanh',0,0),
('RAM0007','RAM',N'SDRam 256 Mhr','0002',N'Thanh',0,0),
('SPK0048','SPK',N'Speaker S-3000','0007',N'Cái',0,0),
('SPK0049','SPK',N'Speaker S-3300','0007',N'Cái',0,0),
('SWT0012','SWT',N'Switch 16ports 10/100Mbps','0003',N'Cái',0,0),
('SWT0020','SWT',N'Switch 8ports 1000Mbps','0008',N'Cái',0,0),
('UPS0003','UPS',N'UPS Power Tree 600VA','0006',N'Cái',0,0),
('UPS0004','UPS',N'UPS Sunpac 600VA','0006',N'Cái',0,0),
('VGA0055','VGA',N'Mercury 64Mb-Chip Geforce2 MX-400-AGB','0003',N'Cái',0,0),
('VGA0096','VGA',N'ASUS V9180SE-64Mb-Chip Geforce 4 MX440-AGB','0007',N'Cái',0,0),
('WEC0010','WEC',N'Webcam Exonics 612-101 pixels,usb port','0002',N'Cái',0,0),
('WEC0026','WEC',N'Webcam Creative NX Pro','0001',N'Cái',0,0)

insert into T_HoaDonBH (MaHDBH, NgayLHD, MaKH, MaNV)
values
('000001','2003/01/12','00001','02'),
('000002','2003/01/26','00002','03'),
('000003','2003/02/03','00003','02'),
('000004','2003/02/13','00004','04'),
('000005','2003/04/05','00005','02'),
('000007','2003/05/25','00005','03'),
('000008','2003/06/02','00008','02'),
('000009','2003/06/25','00009','03'),
('000010','2003/05/30','00010','02')



insert into T_ChiTietBH (MaHDBH, MaHang, SLBan, DGBan, CK, CP, Thue)
values
('000001','CAB0001',10,40,0,0,0),
('000001','CAR00135',20,30,0,0,0),
('000001','HDD0007',10,450,0,0,0),
('000001','WEC0010',2,50,0,0,0),
('000002','CAR00135',1,120,0,0,0),
('000002','HDD0025',5,500,0,0,0),
('000002','MOT0047',2,450,0,0,0),
('000003','MOS0061',1,70,0,0,0),
('000003','SPK0049',1,150,0,0,0),
('000004','KB00025',2,230,0,0,0),
('000004','RAM0006',2,135,0,0,0),
('000005','CPU0050',1,500,0,0,0),
('000005','HDD0075',1,600,0,0,0),
('000007','CAR00135',2,140,0,0,0),
('000007','KB00038',2,120,0,0,0),
('000007','WEC0010',1,100,0,0,0),
('000008','PRT0028',2,530,0,0,0),
('000008','VGA0103',2,300,0,0,0),
('000009','KH00031',1,150,0,0,0),
('000009','RAM0006',1,262,0,0,0),
('000010','CPU0055',2,420,0,0,0),
('000010','MOS0061',2,80,0,0,0),
('000010','RAM0007',2,600,0,0,0)

insert into T_HoaDonMH (MaHDMH, NgayNhap, MaNV, MaNCC)
values
('000001','2003/01/15','07','0002'),
('000002','2003/01/06','04','0005'),
('000003','2003/02/13','04','0005'),
('000004','2003/03/04','01','0006'),
('000005','2003/05/09','01','0008'),
('000006','2003/04/25','04','0005'),
('000007','2003/06/23','04','0003'),
('000008','2003/07/12','06','0002'),
('000009','2003/07/03','08','0001'),
('000010','2003/08/16','07','0002')

insert into T_ChiTietMH (MaHDMH, MaHang, SLNhap, DGNhap, CK, CP, Thue)
values
('000001','CAB0019',50,50,0,0,0),
('000001','HDD0025',20,240,0,0,0),
('000001','MB00190',6,530,0,0,0),
('000002','HDD0069',10,300,0,0,0),
('000002','MB00211',20,500,0,0,0),
('000002','OTH0048',3,100,0,0,0),
('000003','CAB0018',40,20,0,0,0),
('000003','CAR0078',20,101,0,0,0),
('000003','HDD0025',10,230,0,0,0),
('000004','RAM0015',10,130,0,0,0),
('000004','RAM0018',20,200,0,0,0),
('000004','WEC0010',30,120,0,0,0),
('000005','CAR00135',10,78,0,0,0),
('000005','OTH0036',40,50,0,0,0),
('000006','KB00038',20,120,0,0,0),
('000006','MOT0014',5,320,0,0,0),
('000007','CAB0018',30,30,0,0,0),
('000007','KB00025',40,120,0,0,0),
('000008','FM00030',20,121,0,0,0),
('000008','MB00248',10,520,0,0,0),
('000008','OTH0033',100,15,0,0,0),
('000009','HDD0065',10,200,0,0,0),
('000009','MB00211',10,450,0,0,0),
('000009','OTH0033',10,15,0,0,0),
('000010','CAB0004',100,5,0,0,0),
('000010','MB00137',5,500,0,0,0),
('000010','MOT00130',10,400,0,0,0)

insert into T_PhieuThu (MaPTT, MaKH, NgayTT, SoTienTT, MaNV)
values
('000001','00001','2004/01/03',4600,'02')

insert into T_PhieuChi (MaPC, MaNV, MaNCC, NgayChi, SoTien)
values
('000001','02','0002','2004/02/03',40480),
('000002','03','0006','2004/09/16',2000),
('000003','06','0007','2004/10/22',1500),
('000004','02','0002','2005/08/19',20000)
