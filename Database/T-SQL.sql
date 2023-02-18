use TSQL

declare @id int,@name varchar(20),@marks1 int,@marks2 int,@marks3 int,@total int 

set @id=1
set @name='AMAN'

set @marks1=200
set @marks2=210
set @marks3=200

set @total=@marks1+@marks2+@marks3

print @id
print @name
print @total
-----------------------------------GREATER OR EQUAL ----------------------------------
declare @x int=10
declare @y int=12
if(@x>@y)
	begin 
		print(@x)
	end
else
	begin
		print(@y)
	end
---------------------------------- EVEN NUMBER --------------------------------------------
declare @a int=12
declare @b int=13

if(@a%2=0)
	begin
		print('EVEN NUMBER')
	end
else
	begin
		print('ODD NUMBER')
	end

---------------------------------------WHILE LOOPS------------------------------------------

declare @z int=1

while(@z<10)
begin
	Print(@z)
	set @z=@z+1
end

--------------------------------------------------------------------------------------------------------------------------------------------------
												--Stored Procedure
create Procedure    Test1
as
	begin
			print ('WELCOME TO THE FIRST STORED PROCEDURES')
	end
	
	EXECUTE Test1
	EXECUTE Test1
---------
--Q1-> Add two Values with Parameters procedure
create procedure Test2(@x int,@y int)
as 
begin
declare @add int
set @add=@x+@y
end

exec Test2 10,12

sp_helptext Test2

alter procedure Test2(@x int,@y int)
as 
begin
declare @mul int
set @mul=@x+@y
print mul
end

execute Test2 10,10

------------------------------------------------
							--WITHOUT PARAMETERS
create procedure Mix
as begin
declare @x int = 10
declare @y int =15
declare @add int
set @add=@x+@y
print @add
end

execute Mix

-------------------
--With Parameters(ADDITION OPERATION)

alter procedure Mixing(@a int,@b int)
as begin
declare @mixing int
set @mixing=@a+@b
print(@mixing)
end

execute Mixing 10,15



---with Parameter (SUBTRACTION OPERATION)

alter procedure Mining(@a int,@b int)
as begin
declare @mining int
set @mining=@a-@b
end

execute Mining 50,25


sp_helptext Mining

alter procedure Mining(@a int,@b int)
as begin
declare @mining int
set @mining=@a-@b
print(@mining)
end
-------------------------------
create table Employee(name varchar(20),email varchar(20),salary decimal,mobile varchar(20),TDS money,DOB varchar(20))
insert into Employee values('AB','ab@gmail.com',12000,'8977652311',21000,'19-03-2022')

--create Procedure and enter the insert values in it

alter procedure Employeez(@name varchar(20),@email varchar(20),@salary decimal,@mobile varchar(20),@TDS money,@DOB varchar(20)@id int)
as begin
insert into Employee(name,email,salary,mobile,TDS,DOB,id) values(@name,@email,@salary,@mobile,@TDS,@DOB)
end

execute Employeez 'AMAN','aman@gmail.com',21000,9999987645,2100,'19-03-2021'

select * from Employee
-------------------------------------------------------------------------------------------------------------------------------------------------------------------
--FUNCTIONS IN SQL
create Function Cube(@x int)
returns int
as begin
return @x*@x*@x
end

select dbo.Cube(3) 

--Q2
create Function Employee(@x int)
returns int
as begin 
declare @sal int
select @sal = select * from Employee where id=@x
return @sal 
end

select dbo.Employee(1)


create Function saidata(@salary money)
returns table
as 
return()

select * from saidata(10)
select * from Employee

Begin Transaction 

Insert into Employee(name,email,salary,mobile,TDS,DOB) values('A','cd@gmail.com',2100,'098765468',2100,'19-02-2032')

Commit












