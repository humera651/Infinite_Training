--Functions 

--1. create a function to find the greatest of three numbers
create function getGreatest(@a int, @b int, @c int)
returns int
as
begin
declare @max int;
set @max = case 
when @a >= @b and @a >= @c then @a
when @b >= @a and @b >= @c then @b
else @c
end
return @max
end

select dbo.getGreatest(40, 75, 2) as greatest

--2. create a function to calculate to discount of 10% on price on all 
--the products 
create function Calcdiscount(@price decimal(10,2))
returns decimal(10,2)
as
begin
    return @price - (@price * 0.10)
end

select 
    pid,
    pname,
    price,
    dbo.Calcdiscount(price) as discounted_price
from products

--3. create a function to calculate the discount on price as following 
--if productname = 'books' then 10% 
--if productname = toys then 15% 
--else 
--no discount
create function getCategoryDiscount
(
    @pname varchar(50),
    @price decimal(10,2)
)
returns decimal(10,2)
as
begin
declare @finalprice decimal(10,2);
set @finalprice =
case 
when @pname = 'books' then @price - (@price * 0.10)
when @pname = 'toys' then @price - (@price * 0.15)
else @price
end;
return @finalprice;
end;

select 
    pid,
    pname,
    price,
    dbo.getCategoryDiscount(pname,price) as discounted_price
from products

--4. create inline function which accepts number and prints last n 
--years of orders made from  now. 
--(pass n as a parameter)
create function getLastNYearsOrders(@n int)
returns int
as
begin
    return year(getdate()) - @n;
end

select *
from orders
where year(orderdate) >= dbo.getLastNYearsOrders(3);

--Triggers 
 
--1. Create a trigger for table customer, which does not allow 
--the user to delete the record who stays in Bangalore, 
--Chennai, delhi 
create trigger trg_DelCity
on customers
for delete
as
begin
select * 
from deleted 
where caddress in ('Bangalore', 'Chennai', 'Delhi');
if @@rowcount > 0
begin
print('cannot delete customers from bangalore, chennai, delhi');
rollback transaction;
return;
end
delete from customers
where custid in (select custid from deleted);
end;

delete from customers where custid = 103

--2. Create a triggers for orders which allows the user to insert 
--only books, cd, mobile 

create trigger trg_InsertSpecificProducts
on orders
for insert
as
begin
if exists (
select * 
from inserted
where product not in ('books', 'cd', 'mobile')
)
begin
print('only books, cd, mobile can be inserted into orders table')
rollback transaction
return
end
end

insert into orders(custid, orderid, orderdate, product, price, quantity)
values (106, 501, '2025-12-02', 'toys', 500, 5)

--3. Create a trigger for customer table whenever an item is 
--delete from this table. The corresponding item should be 
--added in customerhistory table.
drop trigger trg_CustomerDeleteHistory
create trigger trg_CustomerDeleteHistory
on customers
for delete
as
begin
insert into custhistory (custid, custname, age, caddress, cphone)
select custid, custname, age, caddress, cphone from deleted
select * from deleted
end

delete from customers where custid = 111;

--4. Create update trigger for stock. Display old values and new 
--values

create trigger trg_StockUpdate
on stock
for update
as
begin
select
d.stockid      as old_stockid,
d.minstocklvl  as old_minstock,
d.maxstocklvl  as old_maxstock,
i.stockid      as new_stockid,
i.minstocklvl  as new_minstock,
i.maxstocklvl  as new_maxstock
from deleted d
join inserted i
on d.stockid = i.stockid;
end;

update stock
set minstocklvl = 22, maxstocklvl = 40
where stockid = 'stc-11-aaa';

--5. Create Instead Of Insert Trigger for Joined View (the user 
--should able to insert record for 2 table using single insert 
--command) Use following table 
 
create table a 
( 
custid int, 
custname varchar(12) 
) 
 
create table b	
( 
custid int, 
product varchar(12) 
) 
 
create view testview 
as 
select a.* , b.product from a inner join b on a.custid = 
b.custid 
 
select * from testview

create trigger trg_InsteadOfInsert
on testview
instead of insert
as
begin
insert into a(custid, custname)
select i.custid, i.custname
from inserted i

insert into b(custid, product)
select i.custid, i.product
from inserted i
end

insert into testview (custid, custname, product)
values (201, 'humera', 'books')
 
select * from a
select * from b
select * from testview
