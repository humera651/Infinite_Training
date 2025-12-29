select * from customers

create table tblproducts
(
ID int identity primary key,
pname nvarchar(20),
description nvarchar(50)
)

insert into tblproducts values('Laptops','DELL'),
('Monitor','HP Computers')

insert into tblproducts values('Desktops','HP'),
('iPhones','Apple Ltd'),
('Led TV','Samsung')

create or alter proc spGetProducts
as
begin 
waitfor delay '00:00:05'
select Id,pname,description from tblproducts
end

exec spGetProducts


create or alter proc spGetProductByName
@Productname nvarchar(50)
as
begin
if(@Productname = 'All')
begin
select Id,pname,description from tblproducts
end
else
begin
select Id,pname,description from tblproducts where pname=@Productname
end
end

exec spGetProductByName 'laptops'