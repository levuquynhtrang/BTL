create database DKTC;
use DKTC;

create table tblMonHoc(
MaMon char(10) primary key,
TenMon nvarchar(30),
SoTC int)

drop table tblMonHoc;

create table tblSV(
MaSV char(10) primary key,
TenSV nvarchar(30),
Khoa int)
alter table tblSV add PW char(20)
alter table tblSV add LopCN nvarchar(30)

drop table tblSV;

create table tblLop(
MaLop char(10) primary key,
MaMon char(10) foreign key references tblMonHoc(MaMon),
TenLop nvarchar(10),
GiangVien nvarchar(30),
PhongHoc varchar(10),
SoLuongSV int,
MaSV char(10) foreign key references tblSV(MaSV)
)

drop table tblLop;

create table tblLSDK(
MaSV char(10) foreign key references tblSV(MaSV),
HocKy int,
MaMon char(10) foreign key references tblMonHoc(MaMon)
)

drop table tblLSDK;

create table tblNQL(
MaNQL char(10) primary key,
TenNQL nvarchar(30))

drop table tblNQL;
delete from tblSV;
delete from tblMonHoc;
delete from tblLop;
delete from tblLSDK;

select * from tblMonHoc;

select * from tblSV;
