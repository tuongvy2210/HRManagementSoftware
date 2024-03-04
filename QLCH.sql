﻿DROP TABLE IF EXISTS dbo.T_PhieuChi
DROP TABLE IF EXISTS dbo.T_PhieuThu
DROP TABLE IF EXISTS dbo.T_ChiTietMH
DROP TABLE IF EXISTS dbo.T_HoaDonMH
DROP TABLE IF EXISTS dbo.T_ChiTietBH
DROP TABLE IF EXISTS dbo.T_HoaDonBH
DROP TABLE IF EXISTS dbo.T_NhomHang
DROP TABLE IF EXISTS dbo.T_HangHoa
DROP TABLE IF EXISTS dbo.T_KhachHang
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
('00010',N'QUỐC TIẾN DŨNG',N'Công Ty HuaLon Việt Nam-Khu Công Nghiệp 2-NT-ĐN',N'Đồng Nai','061845564',''),
('00011',N'HUỲNH THANH MAI',N'Ấp 2 An Phước-LT-ĐN',N'Đồng Nai','061845612',''),
('00012',N'NGUYỄN THỊ MAI',N'Ấp 3 Long Thọ-LT-ĐN',N'Đồng Nai','',''),
('00013',N'MAI THỊ THANH NHÀN',N'Ấp Long Phú Phước Thái-LT-ĐN',N'Đồng Nai','061865932',''),
('00014',N'NGUYỄN PHƯỚC TUẤN',N'Long Đức-LT-ĐN',N'Đồng Nai','061545321',''),
('00015',N'PHAN THANH MAI',N'Phước An-NT-ĐN',N'Đồng Nai','',''),
('00016',N'LÝ ĐỨC BÌNH',N'Phước Thiền-NT-ĐN',N'Đồng Nai','845698',''),
('00017',N'VÕ MINH TÂM',N'Long Thành-Đồng Nai',N'Đồng Nai','',''),
('00018',N'PHẠM NGỌC THANH',N'Long Thọ NT_ĐN',N'Đồng Nai','',''),
('00019',N'VĂN THỊ NỮ',N'Phú Mỹ-Bà Rịa Vũng Tàu',N'Vũng Tàu','836412',''),
('00020',N'NGÔ QUANG HUY',N'Phước Thái-LT-ĐN',N'Đồng Nai','061 845211',''),
('00021',N'PHẠM THỊ THANH MAI',N'Khu Văn Hải-Thị Trấn Long Thành',N'Đồng Nai','061 545612',''),
('00022',N'VĂN SỸ HÙNG',N'QL15-BH-ĐN',N'Đồng Nai','061865147',''),
('00023',N'NGUYỄN VĂN THANH',N'Phước Khánh-NT-ĐN',N'Đồng Nai','061 865291',''),
('00024',N'QUỐC ANH DŨNG',N'phú Mỹ-BR Vũng Tàu',N'Vũng Tàu','065 895632',''),
('00025',N'MAI THỊ THANH',N'Mỹ Xuân-BR Vũng Tàu',N'Vũng Tàu','',''),
('00026',N'THÁI THỊ THANH TRÚC',N'Hố Nai-Biên Hòa',N'Biên Hòa','061 865123',''),
('00027',N'QUỐC THI MINH TÂM',N'An PhướcLT-ĐN',N'Đồng Nai','',''),
('00028',N'ÔNG QUỐC DŨNG',N'An Phước-LT-ĐN',N'Đồng Nai','',''),
('00029',N'NGÔ MINH TÂM',N'Long Thọ-LT-ĐN',N'Đồng Nai','',''),
('00030',N'THÁI NGỌC NINH',N'Khu Văn Hải-LT-ĐN',N'Đồng Nai','',''),
('00031',N'TRƯƠNG CHÍ DŨNG',N'long Đức-LT-ĐN',N'Đồng Nai','',''),
('00032',N'VÒ NGỌC MINH',N'An Phước-LT-ĐN',N'Đồng Nai','',''),
('00033',N'NGUYỄN NGỌC SƠN',N'An Lợi-LT-ĐN',N'Đồng Nai','','')


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
('CAB0018','CAB',N'Cable UTP','0007',N'Thùng',0,0),
('CAB0019','CAB',N'Cable UTP 2','0008',N'Thùng',0,0),
('CAR00135','CAR',N'Mực In Hp 24A-HP Lajerjest 1150','0002',N'Thùng',0,0),
('CAR0050','CAR',N'Mực In HP 41A-HP Deskjet 840C, 760','0007',N'Lọ',0,0),
('CAR0075','CAR',N'Mực In Inktec 9014-Epson 480, 580, C20, C40','0003',N'Lọ',0,0),
('CAR0078','CAR',N'Mực In Inktec 9017-Epson 680','0008',N'Lọ',1,6),
('CAR0134','CAR',N'Mực In HP 13A-Hp laserjet 1300','0005',N'Lọ',0,0),
('CAS0107','CAS',N'Case Digital2702D','0003',N'Cái',0,0),
('CAS0108','CAS',N'Case Digital2705A','0003',N'Cái',1,18),
('CAS0109','CAS',N'Case Digital2708B','0006',N'Cái',0,0),
('CAS0110','CAS',N'Case Digital2721B','0003',N'Cái',1,18),
('CDR0003','CDR',N'CD 52X Sansung','0008',N'Cái',4,18),
('CDR0006','CDR',N'CD 52X Actima','0008',N'Cái',0,0),
('CDR002','CDR',N'CD 52X LG','0001',N'Cái',6,19),
('CDR0022','CDR',N'CD 54X Mitsumi','0001',N'Cái',0,0),
('CPU0012','CPU',N'Celeron 1.2 Ghr','0001',N'Con',0,0),
('CPU0014','CPU',N'Celeron 1.3Ghr','0002',N'Con',0,0),
('CPU0025','CPU',N'Intel P4 1.7Ghr','0001',N'Con',1,115),
('CPU0026','CPU',N'Intel P4 2.0 Ghr','0008',N'Con',0,0),
('CPU0027','CPU',N'Intel P4 1.8 Ghr','0005',N'Con',1,117),
('CPU0030','CPU',N'Celeron 1.7 Ghr','0003',N'Con',5,55),
('CPU0038','CPU',N'Intel P4 2.4 Ghr','0001',N'Con',0,0),
('CPU0048','CPU',N'Celeron 1.8Ghr','0005',N'Con',4,66.5),
('CPU0049','CPU',N'Celeron 2.0Ghr','0007',N'Con',0,0),
('CPU0050','CPU',N'Intel P4 2.66 Ghr','0005',N'Con',0,0),
('CPU0053','CPU',N'Intel P4 2.6 Ghr','0001',N'Con',0,0),
('CPU0055','CPU',N'Intel P4 2.8 Ghr','0003',N'Con',0,0),
('CPU0056','CPU',N'Celeron 2.4Ghr','0002',N'Con',1,79),
('CPU0058','CPU',N'Intel P4 3.0 Ghr','0008',N'Con',0,0),
('FDD0002','FDD',N'FDD 1.44 SoNy','0001',N'Cái',0,0),
('FDD0003','FDD',N'FDD 1.44 Panasonic','0003',N'Cái',0,0),
('FDD0005','FDD',N'FDD 1.44 Mitsumi','0008',N'Cái',10,7),
('FDD0006','FDD',N'FDD External Mitsumi,USB','0007',N'Cái',0,0),
('FDD0009','FDD',N'FDD External Nec,USB','0007',N'Cái',0,0),
('FM00010','FM',N'Fax Modem Acorp(ext)','0003',N'Cái',2,24.5),
('FM00030','FM',N'Fax Modem Acorp','0003',N'Cái',0,0),
('FM00031','FM',N'Fax Modem Intel','0008',N'Cái',4,12),
('HDD0002','HDD',N'Seagate 20Gb ATA133-5400rpm-China','0002',N'Cái',4,51.5),
('HDD0003','HDD',N'Baracuda 30Gb-ATA100-7200rpm-Singapor','0005',N'Cái',5,60),
('HDD0007','HDD',N'Maxtor 20 Gb-ATA133-5400 rpm-ChiNa','0006',N'Cái',0,0),
('HDD0013','HDD',N'Seagete 40Gb ATA133-5400rpm-Singapore','0005',N'Cái',6,55),
('HDD0019','HDD',N'Baracuda 40Gr-ATA-7200rpm-China','0005',N'Cái',0,0),
('HDD0025','HDD',N'Maxtor 40 Gb Plus-ATA133-7200rpm-Singapore','0005',N'Cái',0,0),
('HDD0038','HDD',N'Hitachi 30 Ghr,ATA66-420 rpm','0002',N'Cái',1,128),
('HDD0040','HDD',N'Maxtor 40 Gb-ATA133-5400rpm-Singapore','0006',N'Cái',0,0),
('HDD0043','HDD',N'Maxtor 30 Gb-ATA133-5400rpm-Singapor','0003',N'Cái',0,0),
('HDD0048','HDD',N'Maxtor 30 Gb Plus-ATA133-7200rpm-7200rpm','0007',N'Cái',0,0),
('HDD0059','HDD',N'Maxtor 80 Gb Plus-ATA133-7200rpm-Singapor','0003',N'Cái',0,0),
('HDD0060','HDD',N'Hitachi 40 Ghr,ATA66-4200rpm-for noterbook','0003',N'Cái',2,140),
('HDD0065','HDD',N'Maxtor 18.4Gb-SCSI 10000rpm','0002',N'Cái',0,0),
('HDD0069','HDD',N'Fujitsu 30 Ghr,ATA66-4200 rpm,for noterbook','0006',N'Cái',1,128),
('HDD0071','HDD',N'Seagete 80 Gb S.ATA-7200-China','0007',N'Cái',0,0),
('HDD0075','HDD',N'Samsung 120Gb S-ATA-7200-Korea','0006',N'Cái',0,0),
('HDD0080','HDD',N'Maxtor 120Gb S-ATA-7200rpm','0002',N'Cái',1,117),
('HPH0002','HPH',N'headPhone có Micro','0001',N'Cái',0,0),
('HPH0010','HPH',N'Labtec Headphone Elite 840','0002',N'Cái',0,0),
('KB00024','KB',N'Keyboard Vibird','0006',N'Cái',4,5),
('KB00025','KB',N'Keyboard Gigabyte','0003',N'Cái',1,6),
('KB00038','KB',N'Keyboard Mitsumi','0005',N'Cái',12,6),
('KH00031','KB',N'Keyboard Logitech','0006',N'Cái',0,0),
('MB00065','MB',N'Via 266E P4VMM2','0005',N'Cái',0,0),
('MB00137','MB',N'SIS 648 & SIS 963 L4S8A2','0006',N'Cái',0,0),
('MB00190','MB',N'Intel 845 P4IBAD2','0003',N'Cái',0,0),
('MB00192','MB',N'InTel 845GV L4IGVM6','0001',N'Cái',0,0),
('MB00211','MB',N'VIA P4X400 & VT8235 L4VXAF','0006',N'Cái',0,0),
('MB00248','MB',N'D845 GVSR,Socket478,Bus533,S/P 3.06Ghz,Sound=Vga OnBoard','0001',N'Cái',0,0),
('MB00284','MB',N'Intel 845GVMRZ','0006',N'Cái',0,0),
('MOS0005','MOS',N'Mouse Genius','0006',N'Con',6,2.5),
('MOS0028','MOS',N'Mouse Mitsumi','0006',N'Con',20,3.5),
('MOS0061','MOS',N'Mouse Mitoni','0008',N'Con',1,3.5),
('MOS0062','MOS',N'Mouse Vibird','0007',N'Con',0,0),
('MOT00130','MOT',N'Monitor 17" ACERAC713','0007',N'Cái',0,0),
('MOT0014','MOT',N'Monitor 15" Proview','0003',N'Cái',2,79),
('MOT0015','MOT',N'Monitor 17" Proview','0005',N'Cái',1,99),
('MOT0041','MOT',N'Monitor 17" ProLink','0006',N'Cái',1,105),
('MOT0047','MOT',N'Monitor 15" JVC','0001',N'Cái',1,82),
('MOT0050','MOT',N'Monitor 15" Likom','0001',N'Cái',2,78),
('MOT0055','MOT',N'Monitor 17" likom','0001',N'Cái',4,99),
('MOT0113','MOT',N'Monitor 15" E-Machines-15W','0007',N'Cái',0,0),
('OTH0007','OTH',N'Kềm bấm mạng RJ45','0006',N'Cái',0,0),
('OTH0033','OTH',N'Pin Cmos','0008',N'Cái',0,0),
('OTH0036','OTH',N'Bóp đựng đĩa 48 cái','0005',N'Cái',0,0),
('OTH0048','OTH',N'Bộ đồ nghề','0002',N'Hộp',0,0),
('PRT0004','PRT',N'Printer CanonBJC-2100SP','0002',N'Cái',0,0),
('PRT0023','PRT',N'Priter Canon S200SPX','0002',N'Cái',0,0),
('PRT0028','PRT',N'Priter CanonLBP-1210','0006',N'Cái',0,0),
('PRT0030','PRT',N'Printer Canon LBP-1120','0006',N'Cái',0,0),
('RAM0006','RAM',N'SDRam 128 Mhr','0001',N'Thanh',0,0),
('RAM0007','RAM',N'SDRam 256 Mhr','0002',N'Thanh',0,0),
('RAM0015','RAM',N'DDRam 256 Mhr','0008',N'Thanh',0,0),
('RAM0016','RAM',N'DDRam 128 Mhr','0001',N'Thanh',0,0),
('RAM0018','RAM',N'DDRam 512 Mhr','0003',N'Thanh',0,0),
('SPK0048','SPK',N'Speaker S-3000','0007',N'Cái',0,0),
('SPK0049','SPK',N'Speaker S-3300','0007',N'Cái',0,0),
('SPK0050','SPK',N'Speaker S-3600','0006',N'Cái',0,0),
('SPK0060','SPK',N'Speaker J-607','0003',N'Cái',0,0),
('SWT0012','SWT',N'Switch 16ports 10/100Mbps','0003',N'Cái',0,0),
('SWT0020','SWT',N'Switch 8ports 1000Mbps','0008',N'Cái',0,0),
('UPS0003','UPS',N'UPS Power Tree 600VA','0006',N'Cái',0,0),
('UPS0004','UPS',N'UPS Sunpac 600VA','0006',N'Cái',0,0),
('VGA0055','VGA',N'Mercury 64Mb-Chip Geforce2 MX-400-AGB','0003',N'Cái',0,0),
('VGA0096','VGA',N'ASUS V9180SE-64Mb-Chip Geforce 4 MX440-AGB','0007',N'Cái',0,0),
('VGA0103','VGA',N'GIGABYTE R7064T 64Mb-Chip Ati Radeon 7000-AGB','0008',N'Cái',0,0),
('VGA0104','VGA',N'ECS ATI R9200L 64Mb-Chip Ati 9200-AGB','0002',N'Cái',0,0),
('VGA0120','VGA',N'MSI 32Mb MX400 D-32-D1DRam,Chip Geforce 2 MX-400-AGB','0008',N'Cái',0,0),
('WEC0010','WEC',N'Webcam Exonics 612-101 pixels,usb port','0002',N'Cái',0,0),
('WEC0026','WEC',N'Webcam Creative NX Pro','0001',N'Cái',0,0),
('WEC0031','WEC',N'webcam Creative NX-352*288-USB port,Chỉnh xoay được 26 độ','0005',N'Cái',0,0),
('WEC0034','WEC',N'Webcam @Cam Nc-303','0008',N'Cái',0,0)

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
('000010','2003/05/30','00010','02'),
('000011','2003/06/04','00012','03'),
('000012','2003/07/01','00012','06'),
('000013','2003/07/15','00013','05'),
('000014','2003/08/16','00014','06'),
('000015','2003/08/30','00015','02'),
('000016','2003/09/06','00016','03'),
('000018','2003/09/28','00018','01'),
('000019','2003/10/10','00019','01'),
('000020','2003/10/30','00020','02'),
('000023','2003/11/11','00023','04'),
('000024','2003/10/25','00024','04'),
('000025','2003/11/30','00025','03'),
('000026','2003/12/12','00026','03'),
('000027','2004/01/01','00027','01'),
('000028','2004/01/15','00028','02'),
('000029','2004/01/29','00029','05'),
('000030','2004/02/12','00030','05'),
('000031','2004/02/26','00031','01'),
('000032','2004/03/12','00032','01'),
('000033','2004/03/29','00033','06'),
('000034','2004/04/06','00013','03'),
('000035','2004/04/26','00006','03'),
('000036','2004/04/30','00015','01'),
('000037','2004/05/12','00023','06'),
('000039','2004/05/29','00026','06'),
('000040','2004/06/01','00021','03'),
('000041','2004/06/05','00019','04'),
('000042','2004/06/28','00014','04'),
('000043','2004/07/03','00031','05'),
('000044','2004/07/15','00018','01'),
('000045','2004/07/30','00021','01'),
('000046','2004/08/12','00033','04'),
('000047','2004/08/28','00031','04'),
('000048','2004/08/30','00032','02'),
('000049','2004/09/01','00007','05')


insert into T_ChiTietBH (MaHDBH, MaHang, SLBan, DGBan, CK, CP)
values
('000001','CAB0001',10,40,0,0),
('000001','CAR00135',20,30,0,0),
('000001','HDD0007',10,450,0,0),
('000001','WEC0010',2,50,0,0),
('000002','CAR00135',1,120,0,0),
('000002','HDD0025',5,500,0,0),
('000002','MOT0047',2,450,0,0),
('000003','MOS0061',1,70,0,0),
('000003','SPK0049',1,150,0,0),
('000004','KB00025',2,230,0,0),
('000004','RAM0006',2,135,0,0),
('000005','CPU0050',1,500,0,0),
('000005','HDD0075',1,600,0,0),
('000007','CAR00135',2,140,0,0),
('000007','KB00038',2,120,0,0),
('000007','WEC0010',1,100,0,0),
('000008','PRT0028',2,530,0,0),
('000008','VGA0103',2,300,0,0),
('000009','KH00031',1,150,0,0),
('000009','RAM0006',1,262,0,0),
('000010','CPU0055',2,420,0,0),
('000010','MOS0061',2,80,0,0),
('000010','RAM0007',2,600,0,0),
('000011','CPU0038',1,420,0,0),
('000011','MOT0050',1,140,0,0),
('000012','FM00010',2,120,0,0),
('000012','VGA0104',2,150,0,0),
('000013','HDD0069',2,530,0,0),
('000013','MB00137',2,540,0,0),
('000014','HDD0019',5,500,0,0),
('000014','MOS0005',10,80,0,0),
('000015','CAB0004',20,50,0,0),
('000015','CAB0018',100,40,0,0),
('000016','MB00190',4,560,0,0),
('000016','RAM0015',2,560,0,0),
('000018','VGA0120',1,320,0,0),
('000018','WEC0031',1,230,0,0),
('000019','PRT0004',1,3200,0,0),
('000019','RAM0018',1,1002,0,0),
('000020','HDD0040',2,452,0,0),
('000020','VGA0096',2,250,0,0),
('000023','MOS0028',5,80,0,0),
('000023','PRT0028',3,1020,0,0),
('000024','FM00030',1,120,0,0),
('000024','MB00065',1,520,0,0),
('000025','HPH0010',2,100,0,0),
('000025','RAM0006',2,320,0,0),
('000026','CAR0050',1,560,0,0),
('000026','PRT0023',1,1200,0,0),
('000027','CAB0018',30,41,0,0),
('000027','MB00192',2,530,0,0),
('000028','MB00190',1,600,0,0),
('000028','MOS0062',1,100,0,0),
('000029','MB00248',1,510,0,0),
('000029','UPS0003',1,400,0,0),
('000030','OTH0007',1,420,0,0),
('000030','RAM0007',1,540,0,0),
('000031','KB00025',1,230,0,0),
('000031','VGA0096',1,320,0,0),
('000032','MB00211',5,560,0,0),
('000033','MOS0062',1,85,0,0),
('000034','CAB0001',5,20,0,0),
('000034','CAB0004',5,10,0,0),
('000035','CAB0018',10,50,0,0),
('000035','CAB0019',5,500,0,0),
('000036','CAR00135',3,45,0,0),
('000036','CAR0050',2,50,0,0),
('000037','CAR0075',2,70,0,0),
('000037','PRT0023',1,900,0,0),
('000039','FDD0005',2,80,0,0),
('000039','HDD0002',2,560,0,0),
('000040','FM00030',1,350,0,0),
('000041','FM00010',1,360,0,0),
('000041','WEC0031',1,230,0,0),
('000042','MB00065',1,530,0,0),
('000043','OTH0033',10,15,0,0),
('000043','VGA0103',2,230,0,0),
('000044','KB00038',1,120,0,0),
('000044','MOS0005',1,81,0,0),
('000045','KB00024',1,123,0,0),
('000045','SPK0060',1,230,0,0),
('000046','FDD0003',2,80,0,0),
('000047','MOS0062',2,80,0,0),
('000047','WEC0010',2,130,0,0),
('000048','CAB0001',1,50,0,0),
('000048','WEC0034',1,132,0,0),
('000049','CAB0004',2,120,0,0)

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
('000010','2003/08/16','07','0002'),
('000011','2003/09/03','01','0001'),
('000013','2003/10/14','07','0002'),
('000014','2003/11/30','07','0002'),
('000015','2003/12/12','08','0001'),
('000016','2004/01/01','01','0001'),
('000017','2004/01/12','05','0001'),
('000018','2004/02/02','04','0003'),
('000019','2004/03/15','05','0003'),
('000020','2004/04/12','05','0002'),
('000021','2004/05/23','06','0001'),
('000022','2004/05/01','08','0001'),
('000023','2004/05/05','02','0001'),
('000024','2004/06/06','02','0001'),
('000025','2004/06/30','08','0003'),
('000026','2004/07/03','01','0001'),
('000027','2004/08/07','05','0002'),
('000028','2004/08/12','01','0002'),
('000029','2004/08/20','03','0006'),
('000030','2004/08/25','03','0003'),
('000031','2004/08/29','04','0003'),
('000032','2004/08/29','01','0005'),
('000035','2004/08/26','06','0003'),
('000036','2004/08/30','08','0002'),
('000037','2004/09/01','03','0001'),
('000038','2004/09/02','02','0002')

insert into T_ChiTietMH (MaHDMH, MaHang, SLNhap, DGNhap, CK, CP)
values
('000001','CAB0019',50,50,0,0),
('000001','HDD0025',20,240,0,0),
('000001','MB00190',6,530,0,0),
('000002','HDD0069',10,300,0,0),
('000002','MB00211',20,500,0,0),
('000002','OTH0048',3,100,0,0),
('000003','CAB0018',40,20,0,0),
('000003','CAR0078',20,101,0,0),
('000003','HDD0025',10,230,0,0),
('000004','RAM0015',10,130,0,0),
('000004','RAM0018',20,200,0,0),
('000004','WEC0010',30,120,0,0),
('000005','CAR00135',10,78,0,0),
('000005','OTH0036',40,50,0,0),
('000006','KB00038',20,120,0,0),
('000006','MOT0014',5,320,0,0),
('000007','CAB0018',30,30,0,0),
('000007','KB00025',40,120,0,0),
('000008','FM00030',20,121,0,0),
('000008','MB00248',10,520,0,0),
('000008','OTH0033',100,15,0,0),
('000009','HDD0065',10,200,0,0),
('000009','MB00211',10,450,0,0),
('000009','OTH0033',10,15,0,0),
('000010','CAB0004',100,5,0,0),
('000010','MB00137',5,500,0,0),
('000010','MOT00130',10,400,0,0),
('000011','CPU0050',10,500,0,0),
('000011','FM00010',20,210,0,0),
('000011','MB00190',20,460,0,0),
('000013','KB00025',4,120,0,0),
('000013','MB00248',5,530,0,0),
('000013','MOT0015',10,400,0,0),
('000014','HDD0071',5,550,0,0),
('000014','KB00038',20,200,0,0),
('000015','KB00038',100,120,0,0),
('000015','MB00065',5,500,0,0),
('000015','MB00137',20,420,0,0),
('000016','FM00030',20,130,0,0),
('000016','MB00192',8,530,0,0),
('000016','MOT0041',10,450,0,0),
('000017','MB00284',30,600,0,0),
('000017','MOT0055',10,450,0,0),
('000017','VGA0120',30,32,0,0),
('000018','HDD0069',10,350,0,0),
('000018','KB00038',10,120,0,0),
('000019','HDD0060',10,450,0,0),
('000019','OTH0007',10,79,0,0),
('000020','CPU0025',20,450,0,0),
('000020','FDD0005',100,70,0,0),
('000021','CPU0053',10,500,0,0),
('000021','HDD0025',10,450,0,0),
('000021','MB00211',10,520,0,0),
('000022','CAR0075',100,100,0,0),
('000022','CAR0078',20,120,0,0),
('000022','MB00137',3,420,0,0),
('000023','KB00038',10,112,0,0),
('000023','MB00190',5,620,0,0),
('000023','RAM0015',100,200,0,0),
('000024','CAB0004',1000,5,0,0),
('000024','CAR0075',20,10,0,0),
('000024','MB00248',2,560,0,0),
('000025','MOS0028',100,100,0,0),
('000025','WEC0026',10,250,0,0),
('000026','MB00284',5,530,0,0),
('000026','RAM0015',10,450,0,0),
('000026','RAM0018',20,456,0,0),
('000027','CAB0019',10,1000,0,0),
('000027','CAR0078',100,100,0,0),
('000027','KB00038',200,120,0,0),
('000028','CAB0018',20,200,0,0),
('000028','CPU0026',5,450,0,0),
('000029','HDD0019',20,450,0,0),
('000029','MOT0113',10,500,0,0),
('000030','HDD0059',30,600,0,0),
('000030','HDD0071',50,800,0,0),
('000031','CPU0025',20,56,0,0),
('000031','FM00010',20,120,0,0),
('000032','FDD0005',10,120,0,0),
('000032','MB00137',10,560,0,0),
('000035','HPH0010',5,90,0,0),
('000035','SPK0048',5,150,0,0),
('000036','CAB0018',100,50,0,0),
('000036','CAB0019',10,600,0,0),
('000037','CAB0001',10,100,0,0),
('000038','CAB0004',5,500,0,0)

insert into T_PhieuThu (MaPTT, MaKH, NgayTT, SoTienTT, MaNV)
values
('0000000001','00001','2004/01/03',4600,'02')

insert into T_PhieuChi (MaPC, MaNV, MaNCC, NgayChi, SoTien)
values
('000001','02','0002','2004/02/03',40480),
('000002','03','0006','2004/09/16',2000),
('000003','06','0007','2004/10/22',1500),
('000004','02','0002','2005/08/19',20000)