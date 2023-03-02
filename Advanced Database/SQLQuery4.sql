use ITI

CREATE VIEW EMPPROJ
as 
select Employee.Fname,Employee.Lname  from Employee inner join Works_for
on Employee.SSN=Works_for.ESSn
inner join Project 
on Works_for.Pno=Project.Pnumber
where Project.Pname='p1'

select * from EMPPROJ

--1)Create a stored procedure without parameters to show the number of students per department name.

alter procedure nstd
as
   select COUNT(St_Id) as STudent_Number,Department.Dept_Name
   from Student inner join Department
   on Department.Dept_Id=Student.Dept_Id
   group by Department.Dept_Name

nstd

--2)Create a stored procedure number of employees 
use Company_SD

alter proc NOEMP
as
declare @num int
select @num=count(Employee.SSN) from Employee inner join Works_for
on Employee.SSN=Works_for.ESSn
inner join Project 
on Works_for.Pno=Project.Pnumber
where Project.Pname='p1'
     
	 if(@num >3)
	    select 'The number of employees in the project p1 is 3 or more';
	else

       select 'The number of employees in the project p1 is less than  3 ' 
	   select * from EMPPROJ

NOEMP

--3)Employee left and one instaed of him 

alter proc new_old  @oldID int,@newID int, @PID int
as
      if exists (select Employee.SSN from Employee where Employee.SSN=@newID )
		  begin
			  if   exists (select Employee.SSN ,Works_for.Pno from Employee inner join Works_for on Employee.SSN=Works_for.ESSn where SSN=@newID and Works_for.Pno!=@PID )
					 begin 
						  update  Works_for
						  set ESSn= @newID 
						  where ESSn=@oldID and Pno=@PID
					  end
			end
	else
	select 'employee not found'


new_old 112233,123,100

--
create table history
(
_user varchar(20),
_date date,
_ProjectNo  int,
_Budget_Old  int,
_new_Old  int
)
alter trigger BudgetTRig
on Project 
after update
as
	if update(Budget)
		begin
			declare @Budget_Old int,@Budget_new  int,@PNO int
			select @PNO =Pnumber from deleted
			select @Budget_Old=Budget from deleted
			select @Budget_new=Budget from inserted

			insert into history
			values(suser_name(),getdate(),@PNO,@Budget_Old,@Budget_new)
		end

--4)create trigger
use ITI
create trigger PreventTrig
on Department
instead of insert 
as
select 'can’t insert a new record in that table'

insert into Department values


--5)prevent inertion in March

use Company_SD

create Trigger EmpMarch
on Employee
instead of insert
as
	if format(getdate(),'')='March'
		begin
			select 'not allowed'
		end
	else
		insert into Employee
		select * from inserted
--6)trigger in student
use ITI
create table STD_AUDIT
(
_user varchar(50),
_date date,
_Note varchar(100)
)

alter trigger stdTrig
on Student
after insert
as
declare @name varchar(20)
			select @name= St_Id  from inserted;
			insert into STD_AUDIT
			values(suser_name(),getdate(),SUSER_NAME()+'Insert New Row with Key'+@name+' in table Student')


--7)
alter trigger DELSTD
on Student
instead of Delete
as
declare @name varchar
			select @name= St_Id  from deleted;
			insert into STD_AUDIT
			values(suser_name(),getdate(),'try to delete Row with '+@name+' in table Student')

--8)
delete from Student where Student.St_Id=1


--9)
use AdventureWorks2012
select *
from HumanResources.Employee
for xml raw('employee'),elements

use AdventureWorks2012
select *
from HumanResources.Employee
for xml raw('employee')

use ITI
select Department.Dept_Name ,Instructor.Ins_Name
from Department inner join Instructor
on Department.Dept_Id=Instructor.Dept_Id
for xml auto

select Department.Dept_Name ,Instructor.Ins_Name
from Department inner join Instructor
on Department.Dept_Id=Instructor.Dept_Id
for xml path

--XML
declare @docs xml ='<customers>
              <customer FirstName="Bob" Zipcode="91126">
                     <order ID="12221">Laptop</order>
              </customer>
              <customer FirstName="Judy" Zipcode="23235">
                     <order ID="12221">Workstation</order>
              </customer>
              <customer FirstName="Howard" Zipcode="20009">
                     <order ID="3331122">Laptop</order>
              </customer>
              <customer FirstName="Mary" Zipcode="12345">
                     <order ID="555555">Server</order>
              </customer>
       </customers>'
declare @hdocs int

Exec sp_xml_preparedocument @hdocs output, @docs

SELECT * 
FROM OPENXML (@hdocs, '//customer')  --levels  XPATH Code
WITH (
       FirstName varchar(50) '@FirstName',
	   Zipcode varchar(50) '@Zipcode',
	    ID int  'order/@ID'
	  )
--5)remove memory tree
Exec sp_xml_removedocument @hdocs