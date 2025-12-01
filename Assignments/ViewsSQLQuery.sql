CREATE TABLE Employees 
( 
    EmpId INT PRIMARY KEY, 
    EmpName VARCHAR(100), 
    DeptId INT, 
    ManagerId INT NULL, 
    JoinDate DATE, 
    Salary DECIMAL(10,2) 
); 
 
INSERT INTO Employees VALUES 
(1, 'Amit', 10, NULL, '2020-01-10', 65000), 
(2, 'Neha', 10, 1,    '2022-02-15', 50000), 
(3, 'Ravi', 20, 1,    '2023-03-12', 45000), 
(4, 'Sana', 20, 3,    '2024-01-20', 42000), 
(5, 'Karan', 30, 1,   '2021-07-18', 55000);

CREATE TABLE Departments 
( 
    DeptId INT PRIMARY KEY, 
    DeptName VARCHAR(100) 
); 
 
INSERT INTO Departments VALUES 
(10, 'IT'), 
(20, 'HR'), 
(30, 'Finance');

CREATE TABLE Sales 
( 
    SaleId INT PRIMARY KEY, 
    EmpId INT, 
    Region VARCHAR(50), 
    SaleAmount DECIMAL(10,2), 
    SaleDate DATE 
); 
 
INSERT INTO Sales VALUES 
(1, 1, 'North', 100000, '2024-01-01'), 
(2, 2, 'North',  90000, '2024-01-10'), 
(3, 3, 'South', 120000, '2024-02-05'), 
(4, 4, 'South', 120000, '2024-02-20'), 
(5, 5, 'North', 110000, '2024-03-15');

CREATE TABLE Transactions 
( 
    TransId INT PRIMARY KEY, 
    AccountId INT, 
    Amount DECIMAL(10,2), 
    TransDate DATE 
); 
 
INSERT INTO Transactions VALUES 
(1, 101, 1000, '2024-01-01'), 
(2, 101, 2000, '2024-02-01'), 
(3, 101, -500, '2024-03-01'), 
(4, 102, 1500, '2024-01-15'), 
(5, 102, -200, '2024-03-10');

--Task-1 
--Write a query using CASE to categorize salary levels on Employees table: 
--<20000 → Low 
--20000–50000 → Medium 
--50000 → High

SELECT 
    EmpName,
    Salary,
    CASE 
        WHEN Salary > 50000 THEN 'High'
        WHEN Salary BETWEEN 20000 AND 50000 THEN 'Medium'
        WHEN Salary < 20000 THEN 'Low'
    END AS SalaryLevels
FROM Employees;

--Task -2 
 
--Declare a variable @Age. 
--Write logic using IF / ELSE: 
--If Age < 18 → print “Minor” 
--Else If Age between 18–60 → “Adult” 
--Else → “Senior”

declare @Age int
set @Age = 18
if @Age < 18
print 'Minor'
else if @Age >= 18 and @Age <= 60
print 'Adult'
else
print 'Senior'

--Task-3 Encrypted & Schema-Bound View 
--Create an encrypted and schemabound view that: 
--Joins Employees, Departments, and Salaries tables 
--Returns only employees who joined in the last 3 years 
--Includes computed column: AnnualSalary = Salary * 12 
--Prevents updates to base tables that break schema binding 
--Tasks 
--1. Create the view with WITH SCHEMABINDING, ENCRYPTION. 
--2. Try altering an underlying table column → observe the error.

create view dbo.EmployeeView
with schemabinding, encryption
as
select 
emp.EmpId,
emp.EmpName,
emp.DeptId,
d.DeptName,
emp.Salary,
emp.JoinDate,
(emp.Salary * 12) as AnnualSalary from dbo.Employees emp
join dbo.Departments d on emp.DeptId = d.DeptId
where emp.JoinDate >= dateadd(year, -3, getdate())

alter table Employees alter column empName varchar(200)

select * from EmployeeView

--Task-4— Complex Multi-Table View 
--Create a view that: 
--Joins Employees + Sales 
--Shows total sales per employee 
--Shows rank based on total sales across company

create view  MultiTableView 
as
select 
emp.EmpId,
emp.EmpName,
sum (s.SaleAmount) as TotalSales,
rank() over (order by sum(s.SaleAmount) desc) as SalesRank
from Employees emp
left join Sales s on emp.EmpId = s.EmpId
group by emp.EmpId, emp.EmpName;

select * from MultiTableView

--Task-5— Simulate Error Capture 
--Write a block that: 
--Attempts dividing by zero 
--Catches the error 
--Prints error details

begin try
declare @number int
set @number = 20
print @number / 0
end try
begin catch
print 'Error details: divide by zero exception'
end catch

--Task-6— Nested TRY…CATCH With Custom Error 
--Validate salary: 
--If salary < 1000, throw custom error using THROW. 
--Declare variable  to simulate salary

declare @Salary int = 500;
begin try
if @Salary < 1000
throw 50001, 'Salary cannot be less than 1000', 1
print 'Valid Salary';
end try
begin catch
print 'Exception: ' + error_message();
throw
end catch

--Task-7— Rank Employees by Region Sales 
--Task 
--Compare Rank / Dense_Rank / Row_Number 
--Identify top 2 per region

select *
from (
select 
s.Region,
e.EmpName,
sum(s.SaleAmount) as TotalSales,
dense_rank() over (partition by s.Region order by sum(s.SaleAmount) desc) as dnsrnk,
rank() over (partition by s.Region order by sum(s.SaleAmount) desc) as rnk,
row_number() over (partition by s.Region order by sum(s.SaleAmount) desc) as rownum
from Sales s
join Employees e on s.EmpId = e.EmpId
group by s.Region, e.EmpName
) pqr
where dnsrnk <= 2

--Task-8 -Using Sales table: 
--First CTE: Filter only last 1 year sales 
--Second CTE: Compute total sales per region 
--Third CTE: Rank regions based on total sales 
--Output top 3 regions
--Find Employees With Duplicate SalesAmount in Any Department

with CTE1 as (
 select *
 from Sales
 where SaleDate >= dateadd(year, -2, getdate())
),
CTE2 as (
select Region, sum(SaleAmount) as TotalSales
from CTE1
group by Region
),
CTE3 as (
select *,
rank() over (order by TotalSales desc) as RNK
from CTE2
)
select *
from CTE3
where RNK <= 3

select e.DeptId, e.EmpName, s.SaleAmount
from Sales s
join Employees e on e.EmpId = s.EmpId
where s.SaleAmount in (
    select SaleAmount
    from Sales
    group by SaleAmount
    having count(*) > 1
)

--Task – 9 
--Perform Pagination and list all details from employees who’s page between 6 and 10

WITH EmpCTE AS (
    SELECT 
        EmpId,
        EmpName,
        DeptId,
        ManagerId,
        JoinDate,
        Salary,
        ROW_NUMBER() OVER (ORDER BY EmpId) AS RowNum
    FROM Employees
)
SELECT *
FROM EmpCTE
WHERE RowNum BETWEEN 6 AND 10;