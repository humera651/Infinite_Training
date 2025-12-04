--Stored Procedure Assignment 
 
--1. Create a procedure which accepts input parameter and inserts the 
--data in the customer table.

create procedure myInput(@custid int,@custname varchar(50),@age int,@caddress varchar(50), @cphone varchar(10))
as
insert INTO customers(custid, custname, age, caddress, cphone)
    VALUES(@custid, @custname, @age, @caddress, @cphone)

myInput 111,'chandini',25,'kerela','9898778787'

--2.  Create a procedure for orders table , which displays all the purchase 
--made between  1-12-2005  and 2-12-2007 
--(Accept date as parameter_) 

create procedure spOrdersWithDates(@StartDate date, @EndDate date)
as
select *from orders where orderdate between @StartDate and @EndDate

spOrdersWithDates '2019-10-12','2025-11-26'

--3. create a procedure which reads custid as parameter  
--and return qty and produtid as output parameter 



create procedure spGetOrderDetails
@CustID int, @Qty int output, @ProductID int output
as
select
@Qty = Qty, @ProductID = ProductID
from [Order]
where CustID = @CustID

declare @m int
declare @n int
exec spGetOrderDetails 102,@m output,@n output
print @m
print @n

CREATE TABLE [Order](
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustID INT,
    ProductID INT,
    Qty INT,
    OrderDate DATE,
    
    CONSTRAINT FK_Orders_Products
        FOREIGN KEY (ProductID)
        REFERENCES Products(pid)
);


INSERT INTO [Order] (CustID, ProductID, Qty, OrderDate)
VALUES
(101, 121, 1, '2024-01-12'),
(102, 122, 2, '2024-02-15'),
(103, 121, 11, '2024-03-20'),
(101, 122, 20, '2024-04-05'),
(104, 121, 3, '2024-04-25')

--4. Write a batch that will check for the existence of the productname 
--“books” if it exists, display the total stock of the book else print  
--“productname books not found”.

create procedure cp(@book varchar(20))
as
if exists (select * from products where pname = @book)
begin
select sum(stock) as TotalStock
from products
where pname = 'books'
end
else
begin
print 'productname books not found'
end

cp 'books'

--5.insert  data to customer table via return value of sp_getdata() 
--procedure

create procedure sp_getdata
as
begin
declare @id INT;
set @id = 200;
return @id;
end

declare @custid int;
exec @custid = sp_getdata;
insert into customers (custid, custname, age, caddress, cphone)
values (@custid, 'Pamm',23, 'Delhi', '9898776787')

--6. Create a procedure to display all customer details where rownumber 
--between 2 to 5 (accept row number as a parameter)

create procedure spcustomerdetails (@startrow int, @endrow int)
as
with c as (
select *, row_number() over(order by custid) as rn
from customers
)
select *
from c
where rn between @startrow and @endrow

exec spcustomerdetails 2,5

--7.Create a stored procedure to insert a new employee 
--Create a table Employees and write a stored procedure: 
--• Procedure name: spAddEmployee 
--• Inputs: Name, Department, Salary 
--• Insert the record into Employees table. 
--• Return newly generated CustomerID using SCOPE_IDENTITY().

drop procedure spAddEmployee
create procedure spAddEmployee
    @name varchar(50),
    @department varchar(50),
    @salary decimal(10,2)
as
    insert into employeestbl (ename, department, salary)
    values (@name, @department, @salary);
    return scope_identity()

declare @res int
exec @res = spAddEmployee 'jasmine','IT', 760000 
print @res

create table employeestbl (
    empid int identity(1,1) primary key,
    ename varchar(20),
    department varchar(50),
    salary decimal(10,2)
)

insert into employeestbl (ename, department, salary) values
('humera', 'It', 65000),
('soni', 'hr', 50000),
('fatima', 'sales', 45000),
('pooja', 'marketing', 42000),
('kiran', 'finance', 48000)

--8.Create a stored procedure with default parameter 
--Create spGetProductsByCategory 
--• Parameter: CategoryName (default should be ‘Electronics’) 
--• Return all products of that category. 
--• Create Procedure WITH ENCRYPTION

alter table products
add categoryname varchar(50) default 'electronics'

create procedure spGetProductsByCategory
@categoryname varchar(50) = 'electronics'
with encryption
as
select * from products where categoryname = @categoryname;

exec spGetProductsByCategory 'electronics'

--9. Stored procedure using TRY…CATCH 
--Create spSafeOrderInsert 
--• Insert a new order 
--• If any error occurs, insert error details into an ErrorLog table

create table ErrorLogs
(
ErrorId int identity primary key,
ErrorMessage varchar(max),
ErrorTime Datetime default GetDate()
)

create procedure spSafeOrderInsert
@custID int,
@orderId int,
@Price money,
@Qty int
as
begin Try
insert into Orders(custId,orderId,orderDate,price,quantity)
values (@custID,@orderId,GetDate(),@Price,@Qty)
end try
begin catch
insert into ErrorLogs(ErrorMessage)
values(Error_message())
end catch
 
 
exec spSafeOrderInsert
@custID=101,
@orderId=60000,
@Price=500,
@Qty=3
 
exec spSafeOrderInsert 102,60001,750,4
 
select * from Orders where orderId=60001
 
exec spSafeOrderInsert 999,54729,800,5
 
displayData 'ErrorLogs'
 
exec spSafeOrderInsert 101, Null, 500, 2

--10.Stored procedure with multiple operations 
--Create spUpdateSalary 
--• Inputs: EmpID, Percentage 
--• Increase employee salary by given percentage 
--• Return updated salary

create procedure spUpdateSalary
@empId int,
@percentage float
as
begin
 
update Employees 
set salary = salary +(salary * (@percentage/100))
where EmpID = @empId
 
select salary as UpdateSalary 
from Employees
where EmpId =@empId
end
 
exec spUpdateSalary
@empId=1,
@percentage=10
 
spUpdateSalary 2,20
 
displayData 'Employees'

displayData 'ErrorLogs'