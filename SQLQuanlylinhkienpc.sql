create database quanlylinhkienpc
go
use quanlylinhkienpc
go
create table taikhoan
(
id int  IDENTITY(1,1)not null ,
username varchar(30) not null ,
password varchar(1000) not null ,
level int default 0 ,
primary key(id,username)
)
go

create table linhkien
(	id int  IDENTITY(1,1)not null,
	malinhkien char(10) not null,
	ten nvarchar(50) not null,	
	loai char(10) not null,
	quycach nvarchar(100),
	noisanxuat nvarchar(30),
	namsanxuat date,
	thoigianbh int,
	primary key(malinhkien)
)
go

create table muaban
(
id int  IDENTITY(1,1)not null,
malinhkien char(10) not null,
chatluong int not null,
gianhap float not null,
giaxuat float not null,
lai float,
primary key(id,malinhkien),
foreign key(malinhkien) references linhkien(malinhkien)
)
go

create table soluong
(
id int  IDENTITY(1,1)not null,
malinhkien char(10) not null,
slnhap int default 0,
slxuat int default 0,
slcon int default 0,
primary key(id,malinhkien),
foreign key(malinhkien) references linhkien(malinhkien)
)
go

create table thunhap
(
id int  IDENTITY(1,1)not null,
malinhkien char(10) not null,
tienvon float,
tienthu float,
tienlai float ,
hoivon float,
primary key(id,malinhkien),
foreign key(malinhkien) references linhkien(malinhkien)
)
go
create table khachhang(
makhachhang int  IDENTITY(1,1)not null,
ngaythanhtoan datetime,
hoten nvarchar(50) not null,
diachi nvarchar(20) not null,
sdt nvarchar(12)not null,
tongtien float not null,
hanhdong nvarchar(30) not null,
primary key(makhachhang)
)
go
create table hoadon(
mahoadon int IDENTITY(1,1)not null,
makhachhang int not null,
malinhkien char(10) not null,
gia float not null,
soluong int not null,
thanhtien float not null,
primary key(mahoadon),
foreign key(malinhkien) references linhkien(malinhkien),
foreign key(makhachhang) references khachhang(makhachhang),
)
go


create proc inshoadon(
@makhachhang int,
@malinhkien char(10) ,
@gia float,
@soluong int ,
@thanhtien float 
)
as begin
insert into hoadon values(@makhachhang,@malinhkien,@gia,@soluong,@thanhtien)
end
go
create proc delhoadon(
@mahoadon int
)
as begin
delete from hoadon where mahoadon=@mahoadon
end
go

create proc inskhachhang(
@ngaythanhtoan datetime,
@hoten nvarchar(50) ,
@diachi nvarchar(20) ,
@sdt nvarchar(12),
@tongtien float ,
@hanhdong nvarchar(30))
as begin
insert into khachhang values(@ngaythanhtoan,@hoten,@diachi,@sdt,@tongtien,@hanhdong)
end
go
create proc delkhachhang(@makhachhang int)
as begin
delete from khachhang where makhachhang=@makhachhang
end 
go

create proc  insertmuaban( @malinhkien char(10),@chatluong int,@gianhap float,@giaxuat float)
as
begin
insert into muaban values (@malinhkien,@chatluong,@gianhap,@giaxuat,@giaxuat-@gianhap)
end
go
create proc  updatemuaban(@id int, @malinhkien char(10),@chatluong int,@gianhap float,@giaxuat float)
as
begin
update  muaban 
set malinhkien=@malinhkien,chatluong=@chatluong,gianhap=@gianhap,giaxuat=@giaxuat,lai=@giaxuat-@gianhap
where id=@id
end
go

create proc  insertsoluong( @malinhkien char(10),@slnhap int,@slxuat int)
as
begin
insert into soluong values (@malinhkien,@slnhap,@slxuat,@slnhap-@slxuat)
end
go

create proc  updatesoluong(@id int, @malinhkien char(10),@slnhap int,@slxuat int)
as
begin
update soluong set slnhap=@slnhap,slxuat=@slxuat
where id=@id
update soluong set slcon=slnhap-slxuat
where id=@id
end
go

create proc  insertthunhap( @malinhkien char(10))
as
begin
DECLARE @slnhap int
select @slnhap=slnhap from soluong where malinhkien= @malinhkien
DECLARE @slxuat int
select @slxuat=slxuat from soluong where malinhkien= @malinhkien
DECLARE @gianhap float
select @gianhap=gianhap from muaban where malinhkien= @malinhkien
DECLARE @giaxuat float
select @giaxuat=giaxuat from muaban where malinhkien= @malinhkien
DECLARE @tienvon float
insert into thunhap values (@malinhkien,@slnhap*@gianhap,@slxuat*@giaxuat,@slxuat*(@giaxuat-@gianhap),@slxuat*@giaxuat-@slnhap*@gianhap)
end
go
create proc  updatethunhap( @id int,@malinhkien char(10))
as

begin
DECLARE @slnhap int
select @slnhap=slnhap from soluong where malinhkien= @malinhkien
DECLARE @slxuat int
select @slxuat=slxuat from soluong where malinhkien= @malinhkien
DECLARE @gianhap float
select @gianhap=gianhap from muaban where malinhkien= @malinhkien
DECLARE @giaxuat float
select @giaxuat=giaxuat from muaban where malinhkien= @malinhkien
DECLARE @tienvon float
UPDATE thunhap
SET malinhkien=@malinhkien,tienvon = @slnhap*@gianhap, tienthu = @slxuat*@giaxuat,tienlai=@slxuat*(@giaxuat-@gianhap),hoivon=@slxuat*@giaxuat-@slnhap*@gianhap
WHERE id=@id;
 end
go
create proc nhaplinhkien ( @malinhkien char(10),
	@ten nvarchar(50) ,	
	@loai char(10) ,
	@quycach nvarchar(100),
	@noisanxuat nvarchar(30),
	@namsanxuat date,
	@thoigianbh int,
	@chatluong int ,
	@gianhap float ,
	@giaxuat float ,
	@slnhap int,
	@slxuat int )
as

begin

	insert into linhkien values (@malinhkien,@ten,@loai,@quycach,@noisanxuat,@namsanxuat,@thoigianbh)
	insert into muaban values (@malinhkien,@chatluong,@gianhap,@giaxuat,@giaxuat-@gianhap)
	insert into soluong values (@malinhkien,@slnhap,@slxuat,@slnhap)
end
go

create proc insertlinhkien ( @malinhkien char(10),
	@ten nvarchar(50) ,	
	@loai char(10) ,
	@quycach nvarchar(100),
	@noisanxuat nvarchar(30),
	@namsanxuat date,
	@thoigianbh int)
as
begin
	insert into linhkien values (@malinhkien,@ten,@loai,@quycach,@noisanxuat,@namsanxuat,@thoigianbh)
end
go
create proc updatelinhkien (@id int, @malinhkien char(10),
	@ten nvarchar(50) ,	
	@loai char(10) ,
	@quycach nvarchar(100),
	@noisanxuat nvarchar(30),
	@namsanxuat date,
	@thoigianbh int)
as
begin
	update  linhkien set malinhkien=@malinhkien,ten=@ten,loai=@loai,quycach=@quycach,noisanxuat=@noisanxuat,namsanxuat=@namsanxuat,thoigianbh=@thoigianbh
	where id=@id
end
go
--dbo.updatelinhkien 2 , 'a12',N'ten','loai a',N'quycach',N'xuat sư','2010/06/10',6

create proc deletelinhkien (@malinhkien char(10))
as
begin
	delete from muaban where malinhkien=@malinhkien
	delete from soluong where malinhkien=@malinhkien
	delete from thunhap where malinhkien=@malinhkien
	delete from linhkien where malinhkien=@malinhkien
end
go


 create proc getidmuaban( @idlinhkien int)
 as
 begin
	select mb.id from linhkien as lk, muaban as mb where lk.malinhkien=mb.malinhkien and lk.id=@idlinhkien
 end
 go
 
 create proc getidsoluong( @idlinhkien int)
 as
 begin
	select sl.id from linhkien as lk, soluong as sl where lk.malinhkien=sl.malinhkien and lk.id=@idlinhkien
 end
 go
 
 create proc getidthunhap(@idlinhkien int)
 as
 begin
	select tn.id from linhkien as lk, thunhap as tn where lk.malinhkien=tn.malinhkien and lk.id=@idlinhkien
 end
 go
 
 create proc updatetaikhoan( 
@id int, 
@username varchar(30) ,
@password varchar(1000),
@level int)
as
begin
		update taikhoan 
		set username=@username,password=@password,level=@level
		where id=@id
end
go

create proc inserttaikhoan(
@username varchar(30) ,
@password varchar(1000),
@level int)
as
begin
	insert into taikhoan values (@username,@password,@level)
end
go
create proc deletetaikhoan(@id int)
as
begin
delete from taikhoan where id=@id
end
go
create proc dangnhap
(
@username varchar(30) ,
@password varchar(1000)
 )
as
	begin
		 select * from taikhoan where username=@username and password=@password
	end
go

create VIEW  selectmuaban
as
select  lk.malinhkien as[Mã Linh Kiện],lk.ten as[Tên Linh Kiện],lk.loai as [Loại],lk.quycach as [Quy Cách],lk.noisanxuat as[Xuất Sứ],
lk.thoigianbh as [Bảo Hành],lk.namsanxuat[Năm Sản Xuất],mb.chatluong[Chất Lượng],mb.giaxuat as[Giá Bán] ,sl.slcon [Còn Lại]
from linhkien as lk, soluong as sl, muaban as mb 
where lk.malinhkien=sl.malinhkien and mb.malinhkien =lk.malinhkien 
go

create VIEW  selectban
as
select  lk.malinhkien as[Mã Linh Kiện],lk.ten as[Tên Linh Kiện],lk.loai as [Loại],lk.quycach ,mb.chatluong[Chất Lượng],mb.giaxuat as[Giá Bán] ,sl.slcon [Còn Lại]
from linhkien as lk, soluong as sl, muaban as mb 
where lk.malinhkien=sl.malinhkien and mb.malinhkien =lk.malinhkien 
go

create VIEW  selectnhap
as
select  lk.malinhkien as[Mã Linh Kiện],lk.ten as[Tên Linh Kiện],lk.loai as [Loại],lk.quycach ,mb.chatluong[Chất Lượng],mb.gianhap as[Giá nhập] ,sl.slcon [Còn Lại]
from linhkien as lk, soluong as sl, muaban as mb 
where lk.malinhkien=sl.malinhkien and mb.malinhkien =lk.malinhkien 
go

create VIEW  selectnhaplinhkien
as
select  lk.id,lk.malinhkien as[Mã Linh Kiện],lk.ten as[Tên Linh Kiện],lk.loai as [Loại],lk.quycach as [Quy Cách],lk.noisanxuat as[Xuất Sứ],
lk.namsanxuat[Năm Sản Xuất],lk.thoigianbh as [Bảo Hành],
mb.chatluong[Chất Lượng],mb.gianhap as [Giá Nhập],mb.giaxuat as[Giá Bán] ,
sl.slnhap as[Đã Nhập],sl.slxuat as[Đã Bán]
from linhkien as lk, soluong as sl, muaban as mb 
where lk.malinhkien=sl.malinhkien and mb.malinhkien =lk.malinhkien 
go

create VIEW  selectthongke
as
select  lk.malinhkien as[Mã Linh Kiện],lk.ten as[Tên Linh Kiện],lk.loai as [Loại],mb.chatluong[Chất Lượng],
lk.thoigianbh as [Bảo Hành],sl.slnhap as [Số Lượng Nhập],sl.slxuat as[Số Lượng Bán],sl.slcon [Còn Lại]
,mb.gianhap as [Giá Nhập], mb.giaxuat as[Giá Bán] ,
tn.tienvon as[Vốn],tn.tienthu as[Thu Lại], tn.tienlai as[Lãi],tn.hoivon as [Hồi Vốn]
from linhkien as lk, soluong as sl, muaban as mb ,thunhap as tn
where lk.malinhkien=sl.malinhkien and mb.malinhkien =lk.malinhkien and tn.malinhkien=lk.malinhkien
go

create proc getidlinhkien(@malinhkien char(10))
as
begin
select id from linhkien where malinhkien=@malinhkien
end
go
----------------------------------------------------------------------------------------------
insert into taikhoan values ('admin','1',1)
go
insert into taikhoan values ('nhanvien1','1',0)
 go
 	dbo.insertlinhkien 'A011',N'Mainboard','A',N' ASUS Z10PE-D8WS',N'Taipei, Taiwan','2015-02-23',36
	go
	 dbo.insertmuaban 'A011' , 1 , 1250000 , 1499900
	 go
   dbo.insertsoluong 'A011' , 15 , 0
   go
   dbo.insertthunhap 'A011'
   go

   dbo.insertlinhkien 'A021',N'CPU','A',N'Intel Core i7 8700K 3.7Ghz Turbo Up to 4.7Ghz ',N'Santa Clara, California, Unite','2016-07-21',36
   go
 dbo.insertmuaban 'A021' , 1 , 790000 ,974900
 go
   dbo.insertsoluong 'A021' , 12 , 0
   go
   dbo.insertthunhap 'A021'
   go
   
 
   dbo.insertlinhkien 'A031',N'Ổ Cứng HDD ','A',N'Western Purple 4TB/5400 Sata 3 64Mb',N'United States','2015-01-04',36
   go
 dbo.insertmuaban 'A031' , 1 , 272000 , 395000
 go
   dbo.insertsoluong 'A031' , 12 , 0
   go
   dbo.insertthunhap 'A031'
   go

    dbo.insertlinhkien 'A041',N'Ổ cứng SSD  ','A',N'AVEXIR S100 Blue 120GB SATA3 6Gb/s 2.5',N'Hsinchu County, Taiwan','2016-11-03',36
	go
	dbo.insertmuaban 'A041' , 1 , 121000 , 189900
	go
   dbo.insertsoluong 'A041' , 22 , 0
   go
   dbo.insertthunhap 'A041'
   go

   dbo.insertlinhkien 'A051',N'Ram','A',N'Gskill Triden 32GB (4*8GB) DDR4 Bus 3200 Mhz',N'Taipei, Taiwan','2016-12-08',36
   go
 dbo.insertmuaban 'A051' , 1 , 820000 , 929900
 go
   dbo.insertsoluong 'A051' , 16 , 0
   go
   dbo.insertthunhap 'A051'
   go

   dbo.insertlinhkien 'A061',N'Tản nhiệt CPU','A',N'Corsair Hydro Series H115i 280mm Ext',N'Fremont, California, United St','2016-01-23',24
   go
 dbo.insertmuaban 'A061' , 1 , 242000 , 358900
 go
   dbo.insertsoluong 'A061' , 8 , 0
   go
   dbo.insertthunhap 'A061'
   go

   dbo.insertlinhkien 'A071',N'VGA','A',N' GIGABYTE Radeon RX VEGA 64 Watercooling 8G',N'New Taipei City, Taiwan','2017-01-15',36
   go
 dbo.insertmuaban 'A071' , 1 , 1832000 ,2299900
 go
   dbo.insertsoluong 'A071' , 6 , 0
   go
   dbo.insertthunhap 'A071'
   go

   dbo.insertlinhkien 'A081',N'Case','A',N' Corsair Obsidian Series® 900D (Window - Super)',N'Fremont, California, United St','2016-09-22',12
   go
 dbo.insertmuaban 'A081' , 1 ,632000  , 734800
 go
   dbo.insertsoluong 'A081' , 8 , 0
   go
   dbo.insertthunhap 'A081'
   go

    dbo.insertlinhkien 'A091',N'Nguồn','A',N' FSP Power Supply HYDRO X Series HGX650 - Active PFC - 80 Plus Gold',N'Oslo, Norway','2016-08-29',36
	go
 dbo.insertmuaban 'A091' , 1 ,199900  , 239900
 go
   dbo.insertsoluong 'A091' , 15 , 0
   go
   dbo.insertthunhap 'A091'
   go

    dbo.insertlinhkien 'A101',N'Màn hình','A',N' Asus 28"PB287Q LED 4K',N'Taipei, Taiwan','2016-01-25',36
	go
 dbo.insertmuaban 'A101' , 1 ,1199900  , 1299900
 go
   dbo.insertsoluong 'A101' , 18 , 0
   go
   dbo.insertthunhap 'A101'
   go

    dbo.insertlinhkien 'B011',N'Bàn Phím','B',N' SteelSeries Apex M750 Mechanical Gaming',N'Copenhagen, Denmark','2016-02-27',36
	go
 dbo.insertmuaban 'B011' , 1 ,220000  , 323000
 go
   dbo.insertsoluong 'B011' , 20 , 0
   go
   dbo.insertthunhap 'B011'
   go

     dbo.insertlinhkien 'B021',N'Chuột','B',N' SteelSeries Rival 300 CS:GO Hyperbeast Editiion',N'Copenhagen, Denmark','2016-03-01',36
	 go
 dbo.insertmuaban 'B021' , 1 ,99000  , 142000
 go
   dbo.insertsoluong 'B021' , 25 , 0
   go
   dbo.insertthunhap 'B021'
   go

 dbo.insertlinhkien 'B031',N'Bàn Di','B',N'SteelSeries QcK+ Limited Gaming(63700)',N'Copenhagen, Denmark','2015-09-11',36
 go
 dbo.insertmuaban 'B031' , 1 ,42000  , 69900
 go
   dbo.insertsoluong 'B031' , 22 , 0
   go
   dbo.insertthunhap 'B031'
   go

  dbo.insertlinhkien 'B041',N'Tai nghe','B',N' Razer Tiamat 2.2 V2 - Analog Gaming Headset',N'San Francisco, California, United States','2016-04-17',36
  go
 dbo.insertmuaban 'B041' , 1 ,272000  , 333900
 go
   dbo.insertsoluong 'B041' , 18 , 0
   go
   dbo.insertthunhap 'B041'
   go

    dbo.insertlinhkien 'B051',N'Ghế','B',N' DXRACER R Series R288-NRW-W1 ',N'9177 E. Michigan 36','2016-04-17',36
  go
 dbo.insertmuaban 'B051' , 1 ,699900  , 799900
 go
   dbo.insertsoluong 'B051' , 25 , 0
   go
   dbo.insertthunhap 'B051'
   go
 ---------------------------------------------------------------------------------

/*
insert into linhkien values ('a11',N'linhkien a1 loai 1','loai a',N'quy cach',N'china','2010/10/5',12),
 ('a12',N'linhkien a1 loai 2','loai a',N'quy cach',N'china','2010/10/5',6),
('a21',N'linhkien a2 loai 1','loai a',N'quy cach',N'china','2010/10/5',12),
 ('a31',N'linhkien a3 loai 1','loai a',N'quy cach',N'china','2010/10/5',24),
 ('a32',N'linhkien a3 loai 2','loai a',N'quy cach',N'china','2010/10/5',18)
go


 dbo.insertlinhkien 'a41',N'linhkien a4 loai 1','loai b',N'quy cach',N'china','2010/10/5',12
go

insert into taikhoan values ('admin','1',1)
select * from taikhoan where username='admin' and password='1'
go

dbo.dangnhap 'admin','1'
go

 dbo.insertmuaban 'a11' , 1 , 1000 , 1400
 go
 dbo.insertmuaban 'a12' , 2 , 2300 , 2800
 go
 dbo.insertmuaban 'a21' , 1 , 4000 , 4800
 go
 dbo.insertmuaban 'a31' , 1 , 1400 , 1900
 go
 dbo.insertmuaban 'a32' , 2 , 2000 , 2900
 go
 
  dbo.insertsoluong 'a11' , 15 , 0
 go
 dbo.insertsoluong 'a12' , 15 , 3
 go
 dbo.insertsoluong 'a21' , 15 , 4
 go
 dbo.insertsoluong 'a31' , 15 , 0
 go
 dbo.insertsoluong 'a32' , 15 , 0
 go
 
dbo.insertthunhap 'a11' 
 go
 dbo.insertthunhap 'a12'
 go
 dbo.insertthunhap 'a21'
 go
 dbo.insertthunhap 'a31'
 go
 dbo.insertthunhap 'a32'
 go

---------------------------------------------------------------
 
select muaban.id from linhkien,muaban where linhkien.malinhkien=muaban.malinhkien and linhkien.id=1
 
 select * from selectnhaplinhkien
 select * from selectthongke
 
 select * from selectthongke
 order by [số lượng bán] desc
 
 select * from selectthongke  order by [còn lại] desc
 
  select * from selectthongke
 order by [số lượng bán] 
 
 select * from selectthongke order by [thu lại] desc
 
  select * from selectthongke
 order by [lãi] desc
 
  select * from selectthongke
 order by [giá nhập]  
 
 select * from selectthongke
 order by [giá nhập] 
 

select * from linhkien as lk, soluong as sl, muaban as mb where lk.malinhkien=sl.malinhkien and mb.malinhkien =lk.malinhkien
go

select *,N'Bán ra' as[bán ra] ,N'Nhập vào' as [Nhập vào] from selectmuaban 
go
select *  from selectmuaban 
order by [loại],[tên linh kiện]
go
select *  from selectmuaban
order by [năm sản xuất] DESC

select *  from selectmuaban
where [bảo hành]>12
*/