create table Department(
DepNo varchar(10) primary key,
DepName varchar(20),
Location loc,
);

create default def1 as 'NY'
create rule r as @x in ('NY','DS','KW')
sp_addtype loc,'nchar(2)'
sp_bindrule r,loc
sp_bindefault def1,loc

insert into Department values('d1','Research','DS')
insert into Department (DepNo,DepName) values('d2','Accounting')
select * from Department



create table Employee(
EmpNo int,
EmpFname varchar(20) not null,
EmpLname varchar(20) not null,
DepNo varchar(10),
Salary int,
constraint c1 primary key(EmpNo),
constraint c2 foreign key(DepNo) references Department(DepNo)
      on delete set NULL on update cascade,
 constraint c3 unique(Salary),

);
create rule rules as @y<6000
sp_bindrule rules,'Employee.Salary'


select * from Works_on

insert into Works_on (EmpNo) values(11111)
---projectNo cannot be null
UPDATE Works_on
SET EmpNo = 11111
WHERE EmpNo=10102; --conflict with fk on employee

UPDATE Employee
SET EmpNo = 22222
WHERE EmpNo=10102; --conflict with fk on works on

DELETE FROM Employee WHERE EmpNo=10102;--conflict with fk on works on

ALTER TABLE Employee
ADD phonenumber varchar(20);

ALTER TABLE Employee
DROP COLUMN phonenumber;
 
create schema Campany
create schema HR
alter schema Campany transfer Department

alter schema HR transfer Employee

SELECT CONSTRAINT_NAME, CONSTRAINT_TYPE
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME='Employee';

create synonym Emp
for  HR.Employee

select * from Employee --invalid object name
Select * from [HR].Employee --valid
Select * from Emp --valid and same result
Select * from [HR].Emp--invalid object name


-- 5 Increase the budget of the project where the manager number is 10102 by 10%.
UPDATE Campany.Projects
SET Budget = Budget * 1.1
(SELECT EmpNo, job
FROM Works_on
WHERE job = 'Manager'
AND EmpNo = 10102);
select * from Campany.Projects


-- 6 Change the name of the department for which the employee named James works.The new department name is Sales.
UPDATE Campany.Department
SET DepName = 'Sales'
from  Campany.Department inner join Emp
on  Campany.Department.DepName=Emp.DepNo
where EmpFname='james'
--test
select Department.DepName,Emp.EmpFname
from Emp inner join Campany.Department
on Emp.EmpFname='james'

--7 Change the enter date for the projects for those employees who work in project p1 and belong to department ‘Sales’. The new date is 12.12.2007.
UPDATE Works_on
SET Enter_Date='12/12/2007'
from Works_on inner join Emp on Works_on.EmpNo=Emp.EmpNo inner join Campany.Department
on Emp.DepNo=Campany.Department.DepNo
where ProjectNo='p1' and Campany.Department.DepName='Sales';



--8.Delete the information in the works_on table for all employees who work for the department located in KW.


delete Works_on 
from  Works_on inner join Emp 
on Works_on.EmpNo=Emp.EmpNo
inner join Campany.Department
on Emp.DepNo=Campany.Department.DepNo
where Campany.Department.Location='KW'

