--1.Create a view that displays student full name, course name if the student has a grade more than 50. 
create view sgrade
as
select s.St_Fname+' '+s.St_Lname as fullname , c.Crs_Name
from Student s inner join  Stud_Course ss
on s.St_Id=ss.St_Id
inner join Course c
on c.Crs_Id=ss.Crs_Id
where ss.Grade>50

--2.Create an Encrypted view that displays manager names and the topics they teach. 
alter view instructorcourse
with encryption
as 
select i.Ins_Name,T.Top_Name
from Department d inner join Instructor i
on d.Dept_Id=i.Dept_Id
inner join Ins_Course ic
on i.Ins_Id=ic.Ins_Id
inner join course c
on ic.Crs_Id=c.Crs_Id
inner join Topic T
on c.Top_Id=T.Top_Id

--3.Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department 
create view insDepatment
as
SELECT i.Ins_Name,d.Dept_Name
from Instructor i,Department d
where d.Dept_Name='SD' or d.Dept_Name='Java'

--4.Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
create view V1
as
select *
from Student s
where s.St_Address='Cairo' or s.St_Address='Alex'
with check option

--5.Create a view that will display the project name and the number of employees work on it. “Use SD database”
use SD
alter view pname
as
select p.ProjectName,count(w.EmpNo) as number_Emp
from Campany.Projects p inner join Works_on w
on p.ProjectNo=w.ProjectNo
group by p.ProjectName

--6.Create index on column (Hiredate) that allow u to cluster the data in table Department. What will happen?
use ITI
create clustered index i2
on Department(Manager_hiredate)--cannot must drop pk
--7.	Create index that allow u to enter unique ages in student table. What will happen? 
create clustered index i3
on student(St_Age)--cannot must drop pk

--8.	Using Merge statement between the following two tables [User ID, Transaction Amount]
create table Lastt
(
 lid int,
 Xval int
)

create table Daily
(
 did int,
 Yval int
)

merge into Lastt as t
using Daily as s
on t.lid=s.did
when matched then
update set t.Xval=s.Yval
when not matched then
insert 
values (s.did,s.Yval);




--part 2
	--1)Create view named   “v_clerk” that will display employee#,project#, the date of hiring of all the jobs of the type 'Clerk'.
	use SD
	create view v_clerk
	as
	select e.EmpNo,p.ProjectNo,w.Enter_Date
	from hr.Employee e inner join Works_on w
	on e.EmpNo=w.EmpNo
	inner join Campany.Projects p
	on w.ProjectNo=p.ProjectNo

--Create view named  “v_without_budget” that will display all the projects data without budget
create view v_without
as
select p.ProjectName,p.ProjectNo
from Campany.Projects p

--3)Create view named  “v_count “ that will display the project name and the # of jobs in it
create view v_count
as
select p.ProjectName , count(w.Job) as countt
from Campany.Projects p, Works_on w
group by p.ProjectName

--4) Create view named ” v_project_p2” that will display the emp#  for the project# ‘p2’use the previously created view  “v_clerk”
 create view v_prject_p2
 as
select EmpNo,ProjectNo
from v_clerk
where ProjectNo='p2'

--5)modifey the view named  “v_without_budget”  to display all DATA in project p1 and p2 
alter view v_without
as
select *
from Campany.Projects p
where p.ProjectNo in ('p1','p2')


--6)Delete the views  “v_ clerk” and “v_count”
drop view v_clerk
drop view v_count

--7)Create view that will display the emp# and emp lastname who works on dept# is ‘d2’
create view empp
as
select e.EmpNo,e.EmpFname
from hr.Employee e inner join Campany.Department d
on d.DepNo='d2'

--8)Display the employee  lastname that contains letter “J”Use the previous view created in Q#7
alter view empp
as 
select HR.Employee.EmpNo,HR.Employee.EmpLname 
from HR.Employee inner join Campany.Department
on 
HR.Employee.DepNo=Campany.Department.DepNo
where Campany.Department.DepName='d2' and HR.Employee.EmpLname like '%J%';

select * from empp;




--9)	Create view named “v_dept” that will display the department# and department name.
create view v_dept
as 
select Campany.Department.DepNo,Campany.Department.DepName 
from Campany.Department;



--10)	using the previous view try enter new department data where dept# is ’d4’ and dept name is ‘Development’


insert into v_dept values (4,'Development')

select * from v_dept


--11)	Create view name “v_2006_check” that will display employee#, the project #where he works and the date of joining the project which must be from the first of January and the last of December 2006.
create  view v_2006_check
as 
select HR.Employee.EmpNo,Campany.Projects.ProjectNo,Works_on.Enter_Date
FROM HR.Employee inner join Works_on
on HR.Employee.EmpNo = Works_on.EmpNo
inner join Campany.Projects
ON Campany.Projects.ProjectNo=Works_on.ProjectNo
where Works_on.Enter_Date between '1/1/2006' and '31/12/2006'

