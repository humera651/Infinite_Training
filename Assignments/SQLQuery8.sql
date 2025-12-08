--task 1
create procedure sp_GetEmployeesByDate
@d1 datetime,
@d2 datetime
as
begin
select * from Employee
where DateOfJoin between @d1 and @d2
end

--task 2
create procedure sp_getCommon
@deptId int
as
begin
select e.EmpId, e.EmpName,d.DeptName, e.Salary from Employee e
inner join Department d on e.DeptId=d.DeptId
where e.DeptId=@deptId
end

--task 3
create procedure InsertEmployee
(@EmpName varchar(100), @Salary decimal(10,2), @DateOfJoin date, @DeptID int )
as
begin
insert into Employee(EmpName, Salary, DateOfJoin, DeptID) values (@EmpName, @Salary, @DateOfJoin, @DeptID)
end

create procedure InsertDepartment
( @DeptID int, @DeptName varchar(50) )
as
begin
insert into Department (DeptID, DeptName) values (@DeptID, @DeptName)
end

--task 6
create procedure sp_GetEmployeeDetails
( @EmpID int, @DateOfJoin date output, @Department varchar(50) output)
as
begin
select @DateOfJoin = DateOfJoin, @Department = d.DeptName from Employee e
inner join Department d ON e.DeptID = d.DeptID
where e.EmpID = @EmpID;
end

