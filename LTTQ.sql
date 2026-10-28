create database DuLieu

create table SanPham(
MaSanPham nvarchar(10) primary key,
TenSanPham nText not null,
GiaBan nvarchar(12) not null
);

insert into SanPham(MaSanPham,TenSanPham,GiaBan)Values('SP001',N'Nước Khoáng',10000),('SP002',N'Sữa tươi Vinamilk',25000),('SP003',N'Gạo tẻ thơm',45000),('SP004',N'Bánh quy AFC',30000),('SP005',N'Dầu ăn Tường An',65000);
select * from SanPham;