use Employee_Eclaim

create Procedure Usp_create_Employee
(
@First_Name varchar(50),@Last_Name varchar(50),@Email varchar(50),@Gender varchar(50)=NULL,@Mobile varchar(50)=NULL,@Profile_Image varchar(50)=NULL,
@Password varchar(40)
)

as 
Begin 
-----------TEMPORARY ERROR TABLE-----------------
create table #error(Name varchar(30),Message varchar(30),Sequence int)
-----------

------------Check for E-mail------
if (Exists(select Email from Tbl_Employee where Email=@Email))
Begin
Insert into #error values('Email','This Email already Exist',1)
End

------------Check for Mobile------

if(Exists(select Mobile from Tbl_Employee where Mobile=@Mobile))
begin
Insert into #error values('Mobile','This Mobile Number already Exist',2)
End
