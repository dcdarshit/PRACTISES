create database Testing
use testing

select * from TemEmp

delete from TemEmp where id=4

delete from TemEmp where id=2
drop table TemEmp
truncate table TemEmp

Create table TemEmp (Id int identity(1,1),Name varchar(20),Email varchar(20),Address varchar(30))
Insert into TemEmp(Name,Email,Address) values('Aman','Aman@gmail.com','House No.10')
Insert into TemEmp(Name,Email,Address) values('Naman','Aman@gmail.com','Hoouse No.11')
Insert into TemEmp(Name,Email,Address) values('Suresh','Suresh@gmail.com','House No.12')
Insert into TemEmp(Name,Email,Address) values('Naresh','Naresh@gmail.com','Hoouse No.13')
-------------------------------------------------------------------------------------
--select Max(Id) as ID from TemEmp group by Id having Count(*)>1

--Delete Duplicate records from the Table

delete from TemEmp where id in(
select Max(id) from TemEmp group by Name having count(*)>1)


delete from TemEmp where id in 
(select Max(id) as Id from TemEmp group by Name having Count(*)>1)
-----------------------------------------------------------------------------------------------
--Trigger
create Trigger T_Delete1 on TemEmp
for Delete
as
Begin
select * from deleted
end

create Trigger t_Insert on TemEmp
for Insert
as Begin
select * from Inserted
end

Insert into TemEmp(Name,Email,Address) values('Deepu','Deep@gmail.com','Hoouse No.20')



drop table abc
create table abc (name varchar(10),email varchar(20))
insert into abc (name,email) values('z','xyz'),('x','ghi')
select ROW_NUMBER() over (order by name) as id,name,email from abc