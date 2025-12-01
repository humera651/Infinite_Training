select * from Students

--view with encryption
-----------------------
create view v1
with encryption
as
select StudentRollNumber, StudentName,Class from Students 

---- i want u to create a view which will find who's studentname contains _
create view v5
with encryption
as
select StudentRollNumber, StudentName from dbo.Students
where StudentName like '%[_]%'

select * from v5

insert into v5 values(121,'humera_shaikh')

select * from v1

--view with checkoption
-----------------------
create view v2
as
select StudentRollNumber, StudentName,Class from Students 
where Class = 9
with check option

select * from v2

--view with schemabinding
-----------------------

create view v3
with schemabinding  --u cannot drop table now 
as
select StudentRollNumber, StudentName,Class from dbo.Students 

select * from v3


create view v4
with encryption,schemabinding
as
select StudentRollNumber, StudentName,Class from dbo.Students 
where Class = 9
with check option

sp_helptext  v2

sp_depends v1
