create database cuibap
go
use cuibap
go
create table Lop(
	MaLop varchar(10) not null primary key,
	TenLop nvarchar(50) not null
)
go
create table SinhVien(
	MSSV varchar(10) not null primary key,
	HoTen nvarchar(50) not null,
	MaLop varchar(10) not null,
	foreign key (MaLop) references Lop(MaLop)
)
go