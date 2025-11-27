create table customers
(custid int,custname varchar(20),age tinyint,caddress varchar(50),
cphone varchar(12))

create table orders
(custid int,orderid int,orderdate date,product varchar(30),price float,
quantity int)

insert into customers values
(101,'Humera',22,'Pune',8988767876),
(102,'Soni',23,'Lonavla',9988787656),
(103,'Mehraj',21,'Bangalore',7876765676),
(104,'Pooja',24,'Chennai',9866543454),
(105,'Keerthi',22,'Hyderabad',7876787765),
(106,'Jasmine',25,'Vizag',9878787677)

select * from customers

insert into orders values
(101,1,'2025-11-26','shampoo',560,5),(102,2,'2025-10-12','biscuit',460,10),
(103,3,'2025-05-03','conditioner',720,15),(104,4,'2025-11-26','dress',1500,4),
(105,5,'2025-10-17','chocolate',260,2),(106,6,'2025-10-17','bottle',150,20),
(107,7,'2025-10-17','laptop',70000,5),(108,8,'2025-04-11','icecream',960,12)

select * from orders

--1. Display the list of customers who resides in Bangalore 
select * from customers where caddress = 'Bangalore'

--2. Display the list of customers who does not resides in Bangalore or chennai 
select * from customers where caddress != 'Bangalore' and caddress != 'Chennai'

--3. Display the list of customers who’s age is greater then 50 and does not resides in Bangalore 
select * from customers where age > 50 and caddress != 'Bangalore'

--4. Display the list of customers who’s name starts with A 
select * from customers where custname like 'A%'

--5. Display the list of customers who’s name contains a word Br 
select * from customers where custname like '%Br%'

--6. Display the list of customer who’s name start between a to k 
select * from customers where custname like '[A-K]%'

--7. Display the list of customers who’s name is 5 character long 
select * from customers where custname like '_____'

--8. Display the list of customer who’s name  
--a. Start with s 
--b. Third character is c 
--c. Ends with e
select * from Customers where custname like 'S_c%e'

--9. Display unique customer names from customers table 
select distinct custname from customers

--10. List orders details where qty falling in the range 100-200  and 700-1200 
select * from orders where quantity between 100 and 200 
or quantity between 700 and 1200

--11.  List customer details where custname beginning with AL and ending with N 
select * from customers where custname like 'Al%N'

--12. Display what each  price would be if a 20% price increase were to take place. Show the custid , old price and new price ,using meaningful headings(use orders table)
select custid,price as oldprice,price * 1.20 as newprice from orders;

--13. Display top 3 highest qty from orders table
select top 3 * from orders order by quantity desc

--14. Display how many times customers have purchased a product (display count and customerid from orders table)
select custid,count(*) as purchase_count from orders group by custid

--15. Display the list of orders who’s orders made earlier then 5 years from now 
select * from orders where year(getdate()) - year(orderdate) > 5

--16.  Select * from customers where custname is null 
select * from customers where custname is null

--17.  Display orderdetails in following format 
--OrderID-Date Total(price*qty) 
--100-1/1/2000 500 
select CONCAT(orderid,'-',orderdate) as [OrderID-Date],(price * quantity) as [Total(price*qty)] from orders

--18.  Update orders table by decreasing price by 20% for qty > 50 
update orders set price = price * 0.80 where quantity > 50

--19. You want to retrieve data for all the orders who made order  '1-12-90' having price 4000 – 6000 and sort the column in descending order on price
select * from orders where orderdate = '1990-12-01' and price between 4000 and 6000
order by price desc

--20. Display order details in following format 
--Custid Price (sum of price) Count (count of qty) 
--1 5000 3 
--2 4000 9 
--3 6700 6 
select custid,sum(price) as [Price (sum of price)],count(quantity) as 
[Count (count of qty)] from orders group by custid

--21. Display above details only for price > 4000 
select custid,sum(price) as [Price (sum of price)],count(quantity) as 
[Count (count of qty)] from orders group by custid having sum(price) > 4000

--22. Write a query to create duplicate table of customer , and name it as custhistory 
--a. Delete all the records of custhistory 
--b. Copy records of customers to custhistory where age > 30
select * into custhistory from customers where age > 30