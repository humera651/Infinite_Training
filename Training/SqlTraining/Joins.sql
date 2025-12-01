select * from customers
select * from orders

-- inner join common values
select * from customers inner join orders 
on customers.custid = orders.custid 

-- outerjoin(atleast from 1 table it will display all the records)
select * from customers left outer join orders 
on customers.custid = orders.custid 

select * from customers right outer join orders 
on customers.custid = orders.custid 

select * from customers full outer join orders 
on customers.custid = orders.custid

select * from customers cross join orders 

select a.* from customers a ,customers b
where a.age > b.age 
and b.custname ='Alan'

select * into customersnew from customers

--union
select * from customers union select * from customersnew

select * from customers union all select * from customersnew

-- except

select * from customers except select * from customersnew

--intersect

select * from customers intersect select * from customersnew

