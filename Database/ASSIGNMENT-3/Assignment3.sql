create Database Assignment3
use Assignment3

select * from EmployeeDetail
select * from ProjectDetail
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------TABLE-1---------------------------

create table EmployeeDetail(EmployeeId int primary key,FirstName varchar(50),LastName Varchar(50),Salary money,JoiningDate datetime,Department Varchar(20),Gender varchar(20))

Insert into EmployeeDetail(EmployeeId,FirstName,LastName,Salary,JoiningDate,Department,Gender) values(1,'Vikas','Ahlawat',600000,'2013-02-15 11:16:28.290','IT','MALE')
Insert into EmployeeDetail(EmployeeId,FirstName,LastName,Salary,JoiningDate,Department,Gender) values(2,'Nikita','JAIN',530000,'2014-01-09 17:31:07.793','HR','FEMALE')
Insert into EmployeeDetail(EmployeeId,FirstName,LastName,Salary,JoiningDate,Department,Gender) values(3,'Ashish','Kumar',1000000,'2014-01-09 10:05:07.793','IT','MALE')
Insert into EmployeeDetail(EmployeeId,FirstName,LastName,Salary,JoiningDate,Department,Gender) values(4,'Nikhil','Sharma',480000,'2014-01-09 09:00:07.793','HR','MALE')
Insert into EmployeeDetail(EmployeeId,FirstName,LastName,Salary,JoiningDate,Department,Gender) values(5,'Anish','Kaidan',500000,'2014-01-09 09:31:07.793','Payroll','MALE')



select 
case
when active = 0 then 'ONLINE'
when active = 1 then 'OFFLINE'
when active = 2 then 'LOCK'
end  active
from EmployeeDetail 

select Left('Darshit',3)
select Replace('BLACK AND BLUE','B','C')



--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------TABLE-2-------------------------------------------------------

create table ProjectDetail (ProjectDetailId varchar(30),EmployeeDetailId int foreign key references EmployeeDetail(EmployeeId),ProjectName varchar(30))

insert into ProjectDetail(ProjectDetailId,EmployeeDetailId,ProjectName) values(1,1,'Task Track')
insert into ProjectDetail(ProjectDetailId,EmployeeDetailId,ProjectName) values(2,1,'CLP')
insert into ProjectDetail(ProjectDetailId,EmployeeDetailId,ProjectName) values(3,1,'Servey Management')
insert into ProjectDetail(ProjectDetailId,EmployeeDetailId,ProjectName) values(4,2,'HR Management')
insert into ProjectDetail(ProjectDetailId,EmployeeDetailId,ProjectName) values(5,3,'Task Track')
insert into ProjectDetail(ProjectDetailId,EmployeeDetailId,ProjectName) values(6,3,'GRS')
insert into ProjectDetail(ProjectDetailId,EmployeeDetailId,ProjectName) values(7,3,'DDS')
insert into ProjectDetail(ProjectDetailId,EmployeeDetailId,ProjectName) values(8,4,'HR Management')
insert into ProjectDetail(ProjectDetailId,EmployeeDetailId,ProjectName) values(9,6,'GL Management')
insert into ProjectDetail(ProjectDetailId,EmployeeDetailId,ProjectName) values(10,7,'GL Technology')
insert into ProjectDetail(ProjectDetailId,EmployeeDetailId,ProjectName) values(10,NULL,'GL Technology')

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--BASIC QUESTION

--Q1-> 
Select * from EmployeeDetail where FirstName not like '[a-p]%'

--Q2->
select * from EmployeeDetail where Gender like '__le%'

--Q3->
select * from EmployeeDetail where FirstName like '%a____'

--Q4->
select * from EmployeeDetail where FirstName not like '[%]'

--Q5->
select Distinct(Department) from EmployeeDetail 

--Q6->
select FirstName,Salary from EmployeeDetail where salary=(select MAX(Salary) from EmployeeDetail)

--Q7->
select Format(JoiningDate,'yyyy MMM dd') as date from EmployeeDetail

--Q8->
select Format(JoiningDate,'yyyy/MM/dd') as date from EmployeeDetail

--Q9->
select Format(Joiningdate,'hh:mm:sec')as date from EmployeeDetail


--Q10->
select Format(joiningdate,'yyyy') as date from EmployeeDetail


--Q11->
Select Firstname,GETDATE() as Date,JoiningDate,CONCAT(DATEDIFF(mm,JoiningDate,GETDATE()),'MONTHS') as Difference from EmployeeDetail

--Q12->
select * from EmployeeDetail where 2014= year(JoiningDate)

--Q13->
select * from EmployeeDetail where month(JoiningDate)=1

--Q14->
select * from EmployeeDetail where JoiningDate > '2013-01-01' and JoiningDate<'2013-12-01'

--Q15->
select *,
case 
when Gender='Male' then 'M'
when Gender='Female' then 'F'
end as Genders
from EmployeeDetail

--OR

select  * ,left(Gender,1) from EmployeeDetail 

--Q16->
select  ProjectName from ProjectDetail  group by ProjectName having count(EmployeeDetailId)>1

----JOINS QUESTIONS

--Q1->
select FirstName,LastName from EmployeeDetail e inner join ProjectDetail p on e.EmployeeId=p.EmployeeDetailId order by FirstName


--Q2->
select FirstName,LastName,ProjectName from EmployeeDetail e left join ProjectDetail p on e.EmployeeId=p.EmployeeDetailId order by FirstName

--Q3->
select FirstName, LastName from EmployeeDetail e join ProjectDetail p on e.EmployeeId=p.EmployeeDetailId order by FirstName 

--Q4->
select ProjectName,EmployeeId from ProjectDetail p left join EmployeeDetail e on p.EmployeeDetailId=e.EmployeeId order by FirstName

--Q5->
select Fullname=FirstName+' '+LastName,ProjectName from EmployeeDetail e full outer join ProjectDetail p on e.EmployeeId = p.EmployeeDetailId

--Q6->
select isnull(p.ProjectName,'NO Project Assigned') from EmployeeDetail e full outer join ProjectDetail p on e.EmployeeId=p.EmployeeDetailId

--Q7->
select ProjectName from ProjectDetail where EmployeeDetailId is NULL

--Q8->
select Detail=FirstName+''+LastName from EmployeeDetail e join ProjectDetail p on e.EmployeeId = p.EmployeeDetailId group by e.FirstName+''+e.LastName having count(e.FirstName+e.LastName)>1

--Q9->
select ProjectName from ProjectDetail p join EmployeeDetail e on e.EmployeeId= p.EmployeeDetailId 
group by ProjectName having Count(ProjectName)>1
