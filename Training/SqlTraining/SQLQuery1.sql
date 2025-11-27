--create database infinitedb

create table students
(studentid int,studentname varchar(20),age tinyint,address varchar(50))

insert into students values
(300,'mehraj',23,'pune'),
(400,'pooja',24,'bangalore')

insert into students
(studentid,studentname)
values (500,'ABC')

select * from students

select * from students where age > 22

select * from students order by age desc

select * from students order by studentname asc,age desc

select * from students where age between 20 and 22

select * from students where studentname like 'h%'

select sum(age) from students

select sum(age) from students where address = 'hyd'

select sum(age), address from students group by address


