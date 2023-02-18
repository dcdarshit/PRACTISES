create database Employee_Eclaim
use  Employee_Eclaim

drop table 
create table tbl_Employee
(
Id int primary Key identity(1,1),
EmpId varchar(20),
FirstName varchar(30),
LastName varchar(30),
Email varchar(22),
Mobile varchar(30),
Gender varchar(10),
ProfileImage varchar(40),
Created_On DateTime,
Updated_On DateTime,
IsActive tinyInt
)

create table tbl_EmployeeAutho
(
Id int ,
LoginEmail varchar(20),
Password varchar(30),
EmployeeId int foreign key references tbl_Employee(id) 
)

select * from tbl_Employee
select * from tbl_EmployeeAutho