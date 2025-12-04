--5.Isolation Level – Dirty Read 
--Use two sessions: 
--• Session 1: Open a transaction, update a row, but don’t commit 
--• Session 2: Use SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED and read 
--the same row 
--Check whether dirty reads are allowed.

--session 2
begin transaction

update customers
set age = 98
where custid = 103	

--6. Isolation Level – Non-repeatable Read 
--Using two sessions: 
--• Session 1 reads a row twice inside a transaction 
--• Session 2 updates and commits the same row in between 
--Observe changes and understand non-repeatable reads.

--session 2
begin transaction

update customers
set age = 40
where custid = 103

commit

--7. Isolation Level – Phantom Read 
--Create a table Sales. 
--Using two sessions: 
--• Session 1 selects rows between a range inside a transaction 
--• Session 2 inserts a new row within the range and commits 
--See if the first session sees new rows depending on isolation level.

--session 2
begin transaction

insert into sales (SaleId,EmpId, region, SaleAmount, saledate)
values (6,6, 'north', 95000, getdate())

commit