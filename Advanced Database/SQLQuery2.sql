--1)Create a scalar function that takes date and returns Month name of that date.

create function getmon(@da date)
returns varchar(20)
      begin
		declare @month varchar(20)
		SELECT @month= DATENAME(month, @da) 
		return @month
	  end

select dbo.getmon('12/12/2022')

--2)Create a multi-statements table-valued function that takes 2 integers and returns the values between them

alter  function num(@num1 int ,@num2 int)
returns @t table
			(
			numbers int
			)
as 
begin
   
    while @num1<@num2
	begin 
	 set @num1+=1
	 insert into @t  
	 select @num1
	end
	return 
end

select * from num(1,10)


--3)Create inline function that takes Student No and returns Department Name with Student full name.
alter function getdata(@id int)
returns table
as 
return 
(
   select s.St_Fname+' '+s.St_Lname as fullname , d.Dept_Name
   from Student s,Department d
   where s.Dept_Id=d.Dept_Id and s.St_Id=@id
)


select * from dbo.getdata(1)


--4)Create a scalar function that takes Student ID and returns a message to user 

create function mesage(@id int )
returns varchar(50)
begin 
declare @mes varchar(50)
select @mes=
 case
  when (ss.St_Fname is null and ss.St_Lname is null)
 then 'both are null'
 when (ss.St_Fname is null )
 then 'f name  are null'
  when (ss.St_Lname is null)
 then 'l name are null'
 else 'both are not null'
 end
 from Student ss
 where ss.St_Id=@id
 return @mes
 end

 select dbo.mesage(1)


 --5)Create inline function that takes integer which represents manager ID and displays department name, Manager Name and hiring date 
 alter function manager(@id int)
 returns table
 as 
 return 
 (
    select d.Dept_Manager,d.Dept_Name,d.Manager_hiredate,s.Ins_Name
	from Department d,Instructor s
	where d.Dept_Id=s.Dept_Id and s.Ins_Id=@id
 )

select * from dbo.manager(3)


--6)Create multi-statements table-valued function that takes a string
create function stud(@st varchar(30))
returns @t table
(
 student_name varchar(30)
)
as
begin 
  if @st='first name'
  insert into @t 
  select isnull(s.St_Fname,' ')
  from Student s
  else if @st='last name'
  insert into @t 
  select isnull(s.St_Lname,' ')
  from Student s
  else if @st='full name'
  insert into @t 
  select concat(isnull(s.St_Fname,' '),' ',isnull(s.St_Lname,' '))
  from Student s
  return
end


select * from stud('first name')
select * from stud('last name')
select * from stud('full name')

--7)Write a query that returns the Student No and Student first name without the last char

SELECT s.st_id, SUBSTRING(s.st_fname, 1, LEN(s.st_fname)-1)
FROM Student s

--8)Wirte query to delete all grades for the students Located in SD Department 

DELETE Stud_Course
FROM  Stud_Course
inner join Student
	on Stud_Course.St_Id = Student.St_Id 
inner join Department 
	on Department.Dept_Id = Student.Dept_Id  
WHERE Dept_Name = 'SD'

--Bonus:
--1.	Give an example for hierarchyid Data type
create table family  
(Node hierarchyid not null,  
namee nvarchar(30),  
age  int);
insert family  
values
-- second level data 
 ('/1/1/','ahmed',80)
,('/1/2/','ali',90)
,('/1/3/','ahmed',40)
,('/2/1/','naser',12)
,('/2/2/','rehab',12)
,('/3/1/','eslam',78)
 
-- first level data
,('/1/','ali',40)
,('/2/','ahmed',45)
,('/3/','ahmed',11)
 
-- third level data
,('/1/1/1/','rehab',78)
,('/1/2/1/','basma',85)
,('/1/3/1/','toka',77)
,('/2/1/1/','ahmed',78)
,('/2/2/1/','noura',45)
,('/3/1/1/','ali',1)
 
-- root level data
,('/', 'Grand', 12)  
 
 select 
 Node
,Node.ToString() AS [Node Text]
,Node.GetLevel() [Node Level]
,namee
,age  
from family
--2)Create a batch that inserts 3000 rows in the student table(ITI database). The values of the st_id column should be unique and between 3000 and 6000. All values of the columns st_fname, st_lname, should be set to 'Jane', ' Smith' respectively.

CREATE TABLE HAMADA 
(
x INT,
Y  varchar(50),
z varchar(50)
)

DECLARE @i int = 3000

WHILE @i <= 6000
	BEGIN
		INSERT INTO Student (St_Id,St_Fname,St_Lname) values(@i,'jane','Smith')
		SET @i =  @i+1
	END