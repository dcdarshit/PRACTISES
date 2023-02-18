create database Employee_Eclaim
use Employee_Eclaim

Create Table Tbl_Employee
(Id int identity primary key,Emp_Id varchar(20),FirstName varchar(30),LastName varchar(30),Email varchar(30),
Mobile varchar(30),Gender varchar(20),ProfileImage varchar(20),Created_On datetime,Updated_On datetime,IsActive tinyint)

Create Table Tbl_Employee_Autho
(Id int,Login_Email varchar(20),Password varchar(20),Employee_Id int foreign key References Tbl_Employee(Id))
